using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_procvicovani
{
    abstract class Zvire
    {
        public string Jmeno { get;}
        public int Vek { get; set; }
        private int _datumNarozeni;
        public static bool MaOci = true;

        public Zvire(string jmeno, int vek, int datumNarozeni)
        {
            this.Jmeno = jmeno;
            this.Vek = vek;
            this._datumNarozeni = datumNarozeni;
        }

        public void Prohlaseni()
        {
            Console.WriteLine($"Jmenuji se {this.Jmeno}, je mi {this.Vek} let a narodilo jsem se v roce {this._datumNarozeni}.");
        }
        public void NovyRok()
        {
            this.Vek += 1;
            Console.WriteLine($"{this.Jmeno} má nyní {this.Vek} let.");
        }

        public abstract void VydatZvuk();
        public abstract string Sound { get; }
        }
}
