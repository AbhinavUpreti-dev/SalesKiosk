using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesKiosk;
using SalesKiosk.Entities;
using SalesKiosk.Interfaces;

namespace SalesKioskTest
{
    [TestFixture]
    public class SalesSystemTest
    {

        [TestCase(0, true, 100, "Apple")]
        public void CalculateSalesOnNormalPriceTest(int id, bool isDealEnabled, double baseprice, string name)
        {
            var salesSystem = new SalesSystem();
            // Arrage            
            salesSystem.ConfigureItemsWithDeals(new Apple { basePrice = baseprice,Id=id,IsDealEnabled= isDealEnabled, });               

            // Act
            var actual = salesSystem.CalculateSales();

            // Assert
            Assert.That(actual, Is.EqualTo(105.0));
        }

        [TestCase(0, false, 100,"Apple")]
        public void CalculateSalesOnDealEnabled(int id, bool isDealEnabled, double baseprice, string name)
        {
            // Arrage
            var salesSystem = new SalesSystem();
            salesSystem.ConfigureItemsWithDeals(new Apple { basePrice = baseprice, Id = id, IsDealEnabled = isDealEnabled,Name=name });

            // Act
            var actual = salesSystem.CalculateSales();

            // Assert
            Assert.That(actual, Is.EqualTo(105.0));
        }

        [TestCase(0, true, 100, "Butter")]
        public void CalculateSalesOnDealEnabledButter(int id, bool isDealEnabled, double baseprice, string name)
        {
            // Arrage
            var salesSystem = new SalesSystem();
            salesSystem.ConfigureItemsWithDeals(new AmulButter { basePrice = baseprice, Id = id, IsDealEnabled = isDealEnabled, Name = name });

            // Act
            var actual = salesSystem.CalculateSales();

            // Assert
            Assert.That(actual, Is.EqualTo(94.0));
        }

        [TestCase(0, false, 100, "Butter")]
        public void CalculateSalesOnDealDisabledButter(int id, bool isDealEnabled, double baseprice, string name)
        {
            // Arrage
            var salesSystem = new SalesSystem();
            salesSystem.ConfigureItemsWithDeals(new AmulButter { basePrice = baseprice, Id = id, IsDealEnabled = isDealEnabled, Name = name });

            // Act
            var actual = salesSystem.CalculateSales();

            // Assert
            Assert.That(actual, Is.EqualTo(105.0));
        }

    }
}
