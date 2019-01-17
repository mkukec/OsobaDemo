using System;
using System.Collections.Generic;
using System.Text;

namespace OsobaDemo
{
    class Profesor : Osoba
    {
        public string OznakaRadnogMjesta { get; set; }

        public Profesor(string ime, string prezime, string oib)
            : base(ime, prezime, oib)
        {

        }

        public Profesor(string ime, string prezime, string oib, string oznakaRadnogMjesta)
            : base(ime, prezime, oib)
        {
            OznakaRadnogMjesta = oznakaRadnogMjesta;
        }

        public override string dohvatiIdentifikator()
        {
            return "Oib: " + Oib + " OznakaRM: " + OznakaRadnogMjesta;
        }

    }
}
