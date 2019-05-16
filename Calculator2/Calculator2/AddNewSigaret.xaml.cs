using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;
using Realms;

namespace Calculator2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewSigaret
    {
        public AddNewSigaret()
        {            
            InitializeComponent();
        }

        private void OutClicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
        }

        private void AddClick(object sender, EventArgs e)
        {
            if (Name.Text == null || Cnt.Text == null || Cost.Text == null)
            {
                BadAlarm();
                return;
            }

            if (Name.Text == "" || Cnt.Text == "" || Cost.Text == "")
            {
                BadAlarm();
                return;
            }

            uint CntSigaret = 0, CostSigaret = 0;

            if (!uint.TryParse(Cnt.Text, out CntSigaret) || !uint.TryParse(Cost.Text, out CostSigaret) || CostSigaret == 0)
            {
                BadAlarm();
                return;
            }

            var config1 = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config1);
            var AllSigarets = _realm.All<SigaretsBrands>().ToList();
            for (int i = 0; i < AllSigarets.Count; ++i)
            {
                if (AllSigarets[i].Name.Length != Name.Text.Length)
                    continue;

                bool flag = true;
                for (int j = 0; j < AllSigarets[i].Name.Length; ++i)
                {
                    if (Char.ToUpper(AllSigarets[i].Name[j]) != Char.ToUpper(Name.Text[j]))
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    BadAlarm();
                    return;
                }
            }

            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _Realm = Realm.GetInstance(config);
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            var AllSigaret = _Realm.All<SigaretsBrands>();
            var AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            var NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = Name.Text);
            _Realm.Write(() => NewSigaret.Cost = (int)CostSigaret);
            _Realm.Write(() => NewSigaret.Cnt = (int)CntSigaret);
            
            DisplayAlert("", "Бренд сигарет добавлен!", "ОK");

            PopupNavigation.Instance.PopAsync(true);
        }

        private void BadAlarm()
        {
            DisplayAlert("", "Не удалось добавить бренд!", "ОK");
        }
    }
}