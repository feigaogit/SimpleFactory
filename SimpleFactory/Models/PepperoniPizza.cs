using SimpleFactory.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Models
{
    /// <summary>
    /// 香肠比萨
    /// </summary>
    public class PepperoniPizza : Pizza
    {
        public override string Type => nameof(PepperoniPizza);
    }
}
