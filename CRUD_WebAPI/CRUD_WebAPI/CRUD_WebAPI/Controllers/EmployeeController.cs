using CRUD_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD_WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        private static EmployeeCollection listEmployee = new EmployeeCollection();

        //api/employee GET - Lấy dữ liệu
        public IEnumerable<Employee> GetAllEmployees()
        {
            return listEmployee.GetAll();
        }

        //api/employee/{id}
        public Employee GetEmployee(int id)
        {
            return listEmployee.Get(id);
        }

        //api/employee/ POST - Thêm mới
        public Employee PostEmployee(Employee employee)
        {
            return listEmployee.Add(employee);
        }

        //api/employee/{id} PUT - Cập nhật
        public Employee PutEmployee(int id, Employee employee)
        {
            employee.Id = id;
            return listEmployee.Update(employee);
        }

        //api/employee/{id} Delete - Xóa
        public IEnumerable<Employee> DeleteEmployee(int id)
        {
            return listEmployee.Delete(id);
        }
    }
}
