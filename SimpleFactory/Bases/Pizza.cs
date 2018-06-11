using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Bases
{
    public abstract class Pizza : IPizza
    {
        public abstract string Type { get; }

        public void Prepare()
        {
            Console.WriteLine($"{Type} is Preparing...");
        }
        public void Bake()
        {
            Console.WriteLine($"{Type} is Baking...");
        }
        public void Cut()
        {
            Console.WriteLine($"{Type} is Cutting...");
        }

        public void Box()
        {
            Console.WriteLine($"{Type} is Boxing...");
        }
    }
}
