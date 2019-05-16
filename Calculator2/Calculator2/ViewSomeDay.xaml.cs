using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Realms;

namespace Calculator2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewSomeDay : ContentPage
	{
        Dictionary<string, int> GetInformation = new Dictionary<string, int>(0);
        MyDate DateNow = new MyDate();        
        MyDate LastSigarete = new MyDate();
        MyDate LastSigareteYesterday = new MyDate();
        MyDate FirstSigaret = new MyDate();
        double AverageSpan = 0, AverageSpanYesterday = 0;
        int CntEndSmoking = 1;
        long MaxTime = 0;
        int SpentOnSigaretToday = 0;
        int SpentOnSigaretAll = 0;

        public ViewSomeDay ()
		{
			InitializeComponent ();

            // Вывод данных за текущий день (по умолчанию)
            ReadMyInfo((new MyDate(DateTime.Today)).ToString(), new MyDate(DateTime.Today));            

            // Обработчики изменения даты
            datePicker.DateSelected += WantRead;            
        }

        // Обработчик изменения даты
        private void WantRead(object sender, DateChangedEventArgs e)
        {
            string SearchDate = (new MyDate(e.NewDate)).ToString();

            ReadMyInfo(SearchDate, new MyDate(e.NewDate));
        }

        // Чтение данных из БД
        private void ReadMyInfo(string Search, MyDate DateForSearch)
        {
            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);
            var AllDay = _realm.All<Day>();
            string SearchDate = Search;
            var AllNeedDays = _realm.All<Day>().Where(f => f.Date == SearchDate).ToList();
            if (AllNeedDays.Count == 0) // Вывод если в этот день не велась статистика
            {
                PrintException();
                return;
            }
            var NeedDay = AllNeedDays[0];

            GetInformation["Cnt_sigarets"] = NeedDay.CntSigarets;
            GetInformation["Cnt_sigarets_today"] = NeedDay.CntSigaretsToday;            
            LastSigarete = new MyDate(NeedDay.LastSigaret);
            LastSigareteYesterday = new MyDate(NeedDay.LastSigaretYesterday);
            AverageSpan = NeedDay.SigaretAverageSpan;
            AverageSpanYesterday = NeedDay.SigaretAverageSpanYesterday;
            FirstSigaret = new MyDate(NeedDay.FirstSigaret);
            CntEndSmoking = NeedDay.CntEndSmoking;
            MaxTime = NeedDay.MaxTimeWithoutSigaret;
            SpentOnSigaretAll = NeedDay.SpentOnSigaretAll;
            SpentOnSigaretToday = NeedDay.SpentOnSigaretToday;

            // Если сбросили статистику или не использовали приложение
            if (NeedDay.CntSigarets == 0)
            {
                PrintException();
                return;
            }

            PrintInfo(Search, DateForSearch);
        }

        // Вывод данных из БД
        private void PrintInfo(string SearchDate, MyDate NeedDay)
        {            
            if (DateTime.Today.ToString() != SearchDate)
            {
                NeedDay.Hour = 23;
                NeedDay.Minute = 59;
                NeedDay.Second = 00;
            }
            else
            {
                NeedDay = new MyDate(DateTime.Now);
            }
            
            LabelSigaretsAll.Text = "Количество сигарет всего: " + GetInformation["Cnt_sigarets"];
            LabelSigaretsToday.Text = "Количество сигарет сегодня: " + GetInformation["Cnt_sigarets_today"];            
            LabelFromLastSigaret.Text = MyDate.TimeToString(MyDate.DateToLong(NeedDay) - MyDate.DateToLong(LastSigarete), 1);            
            LabelAverageSpan.Text = MyDate.TimeToString((long)AverageSpan, 3);
            LabelFirstSigaret.Text = "Дата первой сигареты: \n" + FirstSigaret.ToString();            
            LabelFromFirstSigaret.Text = MyDate.TimeToString(MyDate.DateToLong(NeedDay) - MyDate.DateToLong(FirstSigaret), 5);
            LabelCntEndSmoking.Text = "Попытка бросить курить: " + CntEndSmoking + "я";
            LabelMaxTime.Text = MyDate.TimeToString(MaxTime, 7);            
            LabelSpentOnSigaretAll.Text = "Потрачено на сигареты: " + SpentOnSigaretAll + "RUB";
            LabelSpentOnSigaretToday.Text = "Потрачено на сигареты сегодня: " + SpentOnSigaretToday + "RUB";
        }

        // Вывод данных за день, в который не вёлся учёт
        private void PrintException()
        {
            LabelSigaretsAll.Text = "Количество сигарет всего: ?";
            LabelSigaretsToday.Text = "Количество сигарет сегодня: ?";
            LabelFromLastSigaret.Text = "С последней сигареты: ?";
            LabelAverageSpan.Text = "Среднее время между сигаретами: ?";
            LabelFirstSigaret.Text = "Дата первой сигареты: ?";
            LabelFromFirstSigaret.Text = "С первой сигареты прошло: ?";
            LabelCntEndSmoking.Text = "Попытка бросить курить: ?";
            LabelMaxTime.Text = "Максимальный промежуток воздержания: ?";            
            LabelSpentOnSigaretAll.Text = "Потрачено на сигареты: ?";
            LabelSpentOnSigaretToday.Text = "Потрачено на сигареты сегодня: ?";
        }
    }
}