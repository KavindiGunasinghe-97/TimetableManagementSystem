using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    class SessionRoomService : ISessionRoomService
    {
        public bool addSessionRoom(SessionRoom room)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "UPDATE sessions SET  room = @room WHERE id = @session_id";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@room", room.Room);
                cmd.Parameters.AddWithValue("@session_id", room.Session_id);

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

        public bool deleteSessionRoom(int id)
        {
            throw new NotImplementedException();
        }

        public List<SessionRoom> getAllSessionRooms()
        {
            throw new NotImplementedException();
        }

        public SessionRoom GetSessionRoom(int id)
        {
            throw new NotImplementedException();
        }

        public bool updateSession(int id, SessionRoom room)
        {
            throw new NotImplementedException();
        }
    }
}
