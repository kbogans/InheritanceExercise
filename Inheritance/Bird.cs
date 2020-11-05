using Inheritance;
using System;
using System.Collections.Generic;
using System.Text;
// Create a class Bird
// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class


namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Age = 0;
            NumOfLegs = 2;
            Color = "Green";
            IsAlive = true;
        }
        public bool IsBirdAlive { get; set; }
        public bool CanFly { get; set; }
        public string BirdColor { get; set; }
        public bool CanTalk { get; set; }

        


    }
}


