using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.customerID        = 001;
            customer1.customerFirstName = "Salazar";
            customer1.customerLastName  = "Slytherin";
            customer1.customerNumber    = "12345678910";
            customer1.customerMail      = "salazarSlytherin@hogwarts.edu";
            customer1.customerAddres    = "London/UK";

            Customer customer2 = new Customer();
            customer2.customerID        = 002;
            customer2.customerFirstName = "Albus";
            customer2.customerLastName  = "Dumbledore";
            customer2.customerNumber    = "78451296301";
            customer2.customerMail      = "dumbledore@hogwarts.edu";
            customer2.customerAddres    = "London/UK";

            Customer customer3 = new Customer();
            customer3.customerID        = 003;
            customer3.customerFirstName = "Severus";
            customer3.customerLastName  = "Snape";
            customer3.customerNumber    = "98653274106";
            customer3.customerMail      = "severusSnape@hogwarts.edu";
            customer3.customerAddres    = "London/UK";

            CustomerManager cm = new CustomerManager(); 
            //müşteri ekleme işlemleri.
            cm.CustomerAdd(customer1);
            cm.CustomerAdd(customer2);
            cm.CustomerAdd(customer3);

            //müşteri silme işlemleri.
            cm.CustomerDelete(customer1);

            //müşteri listeleme.

            Customer[] customers = new Customer[]
            {
                customer1,customer2,customer3
            };

            foreach (var customer in customers)
            {
                cm.ListCustomer(customer);
            }

            Console.ReadKey();



        }
    }
}
