using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_I.Solution;
internal class Program
{
    public static void Main()
    {
        BurgerOrderService serviceBurger = new BurgerOrderService();
        serviceBurger.OrderBurger(1);

        SaladOrderService serviceSalad = new SaladOrderService();
        serviceSalad.OrderSalad(3);

        SteakOrderService steakOrderService = new SteakOrderService();
        steakOrderService.OrderSteak(1);

    }
}
