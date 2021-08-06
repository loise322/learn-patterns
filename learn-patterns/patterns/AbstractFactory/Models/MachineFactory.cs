using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.AbstractFactory.Models
{
    public abstract class MachineFactory
    {
        public abstract Movement CreateMovement();

        public abstract Bensin CreateBensin();
    }
}
