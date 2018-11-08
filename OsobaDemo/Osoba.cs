using System;
using System.Collections.Generic;
using System.Text;

namespace OsobaDemo
{
    class Osoba
    {
        // Sakrivanje podataka, onemogućava pristup
        private string Ime;
        private string Prezime;
        private string OIB;

        // Metoda za postavljanje podatka 'Ime'
        public void postaviIme(string Ime)
        {
            this.Ime = Ime;
        }

        // Metoda za dohvat podataka 'Ime'
        public string dohvatiIme()
        {
            return Ime;
        }

        // Metoda za postavljanje podataka 'Prezime'
        public void postaviPrezime(string Prezime)
        {
            this.Prezime = Prezime;
        }

        // Metoda za dohvat podataka 'Prezime'
        public string dohvatiPrezime()
        {
            return Prezime;
        }

        // Metoda za postavljanje podataka 'OIB'
        public void postaviOIB(string OIB)
        {
            this.OIB = OIB;
        }

        // Metoda za dohvat podataka 'OIB'
        public string dohvatiOIB()
        {
            return OIB;
        }
        
        public void ispisiPrezimeIme()
        {
            Console.WriteLine("{0}, {1}", Prezime, Ime);
        }
    }

}
