using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CW2B_RP_Audi_Team_4.Models
{
    public class CarImage
    {

        public int CarImageID { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public bool Has3DModel { get; set; }

    }
}
