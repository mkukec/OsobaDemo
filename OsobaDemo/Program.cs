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

            Osoba o1 = new Osoba();
            o1.postaviIme("Ana");
            o1.postaviPrezime("Anić");
            o1.ispisiPrezimeIme();

            Osoba s1 = new Student();
            s1.postaviIme("Drago");
            s1.postaviPrezime("Delač");


            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(o1);
            osobe.Add(s1);
        }
    }
}
