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
    public partial class General : ContentPage
    {
        Dictionary<string, int> GetInformation = new Dictionary<string, int>(0);
        MyDate DateNow = new MyDate();
        MyDate DateLast = new MyDate();
        MyDate LastSigarete = new MyDate(DateTime.Today);
        MyDate LastSigareteYesterday = new MyDate();
        MyDate FirstSigaret = new MyDate();
        double AverageSpan = 0, AverageSpanYesterday = 0;
        int CntEndSmoking = 1;
        long MaxTime = 0;
        int SpentOnSigaretToday = 0;
        int SpentOnSigaretAll = 0;
        bool MayBreakPlan = true;

        public General()
        {
            InitializeComponent();

            ToolbarItem tb = new ToolbarItem
            {
                Text = "Выбор марки сигарет",
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
                Icon = new FileImageSource
                {
                    File = "Sigarets.png"
                }
            };
            tb.Clicked += async (s, e) =>
            {
                ChooseSigaretsBrand chooseSigaretsBrand = new ChooseSigaretsBrand();
                NavigationPage.SetHasNavigationBar(chooseSigaretsBrand, true);
                await Navigation.PushAsync(chooseSigaretsBrand, false);
            };
            ToolbarItems.Add(tb);

            CheckChangeTime();
            CreateInfo(); // Создание БД, если её нет
            ReadMyInfo(); // Чтение данных с последнего запуска
            MyInitialize(); // Настройка видимой информации при запуске

            DateNow = new MyDate(DateTime.Now); // Помечание текущего времени            

            Device.StartTimer(TimeSpan.FromTicks(1000000), OnTimerTick); // Таймер для обновления времени                        
        }

        private void AddDays()
        {
            DateTime LDay = new DateTime(DateLast.Year, DateLast.Month, DateLast.Day);
            DateTime NDay = new DateTime(DateNow.Year, DateNow.Month, DateNow.Day);

            while (LDay.CompareTo(NDay) != 0)
            {
                DateTime NewDay = LDay.AddDays(1);

                string nowdate = (new MyDate(NewDay.Date)).ToString();
                string lastdate;

                // Изменим ссылку в старом дне
                var config = new RealmConfiguration() { SchemaVersion = 1 };
                Realm _realm = Realm.GetInstance(config);
                var AllDay = _realm.All<Day>();
                var AllNewDay = _realm.All<Day>().Where(f => f.NextDay == null).ToList();
                var LastDay = AllNewDay[0];
                _realm.Write(() => LastDay.NextDay = nowdate);
                lastdate = LastDay.Date;

                // Создадим новый день
                var config1 = new RealmConfiguration() { SchemaVersion = 1 };
                Realm _Realm = Realm.GetInstance(config1);
                _Realm.Write(() => _Realm.Add(new Day()));
                AllNewDay = _Realm.All<Day>().Where(f => f.NextDay == null).ToList();
                var DayAdd = AllNewDay[0];
                _Realm.Write(() => DayAdd.Date = nowdate);
                _Realm.Write(() => DayAdd.CntSigarets = LastDay.CntSigarets);
                _Realm.Write(() => DayAdd.CntSigaretsToday = 0);
                _Realm.Write(() => DayAdd.LastSigaret = LastDay.LastSigaret);
                _Realm.Write(() => DayAdd.LastSigaretYesterday = LastDay.LastSigaret);
                _Realm.Write(() => DayAdd.SigaretAverageSpan = LastDay.SigaretAverageSpan);
                _Realm.Write(() => DayAdd.SigaretAverageSpanYesterday = LastDay.SigaretAverageSpan);
                _Realm.Write(() => DayAdd.FirstSigaret = LastDay.FirstSigaret);
                _Realm.Write(() => DayAdd.CntEndSmoking = LastDay.CntEndSmoking);
                _Realm.Write(() => DayAdd.MaxTimeWithoutSigaret = LastDay.MaxTimeWithoutSigaret);
                _Realm.Write(() => DayAdd.LastDay = lastdate);
                _Realm.Write(() => DayAdd.SpentOnSigaretAll = LastDay.SpentOnSigaretAll);
                _Realm.Write(() => DayAdd.SpentOnSigaretToday = 0);
                _Realm.Write(() => DayAdd.DateLast = LastDay.DateLast);

                GetInformation["Cnt_sigarets_today"] = 0;
                LastSigareteYesterday = new MyDate(LastDay.LastSigaret);
                AverageSpanYesterday = LastDay.SigaretAverageSpan;
                SpentOnSigaretToday = 0;
                AverageSpan = DayAdd.SigaretAverageSpan;
                AverageSpanYesterday = DayAdd.SigaretAverageSpanYesterday;
                CntEndSmoking = DayAdd.CntEndSmoking;
                MaxTime = DayAdd.MaxTimeWithoutSigaret;
                SpentOnSigaretAll = DayAdd.SpentOnSigaretAll;

                LDay = NewDay;
            }
        }

        // Проверка и перезапись времени последнего обновления
        private bool OnTimerTick()
        {
            CheckChangeTime();
            ReadMyInfo();

            if (Sigarets.flag)
                return true;

            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);
            var AllMemory = _realm.All<Memory>().ToList();
            if (AllMemory.Count == 0)
            {
                BrandSigaret.Text = "Выбранный бренд: ?";
            }
            else
            {
                var NewMemory = AllMemory[0];
                BrandSigaret.Text = "Выбранный бренд: " + NewMemory.SigaretBrand;
            }

            DateNow = new MyDate(DateTime.Now);
            LabelCntEndSmoking.Text = "Попытка бросить курить: " + CntEndSmoking + "я";

            if (DateLast.Day != DateNow.Day || DateLast.Month != DateNow.Month || DateLast.Year != DateNow.Year)
            {
                AddDays();
            }

            if (GetInformation["Cnt_sigarets"] >= 1)
            {
                LabelFromLastSigaret.Text = MyDate.TimeToString(MyDate.DateToLong(DateNow) - MyDate.DateToLong(LastSigarete), 1);

                LabelFromFirstSigaret.Text = MyDate.TimeToString(MyDate.DateToLong(DateNow) - MyDate.DateToLong(FirstSigaret), 5);

                LabelFirstSigaret.Text = "Дата первой сигареты: \n" + FirstSigaret.ToString();

                if (GetInformation["Cnt_sigarets"] >= 2)
                {
                    LabelAverageSpan.Text = MyDate.TimeToString((long)AverageSpan, 3);
                    LabelMaxTime.Text = MyDate.TimeToString(MaxTime, 7);
                }
            }
            else
            {
                LabelFromLastSigaret.Text = "С последней сигареты прошло: ?";

                LabelFromFirstSigaret.Text = "С первой сигареты прошло: ?";

                LabelFirstSigaret.Text = "Дата первой сигареты: ?";
            }

            DateLast = new MyDate(DateNow.ToString());
            ChangeInfo();
            return true;
        }

        // Запись новых данных в файл
        private void ChangeInfo()
        {
            string nowdate = DateTime.Today.ToString();
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
            _realm.Write(() => Today.SpentOnSigaretAll = SpentOnSigaretAll);
            _realm.Write(() => Today.SpentOnSigaretToday = SpentOnSigaretToday);

            LabelSigaretsAll.Text = "Количество сигарет всего: " + GetInformation["Cnt_sigarets"].ToString();
            LabelSigaretsToday.Text = "Количество сигарет сегодня: " + GetInformation["Cnt_sigarets_today"].ToString();

            SpentAll.Text = "Потрачено на сигареты: " + SpentOnSigaretAll + "RUB";
            SpentToday.Text = "Потрачено на сигареты сегодня: " + SpentOnSigaretToday + "RUB";
        }

        // Чтение данных из файла
        private void ReadMyInfo()
        {
            string nowdate = DateTime.Now.ToString();
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
            SpentOnSigaretAll = Today.SpentOnSigaretAll;
            SpentOnSigaretToday = Today.SpentOnSigaretToday;
        }

        // Внешний вид лэйблов при запуске
        private void MyInitialize()
        {
            LabelSigaretsAll.Text = "Количество сигарет всего: " + GetInformation["Cnt_sigarets"].ToString();
            LabelSigaretsToday.Text = "Количество сигарет сегодня: " + GetInformation["Cnt_sigarets_today"].ToString();
        }

        private void GetAverageSpan(MyDate a, MyDate b)
        {
            AverageSpan *= GetInformation["Cnt_sigarets"] - 2;
            AverageSpan += (MyDate.DateToLong(b) - MyDate.DateToLong(a));
            AverageSpan /= GetInformation["Cnt_sigarets"] - 1;

            LabelAverageSpan.Text = MyDate.TimeToString((long)AverageSpan, 3);
        }

        // Проверка на наличие и выполнение плана
        private async void CheckPlan(object sender, EventArgs e)
        {
            bool ans1 = true, ans2 = true;
            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);
            var AllPlans = _realm.All<Plans>().ToList();
            var Plan = AllPlans[0];
            if (Plan.NeedCntSigaretsInDay != -1)
            {
                if (GetInformation["Cnt_sigarets_today"] >= Plan.NeedCntSigaretsInDay)
                {
                    ans1 = await DisplayAlert("", "Вы уверены, что хотите превысить свой план сигарет на день?", "Да", "Нет");
                }
            }
            if (Plan.NeedCntMoneyInDay != -1)
            {
                if (SpentOnSigaretToday >= Plan.NeedCntMoneyInDay)
                {
                    ans2 = await DisplayAlert("", "Вы уверены, что хотите превысить свой план траты денег на день?", "Да", "Нет");
                }
            }
            MayBreakPlan = (ans1 && ans2);

            // В случае положительного ответа увеличиваем количество сигарет
            if (!MayBreakPlan)
                return;
            Button button = (Button)sender;

            if (GetInformation["Cnt_sigarets"] == 0)
            {
                FirstSigaret = new MyDate(DateTime.Now);
                LabelFirstSigaret.Text = "Дата первой сигареты: " + FirstSigaret.ToString();
            }
            else
            {
                MaxTime = Math.Max(MyDate.DateToLong(new MyDate(DateTime.Now)) - MyDate.DateToLong(LastSigarete), MaxTime);
            }

            GetInformation["Cnt_sigarets"]++;
            GetInformation["Cnt_sigarets_today"]++;

            if (GetInformation["Cnt_sigarets"] > 1)
                GetAverageSpan(LastSigarete, new MyDate(DateTime.Now));

            LastSigarete = new MyDate(DateTime.Now);

            var AllMemory = _realm.All<Memory>().ToList();
            if (AllMemory.Count != 0)
            {
                var NewMemory = AllMemory[0];

                var config1 = new RealmConfiguration() { SchemaVersion = 1 };
                Realm _Realm = Realm.GetInstance(config1);
                var AllSigaret = _Realm.All<SigaretsBrands>();
                var AllMySigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == NewMemory.SigaretBrand).ToList();
                var MySigaret = AllMySigaret[0];

                SpentOnSigaretToday += (int)(MySigaret.Cost / MySigaret.Cnt);
                SpentOnSigaretAll += (int)(MySigaret.Cost / MySigaret.Cnt);
            }

            ChangeInfo();
        }

        // Увеличение количества сигарет на 1
        private void OnButtonClicked1(object sender, EventArgs e)
        {
            CheckPlan(sender, e);
        }

        // Создание БД, если её нет
        private void CreateInfo()
        {
            // Создание БД дней, если она не создана
            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);
            //_realm.Write(() => _realm.RemoveAll());
            List<Day> AllDays = _realm.All<Day>().ToList();
            string nowdate = (new MyDate(DateTime.Today)).ToString();

            if (AllDays.Count == 0)
            {
                // Добавим начальный план на день
                _realm.Write(() => _realm.Add(new Plans() { NeedCntSigaretsInDay = -1, NeedCntMoneyInDay = -1 }));

                _realm.Write(() => _realm.Add(new Day()));
                var AllDay = _realm.All<Day>();
                var AllNewDay = _realm.All<Day>().Where(f => f.NextDay == null).ToList();
                var NewDay = AllNewDay[0];

                MyDate Time = new MyDate(DateTime.Now);
                string StrTime = Time.ToString();

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
            }

            // Создание БД сигарет, если она не создана
            var config1 = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _Realm = Realm.GetInstance(config1);
            List<SigaretsBrands> AllSigarets = _Realm.All<SigaretsBrands>().ToList();

            if (AllSigarets.Count == 0)
            {
                AddSigaretsLibrary.CreateLibrary();

                var config2 = new RealmConfiguration() { SchemaVersion = 1 };
                Realm _Realms = Realm.GetInstance(config2);
                _Realms.Write(() => _Realms.Add(new TopBrands()));
            }
        }

        // Проверка на перевод времени назад
        private void CheckChangeTime()
        {
            int t;
            if (GetInformation.Count != 0 && GetInformation["Cnt_sigarets"] == 1)
                t = 1;

            DateTime dateTime = DateTime.Today;
            DateTime dateTime1 = DateTime.Now;

            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _realm = Realm.GetInstance(config);
            var LastDay = _realm.All<Day>().Where(f => f.NextDay == null).ToList();
            
            if (LastDay.Count != 0)
            {
                MyDate myDate = new MyDate(LastDay[0].Date);
                DateTime dateTimeLast = new DateTime(myDate.Year, myDate.Month, myDate.Day);
                
                if (dateTime.CompareTo(dateTimeLast) < 0) // значит время переводили назад как минимум на 1 день
                {
                    string str = (new MyDate(dateTime)).ToString();
                    var NowDay = _realm.All<Day>().Where(f => f.Date == str).ToList();
                    var ForUpd = _realm.All<Day>().Where(f => f.NextDay == str).ToList();

                    if (NowDay.Count == 0 || ForUpd.Count == 0) // Удалим все дни и добавим новый
                    {
                        var AllDays = _realm.All<Day>().ToList();

                        for (int i = 0; i < AllDays.Count; ++i)
                        {
                            _realm.Write(() => _realm.Remove(AllDays[i]));
                        }

                        _realm.Write(() => _realm.Add(new Day()));
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
                    }
                    else // Удалим все дни после текущего и удалим информацию за текущий
                    {
                        var AllDays = _realm.All<Day>().ToList();                        

                        for (int i = 0; i < AllDays.Count; ++i)
                        {
                            MyDate CheckMyDate = new MyDate(AllDays[i].Date);
                            DateTime CheckDateTime = new DateTime(CheckMyDate.Year, CheckMyDate.Month, CheckMyDate.Day);

                            if (dateTime.CompareTo(CheckDateTime) < 0)
                            {
                                _realm.Write(() => _realm.Remove(AllDays[i]));
                            }
                            else if (dateTime.CompareTo(CheckDateTime) == 0)
                            {
                                MyDate Time = new MyDate(DateTime.Now);
                                string StrTime = Time.ToString();

                                _realm.Write(() => AllDays[i].Date = str);
                                _realm.Write(() => AllDays[i].CntSigarets = ForUpd[0].CntSigarets);
                                _realm.Write(() => AllDays[i].CntSigaretsToday = 0);
                                _realm.Write(() => AllDays[i].LastSigaret = ForUpd[0].LastSigaret);
                                _realm.Write(() => AllDays[i].LastSigaretYesterday = ForUpd[0].LastSigaret);
                                _realm.Write(() => AllDays[i].SigaretAverageSpan = ForUpd[0].SigaretAverageSpan);
                                _realm.Write(() => AllDays[i].SigaretAverageSpanYesterday = ForUpd[0].SigaretAverageSpan);
                                _realm.Write(() => AllDays[i].FirstSigaret = ForUpd[0].FirstSigaret);
                                _realm.Write(() => AllDays[i].CntEndSmoking = ForUpd[0].CntEndSmoking);
                                _realm.Write(() => AllDays[i].MaxTimeWithoutSigaret = ForUpd[0].MaxTimeWithoutSigaret);
                                _realm.Write(() => AllDays[i].LastDay = ForUpd[0].Date);
                                _realm.Write(() => AllDays[i].SpentOnSigaretAll = ForUpd[0].SpentOnSigaretAll);
                                _realm.Write(() => AllDays[i].SpentOnSigaretToday = 0);
                                _realm.Write(() => AllDays[i].NextDay = null);
                                _realm.Write(() => AllDays[i].DateLast = StrTime);
                            }
                        }
                    }
                }
                else if (dateTime.CompareTo(dateTimeLast) == 0) // проверим не перевели ли на сколько-то часов 
                {                    
                    string str = (new MyDate(dateTime)).ToString();
                    var NowDay = _realm.All<Day>().Where(f => f.Date == str).ToList();

                    MyDate CheckDateLast = new MyDate(NowDay[0].DateLast);
                    long CheckDateLast2 = MyDate.DateToLong(CheckDateLast);

                    MyDate CheckLastSigaret = new MyDate(NowDay[0].LastSigaret);
                    long CheckLastSigaret2 = MyDate.DateToLong(CheckLastSigaret);

                    long NowLong = MyDate.DateToLong(new MyDate(dateTime1));

                    if (CheckLastSigaret2 > NowLong) // Сбросим данные за сегодня
                    {
                        var ForUpd = _realm.All<Day>().Where(f => f.NextDay == str).ToList();

                        MyDate Time = new MyDate(DateTime.Now);
                        string StrTime = Time.ToString();

                        if (ForUpd.Count != 0) // Если есть предыдущий день
                        {
                            _realm.Write(() => NowDay[0].Date = str);
                            _realm.Write(() => NowDay[0].CntSigarets = ForUpd[0].CntSigarets);
                            _realm.Write(() => NowDay[0].CntSigaretsToday = 0);
                            _realm.Write(() => NowDay[0].LastSigaret = ForUpd[0].LastSigaret);
                            _realm.Write(() => NowDay[0].LastSigaretYesterday = ForUpd[0].LastSigaret);
                            _realm.Write(() => NowDay[0].SigaretAverageSpan = ForUpd[0].SigaretAverageSpan);
                            _realm.Write(() => NowDay[0].SigaretAverageSpanYesterday = ForUpd[0].SigaretAverageSpan);
                            _realm.Write(() => NowDay[0].FirstSigaret = ForUpd[0].FirstSigaret);
                            _realm.Write(() => NowDay[0].CntEndSmoking = ForUpd[0].CntEndSmoking);
                            _realm.Write(() => NowDay[0].MaxTimeWithoutSigaret = ForUpd[0].MaxTimeWithoutSigaret);
                            _realm.Write(() => NowDay[0].LastDay = ForUpd[0].Date);
                            _realm.Write(() => NowDay[0].SpentOnSigaretAll = ForUpd[0].SpentOnSigaretAll);
                            _realm.Write(() => NowDay[0].SpentOnSigaretToday = 0);
                            _realm.Write(() => NowDay[0].NextDay = null);
                            _realm.Write(() => NowDay[0].DateLast = StrTime);
                        }
                        else // Если нет предыдущего дня
                        {
                            var AllDays = _realm.All<Day>().ToList();

                            for (int i = 0; i < AllDays.Count; ++i)
                            {
                                _realm.Write(() => _realm.Remove(AllDays[i]));
                            }

                            _realm.Write(() => _realm.Add(new Day()));
                            var AllNewDay = _realm.All<Day>().Where(f => f.NextDay == null).ToList();
                            var NewDay = AllNewDay[0];
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
                        }
                    }
                }
            }
        }
    }
}