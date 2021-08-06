using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.AbstractFactory.Models.BensinTypes
{
    public class GasBensin : Bensin
    {
        public override void Fill()
        {
            Console.WriteLine("Заправлен газом.");
        }
    }
}
