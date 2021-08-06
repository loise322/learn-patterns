using patterns.Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Builder
{
    public class CarService
    {
        private Car _car;

        private ClassicCarBuilder _classicCarBuilder;
        private ModernizedCarBuilder _modernizedCarBuilder;

        private CarDirector _classicCarDirector;
        private CarDirector _modernizedCarDirector;

        public CarService()
        {
            _car = new Car();

            _classicCarBuilder = new ClassicCarBuilder();
            _modernizedCarBuilder = new ModernizedCarBuilder();

            _classicCarDirector = new CarDirector(_classicCarBuilder);
            _modernizedCarDirector = new CarDirector(_modernizedCarBuilder);
        }

        public void TestCarBuilder()
        {
            Console.WriteLine("Тест паттерна Builder:");
            Console.WriteLine();

            Console.WriteLine("Построить каркас классической машины");
            _classicCarDirector.BuildCarcassCar();
            _car = _classicCarBuilder.GetResult();
            WriteCarDescription();

            Console.WriteLine("Построить рабочую машину модернизированного типа");
            _modernizedCarDirector.BuildWorkingCar();
            _car = _modernizedCarBuilder.GetResult();
            WriteCarDescription();

            Console.WriteLine("Построить только внешний вид классической машины (Builder можно использовать и без Director)");
            _classicCarBuilder.BuildExterior();
            _car = _classicCarBuilder.GetResult();
            WriteCarDescription();
        }

        private void WriteCarDescription()
        {
            Console.WriteLine($"Внешний вид: Корпус - {_car.Exterior.BodyType}, Цвет - {_car.Exterior.BodyColor}, Стекло - {_car.Exterior.GlassType}");
            Console.WriteLine($"Внутренний вид: Стиль - {_car.Interior.StyleInterior}, Количество сидений - {_car.Interior.SeatCount}");
            Console.WriteLine($"Характеристики: Коробка передач - {_car.Mechanics.TransmissionType}, Двигатель - {_car.Mechanics.Engine}, Свечи зажигания - {_car.Mechanics.SparkPlugs}");
            Console.WriteLine();
        }
    }
}
