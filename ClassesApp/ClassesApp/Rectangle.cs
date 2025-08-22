using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Rectangle
    {
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
