using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Products_managment.BL
{
    class CLS_LOGIN
    {
        public DataTable LOGIN(string ID, string DWS)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();

              SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID",SqlDbType.VarChar,50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@BWS", SqlDbType.VarChar, 50);
            param[1].Value = DWS;
          
            DataTable DT = new DataTable();
            DT = DAL.SelectDate("SP_LOGIN",param);
            DAL.close();

            return DT;
            

        }
    }
}
