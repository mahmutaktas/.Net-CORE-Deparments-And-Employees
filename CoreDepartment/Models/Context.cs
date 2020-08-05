using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartment.Models
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=LAPTOP-G0H4BO0U\\SQLEXPRESS2017; " +
                "database=coreemployees; integrated security = true;");

        }


        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}
