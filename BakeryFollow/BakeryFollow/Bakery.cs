using System;
using static System.Console;


namespace BakeryFollow
{
    public class Bakery
    {
        public Bakery()
        {
            Open();
        }

        public void Open()
        {
            Title = "Wowie Baked";
            WriteLine("Yo! The bakery offers:");
            Bake();
        }

        public void Bake()
        {
            string input;
            double total;

            Item croissant = new Item("Angry Croissant", "hellishly good", 6.66);
            Item donut = new Item("Disasterous Donut", "worryingly square", 4.44);
            Item eclair = new Item("Eclipsed eclair", "radiantly bright", 9.99);

            croissant.About();
            donut.About();
            eclair.About();

            WriteLine($"How many {croissant.Name}s would you like?");
            input = ReadLine();
            total = Convert.ToInt32(input) * croissant.Price;

            WriteLine($"How many {donut.Name}s would you like?");
            input = ReadLine();
            total += Convert.ToInt32(input) * donut.Price;

            WriteLine($"How many {eclair.Name}s would you like?");
            input = ReadLine();
            total += Convert.ToInt32(input) * eclair.Price;

            WriteLine($"Your total is {total}");





            ReadKey(true);

        }
    }   
}
