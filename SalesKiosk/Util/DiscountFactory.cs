using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesKiosk.Interfaces;

namespace SalesKiosk.Util
{
    internal static class DiscountFactory 
    {
        public static double GetActualDiscountedPrice(string itemName , double currentPrice)
        {
            switch (itemName)
            {
                case "Apple":
                    return currentPrice-1;                  
                case "Butter":                 
                    return currentPrice - (currentPrice * 0.10);                    
                case "HairTie":
                    return currentPrice * 0.5;
                default:
                    return currentPrice;
            }
        }
    }
}
