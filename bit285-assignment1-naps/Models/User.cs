using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace bit285_assignment1_naps.Models
{
    public class User
{

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Program { get; set; }
        public string Bday { get; set; }
        public string Color { get; set; }
    }
}
