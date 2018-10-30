using System;
using System.Collections.Generic;
using System.Text;

namespace OsobaDemo
{
    class Osoba
    {
        public string Ime;
        public string Prezime;
        public string OIB;
        
        public void ispisiPrezimeIme()
        {
            Console.WriteLine("{0}, {1}", Prezime, Ime);
        }
    }

}
