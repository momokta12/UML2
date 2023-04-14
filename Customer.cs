using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2PIZZA
{
    public class Customer
    {
        public int CsID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }



        public Customer(int csID, string name, string address, int phonenumber)
        {
            CsID = csID;
            Name = name;
            Address = address;
            PhoneNumber = phonenumber;
        }

        public Customer()
        {
        }

        public override string ToString()
        {
            return $" \nID : {CsID} \nNavn : {Name} \nAdresse : {Address} \nTlf : {PhoneNumber} ";
        }
    }
}