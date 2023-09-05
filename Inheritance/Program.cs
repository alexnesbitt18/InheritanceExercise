using System;
using System.Xml;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal -- Done
            // give this class 4 members that all Animals have in common -- Done


            // Create a class Bird -- Done 
            // give this class 4 members that are specific to Bird -- Done
            // Set this class to inherit from your Animal Class -- Done 

            // Create a class Reptile -- Done
            // give this class 4 members that are specific to Reptile -- Done
            // Set this class to inherit from your Animal Class -- Done




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var Seagull = new Bird();
            Seagull.WingColor = "White";
            Seagull.BeakLength = 5;
            Seagull.CanFly = true;
            Seagull.DoMigrate = true;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var Lizard = new Reptile();
            Lizard.Habitat = "Desert";
            Lizard.HasScales = true;
            Lizard.CanRegenerateTail = true;
            Lizard.IsColdBlooded = true;

            var myAnimals = new Animal[] {Seagull, Lizard};
            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Age: They are {animal.Age} years old.");
                Console.WriteLine($"It has {animal.LegCount} legs.");
                Console.WriteLine($"It lives by {animal.LandSeaAir}.");
                Console.WriteLine("");
            }
        }
    }
}
