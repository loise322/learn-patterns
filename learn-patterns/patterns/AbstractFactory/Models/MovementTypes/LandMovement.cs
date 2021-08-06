using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.AbstractFactory.Models.MovementTypes
{
    public class LandMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Едет по земле");
        }
    }
}
