using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms.Xaml;
using Realms;

namespace Calculator2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DeleteSomeDays
	{
        DatePicker datePickerFrom;

		public DeleteSomeDays ()
		{
			InitializeComponent ();

            picker.Items.Add("Все время");
            picker.Items.Add("Сегодня");
            picker.Items.Add("Период");
        }

        private void Away_Click(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (picker.SelectedIndex == -1)
            {
                DisplayAlert("", "Необходимо выбрать период, за который хотите удалить данные!", "OK");
                return;
            }

            if (picker.SelectedIndex == 0)
            {
                WantDelete(sender, e, 1);
            }
            else if (picker.SelectedIndex == 1)
            {
                WantDelete(sender, e, 2);
            }
            else
            {
                DateTime start = datePickerFrom.Date;
                DateTime end = DateTime.Today;

                if (DateTime.Compare(start, end) > 0)
                {
                    DisplayAlert("", "Начальная дата периода должна быть раньше конечной!", "OK");
                }
                else
                    WantDelete(sender, e, 3);
            }
        }

        private void WantDelete(object sender, EventArgs e, int type)
        {
            if (type == 1)
            {
                var config = new RealmConfiguration() { SchemaVersion = 1 };
                Realm _realm = Realm.GetInstance(config);
                var AllDays = _realm.All<Day>().ToList();

                for (int i = 0; i < AllDays.Count; ++i)
                {
                    _realm.Write(() => _realm.Remove(AllDays[i]));
                }

                _realm.Write(() => _realm.Add(new Day()));
                var AllDay = _realm.All<Day>();
                var AllNewDay = _realm.All<Day>().Where(f => f.NextDay == null).ToList();
                var NewDay = AllNewDay[0];
                MyDate Time = new MyDate(DateTime.Now);
                string StrTime = Time.ToString();
                string nowdate = (new MyDate(DateTime.Today)).ToString();

                _realm.Write(() => NewDay.Date = nowdate);
                _realm.Write(() => NewDay.CntSigarets = 0);
                _realm.Write(() => NewDay.CntSigaretsToday = 0);
                _realm.Write(() => NewDay.DateLast = StrTime);
                _realm.Write(() => NewDay.LastSigaret = StrTime);
                _realm.Write(() => NewDay.LastSigaretYesterday = StrTime);
                _realm.Write(() => NewDay.SigaretAverageSpan = 0);
                _realm.Write(() => NewDay.SigaretAverageSpanYesterday = 0);
                _realm.Write(() => NewDay.FirstSigaret = StrTime);
                _realm.Write(() => NewDay.CntEndSmoking = 1);
                _realm.Write(() => NewDay.MaxTimeWithoutSigaret = 0);
                _realm.Write(() => NewDay.SpentOnSigaretAll = 0);
                _realm.Write(() => NewDay.SpentOnSigaretToday = 0);

                DisplayAlert("", "Данные удалены!", "OK");
                PopupNavigation.Instance.PopAsync(true);
            }
            else if (type == 2)
            {
                string nowdate = DateTime.Today.ToString();
                var config = new RealmConfiguration() { SchemaVersion = 1 };
                Realm _realm = Realm.GetInstance(config);
                var AllDays = _realm.All<Day>();
                List<Day> NowDay = _realm.All<Day>().Where(f => f.NextDay == null).ToList();
                Day Today = NowDay[0];
                string NextDay = NowDay[0].Date;
                List<Day> LastDay = _realm.All<Day>().Where(f => f.NextDay == NextDay).ToList();
                Day Yesterday = new Day();
                if (LastDay.Count != 0)
                    Yesterday = LastDay[0];

                int CntSigaretsAll = Today.CntSigarets;
                int CntSigaretsToday = Today.CntSigaretsToday;
                MyDate DateLast = new MyDate(Today.DateLast);
                MyDate LastSigarete = new MyDate(Today.LastSigaret);
                MyDate LastSigareteYesterday = new MyDate(Today.LastSigaretYesterday);
                int AverageSpan = Today.SigaretAverageSpan;
                int AverageSpanYesterday = Today.SigaretAverageSpanYesterday;
                MyDate FirstSigaret = new MyDate(Today.FirstSigaret);
                int CntEndSmoking = Today.CntEndSmoking;
                int MaxTime = Today.MaxTimeWithoutSigaret;

                _realm.Write(() => Today.CntSigarets = CntSigaretsAll - CntSigaretsToday);
                _realm.Write(() => Today.CntSigaretsToday = 0);
                _realm.Write(() => Today.DateLast = DateLast.ToString());
                _realm.Write(() => Today.LastSigaret = LastSigareteYesterday.ToString());
                _realm.Write(() => Today.LastSigaretYesterday = LastSigareteYesterday.ToString());
                _realm.Write(() => Today.SigaretAverageSpan = (int)AverageSpanYesterday);
                _realm.Write(() => Today.SigaretAverageSpanYesterday = (int)AverageSpanYesterday);
                _realm.Write(() => Today.FirstSigaret = FirstSigaret.ToString());
                _realm.Write(() => Today.CntEndSmoking = CntEndSmoking);
                _realm.Write(() => Today.MaxTimeWithoutSigaret = (int)MaxTime);
                if (LastDay.Count != 0)
                    _realm.Write(() => Today.SpentOnSigaretAll = Yesterday.SpentOnSigaretAll);
                else
                    _realm.Write(() => Today.SpentOnSigaretAll = 0);
                _realm.Write(() => Today.SpentOnSigaretToday = 0);

                DisplayAlert("", "Данные удалены!", "OK");
                PopupNavigation.Instance.PopAsync(true);
            }
            else if (type == 3)
            {
                var config = new RealmConfiguration() { SchemaVersion = 1 };
                Realm _realm = Realm.GetInstance(config);                
                string lastdate = (new MyDate(datePickerFrom.Date)).ToString();
                var AllLastDay = _realm.All<Day>().Where(f => f.Date == lastdate).ToList();
                if (AllLastDay.Count == 0)
                {
                    DisplayAlert("","В выбранную начальную дату вы ещё не пользовались приложением!","OK");
                    return;
                }
                var LastDay = AllLastDay[0];
                string LastGoodDay = LastDay.LastDay;

                string NowDelDay = LastDay.Date;
                while (NowDelDay != null)
                {
                    var AllNowDelDay = _realm.All<Day>().Where(f => f.Date == NowDelDay).ToList();
                    var NowDel = AllNowDelDay[0];
                    NowDelDay = NowDel.NextDay;

                    _realm.Write(() => _realm.Remove(NowDel));
                }

                if (LastGoodDay == null)
                {
                    WantDelete(sender, e, 1);
                    return;
                }

                var AllGoodDays = _realm.All<Day>().Where(f => f.Date == LastGoodDay).ToList();
                var GoodDay = AllGoodDays[0];
                int CntSigaretsAll = GoodDay.CntSigarets;
                int CntSigaretsToday = GoodDay.CntSigaretsToday;
                string LastSigaret = GoodDay.LastSigaret;
                string LastSigaretYesterday = GoodDay.LastSigaretYesterday;
                int SigaretAverageSpan = GoodDay.SigaretAverageSpan;
                int SigaretAverageSpanYesterday = GoodDay.SigaretAverageSpanYesterday;
                string FirstSigaret = GoodDay.FirstSigaret;
                int CntEndSmoking = GoodDay.CntEndSmoking;
                int MaxTimeWithoutSigaret = GoodDay.MaxTimeWithoutSigaret;
                int SpentOnSigaretAll = GoodDay.SpentOnSigaretAll;
                int SpentOnSigaretToday = GoodDay.SpentOnSigaretToday;
                string DateLast = GoodDay.DateLast;

                DateTime NowDate = DateTime.Today;
                string nextday = "1";                
                while ((new MyDate(NowDate)).ToString() != LastGoodDay)
                {
                    _realm.Write(() => _realm.Add(new Day()));                    
                    var AllNewDay = _realm.All<Day>().Where(f => f.NextDay == null).ToList();
                    var DayAdd = AllNewDay[0];
                    string nowdate = (new MyDate(NowDate)).ToString();

                    _realm.Write(() => DayAdd.Date = nowdate);
                    _realm.Write(() => DayAdd.CntSigarets = CntSigaretsAll);
                    _realm.Write(() => DayAdd.CntSigaretsToday = 0);
                    _realm.Write(() => DayAdd.LastSigaret = LastSigaret);
                    _realm.Write(() => DayAdd.LastSigaretYesterday = LastSigaretYesterday);
                    _realm.Write(() => DayAdd.SigaretAverageSpan = SigaretAverageSpan);
                    _realm.Write(() => DayAdd.SigaretAverageSpanYesterday = SigaretAverageSpanYesterday);
                    _realm.Write(() => DayAdd.FirstSigaret = FirstSigaret);
                    _realm.Write(() => DayAdd.CntEndSmoking = CntEndSmoking);
                    _realm.Write(() => DayAdd.MaxTimeWithoutSigaret = MaxTimeWithoutSigaret);
                    _realm.Write(() => DayAdd.NextDay = nextday);
                    _realm.Write(() => DayAdd.SpentOnSigaretAll = SpentOnSigaretAll);
                    _realm.Write(() => DayAdd.SpentOnSigaretToday = 0);
                    _realm.Write(() => DayAdd.DateLast = DateLast);

                    nextday = (new MyDate(NowDate)).ToString();
                    NowDate = NowDate.AddDays(-1);
                    string last = (new MyDate(NowDate)).ToString();

                    _realm.Write(() => DayAdd.LastDay = last);
                }

                nextday = "1";
                var AllNewDay1 = _realm.All<Day>().Where(f => f.NextDay == nextday).ToList();
                var DayAdd1 = AllNewDay1[0];                
                _realm.Write(() => DayAdd1.NextDay = null);
                var All = _realm.All<Day>().ToList();

                DisplayAlert("", "Данные удалены!", "OK");
                PopupNavigation.Instance.PopAsync(true);
            }
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = picker.Items[picker.SelectedIndex];

            if (SelectedItem == "Период")
            {
                stackLayout1.Children.Add(new Label()
                {
                    Text = "Начальная дата: ",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Start,
                });

                datePickerFrom = new DatePicker();
                stackLayout1.Children.Add(datePickerFrom);

                stackLayout2.Children.Add(new Label()
                {
                    Text = "Конечная дата: " + DateTime.Today.ToString("d"),
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Start
                });
            }
            else
            {
                stackLayout1.Children.Clear();
                stackLayout2.Children.Clear();
            }
        }

    }
}