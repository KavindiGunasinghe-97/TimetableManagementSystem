﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;
using System.Data.SQLite;

namespace Time_Table_Management_System.Services
{
    class NonoverlapService : INonoverlapService
    {
        public bool addNonoverlap(int nonSessionID1, int nonSessionID2, int nonSessionID3, int nonSessionID4)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {

                string query = "INSERT INTO nonoverlaps (non1_id, non2_id, non3_id, non4_id) VALUES (@non1_id, @non2_id, @non3_id, @non4_id)";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@non1_id", nonSessionID1);
                cmd.Parameters.AddWithValue("@non2_id", nonSessionID2);
                cmd.Parameters.AddWithValue("@non3_id", nonSessionID3);
                cmd.Parameters.AddWithValue("@non4_id", nonSessionID4);

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

        public bool deleteNonoverlap(int id)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "DELETE FROM nonoverlaps WHERE id = @id";

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

        public List<Nonoverlap> getAllNonoverlaps()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<Nonoverlap> arrayNonoverlaps = null;

            try
            {
                string query = "SELECT * FROM nonoverlaps";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                arrayNonoverlaps = new List<Nonoverlap>();

                while (rdr.Read())
                {
                    Nonoverlap nonoverlap = new Nonoverlap();
                    nonoverlap.Id = rdr.GetInt32(0);
                    nonoverlap.Non1_id = rdr.GetInt32(1);
                    try
                    {
                        nonoverlap.Non2_id = rdr.GetInt32(2);
                        nonoverlap.Non3_id = rdr.GetInt32(3);
                        nonoverlap.Non4_id = rdr.GetInt32(4);
                    }
                    catch (Exception er)
                    {
                        if (er.Message == "")
                        {

                        }
                    }


                    arrayNonoverlaps.Add(nonoverlap);
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

            return arrayNonoverlaps;
        }

        public Nonoverlap GetNonoverlap(int id)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            Nonoverlap nonoverlap = new Nonoverlap();

            try
            {
                string query = "SELECT * FROM nonoverlaps WHERE id = @id";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    nonoverlap.Id = rdr.GetInt32(0);
                    nonoverlap.Non1_id = rdr.GetInt32(1);
                    try
                    {
                        nonoverlap.Non2_id = rdr.GetInt32(2);
                        nonoverlap.Non3_id = rdr.GetInt32(3);
                        nonoverlap.Non4_id = rdr.GetInt32(4);
                    }
                    catch (Exception er)
                    {
                        if (er.Message == "")
                        {

                        }
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

            return nonoverlap;

        }

        public List<Nonoverlap> searchNonoverlap(string key, string type)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<Nonoverlap> arrayNonoverlaps = null;

            try
            {
                string query = "SELECT * FROM nonoverlaps WHERE " + type + " LIKE '%" + key + "%'";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@type", type);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                arrayNonoverlaps = new List<Nonoverlap>();

                while (rdr.Read())
                {
                    Nonoverlap nonoverlap = new Nonoverlap();
                    nonoverlap.Id = rdr.GetInt32(0);
                    nonoverlap.Non1_id = rdr.GetInt32(1);
                    nonoverlap.Non2_id = rdr.GetInt32(2);
                    nonoverlap.Non3_id = rdr.GetInt32(3);
                    nonoverlap.Non4_id = rdr.GetInt32(4);


                    arrayNonoverlaps.Add(nonoverlap);
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

            return arrayNonoverlaps;
        }

        public bool updateNonoverlap(int id, Nonoverlap nonoverlap)
        {
            throw new NotImplementedException();
        }
    }
}
