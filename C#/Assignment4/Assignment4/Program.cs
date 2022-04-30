using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
       /**************************** Abstract Classs  ********************************/
        public abstract class Student
        {
            public String Name;
            public int StudentId;
            public abstract void BooleanIspassed(int Grade);
        }

        /*****************************inherited class ********************************/


        public class Undergraduate : Student
        {
            public override void BooleanIspassed(int Grade)
            {
                try
                {

                    Console.WriteLine("Enter Undergraduate student Grade ");
                    Grade = Convert.ToInt32(Console.ReadLine());
                    if (Grade > 70)
                    {
                        Console.WriteLine(" Student passed exam ");
                    }
                    else
                    {
                        Console.WriteLine(" Student failed exam ");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("input Does not match exception : " + e.StackTrace);
                }
            }
        }
        /**********************************derived class**************************/

        class Graduate : Student
        {
            public override void BooleanIspassed(int Grade)
            {
                try
                {
                    Console.WriteLine("Enter graduate student Grade");
                    Grade = Convert.ToInt32(Console.ReadLine());
                    if (Grade > 80)
                    {
                        Console.WriteLine("student passed the exam ");
                    }
                    else
                    {
                        Console.WriteLine("student failed the exam ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("input does not match the exception " + e.StackTrace);
                }
            }
        }

        /************************* employee ************************************/

        public class Employee
        {
            public int empId;
            public string empName;
            public float salary;

            public Employee(int empId, string empName, float salary)
            {
                this.empId = empId;
                this.empName = empName;
                this.salary = salary;
            }
            public void displayDetails()
            {
                Console.WriteLine($"\nempName {empName} with empid {empId} gets salary of {salary}");
            }
        }
        public class PartTimeemployee
        {
            public int wages = 1500;

            public void showDetails()
            {
                Console.WriteLine($"Part time employee gets " + wages);
            }
        }


        /*******************************Students****************************/
        public class Students
        {
            public int st_Id;
            public string st_Name;
            public double exam_fee;


            public void displayDetails1()
            {
                Console.WriteLine($"\nthe student {st_Name} with id {st_Id} paid {exam_fee}");
            }
            public void Fee()
            {
                Console.WriteLine("\nEnter student id: ");
                st_Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Tnter the student name: ");
                st_Name = Console.ReadLine();
                Console.WriteLine(" Exam fee: is" + 1400);
                Console.WriteLine(" Enter the amount to pay exam fee");
                exam_fee = int.Parse(Console.ReadLine());
                double rem_fee = 1200 - exam_fee;
                if (exam_fee == 1400)
                {
                    Console.WriteLine("fees paid no dues");
                }
                else
                {
                    Console.WriteLine("the remaining fee: " + rem_fee);
                }
            }
        }
        class DayScholar
        {
            public double transport_fees;

            public DayScholar(double transport_fees)
            {
                this.transport_fees = transport_fees;
                double rem1_fee = 25000 - transport_fees;

                Console.WriteLine("\nthe transport fee: " + 25000 + "per year ");


                Console.WriteLine($"the dayscholar  paid {transport_fees} & remaining fee is {rem1_fee}");
                Console.WriteLine();
            }

        }
        public class Hosteller
        {
            public double hostelfee;

            public Hosteller(double hostel_fee)
            {

                this.hostelfee = hostel_fee;

                double rem2_fee = 35000 - hostel_fee;
                Console.WriteLine("the hostel  fee: " + 35000 + "per year ");

                Console.WriteLine($" paid dayscholar fee {hostel_fee} and remaining fee is {rem2_fee} ");
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Undergraduate stu = new Undergraduate();
            stu.BooleanIspassed(15);
            stu.Name = "AJAY";
            stu.StudentId = 204;
            Console.WriteLine($"name is {stu.Name} and id is {stu.StudentId}");

            Graduate std1 = new Graduate();
            std1.Name = "kumar";
            std1.StudentId = 205;
            std1.BooleanIspassed(20);
            Console.WriteLine($"name is {std1.Name} amd id is {std1.StudentId}");


            Employee employee = new Employee(123, "AJAY", 1000.3f);
            employee.displayDetails();
            PartTimeemployee ptemployee = new PartTimeemployee();
            ptemployee.showDetails();

            Students students = new Students();
            students.Fee();
            students.displayDetails1();
            Console.WriteLine("Enter tranport fee : ");
            DayScholar dayScholar = new DayScholar(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the hostel fee : ");
            Hosteller hosteller = new Hosteller(int.Parse(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
