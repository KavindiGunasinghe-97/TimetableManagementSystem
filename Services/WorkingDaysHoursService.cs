using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    class WorkingDaysHoursService : IWorkingDaysHoursService
    {

        public bool addWorkingDaysHours(WorkingDaysHours workingDaysHours)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "INSERT INTO workingdayshours (noOfWorkingDays, monday, tuesday, wednesday, thursday, friday, saturday, sunday, noOfWorkingHours, noOfWorkingMinutes) VALUES (@noOfWorkingDays, @monday, @tuesday, @wednesday, @thursday, @friday, @saturday, @sunday, @noOfWorkingHours, @noOfWorkingMinutes)";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@noOfWorkingDays",workingDaysHours.NoOfWorkingDays);
                cmd.Parameters.AddWithValue("@monday", workingDaysHours.Monday);
                cmd.Parameters.AddWithValue("@tuesday", workingDaysHours.Tuesday);
                cmd.Parameters.AddWithValue("@wednesday", workingDaysHours.Wednesday);
                cmd.Parameters.AddWithValue("@thursday", workingDaysHours.Thursday);
                cmd.Parameters.AddWithValue("@friday", workingDaysHours.Friday);
                cmd.Parameters.AddWithValue("@saturday", workingDaysHours.Saturday);
                cmd.Parameters.AddWithValue("@sunday", workingDaysHours.Sunday);
                cmd.Parameters.AddWithValue("@noOfWorkingHours", workingDaysHours.NoOfHours);
                cmd.Parameters.AddWithValue("@noOfWorkingMinutes", workingDaysHours.NoOfMinutes);

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

        public bool deleteWorkingDaysHours()
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "DELETE FROM workingdayshours";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Prepare();

                if (cmd.ExecuteNonQuery() != 0)
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

        public bool getExistWorkingDaysHours()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            Boolean exist = false;


            try
            {
                string query = "SELECT * FROM workingdayshours";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    exist = true;
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

            return exist;
        }

        public WorkingDaysHours getWorkingDaysHours()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            WorkingDaysHours workingDaysHours = new WorkingDaysHours();
            try
            {
                string query = "SELECT * FROM workingdayshours";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    workingDaysHours.Id = rdr.GetInt32(0);
                    workingDaysHours.NoOfWorkingDays = rdr.GetInt32(1);
                    workingDaysHours.Monday = rdr.GetInt32(2);
                    workingDaysHours.Tuesday = rdr.GetInt32(3);
                    workingDaysHours.Wednesday = rdr.GetInt32(4);
                    workingDaysHours.Thursday = rdr.GetInt32(5);
                    workingDaysHours.Friday = rdr.GetInt32(6);
                    workingDaysHours.Saturday = rdr.GetInt32(7);
                    workingDaysHours.Sunday = rdr.GetInt32(8);
                    workingDaysHours.NoOfHours = rdr.GetInt32(9);
                    workingDaysHours.NoOfMinutes = rdr.GetInt32(10);
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

            return workingDaysHours;
        }




        public Boolean updateWorkingDaysHours(WorkingDaysHours workingDaysHours)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "UPDATE workingdayshours SET noOfWorkingDays = @noworkingdays WHERE id = 2";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@noworkingdays", workingDaysHours);

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
