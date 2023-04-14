using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2PIZZA
{
    class UserDialog
    {
        public MenuCatalog catalog = new MenuCatalog();

        public CustomerCatalog customerCatalog = new CustomerCatalog();

        public OrderCatalog orderCatalog = new OrderCatalog();
        public void Start()
        {
            // Add some Pizzas to the catalog
            var pizza1 = new Pizza() { PizzaID = 1, Name = "hawaii", Bread = "GlutenFri", Size = "small", Price = 60 };
            var pizza2 = new Pizza() { PizzaID = 2, Name = "kebab", Bread = "DeepPan", Size = "Family size", Price = 75 };
            var pizza3 = new Pizza() { PizzaID = 3, Name = "mexicana", Bread = "Majsmel", Size = "Normal", Price = 90 };


            catalog.AddPizza(pizza1);
            catalog.AddPizza(pizza2);
            catalog.AddPizza(pizza3);

            // Add some customers to the catalog
            var customer1 = new Customer() { CsID = 1, Name = "Jens", Address = "Dea trier Mørchs vej 9, 2th 2300", PhoneNumber = 23234223 };
            var customer2 = new Customer() { CsID = 2, Name = "´Lars", Address = "Nylandsvej 13, 2100", PhoneNumber = 84874761 };
            var customer3 = new Customer() { CsID = 3, Name = "Sam", Address = "Maglekærgården 2, 400", PhoneNumber = 23213142 };
            customerCatalog.AddCustomer(customer1);
            customerCatalog.AddCustomer(customer2);
            customerCatalog.AddCustomer(customer3);

            // Add some orders to the catalog
            var order1 = new Order() { Id = 1 };
            var order2 = new Order() { Id = 2 };
            var order3 = new Order() { Id = 3 };
            orderCatalog.AddOrder(order1);
            orderCatalog.AddOrder(order2);
            orderCatalog.AddOrder(order3);


            List<string> menuItems = new List<string>
                {
                    "Add new pizza to the menu",
                    "Delete pizza from the menu",
                    "Update pizza on the menu",
                    "Search for a pizza",
                    "Display pizza menu\n\n",
                    "Add new customer to the catalog",
                    "Delete customer from the catalog",
                    "Update customer in the catalog",
                    "Search for a customer",
                    "Display customer catalog\n\n",
                    "Search Order",
                    "Display OrderMenu",
                    "View OrderCatalog"
                };

            MenuChoice(menuItems);
        }

        public void MenuChoice(List<string> menuItems)
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Please choose an option:");
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuItems[i]}");
                }
                Console.WriteLine("0. Exit\n");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please use a integer between 0 and 9");
                    continue;
                }

                if (choice == 0)
                {
                    exit = true;
                }

                int id;
                string name;
                string bread;
                string size;
                decimal price;

                int Csid;
                string csname;
                string address;
                int phoneNumber;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter pizza id");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter pizza name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter bread:");
                        bread = Console.ReadLine();
                        Console.WriteLine("Enter pizza size");
                        size = Console.ReadLine();
                        Console.WriteLine("Enter pizza price");
                        price = Convert.ToDecimal(Console.ReadLine());
                        var newPizza = new Pizza() { PizzaID = id, Name = name, Bread = bread, Price = price, Size = size };
                        catalog.AddPizza(newPizza);
                        break;

                    case 2:
                        Console.WriteLine("Choose the id on the pizza you want to delete:");
                        id = Convert.ToInt32(Console.ReadLine());
                        catalog.DeletePizza(id);
                        Console.WriteLine($"Pizza with {id} is now delete\n");
                        break;

                    case 3:
                        Console.WriteLine("Choose id on the pizza you want to update");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Choose new name for the pizza");
                        name = Console.ReadLine();
                        Console.WriteLine("Choose new bread for the pizza");
                        bread = Console.ReadLine();
                        Console.WriteLine("Choose new price for the pizza");
                        price = Convert.ToDecimal(Console.ReadLine());
                        var updatedPizza = new Pizza() { Name = name, Bread = bread, Price = price };
                        catalog.UpdatePizza(id, updatedPizza);
                        Console.WriteLine($"Pizza with {id} is now updated");
                        break;
                    case 4:
                        Console.WriteLine($"You selected option 3. to search for a pizza");
                        Console.WriteLine($"Select the pizza number you want to search for");

                        try
                        {
                            int ChosenNumber = Int32.Parse(Console.ReadLine());
                            Console.WriteLine($"the input you gave was {ChosenNumber}");
                            Console.WriteLine(value: $"the pizza you searched for was: {catalog.SearchPizza(ChosenNumber)}");
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex.Message);
                            Console.WriteLine();
                            Console.WriteLine($"The pizza doesn't exist");
                        }
                        Console.Write($"hit any key to continue");
                        Console.ReadKey();

                        break;
                    case 5:
                        ////int ChosenNumberDisplay = Int32.Parse(Console.ReadLine());    
                        ////Console.WriteLine($"You selected {ChosenNumberDisplay}");
                        Console.WriteLine($"Dette er kataloget");
                        catalog.PrintMenu();
                        Console.Write($"hit any key to continue");
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.WriteLine("Enter Customer id");
                        Csid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Customer name:");
                        csname = Console.ReadLine();
                        Console.WriteLine("Enter Adress:");
                        address = Console.ReadLine();
                        Console.WriteLine("Enter Phonenumber ");
                        phoneNumber = Convert.ToInt32(Console.ReadLine());
                        var newCustomer = new Customer() { CsID = Csid, Name = csname, Address = address, PhoneNumber = phoneNumber };
                        customerCatalog.AddCustomer(newCustomer);
                        catalog.PrintMenu();
                        break;

                    case 7:
                        Console.WriteLine("Choose the id on the customer you want to delete:");
                        Csid = Convert.ToInt32(Console.ReadLine());
                        customerCatalog.DeleteCustomer(Csid);
                        Console.WriteLine($"Customer with id {Csid} has been deleted.\n");
                        break;

                    case 8:
                        Console.WriteLine("Choose the id on the customer you want to update:");
                        Csid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Choose new name for the customer:");
                        csname = Console.ReadLine();
                        Console.WriteLine("Choose new address for the customer:");
                        address = Console.ReadLine();
                        Console.WriteLine("Choose new phone number for the customer:");
                        phoneNumber = Convert.ToInt32(Console.ReadLine());
                        var updatedCustomer = new Customer() { Name = csname, Address = address, PhoneNumber = phoneNumber };
                        customerCatalog.UpdateCustomer(Csid, updatedCustomer);
                        Console.WriteLine($"Customer with id {Csid} has been updated.\n");
                        break;

                    case 9:
                        Console.WriteLine("Enter the id of the customer you want to search for:");
                        Csid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(customerCatalog.SearchCustomer(Csid));
                        break;

                    case 10:
                        Console.WriteLine("This is the customer catalog:");
                        customerCatalog.PrintCatalog();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid option.\n");
                        break;

                    case 11:
                        Console.WriteLine("Enter the ID of the order you want to search:");
                        id = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            Console.WriteLine($"Order with ID {id} contains the following pizzas: ");
                            Console.WriteLine(orderCatalog.SearchOrder(id).GetType());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 12
                    :
                        Console.WriteLine("Enter the ID of the order you want to display:");
                        id = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            Console.WriteLine(orderCatalog.SearchOrder(id).ToString());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 13:
                        Console.WriteLine("Displaying the order catalog:\n");
                        Console.WriteLine(orderCatalog.ToString());
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}