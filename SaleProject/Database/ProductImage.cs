using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SaleProject.Database
{
    public class ProductImage
    {
        [Key]
        public int ID { get; set; }
        public string ImageUrl { get; set; }
        [Column("Product_ID")]
        public int? Product_ID { get; set; }
        [JsonIgnore]
        [ForeignKey("Product_ID")]
        public virtual Product Products { get; set; }
        [DefaultValue("false")]
        public bool IsMain { get; set; }
    }
}