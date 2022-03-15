using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proba1.Data
{
    public class User:IdentityUser
    {
       [Key]
        public string FirstName { get; set; }
     
        public string LastName { get; set; }
       
        public ICollection<Signal> Signal { get; set; }
    }
}
