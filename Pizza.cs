using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2PIZZA
{
    class Pizza
    {
        public string Name { get; set; }
        public string Bread { get; set; }
        public string Size { get; set; }
        public int PizzaID { get; set; }
        public decimal Price { get; set; }
        public List<string> Toppings { get; set; }

        public Pizza()
        {
            Pizza pizza;
            Toppings = new List<string>();
        }

        public Pizza(string name, string bread, string size, int pizzaID, decimal price)
        {
            Name = name;
            Bread = bread;
            Size = size;
            PizzaID = pizzaID;
            Price = price;
        }
        public override string ToString()
        { return $"\n Navn: {Name} \nPizzabund : {Bread} \nPizzastørrelse : {Size} \nPizza nummer : {PizzaID} \nPris : {Price} kr,. \n"; }

        public void AddTopping(string topping)
        {
            Toppings.Add(topping);
        }
    }

}