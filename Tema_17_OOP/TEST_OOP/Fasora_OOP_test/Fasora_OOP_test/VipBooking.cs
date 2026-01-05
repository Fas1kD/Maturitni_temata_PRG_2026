using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasora_OOP_test
{
    internal class VipBooking : Booking
    {
        public VipBooking(string customerName, double basePrice, int id) : base(customerName, basePrice, id)
        {
        }
        private  string _customerName;

        public override string CustomerName
        {
            get
            {
                return _customerName;
            }

            set => _customerName = value == "" ? "Unknown customer" : value;
        }

        public override double BasePrice
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

        

        public override string ToString() => GetInfo();
    }
}
