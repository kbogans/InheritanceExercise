using System;
using System.Collections.Generic;
using System.Text;
// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            Age = 2;
            NumOfLegs = 0;
            Color = "Black";
            IsAlive = true;
        }

        public bool IsColdBlooded { get; set; }
        public bool LaysEggs { get; set; }

        public string RepColor { get; set; }

        public int RepAge { get; set; }
    }
}
