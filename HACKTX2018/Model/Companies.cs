using System;
using System.ComponentModel.DataAnnotations;

namespace HACKTX2018.Model
{
    public class Companies
    {
        [Display(Name = "Funder ID")]
        public Int32 CompaniesID { get; set; }

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

        [Required(ErrorMessage = "Shares is needed")]
        [Display(Name = "Number of Shares")]
        public String NumberShares { get; set; }

        [Required(ErrorMessage = "Company Value is needed")]
        [Display(Name = "Company Value")]
        public String CompanyValue { get; set; }
    }
}
