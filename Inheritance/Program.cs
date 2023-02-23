using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            //DONE Create a class Bird
            //DONE give this class 4 members that are specific to Bird
            //DONE Set this class to inherit from your Animal Class

            //DONE Create a class Reptile
            //DONE give this class 4 members that are specific to Reptile
            //DONE Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var Owl = new Bird()
            {
                canFly = true,
                featherTypes = "comb like",
                flyDistances = 3000,
                beakType = "hooked"
            };

            Console.WriteLine($"Can owls fly? {Owl.canFly}. They have {Owl.featherTypes} feathers. The distance they fly is {Owl.flyDistances} miles, and have {Owl.beakType} beak");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var Turtle = new Reptile()
            {
                heatSource = "heat rocks",
                scaleType = "scutes",
                eggs = 8,
                parentalCare = false
            };

            Console.WriteLine($"Turtles use {Turtle.heatSource} as heat source. Type Scales: {Turtle.scaleType}. Can lay {Turtle.eggs} eggs. Parental care? {Turtle.parentalCare}");
        }
    }
}
