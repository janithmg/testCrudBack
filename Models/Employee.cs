using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testCrudBack.Models
{
    public class Employee
    {
        public int ID { get; set; } 
        public String Name { get; set; }
        public String Age { get; set; }
        public int IsActive { get; set; }
    }
}