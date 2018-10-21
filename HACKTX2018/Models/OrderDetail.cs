// Name: Jerry Sun
// Date: Oct 15 2018
// HW4, MVC Supplier

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HACKTX2018.Models
{
    public class OrderDetail
    {
        [Display(Name = "OrderDetail ID")]
        public Int32 OrderDetailID{ get; set; }

        [Required(ErrorMessage = "Company Name is required.")]
        [Display(Name = "Company Name")]
        public String CompanyName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Display(Name = "Phone Number")]
        [DisplayFormat(DataFormatString = "{0:###-###-####}", ApplyFormatInEditMode = true)]
        public String PhoneNumber { get; set; }

        [Required(ErrorMessage = "Number of Shares is needed")]
        [Display(Name = "Share Amount")]
        public String ShareAmount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Company Comapny { get; set; }


    }
}
