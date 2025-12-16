using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_procvicovani
{
    internal class Pes : Zvire
    {
        public Pes(string jmeno, int vek, int datumNarozeni) : base(jmeno, vek, datumNarozeni)
        {
        }
        public override void VydatZvuk()
        {
            Console.WriteLine("Haf haf!");
        }
        public override string Sound
        {
            get { return "Haf haf"; }
        }
    }
}
