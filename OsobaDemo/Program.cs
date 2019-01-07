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
            
            // Delač, Drago; Erceg, Eva; Fotez, Filip; Grabar, Goran; Horvat, Hrvoje; Ivanda, Ivan; ....

            int i;

            Osoba o1 = new Osoba("Ana", "Anić", "123456789012");
            o1.ispisiPrezimeIme();

            // Korištenje svojstva za dodjelu vrijednosti
            Osoba o3 = new Osoba("Eva", "Erceg", "98765432101");

            Osoba o4 = new Osoba("Filip", "Fotez", "12345678901");

            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(o1);

            Student s1 = new Student();
            s1.Ime = "Goran";
            s1.Prezime = "Grabar";
            s1.JMBAG = "12121213213";

            Profesor p1 = new Profesor();
            p1.Ime = "Hrvoje";
            p1.Prezime = "Horvat";
            p1.OznakaRadnogMjesta = "neka_oznaka";

            Student s2 = new Student("Ivan", "Ivanda", "21321312313");



        }
    }
}
