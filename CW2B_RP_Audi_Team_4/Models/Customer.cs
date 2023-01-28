using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CW2B_RP_Audi_Team_4.Models
{
    public class Customer
    {
        [Display(Name = "CustomerID")]
        [StringLength(10)]
        public int CustomerID { get; set; }

        [Display(Name = "CustomerName")]
        [StringLength(20)]
        public string CustomerName { get; set; } = string.Empty;

        [Display(Name = "CustomerEmail")]
        [StringLength(40)]
        public string CustomerEmail { get; set; } = string.Empty;

        [Display(Name = "CustomerPhone")]
        [StringLength(15)]
        public string CustomerPhone { get; set; } = string.Empty;

        [Display(Name = "CustomerCity")]
        [StringLength(20)]
        public string CustomerCity { get; set; } = string.Empty;

        [Display(Name = "CustomerRegion")]
        [StringLength(20)]
        public string CustomerRegion { get; set; } = string.Empty;

        [Display(Name = "CustomerAddress")]
        [StringLength(50)]
        public string CustomerAddress { get; set; } = string.Empty;

        [Display(Name = "OrderID")]
        [StringLength(10)]
        public string OrderID { get; set; } = string.Empty;

        // Navigation properties

        //public virtual ICollection<Customer> Customers { get; set; }
    }
}
