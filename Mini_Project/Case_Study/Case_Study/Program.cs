using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public class Student
    {
        public String Std_name;
        public int Std_id;
        public string Std_Dob;
        public Student(String name, int id, String Dob)
        {
            Std_name = name;
            Std_id = id;
            Std_Dob =Dob;
        }
        public Student()
        {
        }
        public String getName()
        {
            return Std_name;
        }
        public void setName(String name)
        {
            Std_name = name;
        }
        public void setid(int id)
        {
            Std_id = id;
        }
        public int getid()
        {
            return Std_id;
        }
        public void setDateOfBirth(String DateOfBirth)
        {
            Std_Dob = DateOfBirth;
        }
        public String getDateOfBirth()
        {
            return Std_Dob;
        }
        public String toString()
        {
            return "'\n'StudentId:" + " " + getid() + "\n " + "Student Name:" + " " + getName() + "\n " + "Student Dob:" + " " + getDateOfBirth();
        }
    }

    class App
    {
        public void Scenario1()
        {
            Student s1 = new Student("Ajay", 101, "13-04-1998");
            Student s2 = new Student("Sukumar", 102, "01-09-1999");
            Student s3 = new Student("Sujith", 103, "12-10-2000");
            Info info = new Info();
            info.display(s1);
            info.display(s2);
            info.display(s3);
        }
        public void Scenario2()
        {
            Student[] students = new Student[3];
            students[0] = new Student("Suresh", 104, "12-02-1995");
            students[1] = new Student("Sai", 105, "01-06-2000");
            students[2] = new Student("Mahesh", 106, "11-07-2001"); 
            for (int i = 0; i <= 2; i++)
            {
                Info info = new Info();
                info.display(students[i]);
            }
        }
        public void Scenario3()
        {
            Console.WriteLine("Number of Students :");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Student s = new Student();
                Console.WriteLine("Enter student name :");
                String s1 = Console.ReadLine();
                s.setName(s1);
                Console.WriteLine("Enter student id :");
                int ID = Convert.ToInt32(Console.ReadLine());
                s.setid(ID);
                Console.WriteLine("Enter Student DOB :");
                String DOB = Console.ReadLine();
                s.setDateOfBirth(DOB);
                student[i] = s;
            }
            for (int i = 0; i < n; i++)
            {
                Info info = new Info();
                info.display(student[i]);
            }
        }
    }
    public class MainClass
    {
        public static void Main()
        {
            Course course1 = new Course(1, "Data_Science", "5 months", 5000);
            Course course2 = new Course(2, "Devepos", "6 months", 5000);
            Course course3 = new Course(3, "Artifical_Intelligence", "4 months", 8000);
           
            AppEngine engine = new AppEngine();

            new UserInterFace().showFirstScreen();
            Console.Read();

        }
    }
    public class Course
    {
        public int id;
        public string nameOfCourse;
        public string duration;
        public double fees; public Course(int id, string name, string duration, double fees)
        {
            this.id = id;
            this.nameOfCourse = name;
            this.duration = duration;
            this.fees = fees;
        }
    }
}

