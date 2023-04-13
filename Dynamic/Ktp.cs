using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    internal class Ktp
    {
        private readonly Paragraf paragraf;
        public Paragraf Paragraf { get => paragraf; }

        private readonly VidZanyatiya vidZanyatiya;
        public VidZanyatiya VidZanyatiya { get => vidZanyatiya; }

        private readonly Materiali materiali;
        public Materiali Materiali { get => materiali; }

        private readonly string nomer;
        public string Nomer { get => nomer; }

        private readonly string chasi;
        public string Chasi { get => chasi; }

        public Ktp(Paragraf paragraf, VidZanyatiya vidZanyatiya, Materiali materiali, string nomer, string chasi)
        {
            this.paragraf = paragraf;
            this.vidZanyatiya = vidZanyatiya;
            this.materiali = materiali;
            this.nomer = nomer;
            this.chasi = chasi;
        }
    }
}
