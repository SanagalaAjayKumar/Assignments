using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
   

    // Interface
    interface IStudent
    {
        void showdetails(int studentid, string studentName);
    }

    class DayScholar : IStudent
    {
        public void showdetails(int studentid, string studentName)
        {
            Console.WriteLine($"The student ID is {studentid}, student name is {studentName}", studentid, studentName);
        }
    }

    class Resident : IStudent
    {
        public void showdetails(int studentid, string studentName)
        {
            Console.WriteLine($"The student ID is {studentid}, student name is {studentName}", studentid, studentName);
        }
    }

    //===========================Struct====================//
    struct Book
    {

        int BookId;

        public int Book_Id
        {
            get { return BookId; }
            set { BookId = value; }
        }

        public Book(int BookId)
        {
            this.BookId = BookId;
        }
        public void Display(int value)
        {
            Console.WriteLine($"Book id is:{BookId}, and book value is: {value}");

        }
    }

    //============================LINQ=====================//
    class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpTitle { get; set; }
        public string DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }


        public List<Employee> GetEmployees()
        {
            List<Employee> Emplist = new List<Employee>();
            Employee e1 = new Employee { EmpId = 1001, FirstName = "Malcolm", LastName = "Daruwalla", EmpTitle = "Manager", DOB = "16/11/1984", DOJ = DateTime.Parse("8/6/2011"), City = "Mumbai" };
            Employee e2 = new Employee { EmpId = 1002, FirstName = "Asdin", LastName = "Dhalla", EmpTitle = "AsstManager", DOB = "20/08/1984", DOJ = DateTime.Parse("7/7/2012"), City = "Mumbai" };
            Employee e3 = new Employee { EmpId = 1003, FirstName = "Madhavi", LastName = "Oza", EmpTitle = "Consultant", DOB = "14/11/1987", DOJ = DateTime.Parse("12/4/2015"), City = "Pune" };
            Employee e4 = new Employee { EmpId = 1004, FirstName = "Saba", LastName = "Shaikh", EmpTitle = "SE", DOB = "3/6/1990", DOJ = DateTime.Parse("2/2/2016"), City = "Pune" };
            Employee e5 = new Employee { EmpId = 1005, FirstName = "Nazia", LastName = "Shaikh", EmpTitle = "SE", DOB = "8/3/1991", DOJ = DateTime.Parse("2/2/2016"), City = "Mumbai" };
            Employee e6 = new Employee { EmpId = 1006, FirstName = "Amit", LastName = "Pathak", EmpTitle = "Consultant", DOB = "7/11/1989", DOJ = DateTime.Parse("8/8/2014"), City = "Chennai" };
            Employee e7 = new Employee { EmpId = 1007, FirstName = "Vijay", LastName = "Natrajan", EmpTitle = "Consultant", DOB = "2/12/1989", DOJ = DateTime.Parse("1/6/2015"), City = "Mumbai" };
            Employee e8 = new Employee { EmpId = 1008, FirstName = "Rahul", LastName = "Dubey", EmpTitle = "Associate", DOB = "11/11/1993", DOJ = DateTime.Parse("6/11/2014"), City = "Chennai" };
            Employee e9 = new Employee { EmpId = 1009, FirstName = "Suresh", LastName = "Mistry", EmpTitle = "Associate", DOB = "12/8/1992", DOJ = DateTime.Parse("3/12/2014"), City = "Chennai" };
            Employee e10 = new Employee { EmpId = 1010, FirstName = "Sumit", LastName = "Shah", EmpTitle = "Manager", DOB = "12/4/1991", DOJ = DateTime.Parse("2/1/2016"), City = "Pune" };
            Emplist.Add(e1);
            Emplist.Add(e2);
            Emplist.Add(e3);
            Emplist.Add(e4);
            Emplist.Add(e5);
            Emplist.Add(e6);
            Emplist.Add(e7);
            Emplist.Add(e8);
            Emplist.Add(e9);
            Emplist.Add(e10);
            return Emplist;
        }

        public override string ToString()
        {

            return string.Format("Empid :" + " " + EmpId + "  " + "FirstName :" + " " + FirstName + "  " + "LastName :" + " " + LastName + "  " + "EmpTitle :" + "  " + EmpTitle + " " + "DOB :" + "  " + DOB + "  " + "DOJ :" +
                "  " + DOJ + "  " + " City :" + "  " + City);
        }


    }




    internal class Program
    {
        static void Main(string[] args)
        { 
            //=============================Intreface=====================/


            Console.WriteLine("***************************Dayscholar Detail*************************");
            IStudent ds = new DayScholar();
            ds.showdetails(101, "Ajay");

            Console.WriteLine("****************************Resident Detail*****************************");
            IStudent re = new Resident();
            re.showdetails(201, "kumar");
            Console.WriteLine("********************interface is done*****************");

            //================================= Structers==================//
           

            Book book = new Book(141);
            book.Display(121);
            Console.WriteLine("*******************Structres is done******************** ");


            //===================================QUERY======================//


            Employee emp = new Employee();
            Console.WriteLine("******************************The Employee details**************************** : ");

            IEnumerable<Employee> employees = from Item in emp.GetEmployees()
                                              select Item ;

            foreach (var emps in employees)
            {
                Console.WriteLine(emps.ToString());
            }

         
            Console.WriteLine("***************************Employee citys**********************************");

            IEnumerable<Employee> city = from citys in emp.GetEmployees()
                                          where (citys.City) != "Mumbai"
                                          select citys;

            foreach (var citys in city)
            {
                Console.WriteLine(citys);
            }


            
            Console.WriteLine("************************Employee Tittles******************************");

            IEnumerable<Employee> emptitle = from title in emp.GetEmployees()
                                             where title.EmpTitle.Equals("AsstManager")
                                             select title;

            foreach (var tittle in emptitle)
            {
                Console.WriteLine(tittle);
            }

         
            Console.WriteLine("******************************Employee Lastname starts with s*********************");

            IEnumerable<Employee> empname = from enames in emp.GetEmployees()
                                            where enames.LastName.StartsWith("S")
                                            select enames;
            foreach (var en in empname)
            {
                Console.WriteLine(en);
            }

          
            Console.WriteLine("***********************************Employee doj on before 1/1/2015********************************");

            IEnumerable<Employee> empdoj = from Emp in emp.GetEmployees()
                                           where Emp.DOJ <= Convert.ToDateTime("01/01/2015")
                                           select Emp;

            foreach (var doj in empdoj)
            {
                Console.WriteLine(doj);
            }
            Console.WriteLine("============Qujery is done==============");




            Console.ReadLine();
        }
    }


}
