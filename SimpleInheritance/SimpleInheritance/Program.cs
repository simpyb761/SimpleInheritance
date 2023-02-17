using System;
using System.Drawing;
using static System.Console;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 
    class Reptile : Animal 
    {
        public int _numberOfLegs;
        public string _species;
        public string _color; 
        public Reptile()
        {
            name = "";
            _numberOfLegs = 0;
            _species = "";
            _color = "";
        }
        public Reptile(string name, int numberOfLegs, string species, string color)
        {
            this.name = name;
            _numberOfLegs = numberOfLegs;
            _species = species;
            _color = color;
        }

        public void displayReptile()
        {
            Console.WriteLine($"My name is {name}. I am a {_species} who has {_numberOfLegs} legs. My color is {_color}");
        }
    }

    class Fish : Animal
    {
        public string _species;
        public string _color;
        public string _typeOfWater;

        public Fish()
        {
            name = "";
            _species = "";
            _color = "";
            _typeOfWater = "";
        }
        public Fish(string name, string species, string color, string typeOfWater)
        {
            this.name = name;
            _species = species;
            _color = color;
            _typeOfWater = typeOfWater;
        }
        public void displayFish()
        {
            Console.WriteLine($"I am a {_species} and my name is {name}. I am {_color} and live in {_typeOfWater} water!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Reptile mySnake= new Reptile();
            mySnake.name = "Nairobi";
            mySnake._numberOfLegs = 0;
            mySnake._species = "Copperhead Snake";
            mySnake._color = "brown";
            Fish myFish = new Fish();
            myFish.name = "Gilbert";
            myFish._species = "Lionfish";
            myFish._color = "Red and White";
            myFish._typeOfWater = "Salt";

            //derived class object using parameterized constructor
            Reptile myLizard = new Reptile("Chi", 4, "Bearded Dragon", "Tan");
            Fish mySecondFish = new Fish("Dory", "Blue Tang", "Blue and Yellow", "Salt");
            mySnake.displayReptile();
            myLizard.displayReptile();
            myFish.displayFish();
            mySecondFish.displayFish();

        }

    }
}