using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.AbstractFactory.Models
{
    public abstract class Bensin
    {
        public string BensinType { get; protected set; }

        public abstract void Fill();
    }
}
