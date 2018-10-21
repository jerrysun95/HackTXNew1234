// Name: Jerry Sun
// Date: Oct 15 2018
// HW4, MVC Supplier

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HACKTX2018.Models
{
    public class Funder
    {
        [Display(Name = "Funder ID")]
        public Int32 FunderID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [Display(Name = "Name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Display(Name = "Phone Number")]
        [DisplayFormat(DataFormatString = "{0:###-###-####}", ApplyFormatInEditMode = true)]
        public String PhoneNumber { get; set; }

        [Required(ErrorMessage = "Credit Card is required")]
        [Display(Name = "Credit Card")]
        public String CreditCard { get; set; }

        public virtual List<Order> Orders { get; set; }

    }
}

