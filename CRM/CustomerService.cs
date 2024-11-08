using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    //Implementing the interface/ prototype
    public class CustomerService : ICustomerService
    {

        public CustomerService() { 
            _customerList = new List<Customer>();
            _customerList.Add(new Customer { ID = 1, FirstName = "Vivek", LastName = "Kolambe", Email = "vivek.kolambe@gmail.com", Contact = "9876543210" });
            _customerList.Add(new Customer { ID = 2, FirstName = "Swapnil", LastName = "Patil", Email = "swapnil.patil@gmail.com", Contact = "9638527410" });
            _customerList.Add(new Customer { ID = 3, FirstName = "Chinmay", LastName = "Lute", Email = "chinmay.lute@gmail.com", Contact = "9517536820" });
            _customerList.Add(new Customer { ID = 4, FirstName = "Shubham", LastName = "Pakale", Email = "shubham.pakale@gmail.com", Contact = "9876543210" });
        }
        List<Customer> _customerList;
        public bool Delete(int id)
        {
            return this._customerList.Remove(GetByID(id));
        }

        public List<Customer> GetAll()
        {
            return _customerList;
        }

        public Customer GetByID(int id)
        {
            foreach (Customer customer  in _customerList)
            {
                if (customer.ID == id)
                    return customer;
            }
            return null;
        }

        public bool Insert(Customer customer)
        {
            this._customerList.Add(customer);
            return true;
        }

        public bool Update(Customer customer)
        {
            Customer theCustomer = this.GetByID(customer.ID);
            this._customerList.Remove(theCustomer);
            this._customerList.Add(theCustomer);
            return true;
            //theCustomer.FirstName = customer.FirstName;
            //theCustomer.LastName = customer.LastName;
            //theCustomer.Email=customer.Email;
            
        }
    }
}
