using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    public class Teacher : Directory
    {
        public int seniority { get; set; }
        public override void Work()
        {
            Console.WriteLine("Teacher Name");
        }
    }
}
