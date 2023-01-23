using SalesKiosk.Entities;

namespace SalesKiosk.Interfaces
{
    public interface ISalesSystem
    {
        public double CalculateSales();
        public void ConfigureItemsWithDeals(BaseItem baseItem);
    }
}