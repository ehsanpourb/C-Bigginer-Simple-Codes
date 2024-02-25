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
            Console.WriteLine("Enter the Number 1:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter the Number 2:");
            string num2 = Console.ReadLine();
            int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);

            Console.WriteLine("sum is = "+ sum);
            
            Console.ReadKey();


        }
    }
}
