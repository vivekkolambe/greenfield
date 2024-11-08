using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class OrderService : IOrderService
    {
        List<Order> _orders;
        public OrderService()
        {
            this._orders = new List<Order>();
            _orders.Add(new Order { OrderId = 1, OrderDate = DateTime.Now, Amount = 35000, Status = "Delivered" });
            _orders.Add(new Order { OrderId = 2, OrderDate = DateTime.Now, Amount = 55000, Status = "Delivered" });
            _orders.Add(new Order { OrderId = 3, OrderDate = DateTime.Now, Amount = 65000, Status = "Delivered" });
            _orders.Add(new Order { OrderId = 4, OrderDate = DateTime.Now, Amount = 70000, Status = "Delivered" });
            _orders.Add(new Order { OrderId = 5, OrderDate = DateTime.Now, Amount = 499, Status = "Delivered" });
        }
        public void Delete(int id)
        {
            this._orders.Remove(GetById(id));
        }

        public List<Order> GetAll()
        {
            return _orders;
        }

        public Order GetById(int id)
        {
            foreach (var order in _orders)
            {
                if(order.OrderId == id) return order;
            }
            return null;
        }

        public string GetOrderStatus(int id)
        {
            Order theOrder = GetById(id);
            string status = theOrder.Status;
            switch (status)
            {
                case "Delivered":
                    Console.WriteLine("Your order has been delivered");
                    break;
                case "Cancelled":
                    Console.WriteLine("Your Order has been cancelled");
                    break;
                case "Rejected":
                    Console.WriteLine("Your order has been rejected");
                    break;
                default:
                    Console.WriteLine("Invlaid Order status");
                    break;
            }
            return theOrder.Status;
        }

        public void Insert(Order order)
        {
            this._orders.Add(order);
        }

        public void Update(Order order)
        {
            this.Delete(order.OrderId);
            this._orders.Add(order);
        }
    }
}
