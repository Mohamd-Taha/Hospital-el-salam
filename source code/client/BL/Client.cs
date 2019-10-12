using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
 

namespace client.BL
{
    class Client
    {
        public void addClient(int Client_id, string Name, int id_department_and_role, double salary,
            string type_of_sallary, double value_of_stay)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];

          
            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            param[1] = new SqlParameter("@Name", SqlDbType.VarChar,50);
            param[1].Value = Name;



            param[2] = new SqlParameter("@id_department_and_role", SqlDbType.Int);
            param[2].Value = id_department_and_role;


            param[3] = new SqlParameter("@salary", SqlDbType.Float);
            param[3].Value = salary;



            param[4] = new SqlParameter("@type_of_sallary", SqlDbType.VarChar, 50);
            param[4].Value = type_of_sallary;


            param[5] = new SqlParameter("@value_of_stay", SqlDbType.Float);
            param[5].Value = value_of_stay;


            dal.ExecuteComand("addClient", param);
            dal.close();
        
        
        }



        public void add_role_and_department(int id_department_and_role, string role, string Department)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id_department_and_role", SqlDbType.Int);
            param[0].Value = @id_department_and_role;

            param[1] = new SqlParameter("@role", SqlDbType.VarChar, 50);
            param[1].Value = role;


            param[2] = new SqlParameter("@Department", SqlDbType.VarChar,50);
            param[2].Value = Department;



            dal.ExecuteComand("add_role_and_department", param);
            dal.close();
        
        
        }








        public void add_other(string additions, double value_of_additions, string fans, double value_of_fans,
            DateTime date_of_other, int Client_id, double other, string reaseon_of_other)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@additions", SqlDbType.VarChar, 50);
            param[0].Value = additions;

            param[1] = new SqlParameter("@value_of_additions", SqlDbType.Float);
            param[1].Value = value_of_additions;


            param[2] = new SqlParameter("@fans", SqlDbType.VarChar, 50);
            param[2].Value = fans;


            param[3] = new SqlParameter("@value_of_fans", SqlDbType.Float);
            param[3].Value = value_of_fans;



            param[4] = new SqlParameter("@date_of_other", SqlDbType.Date);
            param[4].Value = date_of_other;


            param[5] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[5].Value = Client_id;


            param[6] = new SqlParameter("@other", SqlDbType.Float);
            param[6].Value = other;


            param[7] = new SqlParameter("@reaseon_of_other", SqlDbType.VarChar, 50);
            param[7].Value = reaseon_of_other;


            dal.ExecuteComand("add_other", param);
            dal.close();


        }














        
        

        public void addDeduction(DateTime _Date, double Lateness, double Loan, double Insurance, int Absence,double Value_of_absence,double Value_of_lateness,
            int Client_id)
 
          
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@_Date", SqlDbType.Date);
            param[0].Value = _Date;

            param[1] = new SqlParameter("@Lateness", SqlDbType.Float);
            param[1].Value = Lateness;

            param[2] = new SqlParameter("@Loan", SqlDbType.Float);
            param[2].Value = Loan;


            param[3] = new SqlParameter("@Insurance", SqlDbType.Float);
            param[3].Value = Insurance;

          


            param[4] = new SqlParameter("@Absence", SqlDbType.Int);
            param[4].Value = Absence;




            param[5] = new SqlParameter("@Value_of_absence", SqlDbType.Float);
            param[5].Value = Value_of_absence;


            param[6] = new SqlParameter("@Value_of_lateness", SqlDbType.Float);
            param[6].Value = Value_of_lateness;



            param[7] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[7].Value = Client_id;


            dal.ExecuteComand("addDeduction", param);
            dal.close();


        }
      
      /*  public void addOverall(int Client_id, DateTime Date, double Salary, double TotalMerit, double TotalDeduction, double Total)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            param[1] = new SqlParameter("@Date", SqlDbType.Date);
            param[1].Value = Date;

            param[2] = new SqlParameter("@Salary", SqlDbType.Float);
            param[2].Value = Salary;

            param[3] = new SqlParameter("@TotalMerit", SqlDbType.Float);
            param[3].Value = TotalMerit;


            param[3] = new SqlParameter("@TotalDeduction", SqlDbType.Float);
            param[3].Value = TotalDeduction;



            param[3] = new SqlParameter("@Total", SqlDbType.Float);
            param[3].Value = Total;

            dal.ExecuteComand("addOverall", param);
            dal.close();
        }


        */

        public void addShift(int Client_id, DateTime Date, double MorningShift, double NightShift, double extra_shift, double over_shift, double no_of_staying_hours)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            param[1] = new SqlParameter("@_Date", SqlDbType.Date);
            param[1].Value = Date;

     
            param[2] = new SqlParameter("@MorningShift", SqlDbType.Float);
            param[2].Value = MorningShift;


            param[3] = new SqlParameter("@NightShift", SqlDbType.Float);
            param[3].Value = NightShift;


            param[4] = new SqlParameter("@extra_shift", SqlDbType.Float);
            param[4].Value = extra_shift;

            param[5] = new SqlParameter("@over_shift", SqlDbType.Float);
            param[5].Value = over_shift;


            param[6] = new SqlParameter("@no_of_staying_hours", SqlDbType.Float);
            param[6].Value = no_of_staying_hours;
            

            dal.ExecuteComand("addShift", param);
            dal.close();
        }


        public void add_overall(int Client_id, string client_name, string department, DateTime _Date, double Total, double no_of_am_shifts,
            double value_of_am_shift, double no_of_pm_shifts, double value_of_pm_shift,
            double extra, double over, double Incentives, double TotalMerit, double latenss, double value_of_latenss, int absence, double value_of_absence,
             double tax, double insurance, double loan, int id_department_and_role, double TotalDeduction, string month, string year, string client_sallary_state)
      
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[25];

            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            param[1] = new SqlParameter("@client_name", SqlDbType.VarChar,50);
            param[1].Value = client_name;


            param[2] = new SqlParameter("@department", SqlDbType.VarChar,50);
            param[2].Value = department;




            param[3] = new SqlParameter("@_Date", SqlDbType.Date);
            param[3].Value = _Date;

            param[4] = new SqlParameter("@Total", SqlDbType.Float);
            param[4].Value = Total;

            param[5] = new SqlParameter("@no_of_am_shifts", SqlDbType.Float);
            param[5].Value = no_of_am_shifts;


            param[6] = new SqlParameter("@value_of_am_shift", SqlDbType.Float);
            param[6].Value = value_of_am_shift;


            param[7] = new SqlParameter("@no_of_pm_shifts", SqlDbType.Float);
            param[7].Value = no_of_pm_shifts;

            param[8] = new SqlParameter("@value_of_pm_shift", SqlDbType.Float);
            param[8].Value = value_of_pm_shift;


            param[9] = new SqlParameter("@extra", SqlDbType.Float);
            param[9].Value = extra;


            param[10] = new SqlParameter("@over", SqlDbType.Float);
            param[10].Value = over;


            param[11] = new SqlParameter("@Incentives", SqlDbType.Float);
            param[11].Value = Incentives;

            param[12] = new SqlParameter("@TotalMerit", SqlDbType.Float);
            param[12].Value = TotalMerit;

            param[13] = new SqlParameter("@latenss", SqlDbType.Float);
            param[13].Value = latenss;


            param[14] = new SqlParameter("@value_of_latenss", SqlDbType.Float);
            param[14].Value = value_of_latenss;


            param[15] = new SqlParameter("@absence", SqlDbType.Int);
            param[15].Value = absence;

            param[16] = new SqlParameter("@value_of_absence", SqlDbType.Float);
            param[16].Value = value_of_absence;

            param[17] = new SqlParameter("@tax", SqlDbType.Float);
            param[17].Value = tax;


            param[18] = new SqlParameter("@insurance", SqlDbType.Float);
            param[18].Value = insurance;

            param[19] = new SqlParameter("@loan", SqlDbType.Float);
            param[19].Value = loan;

            param[20] = new SqlParameter("@id_department_and_role", SqlDbType.Int);
            param[20].Value = id_department_and_role;


            param[21] = new SqlParameter("@TotalDeduction", SqlDbType.Float);
            param[21].Value = TotalDeduction;


            param[22] = new SqlParameter("@month", SqlDbType.VarChar, 50);
            param[22].Value = month;


            param[23] = new SqlParameter("@year", SqlDbType.VarChar, 50);
            param[23].Value = year;




            param[24] = new SqlParameter("@client_sallary_state", SqlDbType.VarChar, 50);
            param[24].Value = client_sallary_state;


            dal.ExecuteComand("add_overall", param);
            dal.close();
        }

        public void addIncentives(int Client_id, double Incentives, int depart_role_id)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            param[1] = new SqlParameter("@Incentives", SqlDbType.Float);
            param[1].Value = Incentives;



            param[2] = new SqlParameter("@depart_role_id", SqlDbType.Int);
            param[2].Value = depart_role_id;


            dal.ExecuteComand("addIncentives", param);
            dal.close();
        }

        public void addtax(int Client_id, double Tax)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            param[1] = new SqlParameter("@Tax", SqlDbType.Float);
            param[1].Value = Tax;


            dal.ExecuteComand("addtax", param);
            dal.close();
        }










        public void add_piad_sallary(int client_id, DateTime date, double total_sallary,string month,string year)
            
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@client_id", SqlDbType.Int);
            param[0].Value = client_id;

            param[1] = new SqlParameter("@date", SqlDbType.Date);
            param[1].Value = date;

            param[2] = new SqlParameter("@total_sallary", SqlDbType.Float);
            param[2].Value = total_sallary;

            param[3] = new SqlParameter("@month", SqlDbType.VarChar,50);
            param[3].Value = month;


            param[4] = new SqlParameter("@year", SqlDbType.VarChar,50);
            param[4].Value = year;



            dal.ExecuteComand("add_piad_sallary", param);
            dal.close();
        }











    





        public void deleteclinet(int Client_id)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;



            dal.ExecuteComand("deleteclinet", param);
            dal.close();
        }

        public void delete_role_department(int @id_department_and_role)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_department_and_role", SqlDbType.Int);
            param[0].Value = id_department_and_role;



            dal.ExecuteComand("delete_role_department", param);
            dal.close();
        }

        public void deleteAllClients()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            dal.ExecuteComand("deleteAllClients", null);
            dal.close();
        
        }


        public void delete_constant(int @id_department_and_role)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_department_and_role", SqlDbType.Int);
            param[0].Value = id_department_and_role;
            dal.ExecuteComand("delete_constant", param);
            dal.close();
        
        }



        public DataTable getConstants(int id_department_and_role)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_department_and_role", SqlDbType.Int);
           param[0].Value = id_department_and_role;


            DataTable dt = new DataTable();
            dt = dal.selectData("getConstants", param);
            dal.close();
            return dt;

        }








        public DataTable search_in_client(string search_word)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search_word", SqlDbType.VarChar, 50);
            param[0].Value = search_word;


            DataTable dt = new DataTable();
            dt = dal.selectData("search_in_client", param);
            dal.close();
            return dt;

        }

        public DataTable get_client()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

        
            DataTable dt = new DataTable();
            dt = dal.selectData("get_client", null);
            dal.close();
            return dt;

        }

        public DataTable get_type_of_salary()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();


            DataTable dt = new DataTable();
            dt = dal.selectData("get_type_of_salary", null);
            dal.close();
            return dt;

        }



















        public DataTable get_number_of_staying_houres(int Client_id)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;


            DataTable dt = new DataTable();
            dt = dal.selectData("get_number_of_staying_houres", param);
            dal.close();
            return dt;

        }

















        public DataTable get_all_Constants()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

       

            DataTable dt = new DataTable();
            dt = dal.selectData("get_all_Constants", null);
            dal.close();
            return dt;

        }




        public DataTable get_other()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            DataTable dt = new DataTable();
            dt = dal.selectData("get_other", null);
            dal.close();
            return dt;

        }







        public DataTable get_other_with_client_id(int Client_id)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            DataTable dt = new DataTable();
            dt = dal.selectData("get_other_with_client_id", param);
            dal.close();
            return dt;

        }

        public DataTable get_depart_and_role_for_id(int id_department_and_role)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_department_and_role", SqlDbType.Int);
            param[0].Value = id_department_and_role;

            DataTable dt = new DataTable();
            dt = dal.selectData("get_depart_and_role_for_id", param);
            dal.close();
            return dt;

        }




        public DataTable get_other_with_client_id_and_btween_two_date(int Client_id, DateTime from_date, DateTime to_date)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            param[1] = new SqlParameter("@from_date", SqlDbType.DateTime);
            param[1].Value = from_date;

            param[2] = new SqlParameter("@to_date", SqlDbType.DateTime);
            param[2].Value = to_date;

            DataTable dt = new DataTable();
            dt = dal.selectData("get_other_with_client_id_and_btween_two_date", param);
            dal.close();
            return dt;

        }







        public DataTable get_incentives(int depart_role_id)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@depart_role_id", SqlDbType.Int);
            param[0].Value = depart_role_id;


            DataTable dt = new DataTable();
            dt = dal.selectData("get_incentives", param);
            dal.close();
            return dt;

        }

        
            
        public DataTable get_id_of_deparment_and_role(string department, string role)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@department", SqlDbType.VarChar,50);
            param[0].Value = department;

            param[1] = new SqlParameter("@role", SqlDbType.VarChar,50);
            param[1].Value = role;

            DataTable dt = new DataTable();
            dt = dal.selectData("get_id_of_deparment_and_role", param);
            dal.close();
            return dt;

        }


        public DataTable get_sallary_with_client_id(int Client_id)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            DataTable dt = new DataTable();
            dt = dal.selectData("get_sallary_with_client_id", param);
            dal.close();
            return dt;

        }


        public DataTable get_value_of_stay_with_client_id(int Client_id)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            DataTable dt = new DataTable();
            dt = dal.selectData("get_value_of_stay_with_client_id", param);
            dal.close();
            return dt;

        }












        public DataTable get_clints_that_received_them_salary_for_month_and_year(string month,string year)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@month", SqlDbType.VarChar, 50);
            param[0].Value = month;

            param[1] = new SqlParameter("@year", SqlDbType.VarChar, 50);
            param[1].Value = year;



            DataTable dt = new DataTable();
            dt = dal.selectData("get_clints_that_received_them_salary_for_month_and_year", param);
            dal.close();
            return dt;

        }






        public DataTable get_clints_that_not_received_them_salary_for_month_and_year(string month, string year, string client_sallary_state)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@month", SqlDbType.VarChar, 50);
            param[0].Value = month;

            param[1] = new SqlParameter("@year", SqlDbType.VarChar, 50);
            param[1].Value = year;

            param[2] = new SqlParameter("@client_sallary_state", SqlDbType.VarChar, 50);
            param[2].Value = client_sallary_state;
             


            DataTable dt = new DataTable();
            dt = dal.selectData("get_clints_that_not_received_them_salary_for_month_and_year", param);
            dal.close();
            return dt;

        }




























        public DataTable get_all_we_need_about_client()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
           

            DataTable dt = new DataTable();
            dt = dal.selectData("get_all_we_need_about_client", null);
            dal.close();
            return dt;

        }

        public DataTable get_month_and_year()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];


            DataTable dt = new DataTable();
            dt = dal.selectData("get_month_and_year", null);
            dal.close();
            return dt;

        }






        public DataTable get_role_and_department()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("get_role_and_department", null);
            dal.close();
            return dt;

        }

        

        public DataTable get_last_client_id()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("get_last_client_id", null);
            dal.close();
            return dt;

        }

    





        public DataTable get_ins_for_id(int client_id)
            
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0]=new SqlParameter("@client_id",SqlDbType.Int);
            param[0].Value=client_id;


            DataTable dt = new DataTable();
            dt = dal.selectData("get_ins_for_id", param);
            dal.close();
            return dt;

        }




        public DataTable get_salary_for_tax(int client_id)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@client_id", SqlDbType.Int);
            param[0].Value = client_id;


            DataTable dt = new DataTable();
            dt = dal.selectData("get_salary_for_tax", param);
            dal.close();
            return dt;

        }











        public DataTable print_sallary_of_depart(string department)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@department", SqlDbType.VarChar, 50);
            param[0].Value = department;

            DataTable dt = new DataTable();
            dt = dal.selectData("print_sallary_of_depart", param);
            dal.close();
            return dt;

        }





        public DataTable getCleint()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("getCleint", null);
            dal.close();
            return dt;

        }

        public DataTable getDeduction()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("getDeduction", null);
            dal.close();
            return dt;

        }



        public DataTable getMerit()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("getMerit", null);
            dal.close();
            return dt;

        }



        public DataTable getOverall()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("getOverall", null);
            dal.close();
            return dt;

        }


        public DataTable getShift()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("getShift", null);
            dal.close();
            return dt;

        }
        public DataTable search_in_clients(string search_word)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("search_word", SqlDbType.VarChar, 50);
            param[0].Value = search_word;
            dt = dal.selectData("search_in_clients", param);

            return dt;

        }






        public void updateClinet(string Name, int id_department_and_role, double salary, string type_of_sallary, double value_of_stay, int Client_id)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
          
            param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            param[0].Value = Name;



            param[1] = new SqlParameter("@id_department_and_role", SqlDbType.Int);
            param[1].Value = id_department_and_role;

            param[2] = new SqlParameter("@salary", SqlDbType.Float);
            param[2].Value = salary;

            param[3] = new SqlParameter("@type_of_sallary", SqlDbType.VarChar , 50);
            param[3].Value = type_of_sallary;

            param[4] = new SqlParameter("@value_of_stay", SqlDbType.Float);
            param[4].Value = value_of_stay;


            param[5] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[5].Value = Client_id;
            dal.ExecuteComand("updateClinet", param);
            dal.close();

        }







        public void update_client_sallary_state(int Client_id, string month, string year, string client_sallary_state)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            param[1] = new SqlParameter("@month", SqlDbType.VarChar, 50);
            param[1].Value = month;

            param[2] = new SqlParameter("@year", SqlDbType.VarChar, 50);
            param[2].Value = year;

            param[3] = new SqlParameter("@client_sallary_state", SqlDbType.VarChar, 50);
            param[3].Value = client_sallary_state;


            dal.ExecuteComand("update_client_sallary_state", param);
            dal.close();

        }



















        public void updateDeduction(DateTime _Date, double Lateness, double Loan, double Insurance, double Tax, int Absence, int Client_id)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@_Date", SqlDbType.Date);
            param[0].Value = _Date;

            param[1] = new SqlParameter("@Lateness", SqlDbType.Float);
            param[1].Value = Lateness;

            param[2] = new SqlParameter("@Loan", SqlDbType.Float);
            param[2].Value = Loan;

            param[3] = new SqlParameter("@Insurance", SqlDbType.Float);
            param[3].Value = Insurance;

            param[4] = new SqlParameter("@Tax", SqlDbType.Float);
            param[4].Value = Tax;


            param[5] = new SqlParameter("@Absence", SqlDbType.Int);
            param[5].Value = Absence;

            param[6] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[6].Value = Client_id;



            dal.ExecuteComand("updateDeduction", param);
            dal.close();


        }

        public void update_consatant( double new_insurance, double old_insurance, double morning_shift, double night_shift, double Incentives,int id_department_and_role)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_department_and_role", SqlDbType.Int);
            param[0].Value = id_department_and_role;

            param[1] = new SqlParameter("@new_insurance", SqlDbType.Float);
            param[1].Value = new_insurance;

            param[2] = new SqlParameter("@old_insurance", SqlDbType.Float);
            param[2].Value = old_insurance;

            param[3] = new SqlParameter("@morning_shift", SqlDbType.Float);
            param[3].Value = morning_shift;

            param[4] = new SqlParameter("@night_shift", SqlDbType.Float);
            param[4].Value = night_shift;


            param[5] = new SqlParameter("@Incentives", SqlDbType.Float);
            param[5].Value = Incentives;


            dal.ExecuteComand("update_consatant", param);
            dal.close();


        }

        public void update_tax_for_month(DateTime curent_date, int client_id, double tax)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[2] = new SqlParameter("@curent_date", SqlDbType.Date);
            param[2].Value = curent_date;



            param[1] = new SqlParameter("@client_id", SqlDbType.Int);
            param[1].Value = client_id;


            param[0] = new SqlParameter("@tax", SqlDbType.Float);
            param[0].Value = tax;


            dal.ExecuteComand("update_tax_for_month", param);
            dal.close();


        }

        public void update_role_and_department(string role, string department, int @id_department_and_role)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@role", SqlDbType.VarChar, 50);
            param[0].Value = role;


            param[1] = new SqlParameter("@department", SqlDbType.VarChar, 50);
            param[1].Value = department;

            param[2] = new SqlParameter("@id_department_and_role", SqlDbType.Int);
            param[2].Value = @id_department_and_role;




            dal.ExecuteComand("update_role_and_department", param);
            dal.close();


        }




        public void updateMerit(int Client_id, DateTime Date, double Salary, double TotalMerit, double TotalDeduction, double Total)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            param[1] = new SqlParameter("@Date", SqlDbType.Date);
            param[1].Value = Date;

            param[2] = new SqlParameter("@Salary", SqlDbType.Float);
            param[2].Value = Salary;

            param[3] = new SqlParameter("@TotalMerit", SqlDbType.Float);
            param[3].Value = TotalMerit;


            param[3] = new SqlParameter("@TotalDeduction", SqlDbType.Float);
            param[3].Value = TotalDeduction;



            param[3] = new SqlParameter("@Total", SqlDbType.Float);
            param[3].Value = Total;

            dal.ExecuteComand("updateMerit", param);
            dal.close();
        }

        public void updateShift(int Client_id, DateTime _Date, double MorningShift, double NightShift, double extra_shift, double over_shift, double no_of_staying_hours)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;

            param[1] = new SqlParameter("@_Date", SqlDbType.Date);
            param[1].Value = _Date;


            param[2] = new SqlParameter("@MorningShift", SqlDbType.Float);
            param[2].Value = MorningShift;


            param[3] = new SqlParameter("@NightShift", SqlDbType.Float);
            param[3].Value = NightShift;

            param[4] = new SqlParameter("@extra_shift", SqlDbType.Float);
            param[4].Value = extra_shift;

            param[5] = new SqlParameter("@over_shift", SqlDbType.Float);
            param[5].Value = over_shift;


            param[6] = new SqlParameter("@no_of_staying_hours", SqlDbType.Float);
            param[6].Value = no_of_staying_hours;
            

            dal.ExecuteComand("updateShift", param);
            dal.close();
        }


        public void update_others(string additions, double value_of_additions,string fans,
            double value_of_fans, double other, string reaseon_of_other, int Client_id, DateTime date_of_other)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@additions", SqlDbType.VarChar, 50);
            param[0].Value = additions;


            param[1] = new SqlParameter("@value_of_additions", SqlDbType.Float);
            param[1].Value = value_of_additions;


            param[2] = new SqlParameter("@fans", SqlDbType.VarChar, 50);
            param[2].Value = fans;


            param[3] = new SqlParameter("@value_of_fans", SqlDbType.Float);
            param[3].Value = value_of_fans;


            param[4] = new SqlParameter("@other", SqlDbType.Float);
            param[4].Value = other;


            param[5] = new SqlParameter("@reaseon_of_other", SqlDbType.VarChar, 50);
            param[5].Value = reaseon_of_other;


            param[6] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[6].Value = Client_id;

            param[7] = new SqlParameter("@date_of_other", SqlDbType.Date);
            param[7].Value = date_of_other;


            dal.ExecuteComand("update_others", param);
            dal.close();
        }









        public DataTable get_salary_to_calc_absence(int Client_id)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
          
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Client_id", SqlDbType.Int);
            param[0].Value = Client_id;


            DataTable dt = new DataTable();
            dt = dal.selectData("get_salary_to_calc_absence", param);
            dal.close();
            return dt;

        }


        public DataTable get_id_of_dept_and_role(string department, string role)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@department", SqlDbType.VarChar, 50);
            param[0].Value = department;

            param[1] = new SqlParameter("@role", SqlDbType.VarChar, 50);
            param[1].Value = role;
            DataTable dt = new DataTable();
            dt = dal.selectData("get_id_of_dept_and_role", param);
            dal.close();
            return dt;

        }






        public void addConstants(int id_department_and_role, double new_insurance, double old_insurance, double morning_shift, double night_shift, double Incentives)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_department_and_role", SqlDbType.Int);
            param[0].Value = id_department_and_role;


            param[1] = new SqlParameter("@new_insurance", SqlDbType.Float);
            param[1].Value = new_insurance;

            param[2] = new SqlParameter("@old_insurance", SqlDbType.Float);
            param[2].Value = old_insurance;

            param[3] = new SqlParameter("@morning_shift", SqlDbType.Float);
            param[3].Value = morning_shift;



            param[4] = new SqlParameter("@night_shift", SqlDbType.Float);
            param[4].Value = night_shift;



            param[5] = new SqlParameter("@Incentives", SqlDbType.Float);
            param[5].Value = Incentives;


            dal.ExecuteComand("addConstant_without_clinet_id", param);
            dal.close();


        }






    }
}
