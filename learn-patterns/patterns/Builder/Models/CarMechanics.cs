using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Builder.Models
{
    public class CarMechanics
    {
        public string TransmissionType { get; set; }

        public string Engine { get; set; }

        public string SparkPlugs { get; set; }

        public CarMechanics()
        {
            TransmissionType = "Не построено";
            Engine = "Не построено";
            SparkPlugs = "Не построено";
        }
    }
}
