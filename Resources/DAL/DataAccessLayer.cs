using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;// تمكيننا من التعامل مع مخزنات البيانات
namespace Products_managment.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlConnection;

        //this constructor inisialize the connecting object
        public DataAccessLayer()
        {
            sqlConnection = new SqlConnection(@"Server=.\فواز ; Database=prodectDB ;integrated security=true"); 
        }

        // Method to open the connection
        public void open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        // Method to close the connection
        public void close()
        {
            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close(); 

            }
        }

        //Method To Read Data From Database

        public DataTable selectData(string stored_procedure, SqlParameter[] param)
        { SqlCommand sqlcmd = new SqlCommand();
        sqlcmd.CommandType = CommandType.StoredProcedure;
        sqlcmd.CommandText = stored_procedure;
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

    }
}
