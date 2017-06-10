using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Patriotisk.Models
{
    public class Subscriber
    {
        
        [Display(Name = "Navn")]
        [Required(ErrorMessage = "Navn er nødvendigt.")]
        public string Name { get; set; }

        [Display(Name = "Emailaddresse")]
        [Required(ErrorMessage = "Email er nødvendig.")]
        [EmailAddress(ErrorMessage = "Ikke gyldig Email")]
        public string Email { get; set; }
    }
}
