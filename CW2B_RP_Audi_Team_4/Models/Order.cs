using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CW2B_RP_Audi_Team_4.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
                       ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        public int TableNumber { get; set; }

        [StringLength(30)]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; } = string.Empty;

        [StringLength(255)]
        [Display(Name = "Confirmation")]
        public string Confirmation { get; set; } = string.Empty;

        [StringLength(20)]
        [Display(Name = "Date of Delivery")]
        public string DeliveryDate { get; set; } = string.Empty;

        [StringLength(40)]
        [Display(Name = "Tracking of Delivery")]
        public string DeliveryTracking { get; set; } = string.Empty;

        // Navigation properties

        //public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
