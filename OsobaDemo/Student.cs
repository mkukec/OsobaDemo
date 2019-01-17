using System;
using System.Collections.Generic;
using System.Text;

namespace OsobaDemo
{
    class Student : Osoba
    {
        public string JMBAG { get; set; }

        public Student() : base("", "", "")
        {
            // Ovo je način da se izbjegne nužnost unosa podataka
            // međutim nije nešto što je općenito preporučljivo.
            // Ukoliko je u baznom razredu podrazumijevani kosntruktor 
            // izostavljen, vjerojatno postoji i razlog zašto je to tako
        }

        public Student(string ime, string prezime, string oib) : base(ime, prezime, oib)
        {

        }

        public Student(string ime, string prezime, string oib, string JMBAG) : base(ime, prezime, oib)
        {
            this.JMBAG = JMBAG;
        }

        public override string dohvatiIdentifikator()
        {
            return "Oib:" + Oib +  " JMBAG: " + JMBAG;
        }

    }
}
