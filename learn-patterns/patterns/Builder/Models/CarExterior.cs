using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Builder.Models
{
    public class CarExterior
    {
        public string BodyType { get; set; }

        public string BodyColor { get; set; }

        public string GlassType { get; set; }

        public CarExterior()
        {
            BodyType = "Не построено";
            BodyColor = "Не построено";
            GlassType = "Не построено";
        }
    }
}
