using SOLID._3_I.Problem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_I.Problem;
internal class BurgerOrderService : IFoodOrderService
{
    public void OrderBurger(int quantity)
    {
        //Code to order a Burger
        Console.WriteLine($"cantidad de Burgers {quantity}");
    }

    public void OrderSalad(int quantity)
    {
        throw new NotImplementedException();
    }

    public void OrderSteak(int quantity)
    {
        throw new NotImplementedException();
    }
}
