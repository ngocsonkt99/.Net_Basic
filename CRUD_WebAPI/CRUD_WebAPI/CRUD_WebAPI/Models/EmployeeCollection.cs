using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_WebAPI.Models
{
    public class EmployeeCollection
    {
        private List<Employee> listEmployee = new List<Employee>();
        private int nextId = 5;

        public EmployeeCollection()
        {
            listEmployee.Add(new Employee { Id = 1, Name = "Trần Thị A", Gender = "Nữ", Age = 25, Salary = 1000000 });
            listEmployee.Add(new Employee { Id = 2, Name = "Hồ Văn B", Gender = "Nam", Age = 24, Salary = 5000000 });
            listEmployee.Add(new Employee { Id = 3, Name = "Lê Thị C", Gender = "Nữ", Age = 35, Salary = 4500000 });
            listEmployee.Add(new Employee { Id = 4, Name = "Huỳnh Văn D", Gender = "Nam", Age = 27, Salary = 1200000 });
        }

        public IEnumerable<Employee> GetAll()
        {
            return listEmployee;
        }

        public Employee Get(int id)
        {
            return listEmployee.Find(e => e.Id == id);
        }

        public Employee Add(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee");
            }
            employee.Id = nextId++;
            listEmployee.Add(employee);
            return employee;
        }

        public Employee Update(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee");
            }
            int index = listEmployee.FindIndex(e => e.Id == employee.Id);
            listEmployee.RemoveAt(index);
            listEmployee.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> Delete(int id)
        {
            listEmployee.RemoveAll(e => e.Id == id);
            return listEmployee;
        }
    }
}