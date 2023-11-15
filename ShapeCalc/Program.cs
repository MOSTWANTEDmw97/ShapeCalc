using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* FORMULAES:         
            *              AREA       || PERIMETER   ||
            *2D sgapes                ||             ||
            *Square = (a^2)           || (4*a)       ||
            *Rectangle = (l*b)        || (l+w)2      ||
            *circle = (pi*r^2)        || (2*pi*r)    ||
            **Triangle = 1/2(b*h)     || (a+b+c)     ||
            *Semi-circle = (pi*r^2)/2 || (pi*r)      ||
            *
            *3D shapes:               ||             || VOLUME 
            *Cube = (6*a^2)           || (12*a)      || (a^3)
            *Sphere = (4*pi*r^2)      || (2*pi*r)    || 4/3(pi*r^3)
            *Cuboid = 2(lb+bh+lh)     || 4(l+b+h)    || (l*b*h)           
            */

            int menuSelect;
            int dimensionSelect;
            int areaSelect;
            int perimeterSelect;
            int volumeSelect;

            double sol;

            Outer:;

            Console.Title = "ShapeCalc";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press 0 to exit!\n__________________________________________________________________");
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine("Please select the type of calculation: \n| 1- area | | 2- perimeter | | 3- volume |");
            Console.ResetColor();
                       
            menuSelect = int.Parse(Console.ReadLine());
            Console.Clear();

            if (menuSelect == 0)
            {
                return;
            }

            while (menuSelect == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Press 0 to go back \nPlease select the dimension of the shape: \n| 1- 2D | | 2 - 3D |"); 
                Console.ResetColor();

                dimensionSelect = int.Parse(Console.ReadLine());
                Console.Clear();

                if (dimensionSelect == 0) 
                { 
                    goto Outer;
                }

                while (dimensionSelect == 1)
                {                      
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Press any number to go back \nSelect the 2D shape to continue: ");
                    Console.WriteLine("| 1- area of square | | 2- area of circle | | 3- area of rectangle|");
                    Console.WriteLine("| 4- area of triangle | |5- area of semi-circle |");
                    Console.ResetColor();
                   
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    areaSelect = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    if (areaSelect == 1)
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
                        Console.Write("\nArea of the square is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // square area
                    }

                    else if (areaSelect == 2)
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
                        Console.Write("\nThe area of the circle is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // Circle area
                    }

                    else if (areaSelect == 3)
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
                        Console.Write("\nArea of the rectangle is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // rectangle area
                    }

                    else if (areaSelect == 4)
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
                        Console.Write("Enter the height of triangle: ");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Gray;
                        triangleHeight = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        sol = 0.5 * (triangleBreadth * triangleHeight);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nArea of the triangle is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // Common triangle area
                    }

                    else if (areaSelect == 5)
                    {
                        float circleRadius;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Enter the radius of semi-circle: ");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Gray;
                        circleRadius = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        sol = ((float)Math.PI * circleRadius * circleRadius) * 0.5;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nArea of the semi-circle is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // Semi-circle area
                    }

                    else
                    {
                        break;
                    }

                }

                while (dimensionSelect == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Press any number to go back \nSelect the 3D shape to continue: ");
                    Console.WriteLine("| 1- area of cube | | 2- area of sphere | | 3- area of cuboid |");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    areaSelect = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    if (areaSelect == 1)
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
                        Console.Write("\nArea of the cube is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // cube area
                    }

                    else if (areaSelect == 2)
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
                        Console.Write("\nArea of the sphere is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // Sphere area
                    }

                    else if (areaSelect == 3)
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
                        Console.Write("\nArea of the cuboid is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // Cuboid area
                    }
                                        
                    else
                    {
                        break;
                    }

                }                          
               
            }

            // Fuck!

            while (menuSelect == 2)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Press 0 to go back \nPlease select the dimension of the shape: \n| 1- 2D | | 2 - 3D |");
                Console.ResetColor();

                dimensionSelect = int.Parse(Console.ReadLine());
                Console.Clear();

                if (dimensionSelect == 0)
                {
                    goto Outer;
                }
            }

            while (menuSelect == 3)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Press 0 to go back \nPlease select the dimension of the shape:          !!PERIMETER == CIRCUMFERENCE!! \n| 1- 2D | | 2 - 3D |");
                Console.ResetColor();

                dimensionSelect = int.Parse(Console.ReadLine());
                Console.Clear();

                if (dimensionSelect == 0)
                { 
                    // 2D shapes dosent have volume!!!
                    goto Outer;
                }
            }
                       
            Console.ReadKey();
            // Get input from user then close
        }
    }
}
