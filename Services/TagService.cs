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
    class TagService : ITagService
    {
        public bool addTag(Tag tag)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
               
                string query = "INSERT INTO tags (subjectName, subjectCode, relatedTag) VALUES (@subjectname, @subjectcode, @relatedtag)";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@subjectname", tag.SubjectName);
                cmd.Parameters.AddWithValue("@subjectcode", tag.SubjectCode);
                cmd.Parameters.AddWithValue("@relatedtag", tag.RelatedTag);

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

        public bool deleteTagr(int id)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "DELETE FROM tags WHERE id = @id";

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

        public List<Tag> getAllTags()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<Tag> arrayTags = null;


            try
            {
                string query = "SELECT * FROM tags";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                arrayTags = new List<Tag>();

                while (rdr.Read())
                {
                    Tag tag = new Tag();
                    tag.Id = rdr.GetInt32(0);
                    tag.SubjectName = rdr.GetString(1);
                    tag.SubjectCode = rdr.GetString(2);
                    tag.RelatedTag = rdr.GetString(3);
                    

                    arrayTags.Add(tag);
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

            return arrayTags;
        }

        public Tag GetTag(int id)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            Tag tag = new Tag();

            try
            {
                string query = "SELECT * FROM tags WHERE id = @id";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    tag.Id = rdr.GetInt32(0);
                    tag.SubjectName = rdr.GetString(1);
                    tag.SubjectCode = rdr.GetString(2);
                    tag.RelatedTag = rdr.GetString(3);

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

            return tag;
        }

        public bool updateTag(int id, Tag tag)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "UPDATE tags SET subjectName = @subjectname, subjectCode = @subjectcode, relatedTag = @relatedtag WHERE id = @id";

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@subjectname", tag.SubjectName);
                cmd.Parameters.AddWithValue("@subjectcode", tag.SubjectCode);
                cmd.Parameters.AddWithValue("@relatedtag", tag.RelatedTag);
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
