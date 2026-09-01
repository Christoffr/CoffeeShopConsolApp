
using CoffeeShopConsoleAppNet60;

List<Coffee> coffeeList = new List<Coffee> { new BlackCoffee(), new Cortado(), new Latte() };

foreach (var coffee in coffeeList)
{
    Console.WriteLine($"{coffee.Price()}, {coffee.Strength()}");
}
