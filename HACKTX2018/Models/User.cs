// Name: Jerry Sun
// Date: Oct 15 2018
// HW4, MVC Supplier

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HACKTX2018.Models
{
    public class User
    {
        [Display(Name = "Startup ID")]
        public Int32 UserID { get; set; }

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

        public virtual List<Organization> Organizations { get; set; }



    }
}
