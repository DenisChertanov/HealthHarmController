using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;

namespace Calculator2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sigarets : MasterDetailPage
    {
        public static bool flag = false;

        public Sigarets()
        {
            InitializeComponent();

            // При повторном запуске раздела сигарет нужно открыть последний открытый раздел в сигаретах
            Detail = new NavigationPage(new General() { Title = "Основное" })
            {
                BarBackgroundColor = Color.FromHex("#B00020")
            };
            IsPresented = false;
        }

        // Раздел "Основное"
        private void ButtonClick1(Object sender, EventArgs e)
        {
            flag = false;
            Detail = new NavigationPage(new General() { Title = "Основное" })
            {
                BarBackgroundColor = Color.FromHex("#B00020")
            };

            IsPresented = false;
        }

        // Раздел "Сброс данных"
        private void ButtonClick2(Object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new DeleteSomeDays());

            IsPresented = false;
        }

        // Раздел "Я бросил курить!"
        private void ButtonClick3(Object sender, EventArgs e)
        {
            EndSmoking endSmoking = new EndSmoking();
            DisplayAlert("", "Поздравляем, Вам удалось отказаться от сигарет!", "ОК");

            IsPresented = false;
        }

        // Раздел "Аналитика"
        private void ButtonClick4(Object sender, EventArgs e)
        {
            flag = true;
            Detail = new NavigationPage(new Analitics() { Title = "Статистика" })
            {
                BarBackgroundColor = Color.FromHex("#B00020")
            };

            IsPresented = false;
        }

        // Раздел "Просмотр данных по дням"
        private void ButtonClick5(Object sender, EventArgs e)
        {
            flag = true;
            Detail = new NavigationPage(new ViewSomeDay() { Title = "Просмотр данных" })
            {
                BarBackgroundColor = Color.FromHex("#B00020")
            };

            IsPresented = false;
        }

        // Раздел "Минусы курения"
        private void ButtonClick6(Object sender, EventArgs e)
        {
            flag = true;
            Detail = new NavigationPage(new WatchMinuses() { Title = "Минусы курения" })
            {
                BarBackgroundColor = Color.FromHex("#B00020")
            };

            IsPresented = false;
        }

        // Раздел "Польза отказа от курения"
        private void ButtonClick7(Object sender, EventArgs e)
        {
            flag = true;
            Detail = new NavigationPage(new WatchPluses() { Title = "Польза отказа" })
            {
                BarBackgroundColor = Color.FromHex("#B00020")
            };

            IsPresented = false;
        }

        // Раздел план на день
        private void ButtonClick8(Object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PlanOnDay());

            IsPresented = false;
        }
    }
}