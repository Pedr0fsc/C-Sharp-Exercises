using System;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Security.Principal;
using ATV_GeometricShape.TriangleRectangle;
using ATV_GeometricShape.Circle;
using ATV_GeometricShape.Rectangle;

namespace Program
{
    public class Exercises
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Geometric Shapes Calculator!\n-------------------------------------\n");
            Console.WriteLine("Choose the geometric shape to be calculated:\n1 -- Triangle Rectangle\n2 -- Circle\n3 -- Rectangle");
            int shape_number = Convert.ToInt32(Console.ReadLine());

            if(shape_number == 1){
                Console.WriteLine("Enter the Base and the Height number: ");

                TriangleRectangle myTriangle = new TriangleRectangle {
                    Base = Convert.ToInt32(Console.ReadLine()),
                    Height = Convert.ToInt32(Console.ReadLine())
                };

                Console.WriteLine($"Area: {myTriangle.Area()}");
                Console.WriteLine($"Perimeter: {myTriangle.Perimeter()}");

            } else if (shape_number == 2){     
                Console.WriteLine("Enter the Ray number: ");

                Circle myCircle = new Circle {
                    Ray = Convert.ToInt32(Console.ReadLine())
                };

                Console.WriteLine($"Area: {myCircle.Area()}");
                Console.WriteLine($"Perimeter: {myCircle.Perimeter()}");

            } else if (shape_number == 3){
                Console.WriteLine("Enter the Base and the Height number: ");

                Rectangle myRectangle = new Rectangle {
                    Base = Convert.ToInt32(Console.ReadLine()),
                    Height = Convert.ToInt32(Console.ReadLine())
                };

                Console.WriteLine($"Area: {myRectangle.Area()}");
                Console.WriteLine($"Perimeter: {myRectangle.Perimeter()}");

            } else {
                Console.WriteLine("Please enter a valid number to choose the operation!");
            }

        }
    }
}