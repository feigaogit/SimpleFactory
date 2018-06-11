using SimpleFactory.Bases;
using SimpleFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.SimpleFactory
{
    public class SimplePizzaFactory
    {
        /// <summary>
        /// 根据类型创建一个pizza
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case nameof(CheesePizza):
                    pizza = new CheesePizza();
                    break;
                case nameof(ClamPizza):
                    pizza = new ClamPizza();
                    break;
                case nameof(PepperoniPizza):
                    pizza = new PepperoniPizza();
                    break;
                case nameof(VeggiePizza):
                    pizza = new VeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
