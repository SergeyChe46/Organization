using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organization.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Adress? Adress { get; set; }
        public ICollection<Employee?> Employees { get; set; }
    }
}