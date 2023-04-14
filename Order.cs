using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2PIZZA
{
    public class Order
    {
        public int Id { get; set; }
        Pizza Pizza { get; set; }
        Customer Customer { get; set; }
        //double tax { get; set; }

        public Order(int id, Customer customer)
        {
            Id = id;
            Pizza = new Pizza();
            Customer = customer;
            //tax = 1.25;
        }
        public Order() { }


        public override string ToString()
        {
            return $"\nOrderID: {Id}\n {Customer} {Pizza}";
        }


    }
}
