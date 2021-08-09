using patterns.FactoryMethod.Models;
using patterns.FactoryMethod.Models.Methods;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.FactoryMethod
{
    public class FactoryMethodCarService
    {
        private readonly Creator creator;


        public FactoryMethodCarService(RoadType roadType)
        {
            if (roadType == RoadType.Classic)
            {
                creator = new ClassicCreator();
            }
            else if (roadType == RoadType.Sport)
            {
                creator = new SportCreator();
            } 
            else
            {
                throw new Exception();
            }
        }

        public void TestFactoryMethod()
        {
            Console.WriteLine("Тест фабричного метода:");
            Console.WriteLine();

            creator.TestRoad();
          
            Console.WriteLine();
        }
    }
}
