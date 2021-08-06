using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Builder.Models
{
    public class CarInterior
    {
        public string StyleInterior { get; set; }

        public int SeatCount { get; set; }

        public CarInterior()
        {
            StyleInterior = "Не построено";
            SeatCount = 0;
        }
    }
}
