using SimpleFactory.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Models
{
    /// <summary>
    /// 奶酪披萨
    /// </summary>
    public class CheesePizza : Pizza
    {
        public override string Type => nameof(CheesePizza);
    }
}
