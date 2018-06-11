using SimpleFactory.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Bases
{
    public class PizzaStore : IPizzaStore
    {
        private readonly SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this._factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            //通过类型获取pizza
            Pizza pizza = _factory.CreatePizza(type);
            if (pizza != null)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
                Console.WriteLine($"{type} Done!!!");
            }
            else
            {
                Console.WriteLine("We don't have this kind of pizza!!");
            }

            return pizza;
        }
    }
}
