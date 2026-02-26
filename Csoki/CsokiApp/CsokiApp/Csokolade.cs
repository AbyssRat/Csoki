using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsokiApp
{
    public class Csokolade
    {
        public string Nev { get; set; }
        public string Kategoria { get; set; }
        public string Iz { get; set; }
        public int Tomeg { get; set; }
        public double Ar { get; set; }
        public bool Alkoholos { get; set; }
        public bool Vegan { get; set; }

        public override string ToString()
        {
            return $"{Nev} - {Ar} EUR";
        }
    }
}
