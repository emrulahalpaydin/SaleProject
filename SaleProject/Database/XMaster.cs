using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaleProject.Database
{
    public class XMaster
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(500)]
        public string Password { get; set; }
        public bool Active { get; set; }
        public DateTime CreationTime { get; set; }
    }
}