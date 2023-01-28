using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW2B_RP_Audi_Team_4.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }

        public decimal SalePrice { get; set; }

        public int quantity { get; set; }

        //public virtual ICollection<Car> Cars { get; set; }
    }
}
