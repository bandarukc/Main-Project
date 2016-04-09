using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapSite1.Domain.Entities
{
    public class Community
    {
        [Key]
        public int ResidentId { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string  Country { get; set; }
        public string State { get; set; }
        public decimal Zip { get; set; }
        public decimal Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
