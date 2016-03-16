using MyShop.Core;
using MyShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Service
{
    public class CustomerService
    {
        public List<Customer> GetCustomers()
        {
            var customers = Repository.GetCustomers();

            foreach(var customer in customers)
            {
                if(customer.CustomerId == 1)
                {
                    customer.Name = "Idiot";
                }
            }

            return customers;
        }

        public Customer GetCustomer(int customerId)
        {
            var customers = Repository.GetCustomers();
            return customers.FirstOrDefault(c => c.CustomerId == customerId);
        }
    }
}
