using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartment.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string EmpName { get; set; }
        public string EmpLastname { get; set; }
        public string EmpCity { get; set; }

        public Department depart { get; set; }
    }
}
