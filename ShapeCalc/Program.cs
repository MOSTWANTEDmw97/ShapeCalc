﻿using System;
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
            *              AREA       || PERIMETER  || Volume      ||
            *2D shapes                ||            ||-------------||
            *Square = (a^2)           || (4*a)      ||             ||
            *Rectangle = (l*b)        || (l+b)2     ||             ||
            *circle = (pi*r^2)        || (2*pi*r)   ||             ||
            *Triangle = 1/2(b*h)      || (a+b+c)    ||             ||
            *Semi-circle = (pi*r^2)/2 || (pi*r)     ||             ||
            *
            *3D shapes:               ||------------||             ||
            *Cube = (6*a^2)           ||            || (a^3)       ||
            *Sphere = (4*pi*r^2)      ||            || 4/3(pi*r^3) ||
            *Cuboid = 2(lb+bh+lh)     ||            || (l*b*h)     ||      
            */

            string menuSelect;
            string dimensionSelect;
            string areaSelect;
            string perimeterSelect;
            string volumeSelect;

            double sol;

            Outer:                  // Label to jump back from the code (used to go back to to menuSelect/ mainmenu)

            Console.Title = "ShapeCalc";

            //Main menu...
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press 0 to exit!\n____________________________________________________________________________________________________________________");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please select the type of calculation:\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("....|| 1      Area ||\n");            
            Console.WriteLine("....|| 2      Perimeter ||\n");                         
            Console.WriteLine("....|| 3      Volume ||\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("____________________________________________________________________________________________________________________\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input:   ");
            Console.ResetColor();
            menuSelect = (Console.ReadLine());
            Console.Clear();
                                  
            // Area
            while (menuSelect == "1")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Press 0 to go back\n \nPlease select the dimension of the shape: \n| 1- 2D |\n \n| 2- 3D |\n"); 
                Console.ResetColor();

                dimensionSelect = (Console.ReadLine());
                Console.Clear();

                if (dimensionSelect == "0") 
                { 
                    goto Outer;
                }

                // 2D shapes
                while (dimensionSelect == "1")
                {                      
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Press any number to go back\n \nSelect the 2D shape to continue: \n");
                    Console.WriteLine("| 1- area of square | | 2- area of circle | | 3- area of rectangle|");
                    Console.WriteLine("| 4- area of triangle | |5- area of semi-circle |");
                    Console.ResetColor();
                   
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    areaSelect = (Console.ReadLine());
                    Console.ResetColor();
                    
                    if (areaSelect == "1")
                    {
                        float squareSide;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Enter the side of square: ");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Gray;
                        squareSide = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        sol = Math.Pow(squareSide, 2f);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nArea of the square is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // square area
                    }

                    else if (areaSelect == "2")
                    {
                        float radius;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Enter the radius of circle: ");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Gray;
                        radius = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        sol = ((float)Math.PI * Math.Pow(radius, 2f));

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nThe area of the circle is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // Circle area
                    }

                    else if (areaSelect == "3")
                    {
                        float rectangleLength;
                        float rectangleBreadth;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Enter the length of rectangle: ");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Gray;
                        rectangleLength = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Enter the breadth of rectangle: ");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Gray;
                        rectangleBreadth = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        sol = rectangleLength * rectangleBreadth;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nArea of the rectangle is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // rectangle area
                    }

                    else if (areaSelect == "4")
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

                        sol = 0.5f * (triangleBreadth * triangleHeight);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nArea of the triangle is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // Common triangle area
                    }

                    else if (areaSelect == "5")
                    {
                        float circleRadius;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Enter the radius of semi-circle: ");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Gray;
                        circleRadius = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        sol = ((float)Math.PI * Math.Pow(circleRadius, 2f)) * 0.5f;

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
                        Console.Clear();
                        break;
                    }

                }

                // 3D shapes
                while (dimensionSelect == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Press any number to go back\n \nSelect the 3D shape to continue: \n");
                    Console.WriteLine("| 1- area of cube | | 2- area of sphere | | 3- area of cuboid |");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    areaSelect = (Console.ReadLine());
                    Console.ResetColor();
                    
                    if (areaSelect == "1")
                    {
                        float cubeSide;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Enter the sides of cube: ");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Gray;
                        cubeSide = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        sol = 6f * (Math.Pow(cubeSide, 2f));

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nArea of the cube is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // cube area
                    }

                    else if (areaSelect == "2")
                    {
                        float sphereRadius;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Enter the radious of sphere: ");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Gray;
                        sphereRadius = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        sol = (4f * (float)Math.PI * Math.Pow(sphereRadius, 2f));

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nArea of the sphere is: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sol + "\n");
                        Console.ResetColor();
                        // Sphere area
                    }

                    else if (areaSelect == "3")
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

                        sol = 2f * (cuboidLength + cuboidBreadth + cuboidHeight);

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
                        Console.Clear();
                        break;
                    }

                }                          
               
            }
                        
            // Perimeter
            while (menuSelect == "2")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Press any number to go back\n \nSelect the shape to continue: \n");
                Console.WriteLine("| 1- perimeter of square | | 2- perimeter of circle | | 3- perimeter of rectangle |");
                Console.WriteLine("| 4- perimeter of triangle | | 5- perimeter of semi-circle |");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                perimeterSelect = (Console.ReadLine());
                Console.ResetColor();
                
                if (perimeterSelect == "1") 
                {
                    float squareSide;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the sides of the square: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    squareSide = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    sol = squareSide * 4f;

                    Console.ForegroundColor= ConsoleColor.Cyan;
                    Console.Write("\nPerimeter of the square is: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(sol + "\n");
                    Console.ResetColor();
                    // Squire perimeter
                }

                else if (perimeterSelect == "2")
                {
                    float circleRadius;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the radius of the circle: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    circleRadius = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    sol = 2f * (float)Math.PI * circleRadius;

                    Console.ForegroundColor= ConsoleColor.Cyan;
                    Console.Write("\nPerimeter of the circle is: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(sol + "\n");
                    Console.ResetColor();
                    // Circle perimeter
                }

                else if (perimeterSelect == "3")
                {
                    float rectangleLength;
                    float rectangleBreadth;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the length of the rectangle: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    rectangleLength = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the breadth of the rectangle: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    rectangleBreadth = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    sol = (rectangleLength + rectangleBreadth) * 2f;

                    Console.ForegroundColor= ConsoleColor.Cyan;
                    Console.Write("\nPerimeter of the rectangle is:  ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(sol + "\n");
                    Console.ResetColor();
                    // Rectangle perimeter
                }

                else if (perimeterSelect == "4")
                {
                    float triangleLength;
                    float triangleBreadth;
                    float triangleHeight;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the first side of the triangle: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    triangleLength = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the second side of the triangle: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    triangleBreadth = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the third and final side of the triangle: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    triangleHeight = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    sol = triangleLength + triangleBreadth + triangleHeight;

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\nPerimeter of the triangle is: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(sol + "\n");
                    Console.ResetColor();
                    // Triangle perimeter
                }

                else if (perimeterSelect == "5")
                {
                    float circleRadius;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the radius of the semi-circle: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    circleRadius = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    sol = (float)Math.PI * circleRadius;

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\nPerimeter of the semi-circle is: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(sol + "\n");
                    Console.ResetColor();
                    // Semi-circle perimeter
                }

                else
                {
                    Console.Clear();
                    goto Outer;
                }
               
            }

            // Volume
            while (menuSelect == "3")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Press any number to go back\n \nSelect the shape to continue: \n");
                Console.WriteLine("| 1- volume of cube | | 2- volume of sphere | | 3- volume of cuboid |");              
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                volumeSelect = (Console.ReadLine());
                Console.ResetColor();
                
                if (volumeSelect == "1")
                {
                    float cubeside;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the sides of the cube: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    cubeside = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    sol = Math.Pow(cubeside, 3f);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\nVolume of the cube is: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(sol + "\n");
                    Console.ResetColor();
                    // Cube volume
                }

                else if (volumeSelect == "2")
                {
                    float sphereRadius;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the radius of the sphere: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    sphereRadius = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    sol = ((float)Math.PI * Math.Pow(sphereRadius, 3f)) * (4f / 3f);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\nVolume of the sphere is: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(sol + "\n");
                    Console.ResetColor();
                    // Sphere volume
                }

                else if (volumeSelect == "3")
                {
                    float cuboidLength;
                    float cuboidBreadth;
                    float cuboidHeight;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the length of the cuboid: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    cuboidLength = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.Write("Enter the breadth of the cuboid: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    cuboidBreadth = float.Parse(Console.ReadLine());    
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the height of the rectangle: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Gray;
                    cuboidHeight = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    sol = (cuboidLength * cuboidBreadth * cuboidHeight);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\nVolume of the cuboid is: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(sol + "\n");
                    Console.ResetColor();
                    // Cuboid volume
                }

               else
                {
                    Console.Clear();
                    goto Outer;
                }

            }

            if (menuSelect == "0")
            {
                return;
                // Close the program 
            }

            if (menuSelect != "0" || menuSelect != "1" || menuSelect != "2" || menuSelect != "3")
            {
                Console.WriteLine("Well...Nope JUST NOOO! \nPress any key to go back...                                And dont mess up the commands ever again");
                Console.ReadKey();
                Console.Clear();
                goto Outer;
                // Invalid input message
            }

            Console.ReadKey();
            // Get input from user then close

        }
    }
}
