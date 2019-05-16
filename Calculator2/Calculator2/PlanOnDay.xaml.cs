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
    public partial class PlanOnDay
    {
        public PlanOnDay()
        {
            InitializeComponent();
        }

        private void OutClicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
        }

        private void AddClick(object sender, EventArgs e)
        {
            if (NeedCntSigarets.Text == null)
                NeedCntSigarets.Text = "";
            if (NeedCntMoney.Text == null)
                NeedCntMoney.Text = "";

            int CntSigarets = -1, CntMoney = -1;
            if (NeedCntSigarets.Text != "")
            {
                bool check = int.TryParse(NeedCntSigarets.Text, out CntSigarets);
                if (!check || CntSigarets < 0)
                {
                    DisplayAlert("", "Желаемое количество сигарет должно быть неотрицательным числом!", "OK");
                    return;
                }
            }
            if (NeedCntMoney.Text != "")
            {
                bool check = int.TryParse(NeedCntMoney.Text, out CntMoney);
                if (!check || CntMoney < 0)
                {
                    DisplayAlert("", "Желаемая трата денег на сигареты может быть неотрицательным!", "OK");
                    return;
                }
            }

            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);
            var AllPlans = _realm.All<Plans>().ToList();
            var Plan = AllPlans[0];

            _realm.Write(() => Plan.NeedCntSigaretsInDay = CntSigarets);
            _realm.Write(() => Plan.NeedCntMoneyInDay = CntMoney);

            DisplayAlert("", "План на день изменён!", "OK");
            PopupNavigation.Instance.PopAsync(true);
        }
    }
}