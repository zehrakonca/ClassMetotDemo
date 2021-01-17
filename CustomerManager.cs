using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("{0} nolu Müşteri eklendi!", customer.customerID);
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Seçilen müşteri silindi.",customer.customerID);
        }

        public void ListCustomer(Customer customer)
        {
            Console.WriteLine("Customer Name         : "+customer.customerFirstName);
            Console.WriteLine("Customer Last Name    : "+customer.customerLastName);
            Console.WriteLine("Customer Number       : "+customer.customerNumber);
            Console.WriteLine("Customer Mail Address : "+customer.customerMail);
            Console.WriteLine("Customer Location     : "+customer.customerAddres);
            Console.WriteLine("_________________________");
        }
    }
}
