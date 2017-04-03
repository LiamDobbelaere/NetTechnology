using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoolUtils
{
    public class Temperatuur
    {
        public Temperatuur(float celsiusTemperatuur)
        {
            this.Celsius = celsiusTemperatuur;
        }

        public float Celsius { get; set; }

        public float Kelvin
        {
            get
            {
                return Celsius + 273.15f;
            }
        }

        public float Farenheit
        {
            get
            {
                return (Celsius * 9 / 5 + 32f);
            }
        }
    }
}
