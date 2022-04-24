using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

              // first avreage
                int[] marks = { 10, 30, 50, 60, 80 };
                int n = 0;
                foreach (int i in marks) 
                {
                    n += i;
                }
                Console.WriteLine("average marks :{0}", n / marks.Length);
                Console.WriteLine("minimun marks :{0}", marks.Min());
                Console.WriteLine("maximum marks :{0}", marks.Max());

               //2 maximum and minimum

              int[] marks1 = new int[4];
               int n1 = 0;
               Console.WriteLine("Enter Marks : ");
               for (int i = 0; i < marks1.Length; i++)
               {
                   marks1[i] = Convert.ToInt32(Console.ReadLine());
               }
               foreach (int i in marks1)
               {
                   n1 += i;

               }
               Console.WriteLine("Total marks is {0}", n1);
               Console.WriteLine("Average Marks {0}", n1 / 4);
               Console.WriteLine("Maximum marks is {0}", marks1.Max());
               Console.WriteLine("Minimum marks is {0}", marks1.Min());
               Array.Sort(marks1);

               Console.WriteLine("Ascending order ");
               foreach (int i in marks1)
               {
                   Console.Write(i + " ");
               }
               Array.Reverse(marks1);
               Console.WriteLine(" ");
               Console.WriteLine("Descending order ");
               foreach (int i in marks1)
               {
                   Console.Write(i + " ");
               }
               Console.WriteLine(" ");

               //3 A. length of string

               Console.WriteLine("Enter your name:");
               string name = Console.ReadLine();
               Console.WriteLine("Length of the string :{0}", name.Length);


                // 3.b reverse string

                Console.WriteLine("Enter your name");

                string str = Console.ReadLine();
                string str2= string.Empty;
                for (int i =  str.Length - 1; i >= 0; i--)  
                {
                    str2 += str[i];
                }

                Console.WriteLine(str2);

                //3.c same or not

                string str1;
                string str3;
                Console.WriteLine("Enter num:");
                Console.WriteLine("Enter num:");
                str1 = Console.ReadLine();
                str3 = Console.ReadLine();

                if (str1 == str3)
                {
                    Console.WriteLine("Two Number are equal");
                }
                else if(str1 != str2)
                {
                    Console.WriteLine(" two Number are not equal");
                }

               // 4. plaindrom or not

            Console.WriteLine("Enter a String");
            string str5, revs = "";
            str5 = Console.ReadLine();

            for (int i = str5.Length - 1; i >= 0; i--)
            {
                revs += str5[i].ToString();
            }
            if (revs == str5)
            {
                Console.WriteLine("String is a plaindrom ", str, revs);
            }
            
            {
                Console.WriteLine("string is not a palindrome");
            }

            Console.ReadLine();

        }


    }
}
