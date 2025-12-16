using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_procvicovani
{
    internal class Kocka : Zvire
    {
        public Kocka(string jmeno, int vek, int datumNarozeni) : base(jmeno, vek, datumNarozeni)
        {
        }
        public override void VydatZvuk()
        {
            Console.WriteLine("Mňau mňau!");
        }
        public override string Sound
        {
            get { return "Mňau mňau"; }
        }
    {
    }
}
