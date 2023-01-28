using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW2B_RP_Audi_Team_4.Models
{
    public class Car
    {
        public int CarID { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Model Name")]
        public string ModelName { get; set; } = string.Empty;

        [Required]
        [StringLength(30)]
        [Display(Name = "Brand")]
        public string Brand { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        [Display(Name = "Engine Size")]
        public string EngineSize { get; set; } = string.Empty;

        public decimal ZeroToSixty { get; set; }
        public int Power { get; set; }
        public int Torque { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Fuel Type")]
        public string FuelType { get; set; } = string.Empty;

        //public Order Order { get; set; }

        //public OrderItem OrderItem { get; set; }
    }
}
