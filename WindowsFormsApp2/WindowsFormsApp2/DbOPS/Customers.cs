using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DbOPS
{
    public class CustomerOps
    {
        private NorthwindEntities entities = new NorthwindEntities();
        public List<Customer> GetCustomers()
        {
            return entities.Customers.ToList();
        }

        public Customer GetCustomerByID(string id)
        {
            return entities.Customers.FirstOrDefault(c => c.CustomerID == id);
        }

        public void UpdateCustomerName(string id, string companyName)
        {
            var customer = GetCustomerByID(id);

           
            if (customer != null)
            {
                customer.CompanyName = companyName;
                entities.SaveChanges();
            }
        }

        public void DeleteCustomer(string id)
        {
            var customer = GetCustomerByID(id);
            entities.Customers.Remove(customer);

        }

        public void AddCustomer(string id)
        {
             entities.Customers.Add(new Customer() { CustomerID = id });
            
        }
    }
}
