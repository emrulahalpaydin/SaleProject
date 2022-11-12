using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SaleProject.Database
{
    public class DB : IdentityDbContext<IdentityUser>
    {
        public DB() : base("name=DB")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public static DB Create()
        {
            return DBInstance.CreateInstance();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<XMaster> XMasters { get; set; }
    }
}