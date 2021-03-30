using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Products_managment.DAL
{    
    class DataAccesLayer
    {
        SqlConnection sqlconnection;
        public DataAccesLayer()
        {
            sqlconnection = new SqlConnection("Data Source=ENASHAMEED-PC;Initial Catalog=prodectDB;Integrated Security=True");
        }

        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            { sqlconnection.Open(); }
        }


        public void close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            { sqlconnection.Close(); }
        }

        public DataTable SelectDate(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        
        }



        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;

            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
            
        }

    }
}
