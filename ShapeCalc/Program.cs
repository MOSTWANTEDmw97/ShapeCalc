using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* AREA FORMULAES
            *Square = (a^2)
            *Rectangle = (l*b)
            *circle = (pi*r^2)
            *Cube = (6*a^2)
            *Sphere = (4*pi*r^2)
            *Cuboid = 2(lb+bh+lh)
            *Triangle = 1/2(b*h)
            *Semi-circle = (pi*r^2)/2
           */

            int select;
            double sol;

            Console.Title = "Area calculator";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press Enter To Continue");
            Console.ResetColor();
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Select the shape to continue: ");
            Console.WriteLine("| 1- area of square |   | 2- area of circle |   | 3- area of rectangle|");
            Console.WriteLine("| 4- area of cube |   | 5- area of sphere |   | 6- area of cuboid|");
            Console.WriteLine("| 7- area of triangle | |8- area of semi-circle |  ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;

            select = Convert.ToInt16(Console.ReadLine());
            Console.ResetColor();

            if (select == 1)
            {
                float squareSide;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter the side of square: ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                squareSide = float.Parse(Console.ReadLine());
                Console.ResetColor();

                sol = squareSide * squareSide;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Area of the square is: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(sol);
                Console.ResetColor();
                // square area
            }

            else if (select == 2)
            {
                float radius;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter the radius of circle: ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                radius = float.Parse(Console.ReadLine());
                Console.ResetColor();

                sol = ((float)Math.PI * radius * radius);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("The area of the circle is: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(sol);
                Console.ResetColor();
                // Circle area
            }

            else if (select == 3)
            {
                float rectangleLength;
                float rectangleBreath;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter the length of rectangle: ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                rectangleLength = float.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter the breath of rectangle: ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                rectangleBreath = float.Parse(Console.ReadLine());
                Console.ResetColor();

                sol = rectangleLength * rectangleBreath;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Area of the rectangle is: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(sol);
                Console.ResetColor();
                // rectangle area
            }

            else if (select == 4)
            {
                float cubeSide;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter the sides of cube: ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                cubeSide = float.Parse(Console.ReadLine());
                Console.ResetColor();

                sol = 6 * (cubeSide * cubeSide);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Area of the cube is: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(sol);
                Console.ResetColor();
                // cube area
            }

            else if (select == 5)
            {
                float sphereRadius;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter the radious of sphere: ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                sphereRadius = float.Parse(Console.ReadLine());
                Console.ResetColor();

                sol = (4 * (float)Math.PI * sphereRadius * sphereRadius);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Area of the sphere is: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(sol);
                Console.ResetColor();
                // Sphere area
            }

            else if (select == 6)
            {
                float cuboidLength;
                float cuboidBreadth;
                float cuboidHeight;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter the length of cuboid: ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                cuboidLength = float.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter the breadth of cuboid: ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                cuboidBreadth = float.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter the height of cuboid: ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                cuboidHeight = float.Parse(Console.ReadLine());
                Console.ResetColor();

                sol = 2 * (cuboidLength + cuboidBreadth + cuboidHeight);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Area of the cuboid is: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(sol);
                Console.ResetColor();
                // Cuboid area
            }

            else if (select == 7)
            {
                float triangleBreadth;
                float triangleHeight;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter the breadth of breadth of triangle: ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                triangleBreadth = float.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter the height of triangle; ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                triangleHeight = float.Parse(Console.ReadLine());
                Console.ResetColor();

                sol = 0.5 * (triangleBreadth * triangleHeight);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Area of the triangle is: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(sol);
                Console.ResetColor();
                // Common triangle area
            }

            else if (select == 8)
            {
                float circleRadius;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter the radius if semi-circle: ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                circleRadius = float.Parse(Console.ReadLine());
                Console.ResetColor();

                sol = ((float)Math.PI * circleRadius * circleRadius) * 0.5;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Area of the semi-circle is: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(sol);
                Console.ResetColor();
                // Semi-circle area
            }

            else
            {
                Console.WriteLine("Enter a valid command!");
            }

            Console.ReadKey();
        }
    }
}
