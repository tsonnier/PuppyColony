using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IdleGame1.Models
{
    public class Building
    {
        [ScaffoldColumn(false)]
        public int BuildingID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string Name { get; set; }

        [Required, StringLength(10000), Display(Name = "Building Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? Quantity { get; set; }

        public bool Unlocked { get; set; }

        public bool Buildable { get; set; }

        //public virtual Category Category { get; set; }


    }
}