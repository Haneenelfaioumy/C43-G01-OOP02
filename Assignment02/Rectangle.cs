using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal struct Rectangle
    {
        #region Attributes
        // Private fields to store width and height
        private double width;
        private double height;
        #endregion

        #region Constructors
        // Public property for Width with encapsulation
        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0) // Check if the value is non-negative
                {
                    width = value;
                }
                else
                {
                    // Print an error message if the value is negative
                    Console.WriteLine("Error: Width cannot be negative.");
                }
            }
        }

        // Public property for Height with encapsulation
        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0) // Check if the value is non-negative
                {
                    height = value;
                }
                else
                {
                    // Print an error message if the value is negative
                    Console.WriteLine("Error: Height cannot be negative.");
                }
            }
        }
        // Read-only property to calculate the area of the rectangle
        public double Area
        {
            get { return width * height; } // Area is width multiplied by height
        }
        #endregion

        #region Methods
        // Method to display rectangle's dimensions and area
        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {width}, Height: {height}, Area: {Area}");
        }
        #endregion

    }
}
