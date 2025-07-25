using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                double celcius;
                double fahrenheit;

                Console.Write("Enter temperature in Celsius (-100 to 100): ");
                celcius = Convert.ToDouble(Console.ReadLine());
                if (celcius >= -100 && celcius <= 100)
                {
                    fahrenheit = (celcius * 9 / 5) + 32;
                    Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
                }
                else
                {
                    Console.WriteLine("Invalid temperature input.");
                }
            }
        }

    }

