using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Time_Table_Management_System.Services
{
    class StudentService : IStudentService
    {
        public bool addStudent(Student student)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                //string query = "SELECT * FROM people WHERE username= @user AND password= @pass";
                string query = "INSERT INTO students (academicYear, programme, groupNumber, subGroupNumber, groupId, subGroupId) VALUES (@academicyear, @programme, @groupno, @subgroupno, @groupid, @subgroupid)";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@academicyear", student.AcademicYear);
                cmd.Parameters.AddWithValue("@programme", student.Programme);
                cmd.Parameters.AddWithValue("@groupno", student.GroupNumber);
                cmd.Parameters.AddWithValue("@subgroupno", student.SubGroupNumber);
                cmd.Parameters.AddWithValue("@groupid", student.GroupId);
                cmd.Parameters.AddWithValue("@subgroupid", student.SubGroupId);
                

                cmd.Prepare();

                //Console.WriteLine(cmd);

                if (cmd.ExecuteNonQuery() == 1)
                    result = true;
                else
                    result = false;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public bool deleteStudent(int id)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "DELETE FROM students WHERE id = @id";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                if (cmd.ExecuteNonQuery() == 1)
                    result = true;
                else
                    result = false;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public List<Student> getAllStudents()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<Student> arrayStus = null;


            try
            {
                string query = "SELECT * FROM students";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                arrayStus = new List<Student>();

                while (rdr.Read())
                {
                    Student stu = new Student();
                    stu.Id = rdr.GetInt32(0);
                    stu.AcademicYear = rdr.GetString(1);
                    stu.Programme = rdr.GetString(2);
                    stu.GroupNumber = rdr.GetInt32(3);
                    stu.SubGroupNumber = rdr.GetInt32(4);
                    stu.GroupId = rdr.GetString(5);
                    stu.SubGroupId = rdr.GetString(6);
                  
                    arrayStus.Add(stu);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return arrayStus;
        }

        public Student GetStudent(int id)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            Student stu = new Student();

            try
            {
                string query = "SELECT * FROM students WHERE id = @id";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    stu.Id = rdr.GetInt32(0);
                    stu.AcademicYear = rdr.GetString(1);
                    stu.Programme = rdr.GetString(2);
                    stu.GroupNumber = rdr.GetInt32(3);
                    stu.SubGroupNumber = rdr.GetInt32(4);
                    stu.GroupId = rdr.GetString(5);
                    stu.SubGroupId = rdr.GetString(6);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return stu;
        }

        public bool updateStudent(int id, Student student)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "UPDATE students SET academicYear = @academicyear, programme = @programme, groupNumber = @groupno, subGroupNumber = @subgroupno, groupId = @groupid, subGroupId = @subgroupid WHERE id = @id";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@academicyear", student.AcademicYear);
                cmd.Parameters.AddWithValue("@programme", student.Programme);
                cmd.Parameters.AddWithValue("@groupno", student.GroupNumber);
                cmd.Parameters.AddWithValue("@subgroupno", student.SubGroupNumber);
                cmd.Parameters.AddWithValue("@groupid", student.GroupId);
                cmd.Parameters.AddWithValue("@subgroupid", student.SubGroupId);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.Prepare();

                if (cmd.ExecuteNonQuery() == 1)
                    result = true;
                else
                    result = false;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
    }
}
