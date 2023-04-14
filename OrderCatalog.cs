using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2PIZZA
{
    internal class OrderCatalog
    {
        private List<Order> _orders;
        public OrderCatalog()
        {
            _orders = new List<Order>();
        }
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public void UpdateOrder(int id, Customer customer, Pizza pizza)
        {
            var OrdertoUpdate = _orders.Find(o => o.Id == id);
            if (OrdertoUpdate != null)
            {
                OrdertoUpdate.Id = id;
                OrdertoUpdate.Equals(customer);
                OrdertoUpdate.Equals(pizza);
            }
            else
            {
                Console.WriteLine("There is no Order with that ID");
            }
        }
        public void DeleteOrder(int id)
        {
            _orders.RemoveAll(o => o.Id == id);
        }
        public void printORDER()
        {
            Console.WriteLine("Order's\n----");
            foreach (var order in _orders)
            {
                Console.WriteLine(order.ToString());

            }
        }

        public Order SearchOrder(int Id)
        {
            foreach (Order o in _orders)
            {
                if (o.Id == Id)
                {
                    return o;
                }
            }
            return null;
        }


    }
}