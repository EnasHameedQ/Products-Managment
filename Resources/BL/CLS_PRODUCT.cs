using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Products_managment.BL
{
    class CLS_PRODUCT
    {
        public DataTable GET_ALL_CATEGORIES( )
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectDate("GET_ALL_CATEGORIES",null);
            DAL.close();

            return DT;


        }

        public void ADD_PRODUCT(int ID_CAT,string label_peoduct,string ID_product ,
                                 int Qte, string Price,byte[] img )
        { DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
        DAL.open();
        SqlParameter[] param = new SqlParameter[6];
        param[0] = new SqlParameter("@ID_CAT",SqlDbType.Int );
        param[0].Value=ID_CAT;

        param[1] = new SqlParameter("@ID_BRODUCT", SqlDbType.VarChar,30);
        param[1].Value = ID_product;

        param[2] = new SqlParameter("@LEBAL_PRODUCT", SqlDbType.VarChar, 30);
        param[2].Value = label_peoduct;

        param[3] = new SqlParameter("@Qte", SqlDbType.Int);
        param[3].Value = Qte;

        param[4] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
        param[4].Value = Price;

        param[5] = new SqlParameter("@img", SqlDbType.Image);
        param[5].Value = img;

        DAL.ExecuteCommand("ADD_PRODCUT", param);
        DAL.close();
        }

        public DataTable varifayProductID(string ID )
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID",SqlDbType.VarChar,50);
            param[0].Value = ID;
            DT = DAL.SelectDate("varifayProductID", param);
            DAL.close();

            return DT;


        }

        public DataTable GET_ALL_PRODUCTS()
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectDate("GET_ALL_PRODUCTS", null);
            DAL.close();

            return DT;


        }
        public DataTable searchProduct(string ID)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value =ID;
            DT = DAL.SelectDate("searchProduct", param);
            DAL.close();

            return DT;


        }

        public DataTable Get_IMAGE_Product(string ID)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DT = DAL.SelectDate("Get_IMAGE_Product", param);
            DAL.close();

            return DT;


        }
        public DataTable DeleteProduct(string ID)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DT = DAL.SelectDate("DeleteProduct", param);
            DAL.close();

            return DT;


        }
        public void UPDATE_PRODUCT(int ID_CAT, string label_peoduct, string ID_product,
                                int Qte, string Price, byte[] img)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_CAT;

            param[1] = new SqlParameter("@ID_BRODUCT", SqlDbType.VarChar, 30);
            param[1].Value = ID_product;

            param[2] = new SqlParameter("@LEBAL_PRODUCT", SqlDbType.VarChar, 30);
            param[2].Value = label_peoduct;

            param[3] = new SqlParameter("@Qte", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@img", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("UPDATE_PRODUCT", param);
            DAL.close();
        }
        
    }
}
