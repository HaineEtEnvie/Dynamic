using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    internal class Oborudovanie
    {
        private readonly string nazvanie;
        public string Nazvanie { get => nazvanie; }

        private readonly int stoimost;
        public int Stoimost { get => stoimost; }

        private readonly DateTime postanovka;
        public DateTime Postanovka { get => postanovka; }

        public Oborudovanie(string nazvanie, int stoimost, DateTime postanovka)
        {
            this.nazvanie = nazvanie;
            this.stoimost = stoimost;
            this.postanovka = postanovka;
        }
    }
}
