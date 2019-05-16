using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using Realms;

namespace Calculator2
{
    public class AddSigaretsLibrary
    {
        public static void CreateLibrary()
        {
            var config = new RealmConfiguration() { SchemaVersion = 1 };
            Realm _Realm = Realm.GetInstance(config);

            // 1
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            var AllSigaret = _Realm.All<SigaretsBrands>();
            var AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            var NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ALLIANCE ДЕМИ");
            _Realm.Write(() => NewSigaret.Cost = 75);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 2
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ALLIANCE МОДЕРН СЛИМС");
            _Realm.Write(() => NewSigaret.Cost = 106);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 3
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ALLIANCE ОРИДЖИНАЛ СЛИМС");
            _Realm.Write(() => NewSigaret.Cost = 106);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 4
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH APPLE");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 5
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH APPLE SUPERSLIMS");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 6
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH BARDSEY BLEND");
            _Realm.Write(() => NewSigaret.Cost = 130);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 7
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH IRISH BLEND");
            _Realm.Write(() => NewSigaret.Cost = 136);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 8
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH IRISH BLEND SUPERSLIMS");
            _Realm.Write(() => NewSigaret.Cost = 136);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 9
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH IRISH COFFEE");
            _Realm.Write(() => NewSigaret.Cost = 136);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 10
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH IRISH COFFEE SUPERSLIMS");
            _Realm.Write(() => NewSigaret.Cost = 136);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 11
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH PINO BLEND");
            _Realm.Write(() => NewSigaret.Cost = 136);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 12
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH PINO BLEND");
            _Realm.Write(() => NewSigaret.Cost = 136);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 13
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH RED & AGED");
            _Realm.Write(() => NewSigaret.Cost = 136);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 14
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH RED & AGED SUPERSLIMS");
            _Realm.Write(() => NewSigaret.Cost = 136);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 15
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH RED&AGED");
            _Realm.Write(() => NewSigaret.Cost = 120);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 16
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH RED&AGED SUPERSLIMS");
            _Realm.Write(() => NewSigaret.Cost = 120);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 17
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH RUM & CHERRY");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 18
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH RUM & CHERRY SUPERSLIMS");
            _Realm.Write(() => NewSigaret.Cost = 136);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 19
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "AROMA RICH WINE GRAPE");
            _Realm.Write(() => NewSigaret.Cost = 126);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 20
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET BLUE SELECTION KS RCB STD");
            _Realm.Write(() => NewSigaret.Cost = 119);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 21
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET COMPACT BLUE");
            _Realm.Write(() => NewSigaret.Cost = 110);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 22
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET COMPACT BLUE KS DSP SLI");
            _Realm.Write(() => NewSigaret.Cost = 110);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 23
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET COMPACT PREMIUM (GREEN) KS DSP SLI");
            _Realm.Write(() => NewSigaret.Cost = 110);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 24
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET COMPACT PREMIUM 2.0 KS DSP SLI");
            _Realm.Write(() => NewSigaret.Cost = 110);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 25
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET COMPACT PREMIUM АРОМАТНЫЙ KS DSP SLI");
            _Realm.Write(() => NewSigaret.Cost = 106);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 26
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET COMPACT SILVER");
            _Realm.Write(() => NewSigaret.Cost = 120);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 27
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET COMPACT SILVER KS DSP SLI");
            _Realm.Write(() => NewSigaret.Cost = 120);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 28
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET PREMIUM KS DSP SLI");
            _Realm.Write(() => NewSigaret.Cost = 107);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 29
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET RED SELECTION KS RCB STD");
            _Realm.Write(() => NewSigaret.Cost = 119);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 30
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET SILVER SELECTION KS RCB STD");
            _Realm.Write(() => NewSigaret.Cost = 125);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 31
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET SPECIAL BLUE");
            _Realm.Write(() => NewSigaret.Cost = 125);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 32
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET SPECIAL BLUE KS DSP SSL");
            _Realm.Write(() => NewSigaret.Cost = 125);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 33
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET SPECIAL SILVER");
            _Realm.Write(() => NewSigaret.Cost = 115);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 34
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "BOND STREET VIOLET");
            _Realm.Write(() => NewSigaret.Cost = 115);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 35
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CAMEL ACTIVATE DUAL");
            _Realm.Write(() => NewSigaret.Cost = 131);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 36
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CAMEL BLUE");
            _Realm.Write(() => NewSigaret.Cost = 152);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 37
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CAMEL COMPACT 100'S");
            _Realm.Write(() => NewSigaret.Cost = 152);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 38
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CAMEL COMPACT");
            _Realm.Write(() => NewSigaret.Cost = 152);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 39
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CAMEL FILTERS");
            _Realm.Write(() => NewSigaret.Cost = 152);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 40
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CAMEL YELLOW");
            _Realm.Write(() => NewSigaret.Cost = 152);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 41
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CAPTAIN BLACK COMPACT BLUE");
            _Realm.Write(() => NewSigaret.Cost = 95);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 42
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CAPTAIN BLACK COMPACT WHITE");
            _Realm.Write(() => NewSigaret.Cost = 95);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 43
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CAPTAIN BLACK S-TEK 1.0");
            _Realm.Write(() => NewSigaret.Cost = 70);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 44
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CAPTAIN BLACK S-TEK 2.0");
            _Realm.Write(() => NewSigaret.Cost = 70);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 45
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CAPTAIN BLACK S-TEK 3.0");
            _Realm.Write(() => NewSigaret.Cost = 70);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 46
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CAPTAIN BLACK S-TEK 5.0");
            _Realm.Write(() => NewSigaret.Cost = 70);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 47
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CHESTERFIELD BLUE KS RCB STD");
            _Realm.Write(() => NewSigaret.Cost = 142);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 48
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CHESTERFIELD CROWN BLUE KS DSP SLI");
            _Realm.Write(() => NewSigaret.Cost = 120);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 49
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "CHESTERFIELD RED KS RCB STD");
            _Realm.Write(() => NewSigaret.Cost = 142);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 50
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL BLACK");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 51
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL BLUE");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 52
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL CLASSIC BLEND");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 53
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL FINE CUT");
            _Realm.Write(() => NewSigaret.Cost = 177);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 54
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL FINE CUT BLOND BLEND");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 55
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL FINE CUT BLUE");
            _Realm.Write(() => NewSigaret.Cost = 177);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 56
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL FINE CUT DARK BLUE");
            _Realm.Write(() => NewSigaret.Cost = 177);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 57
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL FINE CUT GOLD");
            _Realm.Write(() => NewSigaret.Cost = 177);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 58
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL GOLD");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 59
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL NANO CUT MASTER BLEND");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 60
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL NANO CUT SIGNATURE BLEND");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 61
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL RED");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 62
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL SWISS BLEND");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 63
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL WHITE");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 64
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL МАСТЕР БЛЕНД БЛЮ");
            _Realm.Write(() => NewSigaret.Cost = 177);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 65
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL МАСТЕР БЛЕНД РЕД");
            _Realm.Write(() => NewSigaret.Cost = 160);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 66
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL ФАЙН КАТ БЛЮ");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 67
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "DUNHILL ФАЙН КАТ ГОЛД");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 68
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "GLAMOUR AMBER");
            _Realm.Write(() => NewSigaret.Cost = 137);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 69
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "GLAMOUR AZURE");
            _Realm.Write(() => NewSigaret.Cost = 137);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 70
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "GLAMOUR COMPACT IMPULSE");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 71
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "GLAMOUR IMPULSE");
            _Realm.Write(() => NewSigaret.Cost = 110);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 72
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "GLAMOUR LILAC");
            _Realm.Write(() => NewSigaret.Cost = 137);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 73
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "GLAMOUR MENTHOL");
            _Realm.Write(() => NewSigaret.Cost = 137);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 74
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT BLUE");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 75
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT CONVERTIBLES");
            _Realm.Write(() => NewSigaret.Cost = 151);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 76
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT DEMISLIMS BLUE");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 77
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT DEMISLIMS SILVER");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 78
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT DOUBLE MIX");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 79
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT DS 90 BLUE");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 80
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT DS 90 SILVER");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 81
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT DUAL MIX");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 82
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT FEEL");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 83
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT FEEL AROMA");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 84
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT FEEL FRESH");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 85
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT FEEL VELVET");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 86
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HD 1");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 87
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HD 2.5 NAVY BLUE");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 88
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HD 4");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 89
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HD 6 МГ");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 90
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HD 8");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 91
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HD FUTURA");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 92
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HD INFINA");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 93
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HD NAVY BLUE");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 94
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HD NEO");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 95
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HD SILVER");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 96
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HD WHITE");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 97
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HDI 1.5 6 MG");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 98
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HDI 4MG");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 99
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HDI 6MG");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 100
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HDI BLUE");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 101
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HDI SILVER");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 102
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HDI БЛЮ");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 103
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HDS BLUE");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 104
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT HDS SILVER");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 105
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT ISWITCH");
            _Realm.Write(() => NewSigaret.Cost = 151);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 106
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT MIX");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 107
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT MIX RED BREEZE");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 108
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT MODE BLUE");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 109
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT MODE SILVER");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 110
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANO SILVER");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 111
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANO WHITE");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 112
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANOTEK 1");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 113
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANOTEK 2.0 1");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 114
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANOTEK 2.0 4");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 115
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANOTEK 2.0 6");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 116
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANOTEK 4");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 117
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANOTEK 6");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 118
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANOTEK BLACK 4 MG");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 119
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANOTEK INFINA");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 120
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANOTEK NEO");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 121
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANOTEK SILVER");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 121
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT NANOTEK WHITE");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 122
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT PURPLE");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 123
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT RELOAD SILVER");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 124
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT SILVER");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 125
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT SONIC 1 MG");
            _Realm.Write(() => NewSigaret.Cost = 145);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 126
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT SUPERSLIMS 3 MG");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 127
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT SUPERSLIMS 5 MG");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 128
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT SWITCH");
            _Realm.Write(() => NewSigaret.Cost = 151);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 129
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT WHITE");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 130
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT БЛЮ");
            _Realm.Write(() => NewSigaret.Cost = 156);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 131
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT Д-МИКС");
            _Realm.Write(() => NewSigaret.Cost = 120);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 132
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT Д-МИКС ПЛЮС");
            _Realm.Write(() => NewSigaret.Cost = 131);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 133
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT Д-СЕРИЕС");
            _Realm.Write(() => NewSigaret.Cost = 131);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 134
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT НАНО МИКС");
            _Realm.Write(() => NewSigaret.Cost = 136);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 135
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT НАНО МИКС АМБЕР");
            _Realm.Write(() => NewSigaret.Cost = 136);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 136
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT НАНО МИКС САНСЕТ");
            _Realm.Write(() => NewSigaret.Cost = 131);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 137
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KENT НАНО СИЛЬВЕР");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 138
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS ADDITIVE FREE");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 139
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS BOUQUET");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 140
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS BROWN");
            _Realm.Write(() => NewSigaret.Cost = 100);
            _Realm.Write(() => NewSigaret.Cnt = 20);
            
            // 141
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS CHERRY");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 142
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS CHOCO");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 143
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS CLUBNICHKA");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 144
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS DESSERT");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 145
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS DREAM");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 146
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS DREAM OC");
            _Realm.Write(() => NewSigaret.Cost = 95);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 147
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS DREAM SUPERSLIMS");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 148
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS ENERGY");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 149
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS FIVE");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 150
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS FIVE COMPACT");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 151
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS FRESH");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 152
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS FRESH APPLE");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 153
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS GREEN");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 154
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS JOLLY");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 155
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS LOVELY");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 156
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS MANGO");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 157
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS MENTHOL");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 158
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS MINT GRAPE");
            _Realm.Write(() => NewSigaret.Cost = 100);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 159
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS MOHITO");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 160
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS ONE");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 161
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS ORGANIC");
            _Realm.Write(() => NewSigaret.Cost = 96);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 162
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS ORGANIC PINK");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 163
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS ROMANTIC");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 164
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS SEVEN");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 165
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS SHAKE");
            _Realm.Write(() => NewSigaret.Cost = 100);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 166
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS STRAWBERRY");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 167
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS SUNNY");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 168
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "KISS VIOLETTO");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 169
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M BLUE LABEL");
            _Realm.Write(() => NewSigaret.Cost = 122);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 170
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M BLUE LABEL KS RCB STD");
            _Realm.Write(() => NewSigaret.Cost = 122);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 171
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M COMPACT");
            _Realm.Write(() => NewSigaret.Cost = 115);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 172
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M COMPACT KS DSP SLI");
            _Realm.Write(() => NewSigaret.Cost = 119);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 173
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M COMPACT WHITE KS DSP SLI");
            _Realm.Write(() => NewSigaret.Cost = 115);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 174
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M LOFT (BLUE)");
            _Realm.Write(() => NewSigaret.Cost = 100);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 175
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M LOFT (BLUE) KS DSP SLI");
            _Realm.Write(() => NewSigaret.Cost = 115);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 176
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M LOFT (NEON BLUE) KS DSP SLI");
            _Realm.Write(() => NewSigaret.Cost = 115);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 177
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M LOFT (SEA BLUE)");
            _Realm.Write(() => NewSigaret.Cost = 100);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 178
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M LOFT (SEA BLUE) KS DSP SLI");
            _Realm.Write(() => NewSigaret.Cost = 115);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 179
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M LOUNGE (1 MG)");
            _Realm.Write(() => NewSigaret.Cost = 115);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 180
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M LOUNGE (3 MG)");
            _Realm.Write(() => NewSigaret.Cost = 115);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 181
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M LOUNGE (5 MG)");
            _Realm.Write(() => NewSigaret.Cost = 125);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 182
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M LOUNGE BLUE");
            _Realm.Write(() => NewSigaret.Cost = 125);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 183
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M MOTION BLUE");
            _Realm.Write(() => NewSigaret.Cost = 115);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 184
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M RED LABEL KS RCB STD");
            _Realm.Write(() => NewSigaret.Cost = 122);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 185
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M SENSE (PINK)");
            _Realm.Write(() => NewSigaret.Cost = 125);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 186
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "L&M SENSE (VIOLET)");
            _Realm.Write(() => NewSigaret.Cost = 125);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 187
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD AUTOGRAPH BLUE");
            _Realm.Write(() => NewSigaret.Cost = 96);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 188
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD AUTOGRAPH BLUE");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 189
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD AUTOGRAPH CLUB COMPACT 100’S BLUE");
            _Realm.Write(() => NewSigaret.Cost = 96);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 190
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD AUTOGRAPH CLUB COMPACT CAFЕ");
            _Realm.Write(() => NewSigaret.Cost = 96);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 191
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD AUTOGRAPH CLUB COMPACT LOUNGE");
            _Realm.Write(() => NewSigaret.Cost = 96);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 192
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD AUTOGRAPH CLUB COMPACT SILVER");
            _Realm.Write(() => NewSigaret.Cost = 95);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 193
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD AUTOGRAPH CLUB GOLD");
            _Realm.Write(() => NewSigaret.Cost = 117);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 194
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD AUTOGRAPH CLUB LOUNGE");
            _Realm.Write(() => NewSigaret.Cost = 117);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 195
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD AUTOGRAPH CLUB PLATINUM");
            _Realm.Write(() => NewSigaret.Cost = 117);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 196
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD AUTOGRAPH IMPULSE COMPACT");
            _Realm.Write(() => NewSigaret.Cost = 96);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 197
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD BLUE");
            _Realm.Write(() => NewSigaret.Cost = 117);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 198
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD BY SOVEREIGN SLIMS");
            _Realm.Write(() => NewSigaret.Cost = 110);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 199
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD CLUB BLACK EDITION");
            _Realm.Write(() => NewSigaret.Cost = 117);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 200
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD CLUB COMPACT 100’S BLUE");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 201
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD CLUB COMPACT 100’S SILVER");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 202
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD CLUB COMPACT PLUS");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 203
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD CLUB COMPACT SELECT");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 204
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD CLUB COMPACT SILVER");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 205
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD CLUB GOLD");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 206
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD CLUB GOLD");
            _Realm.Write(() => NewSigaret.Cost = 117);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 207
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD CLUB LONG BLUE");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 208
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD CLUB LONG SILVER");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 209
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD CLUB PLATINUM");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 210
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD IMPULSE COMPACT PURPLE");
            _Realm.Write(() => NewSigaret.Cost = 95);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 211
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD PINK SUPERSLIMS");
            _Realm.Write(() => NewSigaret.Cost = 117);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 212
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD RED");
            _Realm.Write(() => NewSigaret.Cost = 117);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 213
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD SILVER");
            _Realm.Write(() => NewSigaret.Cost = 117);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 214
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD VIRGINIA SLIMS");
            _Realm.Write(() => NewSigaret.Cost = 117);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 215
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD-SAINT GEORGE BLUE");
            _Realm.Write(() => NewSigaret.Cost = 96);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 216
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "LD-SAINT GEORGE RED");
            _Realm.Write(() => NewSigaret.Cost = 96);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 217
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MARLBORO FILTER PLUS KS RCB STD");
            _Realm.Write(() => NewSigaret.Cost = 162);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 218
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MARLBORO FILTER PLUS KS STD");
            _Realm.Write(() => NewSigaret.Cost = 145);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 219
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MARLBORO FINE TOUCH (2.0)");
            _Realm.Write(() => NewSigaret.Cost = 140);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 220
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MARLBORO FLAVOR PLUS KS SRP");
            _Realm.Write(() => NewSigaret.Cost = 145);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 221
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MARLBORO GOLD");
            _Realm.Write(() => NewSigaret.Cost = 162);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 222
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MARLBORO GOLD ORIGINAL");
            _Realm.Write(() => NewSigaret.Cost = 150);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 223
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MARLBORO GOLD ORIGINAL KS RCS");
            _Realm.Write(() => NewSigaret.Cost = 162);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 224
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MARLBORO RED");
            _Realm.Write(() => NewSigaret.Cost = 162);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 225
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MARLBORO TOUCH (2.0)");
            _Realm.Write(() => NewSigaret.Cost = 140);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 226
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MAXIM BY PARKER&SIMPSON; КРАСНЫЙ");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 227
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MAXIM BY PARKER&SIMPSON; СИНИЙ");
            _Realm.Write(() => NewSigaret.Cost = 90);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 228
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MAXIM COMPACT КРАСНЫЙ");
            _Realm.Write(() => NewSigaret.Cost = 85);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 229
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MAXIM COMPACT СИНИЙ");
            _Realm.Write(() => NewSigaret.Cost = 85);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 230
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MAXIM PREMIUM КРАСНЫЙ");
            _Realm.Write(() => NewSigaret.Cost = 85);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 231
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MAXIM PREMIUM СЕРЕБРЯНЫЙ");
            _Realm.Write(() => NewSigaret.Cost = 85);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 232
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "MAXIM PREMIUM СИНИЙ");
            _Realm.Write(() => NewSigaret.Cost = 85);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 233
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL BLUE");
            _Realm.Write(() => NewSigaret.Cost = 121);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 234
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL NANO BLUE");
            _Realm.Write(() => NewSigaret.Cost = 121);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 235
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL NANO SILVER");
            _Realm.Write(() => NewSigaret.Cost = 121);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 236
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL NANO WHITE");
            _Realm.Write(() => NewSigaret.Cost = 121);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 237
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL NANOKINGS BLUE");
            _Realm.Write(() => NewSigaret.Cost = 127);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 238
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL NANOKINGS SILVER");
            _Realm.Write(() => NewSigaret.Cost = 127);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 239
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL NANOKINGS WHITE");
            _Realm.Write(() => NewSigaret.Cost = 127);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 240
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL POCKET BLUE");
            _Realm.Write(() => NewSigaret.Cost = 121);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 241
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL POCKET RED");
            _Realm.Write(() => NewSigaret.Cost = 121);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 242
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL SILVER");
            _Realm.Write(() => NewSigaret.Cost = 121);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 243
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL SUPERSLIMS AZURE");
            _Realm.Write(() => NewSigaret.Cost = 127);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 244
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL SUPERSLIMS BLUE");
            _Realm.Write(() => NewSigaret.Cost = 127);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 245
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL SUPERSLIMS SILVER");
            _Realm.Write(() => NewSigaret.Cost = 127);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 246
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL SUPERSLIMS VIOLET");
            _Realm.Write(() => NewSigaret.Cost = 127);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 247
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PALL MALL SUPERSLIMS WHITE");
            _Realm.Write(() => NewSigaret.Cost = 127);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 248
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARKER & SIMPSON BLUE");
            _Realm.Write(() => NewSigaret.Cost = 95);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 249
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARKER & SIMPSON COMPACT BLUE");
            _Realm.Write(() => NewSigaret.Cost = 95);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 250
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARKER & SIMPSON COMPACT SILVER");
            _Realm.Write(() => NewSigaret.Cost = 95);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 251
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARKER & SIMPSON DUO");
            _Realm.Write(() => NewSigaret.Cost = 85);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 252
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARKER & SIMPSON INTENSE BLUE");
            _Realm.Write(() => NewSigaret.Cost = 80);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 253
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARKER & SIMPSON RED");
            _Realm.Write(() => NewSigaret.Cost = 85);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 254
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARKER & SIMPSON BLACK");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 255
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARKER & SIMPSON WHITE");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 256
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARLIAMENT");
            _Realm.Write(() => NewSigaret.Cost = 175);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 257
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARLIAMENT AQUA BLUE");
            _Realm.Write(() => NewSigaret.Cost = 189);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 258
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARLIAMENT NIGHT BLUE");
            _Realm.Write(() => NewSigaret.Cost = 189);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 259
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARLIAMENT PLATINUM BLUE");
            _Realm.Write(() => NewSigaret.Cost = 189);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 260
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARLIAMENT RESERVE");
            _Realm.Write(() => NewSigaret.Cost = 189);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 261
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARLIAMENT SILVER BLUE");
            _Realm.Write(() => NewSigaret.Cost = 189);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 262
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARLIAMENT SUPER SLIMS");
            _Realm.Write(() => NewSigaret.Cost = 189);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 263
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARLIAMENT TROPIC VOYAGE");
            _Realm.Write(() => NewSigaret.Cost = 159);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 264
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PARLIAMENT VOYAGE");
            _Realm.Write(() => NewSigaret.Cost = 159);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 265
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PHILIP MORRIS BLUE");
            _Realm.Write(() => NewSigaret.Cost = 99);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 266
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PHILIP MORRIS COMPACT BLUE");
            _Realm.Write(() => NewSigaret.Cost = 106);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 267
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PHILIP MORRIS COMPACT PREMIUM");
            _Realm.Write(() => NewSigaret.Cost = 106);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 268
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PHILIP MORRIS COMPACT SIGNATURE");
            _Realm.Write(() => NewSigaret.Cost = 96);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 269
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PHILIP MORRIS DARK BLUE");
            _Realm.Write(() => NewSigaret.Cost = 99);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 270
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PHILIP MORRIS GOLD");
            _Realm.Write(() => NewSigaret.Cost = 99);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 271
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PHILIP MORRIS RED");
            _Realm.Write(() => NewSigaret.Cost = 99);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 272
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "PHILIP MORRIS ULTRA BLUE");
            _Realm.Write(() => NewSigaret.Cost = 80);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 273
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND 1903");
            _Realm.Write(() => NewSigaret.Cost = 201);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 274
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND BLACK EDITION");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 275
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND BRONZE EDITION");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 276
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND CAPSULE SUPERSLIM");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            // 277
            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND CHERRY");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND CHERRY GOLD");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND CHERRY GOLD SUPERSLIM");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND CHERRY SUPERSLIM");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND COFFEE SUPERSLIM");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND COLLECTORS EDITION");
            _Realm.Write(() => NewSigaret.Cost = 380);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND EMPIRE EDITION");
            _Realm.Write(() => NewSigaret.Cost = 320);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND FROZEN RED");
            _Realm.Write(() => NewSigaret.Cost = 161);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND GENTLEMAN");
            _Realm.Write(() => NewSigaret.Cost = 161);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND GOLD EDITION");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND ICE TOUCH");
            _Realm.Write(() => NewSigaret.Cost = 160);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND KLAN");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND LONDON");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND RED EDITION");
            _Realm.Write(() => NewSigaret.Cost = 171);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND ROYAL");
            _Realm.Write(() => NewSigaret.Cost = 85);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND ROYAL BLUE");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND ROYAL MENTHOL");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND ROYAL RED");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND ROYAL SILVER");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "RICHMOND ROYAL SINERGY");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS DEMI BLUE");
            _Realm.Write(() => NewSigaret.Cost = 111);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS DEMI CLICK");
            _Realm.Write(() => NewSigaret.Cost = 112);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS DEMI CLICK AMBER");
            _Realm.Write(() => NewSigaret.Cost = 112);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS DEMI DC");
            _Realm.Write(() => NewSigaret.Cost = 111);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS DEMI SILVER");
            _Realm.Write(() => NewSigaret.Cost = 111);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS INTERNATIONAL");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS INTERNATIONAL BLUE");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS INTERNATIONAL PLATINUM");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS INTERNATIONAL SILVER");
            _Realm.Write(() => NewSigaret.Cost = 105);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS KING SIZE BLUE");
            _Realm.Write(() => NewSigaret.Cost = 122);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS KING SIZE SILVER");
            _Realm.Write(() => NewSigaret.Cost = 122);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS NANO BLUE");
            _Realm.Write(() => NewSigaret.Cost = 122);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS NANO SILVER");
            _Realm.Write(() => NewSigaret.Cost = 122);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "ROTHMANS SUPER SLIM CLICK");
            _Realm.Write(() => NewSigaret.Cost = 122);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR COMPACT BLACK");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR COMPACT BLUE");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR EXTRAORDINARY NANO POWER");
            _Realm.Write(() => NewSigaret.Cost = 135);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR GRAND VIRGINIA");
            _Realm.Write(() => NewSigaret.Cost = 285);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR GRAND VIRGINIA NANO POWER");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR GRAND VIRGINIA SLIMLINE");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR KENTUCKY BLEND");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR ORIGINAL CHERRY");
            _Realm.Write(() => NewSigaret.Cost = 285);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR ORIGINAL PIPE TOBACCO");
            _Realm.Write(() => NewSigaret.Cost = 275);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR ORIGINAL PIPE TOBACCO COMPACT");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR ORIGINAL PIPE TOBACCO NANO POWER");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR PRIME NANO POWER");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR PRIVATE BLEND NANO POWER");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR SUPER SLIMS BLUE");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR WHITE LINE NANO POWER");
            _Realm.Write(() => NewSigaret.Cost = 141);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR WINEGRAPE");
            _Realm.Write(() => NewSigaret.Cost = 285);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR WINEGRAPE COMPACT");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SENATOR WINEGRAPE NANO POWER");
            _Realm.Write(() => NewSigaret.Cost = 77);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE BLACK");
            _Realm.Write(() => NewSigaret.Cost = 167);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE BLACKS");
            _Realm.Write(() => NewSigaret.Cost = 163);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE BLUE");
            _Realm.Write(() => NewSigaret.Cost = 167);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE COCKTAIL");
            _Realm.Write(() => NewSigaret.Cost = 300);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE COLOURS");
            _Realm.Write(() => NewSigaret.Cost = 300);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE GOLD");
            _Realm.Write(() => NewSigaret.Cost = 167);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE GOLDS");
            _Realm.Write(() => NewSigaret.Cost = 163);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE REDEFINED BLACK");
            _Realm.Write(() => NewSigaret.Cost = 158);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE REDEFINED BLUE");
            _Realm.Write(() => NewSigaret.Cost = 158);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE REDEFINED CHROME");
            _Realm.Write(() => NewSigaret.Cost = 158);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE REDEFINED WHITE");
            _Realm.Write(() => NewSigaret.Cost = 158);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE REFINE BLACK");
            _Realm.Write(() => NewSigaret.Cost = 158);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE SUPERSLIMS BLACK");
            _Realm.Write(() => NewSigaret.Cost = 163);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE SUPERSLIMS PINK");
            _Realm.Write(() => NewSigaret.Cost = 163);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "SOBRANIE WHITE");
            _Realm.Write(() => NewSigaret.Cost = 167);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON BLUE");
            _Realm.Write(() => NewSigaret.Cost = 143);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON CLASSIC");
            _Realm.Write(() => NewSigaret.Cost = 143);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON COMPACT BLUE");
            _Realm.Write(() => NewSigaret.Cost = 128);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON COMPACT IMPULSE SUMMER MIX");
            _Realm.Write(() => NewSigaret.Cost = 116);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON COMPACT PLUS BLUE");
            _Realm.Write(() => NewSigaret.Cost = 128);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON COMPACT PLUS IMPULSE");
            _Realm.Write(() => NewSigaret.Cost = 122);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON COMPACT PLUS IMPULSE PURPLE");
            _Realm.Write(() => NewSigaret.Cost = 122);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON COMPACT PLUS SILVER");
            _Realm.Write(() => NewSigaret.Cost = 128);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON COMPACT SILVER");
            _Realm.Write(() => NewSigaret.Cost = 128);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON DUAL");
            _Realm.Write(() => NewSigaret.Cost = 120);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON RED");
            _Realm.Write(() => NewSigaret.Cost = 143);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON SILVER");
            _Realm.Write(() => NewSigaret.Cost = 143);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON SS BLUE");
            _Realm.Write(() => NewSigaret.Cost = 143);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON SUPER SLIMS BLUE");
            _Realm.Write(() => NewSigaret.Cost = 143);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON SUPER SLIMS FRESH MENTHOL");
            _Realm.Write(() => NewSigaret.Cost = 143);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON SUPER SLIMS SILVER");
            _Realm.Write(() => NewSigaret.Cost = 143);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON SUPER SLIMS WHITE");
            _Realm.Write(() => NewSigaret.Cost = 143);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON TACT BLUE");
            _Realm.Write(() => NewSigaret.Cost = 132);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON TACT SILVER");
            _Realm.Write(() => NewSigaret.Cost = 132);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON WHITE");
            _Realm.Write(() => NewSigaret.Cost = 143);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XS BLUE");
            _Realm.Write(() => NewSigaret.Cost = 110);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XS IMPULSE");
            _Realm.Write(() => NewSigaret.Cost = 126);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XS PLUS BLUE");
            _Realm.Write(() => NewSigaret.Cost = 143);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XS PURPLE IMPULSE");
            _Realm.Write(() => NewSigaret.Cost = 126);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XS SILVER");
            _Realm.Write(() => NewSigaret.Cost = 143);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XSLIMS IMPULSE");
            _Realm.Write(() => NewSigaret.Cost = 126);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XSPRESSION LONG");
            _Realm.Write(() => NewSigaret.Cost = 132);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XSTYLE BLUE");
            _Realm.Write(() => NewSigaret.Cost = 132);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XSTYLE DUAL");
            _Realm.Write(() => NewSigaret.Cost = 132);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XSTYLE LONG BLUE");
            _Realm.Write(() => NewSigaret.Cost = 122);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XSTYLE LONG SILVER");
            _Realm.Write(() => NewSigaret.Cost = 122);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XSTYLE PLUS DUO");
            _Realm.Write(() => NewSigaret.Cost = 120);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XSTYLE SILVER");
            _Realm.Write(() => NewSigaret.Cost = 132);
            _Realm.Write(() => NewSigaret.Cnt = 20);

            _Realm.Write(() => _Realm.Add(new SigaretsBrands()));
            AllSigaret = _Realm.All<SigaretsBrands>();
            AllNewSigaret = _Realm.All<SigaretsBrands>().Where(f => f.Name == null).ToList();
            NewSigaret = AllNewSigaret[0];
            _Realm.Write(() => NewSigaret.Name = "WINSTON XSTYLE SILVER");
            _Realm.Write(() => NewSigaret.Cost = 132);
            _Realm.Write(() => NewSigaret.Cnt = 20);
        }
    }
}
