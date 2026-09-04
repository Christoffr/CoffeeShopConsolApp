using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public enum MilkType
    {
        Minimælk,
        Sødmælk,
        Havremælk,
        Soyamælk
    }
    public interface IMilk
    {
        int mlMilk();

        MilkType Milk { get; set; }
    }
}
