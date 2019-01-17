using System;
using System.Collections.Generic;
using System.Text;

namespace OsobaDemo
{
    public class Osoba
    {
        // Sakrivanje podataka, onemogućava pristup
        private string ime;
        private string prezime;
        protected string Oib;

        // Izraditi razred tako da ...
        // Sadrži konstruktor kojim se postavljaju podaci, 
        // onemogućiti stvaranje objekta bez podataka.

        // Ukoliko je Osoba bazni razred kod naslijeđivanja, 
        // obratiti pažnju na podrzaumijevani konstrutor.
        // Radi primjera, ovdje je podrazumijevani konstruktor
        // omogućen, tj. nije u komentaru
        /*
        public Osoba()
        {
            // Onemogućavanje stvaranja objekta bez podataka -->
            // izostaviti podrazumijevani konstruktor iz koda 
            //  i izraditi drugi(e) konstruktore
        }
        */

        public Osoba(string ime, string prezime, string Oib)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.Oib = Oib;
        }

        public virtual string dohvatiIdentifikator()
        {
            return "Oib: " + Oib;
        }

        // O Svojstvima (Properties) - Obavezno proučiti !!!
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties

        // svojstvo Ime
        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        // svojstvo Prezime; operator lambda =>; "Expresion Body Definition"
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties#expression-body-definitions

        public string Prezime { get => prezime; set => prezime = value; }
        
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
        
        public void ispisiPrezimeIme()
        {
            Console.WriteLine("{0}, {1}", prezime, ime);
        }
    }

}
