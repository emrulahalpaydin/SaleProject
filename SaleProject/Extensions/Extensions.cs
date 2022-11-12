using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaleProject.Extensions
{
    public class Extensions
    {
        public static T Map<T>(object objfrom, T objto)
        {
            var toProperties = objto.GetType().GetProperties();
            var fromProperties = objfrom.GetType().GetProperties();
            toProperties.ToList().ForEach(o =>
            {
                var fromp = fromProperties.FirstOrDefault(x => x.Name == o.Name && x.PropertyType == o.PropertyType);
                if (fromp != null)
                {
                    o.SetValue(objto, fromp.GetValue(objfrom));
                }
            });
            return objto;
        }
    }
}