using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;
using OrderProcessing;
namespace eCommerceTest
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Order order1 = new Order();
            order1.OrderId = 1;
            order1.OrderDate = DateTime.Now;
            order1.Status = "Delivered";
            order1.Amount = 34999;

            IOrderService orderService = new OrderService();
            orderService.Insert(order1);
            List<Order> orders = orderService.GetAll();
            foreach (var order in orders)
            {
                Console.WriteLine(order.OrderId);
                Console.WriteLine(order.OrderDate);
                Console.WriteLine(order.Amount);
                Console.WriteLine(order.Status);
            }
            Console.ReadLine();
            /*
            Customer customer1 = new Customer();
            customer1.ID = 34;
            customer1.FirstName = "Vivek";
            customer1.LastName = "Kolambe";
            customer1.Email = "vivek.kolambe@gmail.com";
            customer1.Contact = "897465321";
            
            Customer customer2 = new Customer();
            customer2.ID = 35;
            customer2.FirstName = "Ranjan";
            customer2.LastName = "Patil";
            customer2.Email = "ranjan.patil@gmail.com";
            customer2.Contact = "897465321";

            ICustomerService customerService = new CustomerService();
            customerService.Insert(customer1);
            customerService.Insert(customer2);

            List<Customer> allCustomer = customerService.GetAll();
            foreach (var customer in allCustomer)
            {
                Console.WriteLine(customer.ID);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.Contact);
                

            }
            Console.ReadLine();
            */
        }
    }
}
