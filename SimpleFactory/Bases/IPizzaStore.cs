using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Bases
{
    public interface IPizzaStore
    {
        /// <summary>
        /// 订购pizza
        /// </summary>
        /// <param name="type">pizza类型</param>
        /// <returns></returns>
        Pizza OrderPizza(string type);
    }
}
