using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie2
{
    public class Student
    {
        // co opisuje studenta?
        public string imie;
        public string nazwisko;
        public string email;
        public List<double> oceny;

        // co student moze "robic"?
        public void WyswietlSwojaWizytówke()
        {
            Console.WriteLine("#########################");
            Console.WriteLine(imie);
            Console.WriteLine(nazwisko);
            Console.WriteLine("#########################");
        }
    }
}
