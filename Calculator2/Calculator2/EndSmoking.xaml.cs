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
    public partial class EndSmoking : ContentPage
    {
        Dictionary<string, int> GetInformation = new Dictionary<string, int>(0);
        MyDate DateNow = new MyDate();
        MyDate DateLast = new MyDate();
        MyDate LastSigarete = new MyDate();
        MyDate LastSigareteYesterday = new MyDate();
        MyDate FirstSigaret = new MyDate();        
        double AverageSpan = 0, AverageSpanYesterday = 0;
        int CntEndSmoking = 1;
        long MaxTime = 0;

        public EndSmoking()
        {
            InitializeComponent();
            ReadMyInfo();

            CntEndSmoking++;
            ChangeInfo();
        }

        // Запись новых данных в файл
        private void ChangeInfo()
        {
            string nowdate = (new MyDate(DateTime.Today)).ToString();
            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);
            var AllDays = _realm.All<Day>();
            List<Day> NowDay = _realm.All<Day>().Where(f => f.NextDay == null).ToList();
            Day Today = NowDay[0];

            _realm.Write(() => Today.CntSigarets = GetInformation["Cnt_sigarets"]);
            _realm.Write(() => Today.CntSigaretsToday = GetInformation["Cnt_sigarets_today"]);
            _realm.Write(() => Today.DateLast = (new MyDate(DateTime.Now)).ToString());
            _realm.Write(() => Today.LastSigaret = LastSigarete.ToString());
            _realm.Write(() => Today.LastSigaretYesterday = LastSigareteYesterday.ToString());
            _realm.Write(() => Today.SigaretAverageSpan = (int)AverageSpan);
            _realm.Write(() => Today.SigaretAverageSpanYesterday = (int)AverageSpanYesterday);
            _realm.Write(() => Today.FirstSigaret = FirstSigaret.ToString());
            _realm.Write(() => Today.CntEndSmoking = CntEndSmoking);
            _realm.Write(() => Today.MaxTimeWithoutSigaret = (int)MaxTime);
            _realm.Write(() => Today.Date = nowdate);
        }

        // Чтение данных из файла
        private void ReadMyInfo()
        {
            string nowdate = DateTime.Today.ToString();
            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);
            var AllDay = _realm.All<Day>();
            var AllToday = _realm.All<Day>().Where(f => f.NextDay == null).ToList();
            var Today = AllToday[0];

            GetInformation["Cnt_sigarets"] = Today.CntSigarets;
            GetInformation["Cnt_sigarets_today"] = Today.CntSigaretsToday;
            DateLast = new MyDate(Today.DateLast);
            LastSigarete = new MyDate(Today.LastSigaret);
            LastSigareteYesterday = new MyDate(Today.LastSigaretYesterday);
            AverageSpan = Today.SigaretAverageSpan;
            AverageSpanYesterday = Today.SigaretAverageSpanYesterday;
            FirstSigaret = new MyDate(Today.FirstSigaret);
            CntEndSmoking = Today.CntEndSmoking;
            MaxTime = Today.MaxTimeWithoutSigaret;
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {            
            CntEndSmoking++;

            ChangeInfo();
        }

    }
}