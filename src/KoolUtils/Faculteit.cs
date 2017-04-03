using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoolUtils
{
    public class Faculteit
    {
        public Faculteit(int number)
        {
            Number = number;
        }

        public int Number { get; set; }

        public int Calculate()
        {
            int result = Number;

            for (int i = Number - 1; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
