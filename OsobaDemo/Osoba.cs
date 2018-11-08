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
        public void PostaviIme(string Ime)
        {
            this.Ime = Ime;
        }

        // Metoda za dohvat podataka 'Ime'
        public string DohvatiIme()
        {
            return Ime;
        }

        // Metoda za postavljanje podataka 'Prezime'
        public void PostaviPrezime(string Prezime)
        {
            this.Prezime = Prezime;
        }

        // Metoda za dohvat podataka 'Prezime'
        public string DohvatiPrezime()
        {
            return Prezime;
        }

        // Metoda za postavljanje podataka 'OIB'
        public void PostaviOIB(string OIB)
        {
            this.OIB = OIB;
        }

        // Metoda za dohvat podataka 'OIB'
        public string DohvatiOIB()
        {
            return OIB;
        }
        
        public void ispisiPrezimeIme()
        {
            Console.WriteLine("{0}, {1}", Prezime, Ime);
        }
    }

}
