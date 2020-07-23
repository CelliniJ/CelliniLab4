using System;
using System.ComponentModel;
using System.Data;

namespace Lab4Cellini
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat;
            repeat = "y";

            Console.WriteLine("Learn your squares and cubes!");

            while (repeat == "y" || repeat == "Y")
            {
                Console.WriteLine("Please enter an integer:");
                string number = Console.ReadLine();

                bool numCheck = int.TryParse(number, out _);
                if (numCheck)
                {
                    int input = int.Parse(number);

                    Console.WriteLine("Number  Square  Cubed");
                    Console.WriteLine("======  ======  =====");

                    int counter;
                    for (counter = 1; counter <= input; counter++)
                    {
                        int square = counter * counter;
                        int cubed = counter * counter * counter;
                        Console.WriteLine("{0}        {1}        {2}", counter, square, cubed);
                    }
                    Console.WriteLine("Would you like to continue? (y/n)");
                    repeat = Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("You must enter a valid number.");
                }
                
            }

        }
    }
    }

