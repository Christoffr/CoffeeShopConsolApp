using CoffeeShopConsoleAppNet60;

List<Coffee> coffeeList = new List<Coffee> { new BlackCoffee(2), new Cortado(3), new Latte(6) };

foreach (var coffee in coffeeList)
{
    Console.WriteLine($"{coffee.Price()}, {coffee.Strength()}");
}
