using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
        }
        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }
        public string SkinColor { get; set; }
        public bool CanGrowTail { get; set; }

        //Constructor
        public Reptile(string name, int age, bool hasScales, bool isColdBlooded, string species, bool canGrowTail)
        {
            Name = name;
            Age = age;
            HasScales = hasScales;
            IsColdBlooded = isColdBlooded;
            SkinColor = SkinColor;
            CanGrowTail = canGrowTail;
        }   
    }
    
}
