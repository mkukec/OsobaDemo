using System;

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

            Console.WriteLine("Popis osoba:");
            Console.WriteLine("1. {0}, {1}", prezime1, ime1);
            Console.WriteLine("2. {0}, {1}", prezime2, ime2);
            Console.WriteLine("3. {0}, {1}", prezime3, ime3);

            /*
             * Koliki je potencijal ovog rješenja da se jednostavno primijeni za podatke novih 10 osoba?
             * Novih 20 osoba? Novih 100 osoba? 1000 osoba? ....
             * Kolika je mogućnost primjene ovog rješenja uz porast količine podataka 
             * tj. posla koji on mora odraditi? 
             * Kolika je skalabilnost? 
             */


        }
    }
}
