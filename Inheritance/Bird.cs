using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        private string wingSpan;

        public Bird() 
        {
        }
        public string WingSpan { get; set; }
        public bool HasFeathers { get; set; }
        public string Sound { get; set; }
        public bool CanFly { get; set; }

        //constructor
        public Bird(string name, int age,string wingspan, bool hasFeathers, string sound, bool canFly)
        {
            Name = name;
            Age = age;
            WingSpan = wingSpan;
            HasFeathers = hasFeathers;
            Sound = sound;
            CanFly = canFly;
        }
    }

}
