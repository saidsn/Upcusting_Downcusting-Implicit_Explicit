using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    public class Assistant : Doctor
    {
        public int Worktime { get; set; }
        public override void Work()
        {
            Console.WriteLine("Assistant Name");
        }
    }
}
