using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    class LocationService : ILocationService
    {
        public bool addLocation(Location location)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");

            try
            {
                //string query = "SELECT * FROM people WHERE username= @user AND password= @pass";
                string query = "INSERT INTO locations (buildingName, roomName, roomType,capacity) VALUES (@buildingname, @roomname, @roomtype,@capacity)";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@buildingname", location.BuildingName);
                cmd.Parameters.AddWithValue("@roomname", location.RoomName);
                cmd.Parameters.AddWithValue("@roomtype", location.RoomType);
                cmd.Parameters.AddWithValue("@capacity", location.Capacity);
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

        public bool deleteLocation(int id)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "DELETE FROM location WHERE id = @id";

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


        public List<Location> getAllLocations()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<Location> arrayLocs = null;


            try
            {
                string query = "SELECT * FROM locations";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                arrayLocs = new List<Location>();

                while (rdr.Read())
                {
                    Location loc = new Location();
                    loc.Id = rdr.GetInt32(0);
                    loc.BuildingName = rdr.GetString(1);
                    loc.RoomName = rdr.GetString(2);
                    loc.RoomType = rdr.GetString(3);
                    loc.Capacity = rdr.GetString(4);

                    arrayLocs.Add(loc);
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

            return arrayLocs;
        }


        public Location GetLocation(int id)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            Location loc = new Location();

            try
            {
                string query = "SELECT * FROM locations WHERE id = @id";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    loc.Id = rdr.GetInt32(0);
                    loc.BuildingName = rdr.GetString(1);
                    loc.RoomName = rdr.GetString(2);
                    loc.RoomType = rdr.GetString(3);
                    loc.Capacity = rdr.GetString(4);
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

            return loc;
        }
        public bool updateLocation(int id, Location location)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "UPDATE locations SET buildingName = @buildingname, roomName = @roomname, roomType = @roomtype, capacity = @capacity WHERE id = @id";


                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@buildingname", location.BuildingName);
                cmd.Parameters.AddWithValue("@roomname", location.RoomName);
                cmd.Parameters.AddWithValue("@roomtype", location.RoomType);
                cmd.Parameters.AddWithValue("@capacity", location.Capacity);
                cmd.Parameters.AddWithValue("@id", id);

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
    }
}
