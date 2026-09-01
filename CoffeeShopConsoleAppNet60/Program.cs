using CoffeeShopConsoleAppNet60;

BlackCoffee blackCoffee = new BlackCoffee(2, "Black Coffee");
Cortado cortado = new Cortado(3, "Cortado");
Latte latte = new Latte(5, "Latte");
FlatWhite flatWhite = new FlatWhite(4, "Flat White");


List<Coffee> coffeeList = new List<Coffee> {blackCoffee, cortado, latte };

List<IMilk> coffeesWithMilk = new List<IMilk> { cortado, latte, flatWhite};

foreach (var coffee in coffeeList)
{
    Console.WriteLine($"{coffee.Name}, discounted price: {coffee.Price()}, Strenght {coffee.Strength()}");
}

foreach (var coffee in coffeesWithMilk)
{
    Console.WriteLine(coffee.mlMilk());
}


