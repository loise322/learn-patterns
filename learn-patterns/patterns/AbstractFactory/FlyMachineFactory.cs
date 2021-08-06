using patterns.AbstractFactory.Models;
using patterns.AbstractFactory.Models.BensinTypes;
using patterns.AbstractFactory.Models.MovementTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.AbstractFactory
{
    public class FlyMachineFactory : MachineFactory
    {
        public override Bensin CreateBensin()
        {
            return new ElectricBensin();
        }

        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }
    }
}
