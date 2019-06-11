using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SDP2019
{
    
    class DBConnection
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=sdp;Username=root;password=''");


        public void OpenConnection()
        {
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }


        //下面所有Function 每次行之前要OpenConnection() 行完之後要CloseConnection()
        public DataTable ExecuteSelectQuery(string Query_)
        {
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Query_;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public int ExecuteUpdateQuery(string Query_)
        {
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Query_;
            return cmd.ExecuteNonQuery();
        }

        public int ExecuteInsertQuery(string Query_)
        {
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Query_;
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }
    }
    
}
