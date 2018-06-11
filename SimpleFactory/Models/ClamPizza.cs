using SimpleFactory.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Models
{
    /// <summary>
    /// 蛤蜊披萨
    /// </summary>
    public class ClamPizza : Pizza
    {
        public override string Type => nameof(ClamPizza);
    }
}
