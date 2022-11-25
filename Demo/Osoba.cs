using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Osoba
    {
        private string imie;
        string nazwisko;
        DateTime dataUrodzenia;

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public override string? ToString()
        {
            return imie + " " + nazwisko;
        }
    }
}
