using CoffeeShopConsoleAppNet60;

BlackCoffee blackCoffee = new BlackCoffee(2);
Cortado cortado = new Cortado(3);
Latte latte = new Latte(5);
FlatWhite flatWhite = new FlatWhite(4);


List<Coffee> coffeeList = new List<Coffee> {blackCoffee, cortado, latte };

List<IMilk> coffeesWithMilk = new List<IMilk> { cortado, latte, flatWhite};

foreach (var coffee in coffeeList)
{
    Console.WriteLine($"{coffee.Price()}, {coffee.Strength()}");
}

foreach (var coffee in coffeesWithMilk)
{
    Console.WriteLine(coffee.mlMilk());
}


