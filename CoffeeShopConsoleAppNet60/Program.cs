using CoffeeShopConsoleAppNet60;

BlackCoffee blackCoffee = new BlackCoffee(2);
Cortado cortado = new Cortado(3);
Latte latte = new Latte(5);


List<Coffee> coffeeList = new List<Coffee> {blackCoffee, cortado, latte };

List<IMilk> coffeesWithMilk = new List<IMilk> { cortado, latte };

foreach (var coffee in coffeeList)
{
    Console.WriteLine($"{coffee.Price()}, {coffee.Strength()}");
}


