using System;
using System.Collections.Generic;
using System.Text;

namespace OsobaDemo
{
    class Student : Osoba
    {
        public string JMBAG;

        void ispisiStudent()
        {
            Console.WriteLine("{0} - {1}, {2}", JMBAG, Prezime, Ime);
        }
    }
}
