using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaklad_OOP_lenochod
{
    internal class Lenochod
    {
        // private atributy (_nazev)
        // Rozdíl mezi private public, private - po vytvoření objektu se nemění, public - může se i po vytvoření měnit
        //get; set; - můžu zadat i změnit, můžu číst a zapisovat
        //set; - můžu jen zadat na začátku, dále nemůžu měnit, můžu jen číst
        public string Name { get; } // properties/zapouzdření - chráním data před přepsáním
        private int _datumNarozeni;
        public int DatumNarozeni
        {
            get { return _datumNarozeni; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Věk nemůže bý záporný");
                }
                else if(value < 1900)
                {
                    throw new ArgumentException("Už je dávno po něm");
                }
                else
                {
                    _datumNarozeni = value;
                }
            }
        }
        public int Hmotnost {  get; set; } 
        private bool _isSleeping = false;


        public Lenochod(string jmeno, int datumNarozeni, int hmotnost)
        {
            this.Name = jmeno;
            this.DatumNarozeni = datumNarozeni;
            this.Hmotnost = hmotnost;

        }

        // metoda - napsat zprávu jíst
        public void jist()
        {
            Console.WriteLine($" {this.Name}: Mňam Mňam");
        }

        // metoda spát/vzbudit se (mění se atribut)
        public void Spat()
        {
            if (_isSleeping)
            {
                Console.WriteLine("Lenochod už dávno spí.");
            }
            else
            {
                _isSleeping = true;
                Console.WriteLine("Uspal si lenochoda");
            }
        }

        public void VzbuditSe()
        {
            if (!_isSleeping)
            {
                Console.WriteLine("Lenochod už je dávno vzhůru.");
            }
            else
            {
                _isSleeping = false;
                Console.WriteLine("Vzbudil si lenochoda.");
            }
        }

        // metoda zjisti věk (int rokNarozeni) - něco nám vrátí
        
        public int ZjistiVek(int datumNarozeni)
        {
            int vek = 0;
            return vek;
        }
        //U každého lenochoda vypíše tady toto, je to pak u jiné maturitní otázky
        public override string ToString()
        {
            return $"Toto je hihihihaw lenochod {this.Name}";
        }



        
    }
}
