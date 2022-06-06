using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Case_Study
{
    class AppEngine
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;



        static SqlConnection getConnection()
        {
            con = new SqlConnection("data source = RMGW58ZLPC0941\\SQLEXPRESS; Initial Catalog=StudentDetails; user id=sa; password=Temp1234");
            con.Open();
            return con;
        }
        public void introduce(Course course)
        {
            Console.WriteLine(course.id + " " + course.nameOfCourse + " " + course.duration + " " + "days," + " " + course.fees);
        }

        public void studentregister(Student student)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = getConnection();



                cmd = new SqlCommand("insert into Students values(@StudentId,@StudentName,@studentDOB)", con);
                cmd.Parameters.AddWithValue("@StudentId", student.Std_id);
                cmd.Parameters.AddWithValue("@StudentName", student.Std_name);
                cmd.Parameters.AddWithValue("studentDOB", student.Std_Dob);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Student details 'ADDED'");
                else
                    Console.WriteLine("No Student Details 'ADDED'");




            }
            catch (SqlException e)
            {
                Console.WriteLine(e); //instead throw user defined exception
            }
            finally
            {



                con.Close();
            }
        }



        internal void Updatecourse()
        {
            throw new NotImplementedException();
        }

        public void AllStudentDetails()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("Select * from Students", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateStudent()
        {
            try
            {
                Console.WriteLine("Enter the Student id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Student DOB :");
                string dob = Console.ReadLine();
                con = getConnection();
                cmd = new SqlCommand("update Students set StudentName=@studentname,StudentDOB=@studentdob where StudentId=@studentId", con);
                cmd.Parameters.AddWithValue("@studentId", id);
                cmd.Parameters.AddWithValue("@studentname", name);
                cmd.Parameters.AddWithValue("@studentdob", dob);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Updated");
                }
                else
                {
                    Console.WriteLine("Row Not Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteStudents()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The student Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("delete Students where StudentId=@studentid", con);
                cmd.Parameters.AddWithValue("@studentid", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Row Delete Successfully");
                else
                    Console.WriteLine("Row Not Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }


        public void ParticularStudent()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Student Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from Students where StudentId =@studentid", con);
                cmd.Parameters.AddWithValue("@studentid", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void AllCoursesLists()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("select * from Courses", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + dr[0] + " Course Name : " + dr[1] + " Course Duration : " + dr[2] + " " + "days," + " Course Fees : " + dr[3]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void ParticularCourse()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Course Id ");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from tblCourses where CourseId=@Courseid", con);
                cmd.Parameters.AddWithValue("@Courseid", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + dr[0] + " Course Name : " + dr[1] + " Course Duration : " + dr[2] + " Course Fees : " + dr[3]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void updatestudentCourse()
        {
            try
            {
                Console.WriteLine("Enter the Course id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Course Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Course Duration :");
                int duration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course Fees :");
                float fee = Convert.ToSingle(Console.ReadLine());
                con = getConnection();
                cmd = new SqlCommand("update Courses set Courseduration=@Courseduration,coursename=@coursename,Coursefees=@Coursefees where CourseId=@Courseid", con);
                cmd.Parameters.AddWithValue("@Courseid", id);
                cmd.Parameters.AddWithValue("@Coursename", name);
                cmd.Parameters.AddWithValue("@Courseduration", duration);
                cmd.Parameters.AddWithValue("@Coursefees", fee);
                int res1 = cmd.ExecuteNonQuery();
                if (res1 > 0)
                {
                    Console.WriteLine("Row Updated");
                }
                else
                {
                    Console.WriteLine("Row Not Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeletestudentCourse()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Course Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("delete Courses where CourseId=@courseid", con);
                cmd.Parameters.AddWithValue("@courseid", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Row Delete Successfully");
                else
                    Console.WriteLine("Row Not Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void insertingstudentCourse()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Course Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Course Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Course Duration : ");
                int dur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Couration Fees : ");
                float fee = Convert.ToSingle(Console.ReadLine());
                cmd = new SqlCommand("insert into Courses values(@CourseId,@CourseName,@Courseduration,@Coursefees)", con);
                cmd.Parameters.AddWithValue("@CourseId", id);
                cmd.Parameters.AddWithValue("CourseName", name);
                cmd.Parameters.AddWithValue("@Courseduration", dur);
                cmd.Parameters.AddWithValue("@Coursefees", fee);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Inserted");
                }
                else
                {
                    Console.WriteLine("Row Not Inserted");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }


        public void EnrollstudentDetailslists()
        {
            try
            {
                con = getConnection();



                Console.WriteLine("Enter the Course id :");
                int Id1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Id :");
                int Id = Convert.ToInt32(Console.ReadLine());
                DateTime Enrolldate = DateTime.UtcNow;
                cmd = new SqlCommand("insert into EnrollDetails values(@Courseid,@StudentId,@EnrollDate)", con);
                cmd.Parameters.AddWithValue("@Courseid", Id1);
                cmd.Parameters.AddWithValue("@StudentId", Id);
                cmd.Parameters.AddWithValue("@EnrollDate", Enrolldate);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Inserted Successfully");
                }
                else
                {
                    Console.WriteLine("Row Not Inserted ");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
