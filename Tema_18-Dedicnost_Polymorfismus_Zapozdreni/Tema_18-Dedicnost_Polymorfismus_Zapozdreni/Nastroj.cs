using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_18_Dedicnost_Polymorfismus_Zapozdreni
{
    abstract class Nastroj
    {
       
        public static bool JeNaladeny { get; set; } = true; //statická vlastnost - patří class, ne objektu

        //Od této class zdědí buben a kytara tuto funkci
        //PARENT PRO NÁSTROJE 


        //TAKTO BYCH TO NAPSAL V INTERNAL CLASS NASTROJ - převedu na abstrakt (v abstrakt nemůžu vytvořit objekt nastroj)
        //public virtual void Zahraj()
        //{
        //    Console.WriteLine("Hraju na hrací nástro, a vydávám nějaký zvuk");
        //}

        public abstract void Zahraj(); //nemůžu vytvořit objekt nástroj, ale slíbil jsem že potomci (kytara,buben) budou mít vlastnost zahraj
    }
}
