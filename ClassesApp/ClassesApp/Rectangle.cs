using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Rectangle
    {
        /*In C# const and readonly are two keywords used to define non modifiable fields but they differ in terms of when
         they are initialized and their usage contexts. Understanding the difference between these two can help in
        deciding which one to use based on specific requirements*/

        public const int NumberOfCorners = 4; // constant field
        public readonly string Color; // readonly field

        public Rectangle(string color)
        {
            Color = color;
        }

        // Method to display rectangle details
        public void DisplayDetails()
        {
            Console.WriteLine($"Color: {Color}, Width: {Width}, Height: {Height}, Area: {Area}, Number of corners: {NumberOfCorners}");
        }

        public double Width { get; set; }
        public double Height { get; set; }

        // computed property
        // Read only property
        public double Area
        {
            get { return Width * Height; }
        }
    }
}
