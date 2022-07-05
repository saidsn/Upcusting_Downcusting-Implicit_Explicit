using System;

namespace Homework.Models
{
    public class Shark : Fish
    {
        public int Weight { get; set; } = 50;
        public override void Eat()
        {
            Console.WriteLine("Shark Eating");
        }
    }
}
