using System;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Security.Principal;

namespace HelloWorld
{ 
    public class HelloWorld
    {
        public static void HelloWorldMethod()
        {
            string helloWorld = @"
				    //    / /                            ||   / |  / /                                 /
				   //___ / /   ___     //  //   ___      ||  /  | / /   ___       __      //    ___   /
				  / ___   /  //___) ) //  //  //   ) )   || / /||/ /  //   ) )  //  ) )  //   //   ) /
				 //    / /  //       //  //  //   / /    ||/ / |  /  //   / /  //       //   //   / /
				//    / /  ((____   //  //  ((___/ /     |  /  | /  ((___/ /  //       //   ((___/ /
				";

            Console.WriteLine(helloWorld);
        }
    };
}

namespace Calculator
{
    public class Calculator
    {
        public static void CalculatorMethod()
        {
            Console.WriteLine("\nWelcome to the C# Calculator!\n\nEnter the first number: " );
            int number_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int number_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Look at the operations:\n1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n\nEnter the type of operation to be performed: ");
            int operacao = Convert.ToInt32(Console.ReadLine());

            int total;
            
            if (operacao == 1)
            {
                total = number_1 + number_2;
                Console.WriteLine("Result: " + total);
            } 
            else if (operacao == 2) 
            { 
                total = number_1 - number_2;
                Console.WriteLine("Result: " + total);
            }
            else if (operacao == 3)
            {
                total = number_1 * number_2;
                Console.WriteLine("Result: " + total);
            }
            else if (operacao == 4)
            {
                total = number_1 / number_2;
                Console.WriteLine("Result: " + total);
            }
            else
            {
                Console.WriteLine("Please enter a valid operation");
            }

            

        }
    };
}

namespace Menu
{
    public class Menu
    {
        public static void MenuMethod()
        {
            Console.WriteLine("\n----------------------------------------------------------------------------------------\n");
            Console.WriteLine("Welcome to the Pokemon Console Menu\n\nEnter a pokemon number to see his name (1...12): ");
            int pokemonNumber = Convert.ToInt32(Console.ReadLine());

            switch (pokemonNumber)
            {
                case 1:
                    Console.WriteLine("Bulbasaur\nTypes: Plant and Poison");
                    break;
                case 2:
                    Console.WriteLine("Ivysaur\nTypes: Plant and Poison");
                    break;
                case 3:
                    Console.WriteLine("Venusaur\nTypes: Plant and Poison");
                    break;
                case 4:
                    Console.WriteLine("Charmander\nTypes: Fire");
                    break;
                case 5:
                    Console.WriteLine("Charmeleon\nTypes: Fire");
                    break;
                case 6:
                    Console.WriteLine("Charizard\nTypes: Fire and Flying");
                    break;
                case 7:
                    Console.WriteLine("Squirtle\nTypes: Water");
                    break;
                case 8:
                    Console.WriteLine("Wartortle\nTypes: Water");
                    break;
                case 9:
                    Console.WriteLine("Blastoise\nTypes: Water");
                    break;
                case 10:
                    Console.WriteLine("Caterpie\nTypes: Bug");
                    break;
                case 11:
                    Console.WriteLine("Metapod\nTypes: Bug");
                    break;
                case 12:
                    Console.WriteLine("Butterfree\nTypes: Bug and Flying");
                    break;
                default:
                    Console.WriteLine("Searching for a Pokemon number");
                    break;
            }
        }
    }
}

namespace EvenOrOdd
{
    public class EvenOrOdd
    {
        public static void EvenOrOddMethod()
        {
            Console.WriteLine("\n----------------------------------------------------------------------------------------\n");
            Console.WriteLine("Even or Odd Checker\nEnter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is EVEN!");
            }
            else
            {
                Console.WriteLine("The numver is ODD!");
            }
        }
    }
}

namespace Program
{
    public class Exercises
    {
        public static void Main()
        {
            HelloWorld.HelloWorld.HelloWorldMethod();

            Calculator.Calculator.CalculatorMethod();
            
            Menu.Menu.MenuMethod();

            EvenOrOdd.EvenOrOdd.EvenOrOddMethod();

        }
    }
}
