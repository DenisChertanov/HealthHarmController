using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Realms;
using Rg.Plugins.Popup.Services;

namespace Calculator2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChooseSigaretsBrand : ContentPage
	{
        Button[] buttons = new Button[0];
        Frame[] frames = new Frame[0];
        int id = 0;
        bool HaveTop = true;
        bool AddGeneral = false;
        bool WasLabel = true;

        Label Top;
        Button FirstSigaret;
        Button SecondSigaret;
        Button ThirdSigaret;
        Button FourthSigaret;
        Button FifthSigaret;
        Label General;

        public ChooseSigaretsBrand ()
		{
            ToolbarItem tb = new ToolbarItem
            {
                Text = "Добавить марку сигарет",
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
                Icon = new FileImageSource
                {
                    File = "Add6.png",                    
                },                               
            };
            tb.Clicked += (s, e) =>
            {
                PopupNavigation.Instance.PushAsync(new AddNewSigaret());
            };
            ToolbarItems.Add(tb);

            InitializeComponent ();
            Text_Changed("");
		}

        private void AddLabel(SigaretsBrands NewSigaret)
        {
            if (id == frames.Length)
            {
                Frame[] Newframes = new Frame[frames.Length * 2];
                for (int i = 0; i < id; ++i)
                {
                    Newframes[i] = frames[i];
                }

                frames = Newframes;
            }

            Label label = new Label
            {
                Text = NewSigaret.Name,
                TextColor = Color.FromHex("#FFC4C4C4"),
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                HorizontalTextAlignment = TextAlignment.Center
            };
            frames[id] = new Frame
            {
                Content = label,
                BackgroundColor = Color.FromHex("#424242"),
                Padding = new Thickness(8)
            };

            stackLayout.Children.Add(frames[id]);
            id++;
        }

        private void AddButton(SigaretsBrands NewSigaret) 
        {
            if (id == buttons.Length)
            {
                Button[] Newbuttons = new Button[buttons.Length * 2];
                for (int i = 0; i < id; ++i)
                {
                    Newbuttons[i] = buttons[i];
                }

                buttons = Newbuttons;
            }

            buttons[id] = new Button
            {                
                Text = NewSigaret.Name,
                TextColor = Color.FromHex("#FFC4C4C4"),
                BackgroundColor = Color.FromHex("#ff5916"),
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                BorderWidth = 1
                //VerticalOptions = LayoutOptions.Start,
                //HorizontalOptions = LayoutOptions.Start
            };
            buttons[id].Clicked += (object sender, EventArgs e) => 
            {
                Brand.Text = "Выбранный бренд: " + ((Button)sender).Text;

                var config = new RealmConfiguration() { SchemaVersion = 1 };
                Realm _realm = Realm.GetInstance(config);
                var AllMemory = _realm.All<Memory>().ToList();
                if (AllMemory.Count != 0)
                {
                    var NewMemory = AllMemory[0];
                    _realm.Write(() => _realm.Remove(NewMemory));
                }

                _realm.Write(() => _realm.Add(new Memory { SigaretBrand = ((Button)sender).Text }));

                var config1 = new RealmConfiguration() { SchemaVersion = 1 };
                Realm _Realm = Realm.GetInstance(config1);
                var TopBrand = _Realm.All<TopBrands>().ToList();
                if (((Button)sender).Text != TopBrand[0].First && ((Button)sender).Text != TopBrand[0].Second &&
                    ((Button)sender).Text != TopBrand[0].Third && ((Button)sender).Text != TopBrand[0].Fourth &&
                    ((Button)sender).Text != TopBrand[0].Fifth)
                {
                    _Realm.Write(() => TopBrand[0].Fifth = TopBrand[0].Fourth);
                    _Realm.Write(() => TopBrand[0].Fourth = TopBrand[0].Third);
                    _Realm.Write(() => TopBrand[0].Third = TopBrand[0].Second);
                    _Realm.Write(() => TopBrand[0].Second = TopBrand[0].First);
                    _Realm.Write(() => TopBrand[0].First = ((Button)sender).Text);
                }

                DisplayAlert("", "Бренд сигарет изменён!", "ОK");
            };
            stackLayout.Children.Add(buttons[id]);
            id++;
        }

        private void GetTextChanged(object sender, TextChangedEventArgs e)
        {
            string str;
            if ((Entry)sender == null || ((Entry)sender).Text == null)
                str = "";
            else
                str = ((Entry)sender).Text;

            Text_Changed(str);
        }

        private void Text_Changed(string str)
        {
            if (AddGeneral)
                stackLayout.Children.Remove(General);
            if (!WasLabel)
            {
                for (int i = 0; i < id; ++i)
                {
                    stackLayout.Children.Remove(buttons[i]);
                }
            }
            else
            {
                for (int i = 0; i < id; ++i)
                {
                    stackLayout.Children.Remove(frames[i]);
                }
            }

            buttons = new Button[1];
            frames = new Frame[1];
            id = 0;

            UpdateTop(str);

            General = new Label
            {
                Text = "Результаты поиска:",
                TextColor = Color.FromHex("#FFC4C4C4"),
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
                //VerticalOptions = LayoutOptions.Start,
                //HorizontalOptions = LayoutOptions.Start
            };                        
            stackLayout.Children.Add(General);
            AddGeneral = true;

            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);
            var AllSigarets = _realm.All<SigaretsBrands>().ToList();
            int CntButtons = 0;
            for (int i = 0; i < AllSigarets.Count; ++i)
            {
                bool flag = true;
                for (int j = 0; j < str.Length; ++j)
                {
                    if (AllSigarets[i].Name.Length == j)
                    {
                        flag = false;
                        break;
                    }

                    if (Char.ToUpper(str[j]) != Char.ToUpper(AllSigarets[i].Name[j]))
                    {
                        flag = false;
                        break;
                    } 
                }

                if (flag)
                {
                    if (str == "")
                    {
                        WasLabel = true;
                        AddLabel(AllSigarets[i]);
                    }
                    else
                    {
                        WasLabel = false;
                        AddButton(AllSigarets[i]);
                    }
                    CntButtons++;
                }
            }

            General.Text = $"Результаты поиска: ({CntButtons})";
        }

        private void ClickedTop (object sender, EventArgs e)
        {
            Brand.Text = "Выбранный бренд: " + ((Button)sender).Text;

            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);
            var AllMemory = _realm.All<Memory>().ToList();
            if (AllMemory.Count != 0)
            {
                var NewMemory = AllMemory[0];
                _realm.Write(() => _realm.Remove(NewMemory));
            }

            _realm.Write(() => _realm.Add(new Memory { SigaretBrand = ((Button)sender).Text }));

            DisplayAlert("", "Бренд сигарет изменён!", "ОK");
        }

        private void UpdateTop(string str)
        {
            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _Realm = Realm.GetInstance(config);
            var TopBrand = _Realm.All<TopBrands>().ToList();
            if (str == "")
            {
                if (TopBrand[0].First != "")
                {
                    Top = new Label
                    {
                        Text = "Избранное: ",
                        TextColor = Color.FromHex("#FFC4C4C4"),
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                        //VerticalOptions = LayoutOptions.Start,
                        //HorizontalOptions = LayoutOptions.Start
                    };                    
                    stackLayout.Children.Add(Top);                    

                    FirstSigaret = new Button
                    {
                        Text = TopBrand[0].First,
                        TextColor = Color.FromHex("#FFC4C4C4"),
                        BackgroundColor = Color.FromHex("#ff5916"),
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                        BorderWidth = 1
                        //VerticalOptions = LayoutOptions.Start,
                        //HorizontalOptions = LayoutOptions.Start
                    };
                    FirstSigaret.Clicked += ClickedTop;                    
                    stackLayout.Children.Add(FirstSigaret);

                    if (TopBrand[0].Second != "")
                    {
                        SecondSigaret = new Button
                        {
                            Text = TopBrand[0].Second,
                            TextColor = Color.FromHex("#FFC4C4C4"),
                            BackgroundColor = Color.FromHex("#ff5916"),
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                            BorderWidth = 1
                            //VerticalOptions = LayoutOptions.Start,
                            //HorizontalOptions = LayoutOptions.Start
                        };
                        SecondSigaret.Clicked += ClickedTop;                        
                        stackLayout.Children.Add(SecondSigaret);
                    }
                    if (TopBrand[0].Third != "")
                    {
                        ThirdSigaret = new Button
                        {
                            Text = TopBrand[0].Third,
                            TextColor = Color.FromHex("#FFC4C4C4"),
                            BackgroundColor = Color.FromHex("#ff5916"),
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                            BorderWidth = 1
                            //VerticalOptions = LayoutOptions.Start,
                            //HorizontalOptions = LayoutOptions.Start
                        };
                        ThirdSigaret.Clicked += ClickedTop;                        
                        stackLayout.Children.Add(ThirdSigaret);
                    }
                    if (TopBrand[0].Fourth != "")
                    {
                        FourthSigaret = new Button
                        {
                            Text = TopBrand[0].Fourth,
                            TextColor = Color.FromHex("#FFC4C4C4"),
                            BackgroundColor = Color.FromHex("#ff5916"),
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                            BorderWidth = 1
                            //VerticalOptions = LayoutOptions.Start
                        };
                        FourthSigaret.Clicked += ClickedTop;                        
                        stackLayout.Children.Add(FourthSigaret);
                    }
                    if (TopBrand[0].Fifth != "")
                    {
                        FifthSigaret = new Button
                        {
                            Text = TopBrand[0].Fifth,
                            TextColor = Color.FromHex("#FFC4C4C4"),
                            BackgroundColor = Color.FromHex("#ff5916"),
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                            BorderWidth = 1
                            //VerticalOptions = LayoutOptions.Start,
                            //HorizontalOptions = LayoutOptions.Start
                        };
                        FifthSigaret.Clicked += ClickedTop;                        
                        stackLayout.Children.Add(FifthSigaret);
                    }
                }

                HaveTop = true;
            }
            else if (HaveTop)
            {
                if (TopBrand[0].First != "")
                {
                    stackLayout.Children.Remove(Top);
                    stackLayout.Children.Remove(FirstSigaret);

                    if (TopBrand[0].Second != "")
                        stackLayout.Children.Remove(SecondSigaret);
                    if (TopBrand[0].Third != "")
                        stackLayout.Children.Remove(ThirdSigaret);
                    if (TopBrand[0].Fourth != "")
                        stackLayout.Children.Remove(FourthSigaret);
                    if (TopBrand[0].Fifth != "")
                        stackLayout.Children.Remove(FifthSigaret);
                }

                HaveTop = false;
            }
        }
	}
}