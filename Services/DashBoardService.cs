using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    class DashBoardService : IDashBoardService
    {
        public int getLabCount()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            int labCount = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM locations WHERE roomType = 'Laboratory' ";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    labCount = rdr.GetInt32(0);
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
            return labCount;
        }

        public string getLatestGroupName()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            string latestGroup = null;
            try
            {
                string query = "SELECT subGroupId FROM students";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    latestGroup = rdr.GetString(0);
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
            return latestGroup;
        }

        public string getLatestLecturer()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            string latestLecturer = null;
            try
            {
                string query = "SELECT lec_name FROM lecturers";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    latestLecturer = rdr.GetString(0);
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
            return latestLecturer;
        }

        public string getLatestSubject()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            string latestSubject = null;
            try
            {
                string query = "SELECT subjectName FROM subjects";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    latestSubject = rdr.GetString(0);
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
            return latestSubject;
        }

        public int getLecCount()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            int lacCount = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM locations WHERE roomType = 'Lecture Hall' ";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lacCount = rdr.GetInt32(0);
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
            return lacCount;
        }

        public int getLecturersCount()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            int lecturersCount = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM lecturers";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lecturersCount = rdr.GetInt32(0);
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
            return lecturersCount;
        }

        public int getLocationsCount()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            int locationsCount = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM locations";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    locationsCount = rdr.GetInt32(0);
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
            return locationsCount;
        }

        public int getStudentsCount()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            int studentsCount = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM students";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    studentsCount = rdr.GetInt32(0);
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
            return studentsCount;
        }

        public int getSubjectsCount()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            int subjectsCount = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM subjects";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    subjectsCount = rdr.GetInt32(0);
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
            return subjectsCount;
        }

    }
}
