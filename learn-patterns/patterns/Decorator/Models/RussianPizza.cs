using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Decorator.Models
{
    public class RussianPizza : IPizza
    {
        public void Cook()
        {
            Console.WriteLine("Русская пицца");
        }
    }
}
