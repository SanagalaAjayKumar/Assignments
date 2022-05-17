using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebasequestion2
{
    
public delegate void calculator(int a, int b);

     internal class Program
    {
        public static void addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addition {result}");
        }
        public static void substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"substraction {result}");
        }
        public static void multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($" multiplication { result}");
        }
        public static void division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine($" division result is { result}");
        }
        static void Main(string[] args)
        {
            calculator obj = new calculator(Program.addition);
            obj.Invoke(10, 40);
            obj = substraction;
            obj(50, 10);
            obj = multiplication;
            obj(45, 40);
            obj = division;
            obj(70, 20);
            Console.WriteLine("**************Code base test 2 done************************");
            Console.ReadLine();
        }
    }
}
