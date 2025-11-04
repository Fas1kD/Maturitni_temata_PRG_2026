using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_17_OOP
{
    internal class Osoba
    // VYTVOŘENÍ NOVÉ CLASS Pravím na projekt - přidat - class - přejmenovat na Osoba.cs
    {
        public string Jmeno; // VYTVOŘENÍ ATRIBUTŮ CLASS
        public int Vek;

        //Konstraktor - "CTOR" + TAB
        //bude potřeba při vytváření objektu
        public Osoba(string jmeno, int vek)
        {
            Jmeno = jmeno;
            Vek = vek;
            List<int> znamky = new();
        }


        //Public - lze měnit zvenčí
        //Private - malé písmeno a _ před názvem, je chráněná atribut, nelze zvenčí měnit, potom se píše get a set

        public void PredstavSe() // VYTVOŘENÍ METODY CLASS
        {
            Console.WriteLine($"Ahoj, jmenuji se {Jmeno} a je mi {Vek} let.");
        }
    }
}
