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

        private readonly int nomer;
        public int Nomer { get => nomer; }

        private readonly int chasi;
        public int Chasi { get => chasi; }

        public Ktp(Paragraf paragraf, VidZanyatiya vidZanyatiya, Materiali materiali, int nomer, int chasi)
        {
            this.paragraf = paragraf;
            this.vidZanyatiya = vidZanyatiya;
            this.materiali = materiali;
            this.nomer = nomer;
            this.chasi = chasi;
        }
    }
}
