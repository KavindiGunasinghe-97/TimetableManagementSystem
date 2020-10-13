using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    class TimeSlotService : ITimeSlotService
    {
        public bool addTimeSlots(TimeSlot timeSlot)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "INSERT INTO timeslots (stHours, stMinutes, etHours, etMinutes, duration) VALUES (@stHours, @stMinutes, @etHours, @etMinutes, @duration)";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@stHours", timeSlot.StHours);
                cmd.Parameters.AddWithValue("@stMinutes", timeSlot.StMinutes);
                cmd.Parameters.AddWithValue("@etHours", timeSlot.EtHours);
                cmd.Parameters.AddWithValue("@etMinutes", timeSlot.EtMinutes);
                cmd.Parameters.AddWithValue("@duration", timeSlot.Duration);

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



        public List<TimeSlot> getAllTimeSlots()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<TimeSlot> arrayTimeSlots = null;


            try
            {
                string query = "SELECT * FROM timeslots";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                arrayTimeSlots = new List<TimeSlot>();

                while (rdr.Read())
                {
                    TimeSlot timeSlot = new TimeSlot();
                    timeSlot.Id = rdr.GetInt32(0);
                    timeSlot.StHours = rdr.GetInt32(1);
                    timeSlot.StMinutes = rdr.GetInt32(2);
                    timeSlot.EtHours = rdr.GetInt32(3);
                    timeSlot.EtMinutes = rdr.GetInt32(4);
                    timeSlot.Duration = rdr.GetString(5);


                    arrayTimeSlots.Add(timeSlot);
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

            return arrayTimeSlots;
        }

        public TimeSlot getTimeSlot(int id)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            TimeSlot timeSlot = new TimeSlot();

            try
            {
                string query = "SELECT * FROM timeslots WHERE id = @id";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    timeSlot.Id = rdr.GetInt32(0);
                    timeSlot.StHours = rdr.GetInt32(1);
                    timeSlot.StMinutes = rdr.GetInt32(2);
                    timeSlot.EtHours = rdr.GetInt32(3);
                    timeSlot.EtMinutes = rdr.GetInt32(4);
                    timeSlot.Duration = rdr.GetString(5);

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

            return timeSlot;
        }



        public bool deleteTimeSlot(int id)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "DELETE FROM timeslots WHERE id = @id";

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

    }
}
