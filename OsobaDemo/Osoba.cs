using System;
using System.Collections.Generic;
using System.Text;

namespace OsobaDemo
{
    class Osoba
    {
        // Sakrivanje podataka, onemogućava pristup
        private string ime;
        private string prezime;
        private string oib;

        // Metoda za postavljanje podatka 'Ime'
        public void PostaviIme(string Ime)
        {
            ime = Ime;
        }

        // Metoda za dohvat podataka 'Ime'
        public string DohvatiIme()
        {
            return ime;
        }

        // Metoda za postavljanje podataka 'Prezime'
        public void PostaviPrezime(string Prezime)
        {
            prezime = Prezime;
        }

        // Metoda za dohvat podataka 'Prezime'
        public string DohvatiPrezime()
        {
            return prezime;
        }

        // Metoda za postavljanje podataka 'OIB'
        public void PostaviOIB(string OIB)
        {
            oib = OIB;
        }

        // Metoda za dohvat podataka 'OIB'
        public string DohvatiOIB()
        {
            return oib;
        }
        
        public void ispisiPrezimeIme()
        {
            Console.WriteLine("{0}, {1}", prezime, ime);
        }
    }

}
