using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proba1.Data
{
    public class Signal
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ICollection<SelectListItem> User { get; set; }
        public int EmployeeId { get; set; }
         [ForeignKey("EmployeeId")]
        public ICollection<SelectListItem> Employee { get; set; }
      
 
    }
}
