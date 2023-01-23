using Microsoft.Extensions.DependencyInjection;
using SalesKiosk;
using SalesKiosk.Entities;
using SalesKiosk.Interfaces;
using SalesKiosk.Util;


var serviceProvider = new ServiceCollection()          
          .AddSingleton<ISalesSystem, SalesSystem>()         
          .BuildServiceProvider();
var salesSystem = serviceProvider.GetService<ISalesSystem>();
Console.WriteLine("---Configuring Items---");
salesSystem?.ConfigureItemsWithDeals(new Apple { basePrice=100,Id=1,IsDealEnabled=true,Name=ItemConstants.Apple});
Console.WriteLine("--Calculating Total Sales---");
var totalSales = $"Total Sales {salesSystem?.CalculateSales()}";
Console.WriteLine(totalSales);
Console.ReadLine();



