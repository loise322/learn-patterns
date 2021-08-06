using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.AbstractFactory.Models.MovementTypes
{
    public class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летит над землей");
        }
    }
}
