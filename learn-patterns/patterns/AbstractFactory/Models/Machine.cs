using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.AbstractFactory.Models
{
    public class Machine
    {
        private Movement movement;
        private Bensin bensin;

        public Machine(MachineFactory factory)
        {
            movement = factory.CreateMovement();
            bensin = factory.CreateBensin();
        }

        public void Drive()
        {
            movement.Move();
        }

        public void FIll()
        {
            bensin.Fill();
        }
    }
}
