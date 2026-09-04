using CoffeeShopConsoleAppNet60;

BlackCoffee blackCoffee = new BlackCoffee(2, "Black Coffee", Blend.Keini);
Cortado cortado = new Cortado(3, "Cortado", Blend.Daterra, MilkType.Sødmælk);
Latte latte = new Latte(5, "Latte", Blend.Reshad, MilkType.Minimælk);
FlatWhite flatWhite = new FlatWhite(4, "Flat White", Blend.Basha, MilkType.Havremælk);


List<Coffee> coffeeList = new List<Coffee> {blackCoffee, cortado, latte, flatWhite};
List<Coffee> coffeeList2 = new List<Coffee> { blackCoffee};

List<IMilk> coffeesWithMilk = new List<IMilk> { cortado, latte, flatWhite};

foreach (var coffee in coffeeList)
{
    Console.WriteLine($"{coffee.Name}, discounted price: {coffee.Price()}, Strenght {coffee.Strength()}, Blend: {coffee.Blend}");

}

foreach (var coffee in coffeesWithMilk)
{
    Console.WriteLine(coffee.mlMilk());
}

Order order = new Order("Kip", "Christoffer", -1, coffeeList);
Order order2 = new("Kip", "Kathrine", 2, coffeeList2);

Console.WriteLine(order);

OrderSystem orderSystem = new OrderSystem();

orderSystem.AddOrder(order);
orderSystem.AddOrder(order2);

Console.WriteLine(orderSystem.GetTotalOrders());

