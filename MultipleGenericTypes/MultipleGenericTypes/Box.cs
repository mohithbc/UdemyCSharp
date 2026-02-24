using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleGenericTypes
{
    internal class Box<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }
        public Box(TFirst first, TSecond second) 
        {
            First = first; 
            Second = second; 
        }
        public void Display()
        {
            Console.WriteLine($"First: {First} Second: {Second}");
        }
    }
}
