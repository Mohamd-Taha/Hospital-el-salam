using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace client.BL
{
    class User
    {

        public void addUser( string User_full_name, string User_Name, string User_Password, string User_Accesability)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@User_full_name", SqlDbType.VarChar, 50);
            param[0].Value = User_full_name;

            param[1] = new SqlParameter("@User_Name", SqlDbType.VarChar, 50);
            param[1].Value = User_Name;

            param[2] = new SqlParameter("@User_Password", SqlDbType.VarChar, 50);
            param[2].Value = User_Password;

            param[3] = new SqlParameter("@User_Accesability", SqlDbType.VarChar, 50);
            param[3].Value = User_Accesability;


            dal.ExecuteComand("addUser", param);
            dal.close();

        }

        public void updateUser( string User_full_name, string User_Name, string User_Password, string User_Accesability)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@User_full_name", SqlDbType.VarChar, 50);
            param[0].Value = User_full_name;

            param[1] = new SqlParameter("@User_Name", SqlDbType.VarChar, 50);
            param[1].Value = User_Name;

            param[2] = new SqlParameter("@User_Password", SqlDbType.VarChar, 50);
            param[2].Value = User_Password;

            param[3] = new SqlParameter("@User_Accesability", SqlDbType.VarChar, 50);
            param[3].Value = User_Accesability;

         

            dal.ExecuteComand("updateUser", param);
            dal.close();

        }

        public DataTable getUser()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("getUser", null);
            dal.close();
            return dt;

        }

     

        public void deleteUser(string User_Name)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@User_Name", SqlDbType.VarChar,50);
            param[0].Value = User_Name;



            dal.ExecuteComand("deleteUser", param);
            dal.close();
        }

 

    }
}
