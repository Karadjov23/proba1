using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proba1.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string EmployeersPosition { get; set; }
        [ForeignKey("EmployeeId")]
        public ICollection<Signal> Signals { get; set; }
    }
}
