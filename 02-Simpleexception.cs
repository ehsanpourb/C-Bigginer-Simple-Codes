using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number1, number2;

            try
            {
                Console.WriteLine("Enter Number1:");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Number2:");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sum =" + (number1 + number2));             

            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Only Enter Number .....");
                Console.ResetColor();
            }
            catch
            {
                Console.WriteLine("Please Run Again .....");

            }

            finally
            {
                Console.WriteLine("========================");
                Console.WriteLine("Thanks to Choise us");
                Console.ReadLine();
            }

        }
    }
}
