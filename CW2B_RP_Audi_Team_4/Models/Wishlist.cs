using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW2B_RP_Audi_Team_4.Models
{
    public class Wishlist
    {
        public int WishlistID { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Model Name")]
        public string ModelName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string CustomerName { get; set; } = string.Empty;
    }
}
