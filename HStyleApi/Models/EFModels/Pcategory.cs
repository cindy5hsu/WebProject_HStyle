﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HStyleApi.Models.EFModels
{
    public partial class Pcategory
    {
        public Pcategory()
        {
            Products = new HashSet<Product>();
        }

        public int PcategoryId { get; set; }
        public string PcategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}