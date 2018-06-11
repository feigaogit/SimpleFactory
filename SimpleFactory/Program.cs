using SimpleFactory.Bases;
using SimpleFactory.Models;
using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Factory：");

            PizzaStore pizzaStore = new PizzaStore(new SimpleFactory.SimplePizzaFactory());

            pizzaStore.OrderPizza(nameof(CheesePizza));
            pizzaStore.OrderPizza(nameof(PepperoniPizza));

            Console.ReadLine();
        }
    }
}
