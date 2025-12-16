using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_procvicovani_2
{
    abstract class nastroje
    {
        public string Nazev { get; }
        private int _rokVyroby;
        public abstract string Zahraj { get; }

    }
}
