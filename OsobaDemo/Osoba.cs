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
        
        public void ispisiPrezimeIme()
        {
            Console.WriteLine("{0}, {1}", Prezime, Ime);
        }
    }

}
