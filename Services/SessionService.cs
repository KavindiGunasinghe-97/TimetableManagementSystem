 using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    class SessionService : ISessionService
    {
        public bool addSession(SessionDTO session)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "INSERT INTO sessions (lecturer1_name, lecturer2_name, subject_code, subject_name, tag, group_code, student_count, duration) VALUES (@lec1_name, @lec2_name, @sub_code, @sub_name, @tag, @group_code, @student_count, @duration)";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@lec1_name", session.Lec1_name);
                cmd.Parameters.AddWithValue("@lec2_name", session.Lec2_name);
                cmd.Parameters.AddWithValue("@sub_code", session.Subject_code);
                cmd.Parameters.AddWithValue("@sub_name", session.Subject_name);
                cmd.Parameters.AddWithValue("@tag", session.Tag);
                cmd.Parameters.AddWithValue("@group_code", session.Group_code);
                cmd.Parameters.AddWithValue("@student_count", session.Student_count);
                cmd.Parameters.AddWithValue("@duration", session.Duration);

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

        public bool deleteSession(int id)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "DELETE FROM sessions WHERE id = @id";

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

        public List<SessionDTO> getAllSessions()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<SessionDTO> arraySessions = null;


            try
            {
                string query = "SELECT * FROM sessions";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                arraySessions = new List<SessionDTO>();

                while (rdr.Read())
                {
                    SessionDTO session = new SessionDTO();
                    session.Id = rdr.GetInt32(0);
                    session.Lec1_name = rdr.GetString(1);
                    try
                    {
                        session.Lec2_name = rdr.GetString(2);
                    }
                    catch (Exception er)
                    {
                        if(er.Message == "")
                        {

                        }
                    }
                    session.Subject_code = rdr.GetString(3);
                    session.Subject_name = rdr.GetString(4);
                    session.Tag = rdr.GetString(5);
                    session.Group_code = rdr.GetString(6);
                    session.Student_count = rdr.GetInt32(7);
                    session.Duration = rdr.GetInt32(8);
                    try
                    {
                        session.Room = rdr.GetString(9);
                    }
                    catch (Exception rxr)
                    {
                        if(rxr.Message == "")
                        {

                        }
                    }
                    

                    arraySessions.Add(session);
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

            return arraySessions;
        }

        public SessionDTO GetSession(int id)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            SessionDTO session = new SessionDTO();

            try
            {
                string query = "SELECT * FROM sessions WHERE id = @id";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    session.Id = rdr.GetInt32(0);
                    session.Lec1_name = rdr.GetString(1);
                    try
                    {
                        session.Lec2_name = rdr.GetString(2);
                    }
                    catch (Exception er)
                    {
                        if (er.Message == "")
                        {

                        }
                    }
                    session.Subject_code = rdr.GetString(3);
                    session.Subject_name = rdr.GetString(4);
                    session.Tag = rdr.GetString(5);
                    session.Group_code = rdr.GetString(6);
                    session.Student_count = rdr.GetInt32(7);
                    session.Duration = rdr.GetInt32(8);
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

            return session;
        }

        public List<SessionDTO> searchSession(string key, string type)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<SessionDTO> arraySessions = null;

            try
            {
                if (type == "Lecturer")
                {
                    string query = "SELECT * FROM sessions WHERE lecturer1_name LIKE '%" + key + "%' OR lecturer2_name LIKE '%" + key + "%' ";
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Prepare();
                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    arraySessions = new List<SessionDTO>();

                    while (rdr.Read())
                    {
                        SessionDTO session = new SessionDTO();
                        session.Id = rdr.GetInt32(0);
                        session.Lec1_name = rdr.GetString(1);
                        try
                        {
                            session.Lec2_name = rdr.GetString(2);
                        }
                        catch (Exception er)
                        {
                            if (er.Message == "")
                            {

                            }
                        }
                        session.Subject_code = rdr.GetString(3);
                        session.Subject_name = rdr.GetString(4);
                        session.Tag = rdr.GetString(5);
                        session.Group_code = rdr.GetString(6);
                        session.Student_count = rdr.GetInt32(7);
                        session.Duration = rdr.GetInt32(8);

                        arraySessions.Add(session);
                    }



                }
                else
                {
                    string query = "SELECT * FROM sessions WHERE "+type+" LIKE '%" + key + "%'";
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@type", type);
                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    arraySessions = new List<SessionDTO>();

                    while (rdr.Read())
                    {
                        SessionDTO session = new SessionDTO();
                        session.Id = rdr.GetInt32(0);
                        session.Lec1_name = rdr.GetString(1);
                        try
                        {
                            session.Lec2_name = rdr.GetString(2);
                        }
                        catch (Exception er)
                        {
                            if (er.Message == "")
                            {
                            }
                        }
                        session.Subject_code = rdr.GetString(3);
                        session.Subject_name = rdr.GetString(4);
                        session.Tag = rdr.GetString(5);
                        session.Group_code = rdr.GetString(6);
                        session.Student_count = rdr.GetInt32(7);
                        session.Duration = rdr.GetInt32(8);

                        arraySessions.Add(session);
                    }

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

            return arraySessions;
        }

        public bool updateSession(int id, SessionDTO session)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "UPDATE sessions SET lecturer1_name = @lecname1, lecturer2_name = @lecname2, subject_code = @subject_code, subject_name = @subject_name, tag = @tag, group_code = @group_code, student_count = @student_count, duration = @duration WHERE id = @id";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@lecname1", session.Lec1_name);
                cmd.Parameters.AddWithValue("@lecname2", session.Lec2_name);
                cmd.Parameters.AddWithValue("@subject_code", session.Subject_code);
                cmd.Parameters.AddWithValue("@subject_name", session.Subject_name);
                cmd.Parameters.AddWithValue("@tag", session.Tag);
                cmd.Parameters.AddWithValue("@group_code", session.Group_code);
                cmd.Parameters.AddWithValue("@student_count", session.Student_count);
                cmd.Parameters.AddWithValue("@duration", session.Duration);
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
