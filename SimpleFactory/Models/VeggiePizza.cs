using SimpleFactory.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Models
{
    /// <summary>
    /// 素食披萨
    /// </summary>
    public class VeggiePizza : Pizza
    {
        public override string Type => nameof(VeggiePizza);
    }
}
