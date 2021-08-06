using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.FactoryMethod.Models
{
    public abstract class Creator
    {
        public string Name { get; set; }

        public Creator(string name)
        {
            Name = name;
        }

        public abstract Car CreateCar();
    }
}
