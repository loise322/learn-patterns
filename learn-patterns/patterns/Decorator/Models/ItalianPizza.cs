using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Decorator.Models
{
    public class ItalianPizza : IPizza
    {
        public void Cook()
        {
            Console.WriteLine("Итальянская пицца");
        }
    }
}
