using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    //Defining a prototype
    //Every Interface in a program is called a Prototype/ Contract/ Specification
    public interface ICustomerService
    {
        List<Customer> GetAll();       //abstract method
        Customer GetByID(int id);

        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(int id);
         
    }
}
