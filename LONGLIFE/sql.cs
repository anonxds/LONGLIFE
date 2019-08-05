using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LONGLIFE
{
    class sql
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter db;
        private void setcon()
        {
            con = new SQLiteConnection("Data Source=./character.sqlite3;Version=3;New=False;Compress=true;");

        }
        public void Exe(String query)
        {
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public string getdata(string query, string dato)
        {
            setcon();
            //         con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            SQLiteDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();

            string userRole = string.Empty;
            while (reader.Read())
            {
                userRole = reader[dato].ToString();

            }
            con.Close();
            return userRole;
        }
        public void populate(ComboBox cb, string query, string type)
        {
            setcon();
            cb.Items.Clear();
            con.Open();


            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SQLiteDataAdapter db = new SQLiteDataAdapter(cmd);
            db.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cb.Items.Add(dr[type]).ToString();
            }
            con.Close();

        }
    }
}
