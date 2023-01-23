using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesKiosk.Entities;
using SalesKiosk.Interfaces;
using SalesKiosk.Util;

namespace SalesKiosk
{
    public class SalesSystem : ISalesSystem
    {      

        public List<BaseItem> Items { get; set; } = new List<BaseItem>();

        //Mocking data
        public void ConfigureItemsWithDeals(BaseItem baseItem)
        {
            Items.Add(baseItem);
        }

        public double CalculateSales()
        {
            double total = 0;
            foreach (var item in Items)
            {
                if (item.IsDealEnabled)
                {
                    total = total + item.ActualPrice;
                }
                else
                {
                    total += item.basePrice;
                }
            }
            return Math.Round(AmountWithSalesTax(total));
        }

        private double AmountWithSalesTax(double itemPrice)
        {
            return itemPrice + ItemConstants.SALES_TAX * itemPrice;
        }
    }
}
