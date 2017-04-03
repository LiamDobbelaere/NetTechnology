using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHobbies
{
    public enum Gender
    {
        MALE,
        FEMALE
    }

    public class Bandmember
    {
        public Bandmember(string name, int age, Gender gender, bool alive)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Alive = alive;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public bool Alive { get; set; }
    }
}
