using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public interface IOrderService
    {
        void Insert(Order order);
        void Update(Order order);
        void Delete(int id);
        List<Order> GetAll();
        Order GetById(int id);
        String GetOrderStatus(int id);


    }
}
