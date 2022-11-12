﻿using SaleProject.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaleProject.Models
{
    public class ProductDTO
    {
        public string ProductTitle { get; set; }
        public bool IsActive { get; set; }
        public int Price { get; set; }
        public string DescriptionTR { get; set; }
        public string DescriptionAR { get; set; }
        public string DescriptionRU { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}