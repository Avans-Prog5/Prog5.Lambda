using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    class Garage
    {
        public List<Auto> garage = new List<Auto>();

        public void Filter(double prijs, int jaar, string merk, Uitvoering uitvoering)
        {
            IEnumerable<Auto> autos = garage
                .Where(arg => arg.Prijs < prijs)
                .Where(a => a.Bouwjaar > jaar)
                .Where(a => a.Merk == merk)
                .Where(a => a.Uitvoering == uitvoering)
                .OrderBy(a => a.Prijs)
                .ToList();
        }

        /// <summary>
        /// Het meegeven van een functie heet een 'delegate', callback
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private bool PrijsIsLowerThan(Auto arg)
        {
            return arg.Prijs < 1000;
        }
    }
}
