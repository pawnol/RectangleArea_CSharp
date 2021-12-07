/*
 * Rectangle Area
 * Pawelski
 * 12/6/2021
 * Read the code and run the program serveal times so that you understand
 * how the program currently works. Once you understand the code, modify
 * program so that is also calcualtes the perimeter of a rectnagle with the 
 * length and width given by the user. Lastly, answer any questions on the
 * activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables.
            int length;
            int width;
            int area;

            // Input length and width.
            Console.Write("Please enter the length of the rectangle >> ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the length of the rectangle >> ");
            width = Convert.ToInt32(Console.ReadLine());

            // Calculate and display area.
            area = length * width;
            Console.WriteLine("The area of the rectangle is " + area + ".");

            // Add your code here!
            
        }
    }
}
