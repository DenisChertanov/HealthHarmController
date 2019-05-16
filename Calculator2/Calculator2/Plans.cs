using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace Calculator2
{
    public class Plans : RealmObject
    {
        public int NeedCntSigaretsInDay { get; set; }
        public int NeedCntMoneyInDay { get; set; }
    }
}
