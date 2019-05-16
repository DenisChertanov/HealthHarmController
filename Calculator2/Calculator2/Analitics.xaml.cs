using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Realms;
using Entry = Microcharts.Entry;
using SkiaSharp;
using Microcharts.Forms;
using Microcharts;

namespace Calculator2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Analitics : ContentPage
    {
        string[] ParseToMonth = new string[12] { "Янв", "Фев", "Мар", "Апр", "Май", "Июн", "Июл", "Авг", "Сен", "Окт", "Ноя", "Дек" };
        DatePicker datePickerFrom1, datePickerFrom2, datePickerTo1, datePickerTo2;
        Label StartPeriod1, StartPeriod2, EndPeriod1, EndPeriod2;

        public Analitics()
        {
            InitializeComponent();

            picker1.Items.Add("последние 10 дней");
            picker1.Items.Add("последний год");
            picker1.Items.Add("период");            

            picker2.Items.Add("последние 10 дней");
            picker2.Items.Add("последний год");
            picker2.Items.Add("период");            

            CreateSmokingChart();
            CreateSpentChart();
        }

        private void CreateSmokingChart()
        {
            int CntSigaretsAll = 0;
            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);
            var AllDays = _realm.All<Day>();
            List<Day> NowDay = _realm.All<Day>().Where(f => f.NextDay == null).ToList();
            DateTime dateTime = DateTime.Today;

            CntSigaretsAll += NowDay[0].CntSigaretsToday;
            List<Entry> entries = new List<Entry>
            {                
                new Entry(NowDay[0].CntSigaretsToday)
                {
                    ValueLabel = NowDay[0].CntSigaretsToday.ToString(),
                    Label = $"{dateTime.Day}/{dateTime.Month}",
                    Color = SKColor.Parse("#FF6E40")
                }
            };

            var Today = NowDay[0];
            for (int i = 0; i < 9; ++i)
            {
                dateTime = dateTime.AddDays(-1);
                if (Today.LastDay == null)
                    break;                

                List<Day> NewDay = _realm.All<Day>().Where(f => f.Date == Today.LastDay).ToList();
                Today = NewDay[0];

                CntSigaretsAll += Today.CntSigaretsToday;

                entries.Add(new Entry(Today.CntSigaretsToday)
                {
                    ValueLabel = Today.CntSigaretsToday.ToString(),
                    Label = $"{dateTime.Day}/{dateTime.Month}",
                    Color = SKColor.Parse("#FF6E40"),                    
                });
            }

            LabelCntSigarets.Text = "Выкурено сигарет за указанный период: " + CntSigaretsAll;
            entries.Reverse();
            SmokingChart.Chart = new BarChart { Entries = entries, LabelTextSize = (float)Device.GetNamedSize(NamedSize.Small, typeof(Label)) };
        }

        private void CreateSpentChart()
        {
            int CntMoneyAll = 0;
            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);
            var AllDays = _realm.All<Day>();
            List<Day> NowDay = _realm.All<Day>().Where(f => f.NextDay == null).ToList();
            DateTime dateTime = DateTime.Today;

            CntMoneyAll += NowDay[0].SpentOnSigaretToday;
            List<Entry> entries = new List<Entry>
            {
                new Entry(NowDay[0].SpentOnSigaretToday)
                {
                    ValueLabel = NowDay[0].SpentOnSigaretToday.ToString(),
                    Label = $"{dateTime.Day}/{dateTime.Month}",
                    Color = SKColor.Parse("#FF6E40")
                }
            };

            var Today = NowDay[0];
            for (int i = 0; i < 9; ++i)
            {
                dateTime = dateTime.AddDays(-1);
                if (Today.LastDay == null)
                    break;

                List<Day> NewDay = _realm.All<Day>().Where(f => f.Date == Today.LastDay).ToList();
                Today = NewDay[0];

                CntMoneyAll += Today.SpentOnSigaretToday;

                entries.Add(new Entry(Today.SpentOnSigaretToday)
                {
                    ValueLabel = Today.SpentOnSigaretToday.ToString(),
                    Label = $"{dateTime.Day}/{dateTime.Month}",
                    Color = SKColor.Parse("#FF6E40")
                });
            }

            LabelCntMoney.Text = "Потрачено денег за указанный период: " + CntMoneyAll + "RUB";
            entries.Reverse();
            SpentChart.Chart = new BarChart { Entries = entries, LabelTextSize = (float)Device.GetNamedSize(NamedSize.Small, typeof(Label)) };
        }

        private void WantCreatePeriodSmokingChart(object sender, DateChangedEventArgs e)
        {
            DateTime From = datePickerFrom1.Date;
            DateTime To = datePickerTo1.Date;
            if (DateTime.Compare(From, To) > 0)
            {
                DisplayAlert("", "Начало периода должно быть раньше конца периода!", "OK");
                return;
            }

            int CntDays = 0;
            while (DateTime.Compare(From, To) != 0)
            {
                From = From.AddDays(1);
                CntDays++;
            }
            if (CntDays > 20)
            {
                DisplayAlert("", "В данном диапазоне Вы не сможете получить полезную информацию из-за большого количества дней. Выберите период, состоящий не более чем из 20 дней.", "OK");
                return;
            }

            CreatePeriodSmokingChart();
        }

        private void CreatePeriodSmokingChart()
        {
            int CntSigaretsAll = 0;
            DateTime From = datePickerFrom1.Date;
            DateTime To = datePickerTo1.Date;

            List<Entry> entries = new List<Entry>();
            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);

            while (DateTime.Compare(From, To) <= 0)
            {
                string nowdate = (new MyDate(From)).ToString();
                var NowDays = _realm.All<Day>().Where(f => f.Date == nowdate).ToList();
                if (NowDays.Count == 0)
                {
                    From = From.AddDays(1);

                    entries.Add(new Entry(0)
                    {
                        ValueLabel = "0",
                        Label = $"{From.Day}",
                        Color = SKColor.Parse("#FF6E40")
                    });

                    continue;
                }
                var NowDay = NowDays[0];

                CntSigaretsAll += NowDay.CntSigaretsToday;
                entries.Add(new Entry(NowDay.CntSigaretsToday)
                {
                    ValueLabel = NowDay.CntSigaretsToday.ToString(),
                    Label = $"{From.Day}",
                    Color = SKColor.Parse("#FF6E40")
                });

                From = From.AddDays(1);
            }

            LabelCntSigarets.Text = "Выкурено сигарет за указанный период: " + CntSigaretsAll;
            SmokingChart.Chart = new BarChart { Entries = entries, LabelTextSize = (float)Device.GetNamedSize(NamedSize.Small, typeof(Label)) };
        }

        private void WantCreatePeriodSpentChart(object sender, DateChangedEventArgs e)
        {
            DateTime From = datePickerFrom2.Date;
            DateTime To = datePickerTo2.Date;
            if (DateTime.Compare(From, To) > 0)
            {
                DisplayAlert("", "Начало периода должно быть раньше конца периода!", "OK");
                return;
            }

            int CntDays = 0;
            while (DateTime.Compare(From, To) != 0)
            {
                From = From.AddDays(1);
                CntDays++;
            }
            if (CntDays > 20)
            {
                DisplayAlert("", "В данном диапазоне Вы не сможете получить полезную информацию из-за большого количества дней. Выберите период, состоящий не более чем из 20 дней.", "OK");
                return;
            }

            CreatePeriodSpentChart();
        }

        private void CreatePeriodSpentChart()
        {
            int CntMoneyAll = 0;
            DateTime From = datePickerFrom2.Date;
            DateTime To = datePickerTo2.Date;

            List<Entry> entries = new List<Entry>();
            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);

            while (DateTime.Compare(From, To) <= 0)
            {
                string nowdate = (new MyDate(From)).ToString();
                var NowDays = _realm.All<Day>().Where(f => f.Date == nowdate).ToList();
                if (NowDays.Count == 0)
                {
                    From = From.AddDays(1);

                    entries.Add(new Entry(0)
                    {
                        ValueLabel = "0",
                        Label = $"{From.Day}",
                        Color = SKColor.Parse("#FF6E40")
                    });

                    continue;
                }
                var NowDay = NowDays[0];

                CntMoneyAll += NowDay.SpentOnSigaretToday;
                entries.Add(new Entry(NowDay.SpentOnSigaretToday)
                {
                    ValueLabel = NowDay.SpentOnSigaretToday.ToString(),
                    Label = $"{From.Day}",
                    Color = SKColor.Parse("#FF6E40")
                });

                From = From.AddDays(1);
            }

            LabelCntMoney.Text = "Потрачено денег за указанный период: " + CntMoneyAll + "RUB";
            SpentChart.Chart = new BarChart { Entries = entries, LabelTextSize = (float)Device.GetNamedSize(NamedSize.Small, typeof(Label)) };
        }

        private void picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stackLayout1.Children.Clear();
            stackLayout2.Children.Clear();

            if (picker1.SelectedIndex == 0)
                CreateSmokingChart();
            else if (picker1.SelectedIndex == 1)
            {
                int CntSigaretsAll = 0;
                List<Entry> entries = new List<Entry>();

                DateTime dateTimeNow = DateTime.Today;
                DateTime dateTimeLast;
                int CntSigarets;

                for (int i = 0; i < 12; ++i)
                {
                    CntSigarets = 0;
                    bool Check = false;
                    dateTimeLast = new DateTime(dateTimeNow.Year, dateTimeNow.Month, dateTimeNow.Day);

                    var config = new RealmConfiguration() { SchemaVersion = 1 };
                    Realm _realm = Realm.GetInstance(config);

                    while (dateTimeNow.Month == dateTimeLast.Month)
                    {
                        string nowdate = (new MyDate(dateTimeNow)).ToString();
                        var NowDays = _realm.All<Day>().Where(f => f.Date == nowdate).ToList();
                        if (NowDays.Count == 0)
                            break;
                        var NowDay = NowDays[0];

                        CntSigarets += NowDay.CntSigaretsToday;

                        dateTimeLast = new DateTime(dateTimeNow.Year, dateTimeNow.Month, dateTimeNow.Day);
                        dateTimeNow = dateTimeNow.AddDays(-1);
                        Check = true;
                    }

                    if (Check)
                    {
                        CntSigaretsAll += CntSigarets;
                        entries.Add(new Entry(CntSigarets)
                        {
                            ValueLabel = CntSigarets.ToString(),
                            Label = ParseToMonth[dateTimeLast.Month - 1],
                            Color = SKColor.Parse("#FF6E40")
                        });
                    }
                    else
                        break;
                }

                LabelCntSigarets.Text = "Выкурено сигарет за указанный период: " + CntSigaretsAll;
                entries.Reverse();
                SmokingChart.Chart = new BarChart { Entries = entries, LabelTextSize = (float)Device.GetNamedSize(NamedSize.Small, typeof(Label)) };
            }
            else
            {
                StartPeriod1 = new Label()
                {
                    Text = "Начало периода: ",
                    TextColor = Color.FromHex("FFC4C4C4"),
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                stackLayout1.Children.Add(StartPeriod1);
                EndPeriod1 = new Label()
                {
                    Text = "Конец периода: ",
                    TextColor = Color.FromHex("FFC4C4C4"),
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                stackLayout2.Children.Add(EndPeriod1);

                datePickerFrom1 = new DatePicker() { TextColor = Color.FromHex("#FFC4C4C4"), VerticalOptions = LayoutOptions.CenterAndExpand };
                datePickerFrom1.DateSelected += WantCreatePeriodSmokingChart;
                stackLayout1.Children.Add(datePickerFrom1);

                datePickerTo1 = new DatePicker() { TextColor = Color.FromHex("#FFC4C4C4"), VerticalOptions = LayoutOptions.CenterAndExpand };
                datePickerTo1.DateSelected += WantCreatePeriodSmokingChart;
                stackLayout2.Children.Add(datePickerTo1);

                DateTime From = datePickerFrom1.Date;
                DateTime To = datePickerTo1.Date;

                if (DateTime.Compare(From, To) > 0)
                {
                    DisplayAlert("", "Начало периода должно быть раньше конца периода!", "OK");
                    return;
                }

                CreatePeriodSmokingChart();
            }
        }

        private void picker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            stackLayout3.Children.Clear();
            stackLayout4.Children.Clear();

            if (picker2.SelectedIndex == 0)
                CreateSpentChart();
            else if (picker2.SelectedIndex == 1)
            {
                int CntMoneyAll = 0;
                List<Entry> entries = new List<Entry>();

                DateTime dateTimeNow = DateTime.Today;
                DateTime dateTimeLast;
                int Spent;

                for (int i = 0; i < 12; ++i)
                {
                    Spent = 0;
                    bool Check = false;
                    dateTimeLast = new DateTime(dateTimeNow.Year, dateTimeNow.Month, dateTimeNow.Day);

                    var config = new RealmConfiguration() { SchemaVersion = 1 };
                    Realm _realm = Realm.GetInstance(config);

                    while (dateTimeNow.Month == dateTimeLast.Month)
                    {
                        string nowdate = (new MyDate(dateTimeNow)).ToString();
                        var NowDays = _realm.All<Day>().Where(f => f.Date == nowdate).ToList();
                        if (NowDays.Count == 0)
                            break;
                        var NowDay = NowDays[0];

                        Spent += NowDay.SpentOnSigaretToday;

                        dateTimeLast = new DateTime(dateTimeNow.Year, dateTimeNow.Month, dateTimeNow.Day);
                        dateTimeNow = dateTimeNow.AddDays(-1);
                        Check = true;
                    }

                    if (Check)
                    {
                        CntMoneyAll += Spent;
                        entries.Add(new Entry(Spent)
                        {
                            ValueLabel = Spent.ToString(),
                            Label = ParseToMonth[dateTimeLast.Month - 1],
                            Color = SKColor.Parse("#FF6E40")
                        });
                    }
                    else
                        break;
                }

                LabelCntMoney.Text = "Потрачено денег за указанный период: " + CntMoneyAll + "RUB";
                entries.Reverse();
                SpentChart.Chart = new BarChart { Entries = entries, LabelTextSize = (float)Device.GetNamedSize(NamedSize.Small, typeof(Label)) };
            }
            else
            {
                StartPeriod2 = new Label()
                {
                    Text = "Начало периода: ",
                    TextColor = Color.FromHex("FFC4C4C4"),
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                stackLayout3.Children.Add(StartPeriod2);
                EndPeriod2 = new Label()
                {
                    Text = "Конец периода: ",
                    TextColor = Color.FromHex("FFC4C4C4"),
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                stackLayout4.Children.Add(EndPeriod2);

                datePickerFrom2 = new DatePicker() { TextColor = Color.FromHex("#FFC4C4C4"), VerticalOptions = LayoutOptions.CenterAndExpand };
                datePickerFrom2.DateSelected += WantCreatePeriodSpentChart;
                stackLayout3.Children.Add(datePickerFrom2);

                datePickerTo2 = new DatePicker() { TextColor = Color.FromHex("#FFC4C4C4"), VerticalOptions = LayoutOptions.CenterAndExpand };
                datePickerTo2.DateSelected += WantCreatePeriodSpentChart;
                stackLayout4.Children.Add(datePickerTo2);

                DateTime From = datePickerFrom2.Date;
                DateTime To = datePickerTo2.Date;

                if (DateTime.Compare(From, To) > 0)
                {
                    DisplayAlert("", "Начало периода должно быть раньше конца периода!", "OK");
                    return;
                }

                CreatePeriodSpentChart();
            }
        }
    }
}