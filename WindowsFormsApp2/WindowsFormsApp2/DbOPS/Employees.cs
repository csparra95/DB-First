using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DbOPS
{
    class Employees
    {
        private NorthwindEntities entities = new NorthwindEntities();


        public List<Employee> GetEmployees()
        {
            return entities.Employees.ToList();
        }

        public Employee GetEmployeeByID(int id)
        {
            return entities.Employees.FirstOrDefault(c => c.EmployeeID == id);
        }

        public void UpdateEmployeeTitle(int id, string titulo)
        {
            var customer = GetEmployeeByID(id);


            if (customer != null)
            {
                customer.Title = titulo;
                entities.SaveChanges();
            }
        }

        public void DeleteEmployee(int id)
        {
            var customer = GetEmployeeByID(id);
            entities.Employees.Remove(customer);

        }

        public void AddEmployee()
        {
            entities.Employees.Add(new Employee());

        }
    }
}
