using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHobbies
{
    public class Band
    {
        public Band(string name, int year)
        {
            this.Name = name;
            this.Year = year;
            this.Members = new List<Bandmember>();
        }

        public string Name { get; set; }

        public int Year { get; set; }

        public List<Bandmember> Members { get; set; }
    }
}
