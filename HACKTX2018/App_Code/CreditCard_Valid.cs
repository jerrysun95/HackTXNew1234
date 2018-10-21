using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;


// THIS IS NOT FINISHED!! USE IT TO VALID CARD
namespace HACKTX2018.App_Code
{
    [AttributeUsage(AttributeTargets.Property |
  AttributeTargets.Field, AllowMultiple = false)]
    sealed public class CreditCardValidation : ValidationAttribute
    {

    }



}