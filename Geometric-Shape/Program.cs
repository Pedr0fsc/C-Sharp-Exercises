using System;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Security.Principal;
using ATV_GeometricShape;

namespace Program
{
    public class Exercises
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Geometric Shapes Calculator!\n-------------------------------------\n");
            Console.WriteLine("Choose the geometric shape to be calculated:\n1 -- Triangle Rectangle\n2 -- Circle\n3 -- Rectangle");
            int shape_number = Convert.ToInt32(Console.WriteLine());

            if(shape_number == 1){
                TriangleRectangle myTriangle = new TriangleRectangle {
                    Console.WriteLine("Enter the Base number: ");
                    Base = Console.ReadLine();
                    Console.WriteLine("Enter the Height number: ");
                    Height = Console.ReadLine();
                    Console.WriteLine("Enter the Hypotenuse number: ");
                    Hypotenuse = Console.ReadLine();

                    Console.WriteLine(TriangleRectangle.Area);
                    Console.WriteLine(TriangleRectangle.Perimeter);
                }
            } else if (shape_number == 2){
                Circle myCirle = new Circle {
                    Console.WriteLine("Enter the Ray number: ");
                    Ray = Console.ReadLine();

                    Console.WriteLine(Circle.Area);
                    Console.WriteLine(Circle.Perimeter);
                }
            } else if (shape_number == 3){
                Rectangle myRectangle = new Rectangle {
                    Console.WriteLine("Enter the Base number: ");
                    Base = Console.ReadLine();
                    Console.WriteLine("Enter the Height number: ");
                    Height = Console.ReadLine();

                    Console.WriteLine(Rectangle.Area);
                    Console.WriteLine(Rectangle.Perimeter);
            } else {
                Console.WriteLine("Please enter a valid number to choose the operation!");
            }

        }
    }
}