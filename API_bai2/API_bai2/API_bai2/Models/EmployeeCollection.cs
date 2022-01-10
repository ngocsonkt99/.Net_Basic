using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_bai2.Models
{
    public class EmployeeCollection
    {
        private List<Employee> employees = new List<Employee>();
        private int nextId = 5;

        public EmployeeCollection()
        {
            employees.Add(new Employee { id = 1, name = "Tran thi A", gender = "nu", age = 18, salary = 99999 });
            employees.Add(new Employee { id = 2, name = "Tran thi B", gender = "nu", age = 18, salary = 99999 });
            employees.Add(new Employee { id = 3, name = "Tran thi C", gender = "nam", age = 18, salary = 99999 });
            employees.Add(new Employee { id = 4, name = "Tran thi D", gender = "nu", age = 18, salary = 99999 });
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public Employee Get(int id)
        {
            return employees.Find(e => e.id == id);
        }

        public Employee Add(Employee employee)
        {
            if(employee == null)
            {
                throw new ArgumentNullException("Employee");
            }
            employee.id = nextId++;
            employees.Add(employee);
            return employee;
        }

        public Employee Update(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee");
            }
            int index = employees.FindIndex(e => e.id == employee.id);
            employees.RemoveAt(index);
            employees.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> Delete(int id)
        {
            employees.RemoveAll(e => e.id == id);
            return employees;
        }
    }
}