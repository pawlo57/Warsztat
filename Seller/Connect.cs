using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlServerCe;
using System.Data;

namespace Seller
{
    static class Connect
    {
        static SqlCeConnection con;
        static SqlCeCommand comm;
        static SqlCeDataAdapter adapter;


        static Connect()
        {
            //dataPath = HttpContext.Current.Server.MapPath("/");

            //1
            con = new SqlCeConnection("Data Source='" + Settings.AppDirectory + "\\Database.sdf'");
          
            //2
            comm = new SqlCeCommand();

            //3
            adapter = new SqlCeDataAdapter(comm);

            //dane = new DataSet();

        }

        public static bool CheckDatabase(string datasource)
        {
            SqlCeConnection sqlConnection =
                new SqlCeConnection("Data Source='" + datasource + "'");

            SqlCeCommand sqlCommand = new SqlCeCommand();

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(sqlCommand);

            DataTable table = new DataTable();

            sqlCommand.CommandText = "SELECT * FROM urs";

            sqlCommand.Connection = sqlConnection;

            try { adapter.Fill(table); }

            catch { return false; }

            return true;
        }

        public static DataTable FillCommand(string text)
        {

            DataTable table = new DataTable();

            comm.CommandText = text;

            comm.Connection = con;

            adapter.Fill(table);

            return table;
          
        }

        public static void SetCommand(string text)
        {
            comm.CommandText = text;
            comm.Connection = con;
            //comm.Parameters.Add(par);

            
            con.Open();
            comm.ExecuteNonQuery();
            con.Close();
        }

        public static int SetIDCommand(string text)
        {
            comm.CommandText = text;
            comm.Connection = con;

            int rowID = -1;

            con.Open();

            SqlCeCommand getID = new SqlCeCommand("SELECT @@IDENTITY", con);

            comm.ExecuteNonQuery();

            rowID = int.Parse(getID.ExecuteScalar().ToString());

            con.Close();

            getID.Dispose();

            return rowID;
        }
        
    
    }
}
