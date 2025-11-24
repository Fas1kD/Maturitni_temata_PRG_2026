using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_18_Dedicnost_Polymorfismus_Zapozdreni
{
    //Přídám k Buben :Nastroj (bere vlastnosti z class nastroj)
    //DĚTI Z NÁSTROJE
    internal class Buben : Nastroj
    {
        public override void Zahraj()
        {
            Console.WriteLine("BUM, BUM");
        }

        //abstrakt property (vlastnost) - každý buben bude mít vlastnost sound, která bude brnk, nemůžu ji přepsat

        public override string Sound
        {
            get { return "bum"; }
        }
    }
}
