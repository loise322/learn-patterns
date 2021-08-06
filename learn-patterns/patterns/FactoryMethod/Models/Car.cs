using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace patterns.FactoryMethod.Models
{
    public abstract class Car
    {
        public string Name { get; protected set; }
    }
}