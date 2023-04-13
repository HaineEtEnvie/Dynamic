using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    internal class Korpus
    {
        private readonly string name;
        public string Name { get => name; }

        private readonly string adress;
        public string Adress { get => adress; }

        private readonly Sotrydnik sotrydnik;
        public Sotrydnik Sotrydnik { get => sotrydnik; }

        private readonly Organizacia organization;
        public Organizacia Organizacia { get => organization; }

        public Korpus(string name, string adress, Sotrydnik sotrydnik, Organizacia org)
        {
            this.name = name;
            this.adress = adress;
            this.sotrydnik = sotrydnik;
            this.organization = org;
        }
    }
}
