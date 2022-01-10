using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_bai2.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
    }
}