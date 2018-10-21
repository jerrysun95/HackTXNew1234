using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HACKTX2018.Models;

namespace HACKTX2018.Model
{
    public class Order
    {
        [Display(Name= "Order Id")]
        public Int32 OrderID { get; set; }

        [Display(Name = "Order Date")]
        [Required(ErrorMessage = "Order Date is required")]
        public DateTime OrderDate { get; set; }

        public virtual Funder Funder { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
