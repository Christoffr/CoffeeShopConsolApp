using CoffeeShopConsoleAppNet60;

BlackCoffee blackCoffee = new BlackCoffee(2, "Black Coffee", Blend.Keini);
Cortado cortado = new Cortado(3, "Cortado", Blend.Daterra);
Latte latte = new Latte(5, "Latte", Blend.Reshad);
FlatWhite flatWhite = new FlatWhite(4, "Flat White", Blend.Basha);


List<Coffee> coffeeList = new List<Coffee> {blackCoffee, cortado, latte, flatWhite};

List<IMilk> coffeesWithMilk = new List<IMilk> { cortado, latte, flatWhite};

foreach (var coffee in coffeeList)
{
    Console.WriteLine($"{coffee.Name}, discounted price: {coffee.Price()}, Strenght {coffee.Strength()}, Blend: {coffee.Blend}");
}

foreach (var coffee in coffeesWithMilk)
{
    Console.WriteLine(coffee.mlMilk());
}


