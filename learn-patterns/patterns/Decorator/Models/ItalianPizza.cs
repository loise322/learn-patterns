using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Decorator.Models
{
    public class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Italian pizza")
        {
        }

        public override int GetCost()
        {
            return 10;
        }
    }
}
