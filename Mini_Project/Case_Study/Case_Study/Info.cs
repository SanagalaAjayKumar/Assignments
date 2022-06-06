using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Case_Study
{
    public class Info
    {
        public void display(Student Student)
        {
            Console.WriteLine("StudentName:-" + Student.getName());
            Console.WriteLine("StudentId:-" + Student.getid());
            Console.WriteLine("StudentDOB:-" + Student.getDateOfBirth());
            Console.WriteLine("------------------------------");
        }
        public void displayCourse(Course course)
        {
            Console.WriteLine("couse id:- " + course.id);
            Console.WriteLine("Course Name:- " + course.nameOfCourse);
            Console.WriteLine("Course fees:- " + course.fees);
            Console.WriteLine("Course Duration:- " + course.duration);
            Console.WriteLine("----------------------------");
        }



        public void displayEnrolldetails(Enroll enroll)
        {
            display(enroll._student);
            displayCourse(enroll._course);
            Console.WriteLine(enroll._dateTime);
        }
    }
}
