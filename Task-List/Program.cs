// See https://aka.ms/new-console-template for more information
using System.Collections;
using Task_List;

ArrayList Araay1 = new ArrayList();
Araay1.Add("Box");
Araay1.Add("pen");
Araay1.Add(700);
Araay1.Add(new Product { Name = "fayez", Price = 155.5 });
foreach (var item in Araay1)
{
    Console.WriteLine(item.Name);
}
double Totalsum = 0;

List<Product> list1 = new List<Product>();

list1.Add(new Product { Name = "fayez", Price = 80 });
list1.Add(new Product { Name = "amged", Price = 50 });
list1.Add(new Product { Name = "ahmed", Price = 70.5 });

foreach (var item in list1) {
  
    Console.WriteLine(item.Name);
    Totalsum += item.Price;
}
Console.WriteLine($"///totalsum is{Totalsum}");
