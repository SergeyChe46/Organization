using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Organization.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Position { get; set; }
        public decimal Salary { get; set; }
    }
}