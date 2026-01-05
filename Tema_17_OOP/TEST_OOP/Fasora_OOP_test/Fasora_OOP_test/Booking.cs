using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasora_OOP_test
{
    abstract class Booking  //ABSTRAKT
    {
        //Vlastnosti
        private static  int _id = 0;
        private abstract string _customerName;
        public abstract string CustomerName
        {
            get
            {
                return _customerName;
            }

            set => _customerName = value == "" ? "Unknown customer" : value;
        }
        public abstract double BasePrice
        {
            get;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Nesmí být záporný");
                    return value = 0;
                }
                else
                {
                    return BasePrice = value;
                }
                
            }
        }
        private static int _counter = 0;


        //CTOR :D
        protected Booking(string customerName, double basePrice, int id)
        {
            CustomerName = customerName;
            BasePrice = basePrice;
            _id = _counter++;
            
        }

        //metoda :D
        public virtual string GetInfo();
    }

}
