using MyShop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data
{
    public class Repository
    {
        public static List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() {  CustomerId = 1, Name = "John" },
                new Customer() {  CustomerId = 2, Name = "Jane" },
                new Customer() {  CustomerId = 3, Name = "Foo" }
            };
        }
    }
}
