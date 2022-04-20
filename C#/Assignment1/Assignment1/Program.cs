using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q.1 Two intergers euqal or not

            int num1;
            int num2;
            Console.WriteLine("Enter num1:");
            Console.WriteLine("Enter num2:");
            num1 =Convert.ToInt32(Console.ReadLine());
            num2 =Convert.ToInt32(Console.ReadLine());
            if(num1 == num2)
            {
                Console.WriteLine("Two integer are equal");
            }
            else
            {
                Console.WriteLine(" two integer are not equal");
            }

            // Q.2 check postive or negative

            int num;

            Console.WriteLine(" Type number postive or Negative number");
            num = int.Parse(Console.ReadLine());
            if(num > 0)
            {
                Console.Write("{0} is a postive number", num);
            }
            else
            {
                Console.WriteLine("{0} is a neagtive number",num);
            }

            // Q.3 Arthamatic operation

            int num3;
            int num4;
            Char operation;
            Console.Write("Enter first number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Arhtamatic operation:");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number :");
            num4 = Convert.ToInt32(Console.ReadLine());
           
            if (operation == '+')
            {
                Console.WriteLine("{0} + {1} = {2}",num3,num4, num3+num4);
            }
            else if (operation == '-')
                {
                Console.WriteLine("{0} - {1} = {2}", num3, num4, num3 - num4);
            }

            else if (operation == '*')
            {
                Console.WriteLine("{0} * {1} = {2}", num3, num4, num3 * num4);
            }

            else if (operation == '/')
            {
                Console.WriteLine("{0} / {1} = {2}", num3, num4, num3 + num4);
            }
            Console.ReadLine();
        }
    }
}
