using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace Calculator2
{
    public class SigaretsBrands : RealmObject
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Cnt { get; set; }
        public double Nicotine { get; set; }
        public double Resin { get; set; }
    }
}
