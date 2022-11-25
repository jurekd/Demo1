using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Student : Osoba, IOcenialny
    {
        static int grupa = 1;
        double ocena;
        public Student(string imie, string nazwisko, double ocena) : base(imie, nazwisko)
        {
            this.ocena = ocena;
        }

        public void Ocen()
        {
            throw new NotImplementedException();
        }

        public void PodajSrednia()
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return base.ToString() + " " + ocena + " " + grupa;
        }
    }
}
