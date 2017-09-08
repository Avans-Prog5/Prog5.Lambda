using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    class Auto
    {
        public string Merk { get; set; }
        public double Prijs { get; set; }
        public int Bouwjaar { get; set; }

        public Uitvoering Uitvoering { get; set; }
    }

    enum Uitvoering
    {
        Hatchback, Station, Landrover, Cabrio, Sedan
    }
}

