using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaleProject.Database
{
    public class DBInstance
    {
        protected static DB DatabaseContext { get; set; }
        public static DB CreateInstance()
        {
            return new DB();
        }
    }
}