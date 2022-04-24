using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // 1.student details
    internal class Student
    {
        int rollno;
        String name;
        String branch;
        String sem;
        String clas;

        static public void displayResult()
        {
            int[] marks = new int[5];
            marks[0] = 10;
            marks[1] = 30;
            marks[2] = 50;
            marks[3] = 80;
            marks[4] = 90;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(" marks of " + i + " subject : " + marks[i]);
            }

            double average = marks.Average();

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("FAIL");
                }
                else if (marks[i] > 35 && average < 50)
                {
                    Console.WriteLine("FAIL");
                }
                else if (average > 50)
                {
                    Console.WriteLine("PASS");
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }
        public Student(int rollno, String name, String branch, String sem, String clas)
        {
            this.rollno = rollno;
            this.name = name;
            this.branch = branch;
            this.sem = sem;
            this.clas = clas;
            Console.WriteLine($"\nRollno is: {rollno}, Name is {name},Student class is {clas}, Sem is {sem},Branch is : {branch}");
        }
        static public void displayData()
        {
            Console.WriteLine();
        }
    }

    // 2.car details

    internal class Car
    {
        int car_no;
        string car_name;
        string car_type;
        readonly double cost = 500000;
        public Car(int car_no, string car_name, string car_type, double cost)
        {
            this.car_no = car_no;
            this.car_name = car_name;
            this.car_type = car_type;
            this.cost = cost;
            Console.WriteLine($"\nthe car_no  {car_no},car_name is {car_name},car_type {car_type},price is {cost} ");
        }
        public void showDetails()
        {
            Console.WriteLine("\nbefore changing");
            Console.WriteLine($"the car_no  {car_no},car_name is {car_name},car_type is {car_type},price is {cost} ");
        }
        public Car(double car_cost)
        {
            Console.WriteLine("\nafter changing");
            car_cost = cost;
            Console.WriteLine($"the car_no  {car_no},car_name is {car_name},car_type is {car_type},price is {cost} ");

        }
    }

    //3.bank loan
    internal class bank
    {
        double interestRate;
        public void Bankloan(double loanamt)
        {
            Console.WriteLine("\nPlease enter rate of interest");
            interestRate = Convert.ToDouble(Console.ReadLine());
            double interest = (loanamt * interestRate) / 100;
            Console.WriteLine("\nRate of interest for " + interestRate + " percentage %  is : "+ interest);
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
        
            Student.displayResult();
            Student student = new Student(204, "Ajay", "Electrical", "4-2", "Btech");
            Student.displayData();

            
            Car car = new Car(007, "Audi", "sports", 7000000);
            car.showDetails();
            Car car2 = new Car(40000000);

         
            bank bank = new bank();
            Console.WriteLine("\n enter the loan amount: ");
            bank.Bankloan(Convert.ToInt32(Console.ReadLine()));

            Console.ReadLine();

        }
    }


}
