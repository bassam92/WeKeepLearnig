using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace PractMVC.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        public string EmpName{ get; set; }
        [Required]
        public DateTime doj { get; set; }
        [Required]
        public string dep { get; set; }
        
    }

    public class EmployeeDBcontext : DbContext
    {
        DbSet<Employee> Employees { get; set; }
    }
}