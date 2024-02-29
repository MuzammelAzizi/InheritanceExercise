using System;
using System.Threading;

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

            var parrot = new Bird();
            parrot.Name = "Jojo";
            parrot.Age = 16;
            parrot.HasFeathers = true;
            parrot.Sound = "chunchun";
            parrot.CanFly = true;
            parrot.WingSpan = "7";

            Console.WriteLine($"{parrot.Name} is a {parrot.Age} years old:\n HasFeathers: {parrot.HasFeathers} with different colors \n What sound does Jojo makes: {parrot.Sound}\n" +
                $"CanFly: {parrot.CanFly}\n WingSpan:{parrot.WingSpan}\n\n");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var alligator = new Reptile();
            alligator.Name = "Bumper";
            alligator.Age = 80;
            alligator.HasScales = true;
            alligator.IsColdBlooded = true;
            alligator.SkinColor = "green";
            alligator.CanGrowTail = true;

            Console.WriteLine($"{alligator.Name} is a {alligator.Age} years old and he is a dangerous alligator\n HasScales: {alligator.HasScales} and looks very sharp\n " +
                $"IsColdBlooded: {alligator.IsColdBlooded}\n SkinColor: {alligator.SkinColor} also changes color\n CanGrowTail: {alligator.CanGrowTail}");
        }
    }
}
