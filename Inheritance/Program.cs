using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes



            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.IsBirdAlive = true;
            myBird.CanFly = true;
            myBird.BirdColor = "yellow";
            myBird.CanTalk = true;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myReptile = new Reptile();
            myReptile.IsColdBlooded = true;
            myReptile.LaysEggs = true;
            myReptile.RepColor = "black";
            myReptile.RepAge = 3;

            var myAnimals = new Animal[] { myBird, myReptile };
            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"Number of Legs: {animal.NumOfLegs}");
                Console.WriteLine($"Color: {animal.Color}");
                Console.WriteLine($"IsAlive: {animal.IsAlive}");
                Console.WriteLine($"");
            }
        }
    }
}
