using System;
using static System.Console;    

namespace BakeryFollow
{
    public class Item
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price;



        public Item()
        {
        }

        public Item(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;

        }

        public void About()
        {
            WriteLine($"{Name} is {Description}: "
                + Price);
        }
    }
}
