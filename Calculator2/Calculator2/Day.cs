using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace Calculator2
{
    public class Day : RealmObject
    {
        public string Id { get; set; }
        public string Date { get; set; }

        public string DateLast { get; set; }
        public string LastSigaret { get; set; }
        public string LastSigaretYesterday { get; set; }
        public string FirstSigaret { get; set; }

        public string LastDay { get; set; }
        public string NextDay { get; set; }

        public int CntSigarets { get; set; }
        public int CntSigaretsToday { get; set; }

        public int SigaretAverageSpan { get; set; }
        public int SigaretAverageSpanYesterday { get; set; }

        public int CntEndSmoking { get; set; }
        public int MaxTimeWithoutSigaret { get; set; }

        public int SpentOnSigaretToday { get; set; }
        public int SpentOnSigaretAll { get; set; }
    }
}
