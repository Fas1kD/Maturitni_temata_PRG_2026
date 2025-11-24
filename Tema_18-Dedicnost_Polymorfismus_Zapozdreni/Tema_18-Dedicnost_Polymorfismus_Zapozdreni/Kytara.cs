using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_18_Dedicnost_Polymorfismus_Zapozdreni
{
    //Připsat Kytara : Nastroj (bere funkce/vlastnosti z Nastroj)
    //DĚTI Z NÁSTROJE
    internal class Kytara : Nastroj
    {
        //Dědí z nástroje
        public override void Zahraj()
        {
            Console.WriteLine("Brnk, Brnk");
        }

        //abstrakt property (vlastnost) - každá kytara bude mít vlastnost sound, která bude brnk, nemůžu ji přepsat
        public override string Sound 
        {
            get { return "brnk"; }
        }
    }
}
