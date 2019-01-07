using System;
using System.Collections.Generic;

namespace OsobaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobar dan! ;-)");

            /* ZADATAK
             * Stvoriti popis osoba; programsku podršku
             * za razne primjene gdje je potreban popis osoba
             */

            string ime1 = "Ana";
            string prezime1 = "Anić";

            string ime2 = "Borna";
            string prezime2 = "Bubalo";

            string ime3 = "Cecilija";
            string prezime3 = "Car";

            // Delač, Drago; Erceg, Eva; Fotez, Filip; Grabar, Goran; Horvat, Hrvoje; Ivanda, Ivan; ....

            int i;

            Osoba o1 = new Osoba("Ana", "Anić", "123456789012");
            o1.ispisiPrezimeIme();

            // Nije moguće stvoriti objekt Osoba bez podataka
            // Osoba s1 = new Osoba();
            // s1.PostaviIme("Drago");
            // s1.PostaviPrezime("Delač");

            // Korištenje svojstva za dodjelu vrijednosti
            Osoba o3 = new Osoba("Eva", "Erceg", "98765432101");

            Osoba o4 = new Osoba("Filip", "Fotez", "12345678901");

            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(o1);

        }
    }
}
