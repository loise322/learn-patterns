using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Decorator.Models
{
    public class RussianPizza : Pizza
    {
        public RussianPizza() : base("Russian pizza")
        {
        }

        public override int GetCost()
        {
            return 5;
        }
    }
}
