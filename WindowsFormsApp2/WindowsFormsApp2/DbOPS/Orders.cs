using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DbOPS
{
    class Orders
    {
        private NorthwindEntities entities = new NorthwindEntities();


        public List<Order> GetOrders()
        {
            return entities.Orders.ToList();
        }

        public Order GetOrderByID(int id)
        {
            return entities.Orders.FirstOrDefault(c => c.OrderID == id);
        }

        public void UpdateOrderShipName(int id, string Name)
        {
            var customer = GetOrderByID(id);


            if (customer != null)
            {
                customer.ShipName = Name;
                entities.SaveChanges();
            }
        }

        public void DeleteOrder(int id)
        {
            var customer = GetOrderByID(id);
            entities.Orders.Remove(customer);

        }

        public void AddOrder()
        {
            entities.Orders.Add(new Order());

        }
    }
}
