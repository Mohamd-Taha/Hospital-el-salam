using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
 
namespace client.BL
{
    class motions
    {

        /// الدوال التي تضيف///////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void add_client_motion(int client_id, int motion_id, DateTime motion_date, string month, string year, string day, int id_department_and_role, double number_of_dely_minute)
     
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[8];


            param[0] = new SqlParameter("@client_id", SqlDbType.Int);
            param[0].Value = client_id;

            param[1] = new SqlParameter("@motion_id", SqlDbType.Int);
            param[1].Value = motion_id;



            param[2] = new SqlParameter("@motion_date", SqlDbType.DateTime);
            param[2].Value = motion_date;


            param[3] = new SqlParameter("@month", SqlDbType.VarChar, 50);
            param[3].Value = month;

            param[4] = new SqlParameter("@year", SqlDbType.VarChar, 50);
            param[4].Value = year;


            param[5] = new SqlParameter("@day", SqlDbType.VarChar, 50);
            param[5].Value = day;


            param[6] = new SqlParameter("@id_department_and_role", SqlDbType.Int);
            param[6].Value = id_department_and_role;

            param[7] = new SqlParameter("@number_of_dely_minute", SqlDbType.Float);
            param[7].Value = number_of_dely_minute;



            dal.ExecuteComand("add_client_motion", param);
            dal.close();
        }



        public void add_over_all_summary(int client_id, int number_of_attendence_days, int month, int year, double pure_salary)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@client_id", SqlDbType.Int);
            param[0].Value = client_id;

            param[1] = new SqlParameter("@number_of_attendence_days", SqlDbType.Int);
            param[1].Value = number_of_attendence_days;



            param[2] = new SqlParameter("@month", SqlDbType.Int);
            param[2].Value = month;


            param[3] = new SqlParameter("@year", SqlDbType.Int);
            param[3].Value = year;

            param[4] = new SqlParameter("@pure_salary", SqlDbType.Float);
            param[4].Value = pure_salary;

            dal.ExecuteComand("add_over_all_summary", param);
            dal.close();
        }





        public void add_over_all_salary(int client_id, string client_name, double based_salary, double total_merit,


            double taxs, double insurance, double dely, double loan, double total_deduction, double other, string note_on_other, double pure_salary)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[12];



            param[0] = new SqlParameter("@client_id", SqlDbType.Int);
            param[0].Value = client_id;

            param[1] = new SqlParameter("@client_name", SqlDbType.VarChar, 50);
            param[1].Value = client_name;




            param[2] = new SqlParameter("@based_salary", SqlDbType.Float);
            param[2].Value = based_salary;

            param[3] = new SqlParameter("@total_merit", SqlDbType.Float);
            param[3].Value = total_merit;

            param[4] = new SqlParameter("@taxs", SqlDbType.Float);
            param[4].Value = taxs;

            param[5] = new SqlParameter("@insurance", SqlDbType.Float);
            param[5].Value = insurance;

            param[6] = new SqlParameter("@dely", SqlDbType.Float);
            param[6].Value = dely;


            param[7] = new SqlParameter("@loan", SqlDbType.Float);
            param[7].Value = loan;


            param[8] = new SqlParameter("@total_deduction", SqlDbType.Float);
            param[8].Value = total_deduction;


            param[9] = new SqlParameter("@other", SqlDbType.Float);
            param[9].Value = other;



            param[10] = new SqlParameter("@note_on_other", SqlDbType.VarChar, 50);
            param[10].Value = note_on_other;

            param[11] = new SqlParameter("@pure_salary", SqlDbType.Float);
            param[11].Value = pure_salary;



            dal.ExecuteComand("add_over_all_salary", param);
            dal.close();
        }


        public void add_over_alll_staying(int client_id, string client_name, double value_of_staying, double pure_value_of_staying_24, double pure_value_of_staying,double total_merit,
             


            double taxs, double insurance, double dely, double loan, double total_deduction, double other, string note_on_other, double pure_salary)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[14];

            param[0] = new SqlParameter("@client_id", SqlDbType.Int);
            param[0].Value = client_id;

            param[1] = new SqlParameter("@client_name", SqlDbType.VarChar, 50);
            param[1].Value = client_name;

            param[2] = new SqlParameter("@value_of_staying", SqlDbType.Float);
            param[2].Value = value_of_staying;

            param[3] = new SqlParameter("@pure_value_of_staying_24", SqlDbType.Float);
            param[3].Value = pure_value_of_staying_24;

            param[4] = new SqlParameter("@pure_value_of_staying", SqlDbType.Float);
            param[4].Value = pure_value_of_staying;



            param[5] = new SqlParameter("@total_merit", SqlDbType.Float);
            param[5].Value = total_merit;

            param[6] = new SqlParameter("@taxs", SqlDbType.Float);
            param[6].Value = taxs;

            param[7] = new SqlParameter("@insurance", SqlDbType.Float);
            param[7].Value = insurance;

            param[8] = new SqlParameter("@dely", SqlDbType.Float);
            param[8].Value = dely;


            param[9] = new SqlParameter("@loan", SqlDbType.Float);
            param[9].Value = loan;


            param[10] = new SqlParameter("@total_deduction", SqlDbType.Float);
            param[10].Value = total_deduction;


            param[11] = new SqlParameter("@other", SqlDbType.Float);
            param[11].Value = other;



            param[12] = new SqlParameter("@note_on_other", SqlDbType.VarChar, 50);
            param[12].Value = note_on_other;

            param[13] = new SqlParameter("@pure_salary", SqlDbType.Float);
            param[13].Value = pure_salary;

            dal.ExecuteComand("add_over_alll_staying", param);
            dal.close();
        }


        public void add_over_shift(int client_id, string client_name, int number_moring_shift, int number_night_shifts, double value_night_shifts, double value_moring_shifts, double total_merit,



            double taxs, double insurance, double dely, double loan, double total_deduction, double other, string note_on_other, double pure_salary)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[15];


            param[0] = new SqlParameter("@client_id", SqlDbType.Int);
            param[0].Value = client_id;

            param[1] = new SqlParameter("@client_name", SqlDbType.VarChar, 50);
            param[1].Value = client_name;



            param[2] = new SqlParameter("@number_moring_shift", SqlDbType.Int);
            param[2].Value = number_moring_shift;


            param[3] = new SqlParameter("@number_night_shifts", SqlDbType.Int);
            param[3].Value = number_night_shifts;
            
            param[4] = new SqlParameter("@value_night_shifts", SqlDbType.Float);
            param[4].Value = value_night_shifts;


            param[5] = new SqlParameter("@value_moring_shifts", SqlDbType.Float);
            param[5].Value = value_moring_shifts;

            param[6] = new SqlParameter("@total_merit", SqlDbType.Float);
            param[6].Value = total_merit;

            param[7] = new SqlParameter("@taxs", SqlDbType.Float);
            param[7].Value = taxs;

            param[8] = new SqlParameter("@insurance", SqlDbType.Float);
            param[8].Value = insurance;

            param[9] = new SqlParameter("@dely", SqlDbType.Float);
            param[9].Value = dely;


            param[10] = new SqlParameter("@loan", SqlDbType.Float);
            param[10].Value = loan;


            param[11] = new SqlParameter("@total_deduction", SqlDbType.Float);
            param[11].Value = total_deduction;


            param[12] = new SqlParameter("@other", SqlDbType.Float);
            param[12].Value = other;



            param[13] = new SqlParameter("@note_on_other", SqlDbType.VarChar, 50);
            param[13].Value = note_on_other;

            param[14] = new SqlParameter("@pure_salary", SqlDbType.Float);
            param[14].Value = pure_salary;


            dal.ExecuteComand("add_over_shift", param);
            dal.close();
        }



        
        public void update_total_staying_if_not_exist(int client_id, double total_number_of_staying_in_month, int days, int month, int year)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@client_id", SqlDbType.Int);
            param[0].Value = client_id;

            param[1] = new SqlParameter("@total_number_of_staying_in_month", SqlDbType.Float);
            param[1].Value = total_number_of_staying_in_month;



            param[2] = new SqlParameter("@days", SqlDbType.Int);
            param[2].Value = days;


            param[3] = new SqlParameter("@month", SqlDbType.Int);
            param[3].Value = month;

            param[4] = new SqlParameter("@year", SqlDbType.Int);
            param[4].Value = year;


            dal.ExecuteComand("update_total_staying_if_not_exist", param);
            dal.close();
        }




        public void add_staying_houres(int client_id, double number_of_staying_hours, string month, string year, string day)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@client_id", SqlDbType.Int);
            param[0].Value = client_id;


            param[1] = new SqlParameter("@number_of_staying_hours", SqlDbType.Float);
            param[1].Value = number_of_staying_hours;



            param[2] = new SqlParameter("@month", SqlDbType.VarChar, 50);
            param[2].Value = month;

            param[3] = new SqlParameter("@year", SqlDbType.VarChar, 50);
            param[3].Value = year;


            param[4] = new SqlParameter("@day", SqlDbType.VarChar, 50);
            param[4].Value = day;


            

            dal.ExecuteComand("add_staying_houres", param);
            dal.close();
        }



        public void add_salary_motion(int client_id, string month, string year, string day)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@client_id", SqlDbType.Int);
            param[0].Value = client_id;



            param[1] = new SqlParameter("@month", SqlDbType.VarChar, 50);
            param[1].Value = month;

            param[2] = new SqlParameter("@year", SqlDbType.VarChar, 50);
            param[2].Value = year;


            param[3] = new SqlParameter("@day", SqlDbType.VarChar, 50);
            param[3].Value = day;




            dal.ExecuteComand("add_salary_motion", param);
            dal.close();
        }





        /// الدوال التي تجلب البيانات////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       
        public DataTable get_types_of_motions()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();


            DataTable dt = new DataTable();
            dt = dal.selectData("get_types_of_motions", null);
            dal.close();
            return dt;

        }


        public DataTable get_shites_motions(string month, string year)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@month", SqlDbType.VarChar, 50);
            parm[0].Value = month;

            parm[1] = new SqlParameter("@year", SqlDbType.VarChar, 50);
            parm[1].Value = year;

            DataTable dt = new DataTable();
            dt = dal.selectData("get_shites_motions", parm);
            dal.close();
            return dt;

        }













        public DataTable get_salary_motins(string month,string year )
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@month", SqlDbType.VarChar, 50);
            parm[0].Value=month;

            parm[1] = new SqlParameter("@year", SqlDbType.VarChar, 50);
            parm[1].Value = year;

            DataTable dt = new DataTable();
            dt = dal.selectData("get_salary_motins", parm);
            dal.close();
            return dt;

        }








        public DataTable get_staying_motions(string month, string year)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@month", SqlDbType.VarChar, 50);
            parm[0].Value = month;

            parm[1] = new SqlParameter("@year", SqlDbType.VarChar, 50);
            parm[1].Value = year;

            DataTable dt = new DataTable();
            dt = dal.selectData("get_staying_motions", parm);
            dal.close();
            return dt;

        }






        public DataTable get_number_of_staying_and_number_of_dasy(int client_id ,int month, int year)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] parm = new SqlParameter[3];

            parm[0] = new SqlParameter("@client_id", SqlDbType.Int);
            parm[0].Value = client_id;

            parm[1] = new SqlParameter("@month", SqlDbType.Int);
            parm[1].Value = month;

            parm[2] = new SqlParameter("@year", SqlDbType.Int);
            parm[2].Value = year;

            DataTable dt = new DataTable();
            dt = dal.selectData("get_number_of_staying_and_number_of_dasy", parm);
            dal.close();
            return dt;

        }



        public DataTable get_dely_hours(int client_id, int month, int year)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] parm = new SqlParameter[3];

            parm[0] = new SqlParameter("@client_id", SqlDbType.Int);
            parm[0].Value = client_id;

            parm[1] = new SqlParameter("@month", SqlDbType.Int);
            parm[1].Value = month;

            parm[2] = new SqlParameter("@year", SqlDbType.Int);
            parm[2].Value = year;

            DataTable dt = new DataTable();
            dt = dal.selectData("get_dely_hours", parm);
            dal.close();
            return dt;

        }




















        public DataTable get_cleint_name_id_department_role()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();


            DataTable dt = new DataTable();
            dt = dal.selectData("get_cleint_name_id_department_role", null);
            dal.close();
            return dt;

        }

        public DataTable search_cleint_name_id_department_role(string search_word)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("search_word", SqlDbType.VarChar, 50);
            param[0].Value = search_word;



            DataTable dt = new DataTable();
            dt = dal.selectData("search_cleint_name_id_department_role", param);
            dal.close();
            return dt;

        }








        /// الدوال التي تحذف //////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
