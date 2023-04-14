using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2PIZZA
{
    internal class CustomerCatalog
    {
        private List<Customer> _customerList;
        public CustomerCatalog()
        {
            _customerList = new List<Customer>();
        }
        public void AddCustomer(Customer customer)
        {
            _customerList.Add(customer);
        }
        public void UpdateCustomer(int csid, Customer UpdateCustomer)
        {
            var CustomerToUpdate = _customerList.Find(c => c.CsID == csid);
            if (CustomerToUpdate != null)
            {
                CustomerToUpdate.Name = UpdateCustomer.Name;
                CustomerToUpdate.Address = UpdateCustomer.Address;
                CustomerToUpdate.PhoneNumber = UpdateCustomer.PhoneNumber;
            }
            else
            {
                Console.WriteLine("There is no Customer with that ID");
            }
        }

        public void DeleteCustomer(int csid)
        {
            _customerList.RemoveAll(c => c.CsID == csid);
        }


        public void PrintCatalog()
        {
            Console.WriteLine("Customer's\n-----");
            foreach (var customer in _customerList)
            {
                Console.WriteLine($"Customer ID {customer.CsID}\nName:  {customer.Name}\nAdress: {customer.Address}\nPhoneNumber: {customer.PhoneNumber}\n");
            }
        }

        public Customer SearchCustomer(int csid)
        {
            foreach (Customer c in _customerList)
            {
                if (c.CsID == csid)
                {
                    return c;
                }
            }
            return null;
        }
        internal object addCustomer(Customer customer1)
        {
            throw new NotImplementedException();
        }

    }
}