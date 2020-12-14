using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Model
{
    public class Customer
    {
        [Key]
        public int Id{ get; set; }
        

        public string Name{ get; set; }

        public string Country { get; set; }

        [EmailAddress]
        public string Email{ get; set; }

    }
}
