using SalesKiosk.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesKiosk.Entities
{
    public abstract class BaseItem
    {  
        public double basePrice { get; set; }
        public bool IsDealEnabled { get; set; }
        public int Id { get; set; }

        public string Name { get; set; }

        public double ActualPrice { get { return DiscountFactory.GetActualDiscountedPrice(Name, basePrice); } }
        
    }
}
