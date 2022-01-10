using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_bai2.Models;

namespace API_bai2.Controllers
{
    public class EmployeeController : ApiController
    {
        static EmployeeCollection employeeList = new EmployeeCollection();

        //api/employee Get - lay du lieu
        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeList.GetAll();
        }

        //api/employee/2
        public Employee GetEmployee (int id)
        {
            return employeeList.Get(id);
        }

        //api/employee/  Post - them moi

        public Employee PostEmployee(Employee employee)
        {
            return employeeList.Add(employee);
        }

        //api/employee/ {id} Put - cap nhat/ mo cai tai lieu len di
        public Employee PutEmployee(int id, Employee employee)
        {
            employee.id = id;
            return employeeList.Update(employee);
        }

        //api/employee/{id} - Delete -xoa
        public IEnumerable<Employee> DeleteEmployee(int id)
        {
            return employeeList.Delete(id);
        }


    }
}
