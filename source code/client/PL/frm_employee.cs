using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace client.PL
{
    public partial class frm_employee : Form
    {
        SqlConnection con = new SqlConnection();

         

        void clearboxees()
        {
            txt_am_shift_number.Clear();
            txt_pm_shift_number.Clear();
            txt_over.Clear();
            txt_loan.Clear();
            txt_Incentives.Clear();
            txt_tax.Clear();
            txt_lateness.Clear();
            txt_extra.Clear();
            txt_last_salary.Clear();
            txt_lateness_value.Clear();
            txt_pm_shift_value.Clear();
            txt_am_shift_value.Clear(); 
            txt_all_deduction.Clear();
            txt_all_merit.Clear();
            txt_absence.Clear();
            txt_absence_value.Clear();
            txt_emp_id.Clear();
            txt_emp_name.Clear();
   
            
           
        
        
        }
        private static frm_employee emp;
        static void empClosed(object sender, FormClosedEventArgs e)
        {
            emp = null;

        }
        public static frm_employee myform
        {
            get
            {
                if (emp == null)
                {
                    emp = new frm_employee();
                    emp.FormClosed += new FormClosedEventHandler(empClosed);
                }
                return emp;
            }

        }
        

        BL.Client client = new BL.Client();
        public frm_employee()
        {
            InitializeComponent();
            if (emp == null)
            {
                emp = this;
            }
            rd_add.Checked = true;
            txt_no_of_staying_hours.Text = "0";

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; DataBase=" + Properties.Settings.Default.DataBase + ";Integrated security = false; User ID=" + Properties.Settings.Default.User_Name + ";password=" + Properties.Settings.Default.Password + "");

        private void frm_employee_Load(object sender, EventArgs e)
        {
            using (
       con =new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; DataBase=" + Properties.Settings.Default.DataBase + ";Integrated security = false; User ID=" + Properties.Settings.Default.User_Name + ";password=" + Properties.Settings.Default.Password + "")
)
            {
                SqlCommand cmd = new SqlCommand("Select Name From Client",con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                txt_client_search.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
        


            orginalSize = this.Size;
            label9OrginalArea = new Rectangle(label9.Location.X, label9.Location.Y, label9.Width, label9.Height);
            emp_idOrginalArea = new Rectangle(emp_id.Location.X, emp_id.Location.Y, emp_id.Width, emp_id.Height);
            txt_emp_idOrginalArea = new Rectangle(txt_emp_id.Location.X, txt_emp_id.Location.Y, txt_emp_id.Width, txt_emp_id.Height);
            label3OrginalArea = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            txt_emp_nameOrginalArea = new Rectangle(txt_emp_name.Location.X, txt_emp_name.Location.Y, txt_emp_name.Width, txt_emp_name.Height);
            label8OrginalArea = new Rectangle(label8.Location.X, label8.Location.Y, label8.Width, label8.Height);
            combo_roleOrginalArea = new Rectangle(combo_role.Location.X, combo_role.Location.Y, combo_role.Width, combo_role.Height);
            label7OrginalArea = new Rectangle(label7.Location.X, label7.Location.Y, label7.Width, label7.Height);
            combo_departmentOrginalArea = new Rectangle(combo_department.Location.X, combo_department.Location.Y, combo_department.Width, combo_department.Height);
            label31OrginalArea = new Rectangle(label31.Location.X, label31.Location.Y, label31.Width, label31.Height);
            combo_type_of_salaryOrginalArea = new Rectangle(combo_type_of_salary.Location.X, combo_type_of_salary.Location.Y, combo_type_of_salary.Width, combo_type_of_salary.Height);
            label30OrginalArea = new Rectangle(label30.Location.X, label30.Location.Y, label30.Width, label30.Height);
            txt_salaryOrginalArea = new Rectangle(txt_salary.Location.X, txt_salary.Location.Y, txt_salary.Width, txt_salary.Height);
            label29OrginalArea = new Rectangle(label29.Location.X, label29.Location.Y, label29.Width, label29.Height);
            txt_value_of_stayOrginalArea = new Rectangle(txt_value_of_stay.Location.X, txt_value_of_stay.Location.Y, txt_value_of_stay.Width, txt_value_of_stay.Height);
            groupBox1OrginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            groupBox3OrginalArea = new Rectangle(groupBox3.Location.X, groupBox3.Location.Y, groupBox3.Width, groupBox3.Height);
            groupBox21OrginalArea = new Rectangle(groupBox2.Location.X, groupBox2.Location.Y, groupBox2.Width, groupBox2.Height);
            label25OrginalArea = new Rectangle(label25.Location.X, label25.Location.Y, label25.Width, label25.Height);
            txt_last_salaryOrginalArea = new Rectangle(txt_last_salary.Location.X, txt_last_salary.Location.Y, txt_last_salary.Width, txt_last_salary.Height);
            groupBox13OrginalArea = new Rectangle(groupBox13.Location.X, groupBox13.Location.Y, groupBox13.Width, groupBox13.Height);
            button5OrginalArea = new Rectangle(button5.Location.X, button5.Location.Y, button5.Width, button5.Height);
            txt_monthOrginalArea = new Rectangle(txt_month.Location.X, txt_month.Location.Y, txt_month.Width, txt_month.Height);
            txt_yearOrginalArea = new Rectangle(txt_year.Location.X, txt_year.Location.Y, txt_year.Width, txt_year.Height);
            dateTimePicker1OrginalArea = new Rectangle(dateTimePicker1.Location.X, dateTimePicker1.Location.Y, dateTimePicker1.Width, dateTimePicker1.Height);
            groupBox15OrginalArea = new Rectangle(groupBox15.Location.X, groupBox15.Location.Y, groupBox15.Width, groupBox15.Height);
            label10OrginalArea = new Rectangle(label10.Location.X, label10.Location.Y, label10.Width, label10.Height);
            txt_client_searchOrginalArea = new Rectangle(txt_client_search.Location.X, txt_client_search.Location.Y, txt_client_search.Width, txt_client_search.Height);
            groupBox12OrginalArea = new Rectangle(groupBox12.Location.X, groupBox12.Location.Y, groupBox12.Width, groupBox12.Height);
            groupBox16OrginalArea = new Rectangle(groupBox16.Location.X, groupBox16.Location.Y, groupBox16.Width, groupBox16.Height);
            label32OrginalArea = new Rectangle(label32.Location.X, label32.Location.Y, label32.Width, label32.Height);
            txt_no_of_staying_hoursOrginalArea = new Rectangle(txt_no_of_staying_hours.Location.X, txt_no_of_staying_hours.Location.Y, txt_no_of_staying_hours.Width, txt_no_of_staying_hours.Height);
            label33OrginalArea = new Rectangle(label33.Location.X, label33.Location.Y, label33.Width, label33.Height);
            txt_addsOrginalArea = new Rectangle(txt_adds.Location.X, txt_adds.Location.Y, txt_adds.Width, txt_adds.Height);
            label34OrginalArea = new Rectangle(label34.Location.X, label34.Location.Y, label34.Width, label34.Height);
            txt_type_of_addsOrginalArea = new Rectangle(txt_type_of_adds.Location.X, txt_type_of_adds.Location.Y, txt_type_of_adds.Width, txt_type_of_adds.Height);
            label35OrginalArea = new Rectangle(label35.Location.X, label35.Location.Y, label35.Width, label35.Height);
            txt_fansOrginalArea = new Rectangle(txt_fans.Location.X, txt_fans.Location.Y, txt_fans.Width, txt_fans.Height);
            label36OrginalArea = new Rectangle(label36.Location.X, label36.Location.Y, label36.Width, label36.Height);
            txt_type_of_fansOrginalArea = new Rectangle(txt_type_of_fans.Location.X, txt_type_of_fans.Location.Y, txt_type_of_fans.Width, txt_type_of_fans.Height);
            groupBox17OrginalArea = new Rectangle(groupBox17.Location.X, groupBox17.Location.Y, groupBox17.Width, groupBox17.Height);
            label37OrginalArea = new Rectangle(label37.Location.X, label37.Location.Y, label37.Width, label37.Height);
            txt_otherOrginalArea = new Rectangle(txt_other.Location.X, txt_other.Location.Y, txt_other.Width, txt_other.Height);
            rd_fansOrginalArea = new Rectangle(rd_fans.Location.X, rd_fans.Location.Y, rd_fans.Width, rd_fans.Height);
            rd_addOrginalArea = new Rectangle(rd_add.Location.X, rd_add.Location.Y, rd_add.Width, rd_add.Height);
            txt_type_of_otherOrginalArea = new Rectangle(txt_type_of_other.Location.X, txt_type_of_other.Location.Y, txt_type_of_other.Width, txt_type_of_other.Height);
            label38OrginalArea = new Rectangle(label38.Location.X, label38.Location.Y, label38.Width, label38.Height);
           btn_save_salaryOrginalArea = new Rectangle(btn_save_salary.Location.X, btn_save_salary.Location.Y, btn_save_salary.Width, btn_save_salary.Height);
           groupBox10OrginalArea = new Rectangle(groupBox10.Location.X, groupBox10.Location.Y, groupBox10.Width, groupBox10.Height);
           btn_addOrginalArea = new Rectangle(btn_add.Location.X, btn_add.Location.Y, btn_add.Width, btn_add.Height);
           btn_saveOrginalArea = new Rectangle(btn_save.Location.X, btn_save.Location.Y, btn_save.Width, btn_save.Height);
           btn_editOrginalArea = new Rectangle(btn_edit.Location.X, btn_edit.Location.Y, btn_edit.Width, btn_edit.Height);
           btn_deleteOrginalArea = new Rectangle(btn_delete.Location.X, btn_delete.Location.Y, btn_delete.Width, btn_delete.Height);
           btn_exitOrginalArea = new Rectangle(btn_exit.Location.X, btn_exit.Location.Y, btn_exit.Width, btn_exit.Height);
           groupBox4OrginalArea = new Rectangle(groupBox4.Location.X, groupBox4.Location.Y, groupBox4.Width, groupBox4.Height);
           label11OrginalArea = new Rectangle(label11.Location.X, label11.Location.Y, label11.Width, label11.Height);
           label12OrginalArea = new Rectangle(label12.Location.X, label12.Location.Y, label12.Width, label12.Height);
           txt_am_shift_numberOrginalArea = new Rectangle(txt_am_shift_number.Location.X, txt_am_shift_number.Location.Y, txt_am_shift_number.Width, txt_am_shift_number.Height);
           label15OrginalArea = new Rectangle(label15.Location.X, label15.Location.Y, label15.Width, label15.Height);
           txt_am_shift_valueOrginalArea = new Rectangle(txt_am_shift_value.Location.X, txt_am_shift_value.Location.Y, txt_am_shift_value.Width, txt_am_shift_value.Height);
           label19OrginalArea = new Rectangle(label19.Location.X, label19.Location.Y, label19.Width, label19.Height);
           txt_pm_shift_numberOrginalArea = new Rectangle(txt_pm_shift_number.Location.X, txt_pm_shift_number.Location.Y, txt_pm_shift_number.Width, txt_pm_shift_number.Height);
           label14OrginalArea = new Rectangle(label14.Location.X, label14.Location.Y, label14.Width, label14.Height);
           txt_pm_shift_valueOrginalArea = new Rectangle(txt_pm_shift_value.Location.X, txt_pm_shift_value.Location.Y, txt_pm_shift_value.Width, txt_pm_shift_value.Height);
           label24OrginalArea = new Rectangle(label24.Location.X, label24.Location.Y, label24.Width, label24.Height);
           txt_extraOrginalArea = new Rectangle(txt_extra.Location.X, txt_extra.Location.Y, txt_extra.Width, txt_extra.Height);
           label26OrginalArea = new Rectangle(label26.Location.X, label26.Location.Y, label26.Width, label26.Height);
           txt_overOrginalArea = new Rectangle(txt_over.Location.X, txt_over.Location.Y, txt_over.Width, txt_over.Height);
           label5OrginalArea = new Rectangle(label5.Location.X, label5.Location.Y, label5.Width, label5.Height);
           txt_IncentivesOrginalArea = new Rectangle(txt_Incentives.Location.X, txt_Incentives.Location.Y, txt_Incentives.Width, txt_Incentives.Height);
           label13OrginalArea = new Rectangle(label13.Location.X, label13.Location.Y, label13.Width, label13.Height);
           txt_all_meritOrginalArea = new Rectangle(txt_all_merit.Location.X, txt_all_merit.Location.Y, txt_all_merit.Width, txt_all_merit.Height);
           groupBox5OrginalArea = new Rectangle(groupBox5.Location.X, groupBox5.Location.Y, groupBox5.Width, groupBox5.Height);
           groupBox6OrginalArea = new Rectangle(groupBox6.Location.X, groupBox6.Location.Y, groupBox6.Width, groupBox6.Height);
           groupBox7OrginalArea = new Rectangle(groupBox7.Location.X, groupBox7.Location.Y, groupBox7.Width, groupBox7.Height);
           label16OrginalArea = new Rectangle(label16.Location.X, label16.Location.Y, label16.Width, label16.Height);
           label20OrginalArea = new Rectangle(label20.Location.X, label20.Location.Y, label20.Width, label20.Height);
           txt_latenessOrginalArea = new Rectangle(txt_lateness.Location.X, txt_lateness.Location.Y, txt_lateness.Width, txt_lateness.Height);
           label21OrginalArea = new Rectangle(label21.Location.X, label21.Location.Y, label21.Width, label21.Height);
           txt_lateness_valueOrginalArea = new Rectangle(txt_lateness_value.Location.X, txt_lateness_value.Location.Y, txt_lateness_value.Width, txt_lateness_value.Height);
           label22OrginalArea = new Rectangle(label22.Location.X, label22.Location.Y, label22.Width, label22.Height);
           txt_absenceOrginalArea = new Rectangle(txt_absence.Location.X, txt_absence.Location.Y, txt_absence.Width, txt_absence.Height);
           label18OrginalArea = new Rectangle(label18.Location.X, label18.Location.Y, label18.Width, label18.Height);
           txt_absence_valueOrginalArea = new Rectangle(txt_absence_value.Location.X, txt_absence_value.Location.Y, txt_absence_value.Width, txt_absence_value.Height);
           label17OrginalArea = new Rectangle(label17.Location.X, label17.Location.Y, label17.Width, label17.Height);
           txt_taxOrginalArea = new Rectangle(txt_tax.Location.X, txt_tax.Location.Y, txt_tax.Width, txt_tax.Height);
           check_oldOrginalArea = new Rectangle(check_old.Location.X, check_old.Location.Y, check_old.Width, check_old.Height);
           check_newOrginalArea = new Rectangle(txt_no_of_staying_hours.Location.X, txt_no_of_staying_hours.Location.Y, txt_no_of_staying_hours.Width, txt_no_of_staying_hours.Height);
           label4OrginalArea = new Rectangle(label4.Location.X, label4.Location.Y, label4.Width, label4.Height);
           txt_emp_insuranceOrginalArea = new Rectangle(txt_emp_insurance.Location.X, txt_emp_insurance.Location.Y, txt_emp_insurance.Width, txt_emp_insurance.Height);
           label6OrginalArea = new Rectangle(label6.Location.X, label6.Location.Y, label6.Width, label6.Height);
           txt_loanOrginalArea = new Rectangle(txt_loan.Location.X, txt_loan.Location.Y, txt_loan.Width, txt_loan.Height);
           label23OrginalArea = new Rectangle(label23.Location.X, label23.Location.Y, label23.Width, label23.Height);
           txt_all_deductionOrginalArea = new Rectangle(txt_all_deduction.Location.X, txt_all_deduction.Location.Y, txt_all_deduction.Width, txt_all_deduction.Height);
           groupBox11OrginalArea = new Rectangle(groupBox11.Location.X, groupBox11.Location.Y, groupBox11.Width, groupBox11.Height);
           dataGridView1OrginalArea = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);

           groupBox9OrginalArea = new Rectangle(groupBox9.Location.X, groupBox9.Location.Y, groupBox9.Width, groupBox9.Height);
           groupBox14OrginalArea = new Rectangle(groupBox14.Location.X, groupBox14.Location.Y, groupBox14.Width, groupBox14.Height);


             
          
        }






        private Rectangle groupBox9OrginalArea;
        private Rectangle label9OrginalArea;
        private Rectangle emp_idOrginalArea;
        private Rectangle txt_emp_idOrginalArea;
        private Rectangle label3OrginalArea;
        private Rectangle txt_emp_nameOrginalArea;
        private Rectangle label8OrginalArea;
        private Rectangle combo_roleOrginalArea;
        private Rectangle label7OrginalArea;
        private Rectangle combo_departmentOrginalArea;
        private Rectangle label31OrginalArea;
        private Rectangle combo_type_of_salaryOrginalArea;
        private Rectangle label30OrginalArea;
        private Rectangle txt_salaryOrginalArea;
        private Rectangle label29OrginalArea;
        private Rectangle txt_value_of_stayOrginalArea;
        private Rectangle groupBox1OrginalArea;
        private Rectangle groupBox3OrginalArea;
        private Rectangle groupBox21OrginalArea;
        private Rectangle label25OrginalArea;
        private Rectangle txt_last_salaryOrginalArea;
        private Rectangle groupBox13OrginalArea;
        private Rectangle button5OrginalArea;
        private Rectangle txt_monthOrginalArea;
        private Rectangle txt_yearOrginalArea;
        private Rectangle groupBox15OrginalArea;
        private Rectangle dateTimePicker1OrginalArea;
        private Rectangle label10OrginalArea;
        private Rectangle txt_client_searchOrginalArea;
        private Rectangle groupBox12OrginalArea;
        private Rectangle groupBox16OrginalArea;
        private Rectangle label32OrginalArea;
        private Rectangle txt_no_of_staying_hoursOrginalArea;
        private Rectangle label33OrginalArea;
        private Rectangle txt_addsOrginalArea;
        private Rectangle label34OrginalArea;
        private Rectangle txt_type_of_addsOrginalArea;
        private Rectangle label35OrginalArea;
        private Rectangle txt_fansOrginalArea;
        private Rectangle label36OrginalArea;
        private Rectangle txt_type_of_fansOrginalArea;
        private Rectangle groupBox17OrginalArea;
        private Rectangle label37OrginalArea;
        private Rectangle txt_otherOrginalArea;
        private Rectangle rd_fansOrginalArea;
        private Rectangle rd_addOrginalArea;
        private Rectangle txt_type_of_otherOrginalArea;
        private Rectangle label38OrginalArea;
        private Rectangle btn_save_salaryOrginalArea;
        private Rectangle groupBox10OrginalArea;
        private Rectangle btn_addOrginalArea;
        private Rectangle btn_saveOrginalArea;
        private Rectangle btn_editOrginalArea;
        private Rectangle btn_deleteOrginalArea;
        private Rectangle btn_exitOrginalArea;
        private Rectangle groupBox4OrginalArea;
        private Rectangle label11OrginalArea;
        private Rectangle label12OrginalArea;
        private Rectangle txt_am_shift_numberOrginalArea;
        private Rectangle label15OrginalArea;
        private Rectangle txt_am_shift_valueOrginalArea;
        private Rectangle label19OrginalArea;
        private Rectangle txt_pm_shift_numberOrginalArea;
        private Rectangle label14OrginalArea;
        private Rectangle txt_pm_shift_valueOrginalArea;
        private Rectangle label24OrginalArea;
        private Rectangle txt_extraOrginalArea;
        private Rectangle label26OrginalArea;
        private Rectangle txt_overOrginalArea;
        private Rectangle label5OrginalArea;
        private Rectangle txt_IncentivesOrginalArea;
        private Rectangle label13OrginalArea;
        private Rectangle txt_all_meritOrginalArea;
        private Rectangle groupBox5OrginalArea;
        private Rectangle groupBox6OrginalArea;
        private Rectangle groupBox7OrginalArea;
        private Rectangle label16OrginalArea;
        private Rectangle label20OrginalArea;
        private Rectangle txt_latenessOrginalArea;
        private Rectangle label21OrginalArea;
        private Rectangle txt_lateness_valueOrginalArea;
        private Rectangle label22OrginalArea;
        private Rectangle txt_absenceOrginalArea;
        private Rectangle label18OrginalArea;
        private Rectangle txt_absence_valueOrginalArea;
        private Rectangle label17OrginalArea;
        private Rectangle txt_taxOrginalArea;
        private Rectangle check_oldOrginalArea;
        private Rectangle check_newOrginalArea;
        private Rectangle label4OrginalArea;
        private Rectangle txt_emp_insuranceOrginalArea;
        private Rectangle label6OrginalArea;
        private Rectangle txt_loanOrginalArea;
        private Rectangle label23OrginalArea;
        private Rectangle txt_all_deductionOrginalArea;
        private Rectangle groupBox11OrginalArea;
        private Rectangle dataGridView1OrginalArea;
        private Rectangle groupBox14OrginalArea;
        
        private Size orginalSize;

        
        private void resizeControlers()
        {


            resizeControler(groupBox14OrginalArea, groupBox14);
            resizeControler(groupBox9OrginalArea, groupBox9);
            resizeControler(label9OrginalArea, label9);
            resizeControler(emp_idOrginalArea, emp_id);
            resizeControler(txt_emp_idOrginalArea, txt_emp_id);
            resizeControler(label3OrginalArea, label3);
            resizeControler(txt_emp_nameOrginalArea, txt_emp_name);
            resizeControler(button5OrginalArea, button5);
            resizeControler(label8OrginalArea, label8);
            resizeControler(combo_roleOrginalArea, combo_role);
            resizeControler(label7OrginalArea, label7);
            resizeControler(combo_departmentOrginalArea, combo_department);
            resizeControler(label31OrginalArea, label31);
            resizeControler(combo_type_of_salaryOrginalArea, combo_type_of_salary);
            resizeControler(label30OrginalArea, label30);
            resizeControler(txt_salaryOrginalArea, txt_salary);
            resizeControler(label29OrginalArea, label29);
            resizeControler(txt_value_of_stayOrginalArea, txt_value_of_stay);
            resizeControler(groupBox1OrginalArea, groupBox1);
            resizeControler(groupBox3OrginalArea, groupBox3);
            resizeControler(groupBox21OrginalArea, groupBox2);
            resizeControler(label25OrginalArea, label25);
            resizeControler(txt_last_salaryOrginalArea, txt_last_salary);
            resizeControler(groupBox13OrginalArea, groupBox13);
            resizeControler(button5OrginalArea, button5);
            resizeControler(txt_monthOrginalArea, txt_month);
            resizeControler(txt_yearOrginalArea, txt_year);
            resizeControler(groupBox15OrginalArea, groupBox15);
            resizeControler(dateTimePicker1OrginalArea, dateTimePicker1);
            resizeControler(label10OrginalArea, label10);
            resizeControler(txt_client_searchOrginalArea, txt_client_search);
            resizeControler(groupBox12OrginalArea, groupBox12);
            resizeControler(groupBox16OrginalArea, groupBox16);
            resizeControler(label32OrginalArea, label32);
            resizeControler(txt_no_of_staying_hoursOrginalArea, txt_no_of_staying_hours);
            resizeControler(label33OrginalArea, label33);
            resizeControler(txt_addsOrginalArea, txt_adds);
            resizeControler(label34OrginalArea, label34);
            resizeControler(txt_type_of_addsOrginalArea, txt_type_of_adds);
            resizeControler(label35OrginalArea, label35);
            resizeControler(txt_fansOrginalArea, txt_fans);
            resizeControler(label36OrginalArea, label36);
            resizeControler(txt_type_of_fansOrginalArea, txt_type_of_fans);
            resizeControler(groupBox17OrginalArea, groupBox17);
            resizeControler(label37OrginalArea, label37);
            resizeControler(txt_otherOrginalArea, txt_other);
            resizeControler(rd_fansOrginalArea, rd_fans);
            resizeControler(rd_addOrginalArea, rd_add);
            resizeControler(txt_type_of_otherOrginalArea, txt_type_of_other);
            resizeControler(label38OrginalArea, label38);
            resizeControler(btn_save_salaryOrginalArea, btn_save_salary);
            resizeControler(groupBox10OrginalArea, groupBox10);
            resizeControler(btn_addOrginalArea, btn_add);
            resizeControler(btn_saveOrginalArea, btn_save);
            resizeControler(btn_editOrginalArea, btn_edit);
            resizeControler(btn_deleteOrginalArea, btn_delete);
            resizeControler(btn_exitOrginalArea, btn_exit);
            resizeControler(groupBox4OrginalArea, groupBox4);
            resizeControler(label11OrginalArea, label11);
            resizeControler(label12OrginalArea, label12);
            resizeControler(txt_am_shift_numberOrginalArea, txt_am_shift_number);
            resizeControler(label15OrginalArea, label15);
            resizeControler(txt_am_shift_valueOrginalArea, txt_am_shift_value);
            resizeControler(label19OrginalArea, label19);
            resizeControler(txt_pm_shift_numberOrginalArea, txt_pm_shift_number);
            resizeControler(label14OrginalArea, label14);
            resizeControler(txt_pm_shift_valueOrginalArea, txt_pm_shift_value);
            resizeControler(label24OrginalArea, label24);
            resizeControler(txt_extraOrginalArea, txt_extra);
            resizeControler(label26OrginalArea, label26);
            resizeControler(txt_overOrginalArea, txt_over);
            resizeControler(label5OrginalArea, label5);
            resizeControler(txt_IncentivesOrginalArea, txt_Incentives);
            resizeControler(label13OrginalArea, label13);
            resizeControler(txt_all_meritOrginalArea, txt_all_merit);
            resizeControler(groupBox5OrginalArea, groupBox5);
            resizeControler(groupBox6OrginalArea, groupBox6);
            resizeControler(groupBox7OrginalArea, groupBox7);
            resizeControler(label16OrginalArea, label16);
            resizeControler(label20OrginalArea, label20);
            resizeControler(txt_latenessOrginalArea, txt_lateness);
            resizeControler(label21OrginalArea, label21);
            resizeControler(txt_lateness_valueOrginalArea, txt_lateness_value);
            resizeControler(label22OrginalArea, label22);
            resizeControler(txt_absenceOrginalArea, txt_absence);
            resizeControler(label18OrginalArea, label18);
            resizeControler(txt_absence_valueOrginalArea, txt_absence_value);
            resizeControler(label17OrginalArea, label17);
            resizeControler(txt_taxOrginalArea, txt_tax);
            resizeControler(check_oldOrginalArea, check_old);
            resizeControler(check_newOrginalArea, check_new);
            resizeControler(label4OrginalArea, label4);
            resizeControler(txt_emp_insuranceOrginalArea, txt_emp_insurance);
            resizeControler(label6OrginalArea, label6);
            resizeControler(txt_loanOrginalArea, txt_loan);
            resizeControler(label23OrginalArea, label23);
            resizeControler(txt_all_deductionOrginalArea, txt_all_deduction);
            resizeControler(groupBox11OrginalArea, groupBox11);
            resizeControler(dataGridView1OrginalArea, dataGridView1);
           





        }

        private void resizeControler(Rectangle orginalControlerRect, Control control)
        {
            float xRetio = (float)(this.Width / (float)(orginalSize.Width));
            float yRetio = (float)(this.Height / (float)(orginalSize.Height));

            int newX = (int)(orginalControlerRect.X * xRetio);
            int newY = (int)(orginalControlerRect.Y * yRetio);

            int newWidth = (int)(orginalControlerRect.Width * xRetio);
            int newHeight = (int)(orginalControlerRect.Height * yRetio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }
        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //frm_add_employee frm = new frm_add_employee();
            frm_type_of_add_employee frm = new frm_type_of_add_employee();
         
            frm.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {











            if (txt_absence.Enabled==false)
            {





                txt_emp_name.Enabled = true;
                txt_emp_insurance.Enabled = true;
                txt_lateness.Enabled = true;
                txt_lateness_value.Enabled = true;
                txt_pm_shift_number.Enabled = true;
                txt_pm_shift_value.Enabled = true;
                txt_tax.Enabled = true;
                txt_am_shift_value.Enabled = true;
                txt_am_shift_number.Enabled = true;
                txt_all_merit.Enabled = true;
                txt_all_deduction.Enabled = true;
                txt_absence_value.Enabled = true;
                txt_absence.Enabled = true;
                txt_over.Enabled = true;
                txt_extra.Enabled = true;
                txt_Incentives.Enabled = true;
                txt_tax.Enabled = true;
                txt_last_salary.Enabled = true;
                txt_loan.Enabled = true;

                combo_role.Enabled = true;
                combo_department.Enabled = true;
                btn_save.Enabled = true;
                txt_no_of_staying_hours.Enabled = true;
                txt_adds.Enabled = true;
                txt_fans.Enabled = true;
                txt_type_of_adds.Enabled = true;
                txt_type_of_fans.Enabled = true;
                txt_type_of_other.Enabled = true;
                combo_type_of_salary.Enabled = true;
                txt_salary.Enabled = true;
                txt_value_of_stay.Enabled = true;
                txt_other.Enabled = true;
                rd_add.Enabled = true;
                rd_fans.Enabled = true;
                check_old.Enabled = true;
                check_new.Enabled = true;
                dateTimePicker1.Enabled = true;


            }

            else
            {



                txt_emp_name.Enabled = false;
                txt_lateness.Enabled = false;
                txt_emp_insurance.Enabled = false;
                txt_lateness_value.Enabled = false;
                txt_pm_shift_number.Enabled = false;
                txt_pm_shift_value.Enabled = false;
                txt_tax.Enabled = false;
                txt_am_shift_value.Enabled = false;
                txt_am_shift_number.Enabled = false;
                txt_all_merit.Enabled = false;
                txt_all_deduction.Enabled = false;
                txt_absence_value.Enabled = false;
                txt_absence.Enabled = false;
                txt_over.Enabled = false;
                txt_extra.Enabled = false;
                txt_Incentives.Enabled = false;
                txt_tax.Enabled = false;
                txt_last_salary.Enabled = false;
                txt_loan.Enabled = false;
                btn_save.Enabled = false;
                txt_no_of_staying_hours.Enabled = false;
                txt_adds.Enabled = false;
                txt_fans.Enabled = false;
                txt_type_of_adds.Enabled = false;
                txt_type_of_fans.Enabled = false;
                txt_type_of_other.Enabled = false;
                combo_type_of_salary.Enabled = false;
                txt_salary.Enabled = false;
                txt_value_of_stay.Enabled = false;
                txt_other.Enabled = false;
                rd_add.Enabled = false;
                rd_fans.Enabled = false;
                check_old.Enabled = false;
                check_new.Enabled = false;
                dateTimePicker1.Enabled = false;
                combo_role.Enabled = false;
                combo_department.Enabled = false;






            }





        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
          //  txt_extra.Text = ((Convert.ToDouble(dataGridView1.CurrentRow.Cells[11].Value)) * (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4])) * 1.5).ToString();
            if (
                  txt_emp_id.Text.Trim() == string.Empty ||
                  txt_emp_name.Text.Trim() == string.Empty ||
                  txt_salary.Text.Trim() == string.Empty ||
                  txt_value_of_stay.Text.Trim() == string.Empty ||
                  txt_last_salary.Text.Trim() == string.Empty ||
                  txt_no_of_staying_hours.Text.Trim() == string.Empty ||
                  txt_adds.Text.Trim() == string.Empty ||
                  txt_fans.Text.Trim() == string.Empty ||
                  txt_other.Text.Trim() == string.Empty ||
                  txt_am_shift_number.Text.Trim() == string.Empty ||
                  txt_am_shift_value.Text.Trim() == string.Empty ||
                  txt_pm_shift_number.Text.Trim() == string.Empty ||
                  txt_pm_shift_value.Text.Trim() == string.Empty ||
                  txt_extra.Text.Trim() == string.Empty ||
                  txt_over.Text.Trim() == string.Empty ||
                  txt_Incentives.Text.Trim() == string.Empty ||
                  txt_all_merit.Text.Trim() == string.Empty ||
                  txt_lateness.Text.Trim() == string.Empty ||
                  txt_lateness_value.Text.Trim() == string.Empty ||
                  txt_absence.Text.Trim() == string.Empty ||
                  txt_absence_value.Text.Trim() == string.Empty ||
                  txt_tax.Text.Trim() == string.Empty ||
                  txt_emp_insurance.Text.Trim() == string.Empty ||
                  txt_loan.Text.Trim() == string.Empty ||
                  txt_emp_insurance.Text.Trim() == string.Empty ||
                  txt_all_deduction.Text.Trim() == string.Empty
                  )
            {
                MessageBox.Show("يوجد حقل فارغ وهذا غير مسموح اذا كنت لا تريد وضع قيمة قم بوضع صفر اعادة المحاولة", "يوجد حقل فارغ", MessageBoxButtons.OK);
            }
            else
            {
                //  txt_extra.Text = ((Convert.ToDouble(dataGridView1.CurrentRow.Cells[11].Value)) * (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4])) * 1.5).ToString();

                //txt_adds.Text = "0.0";
              
                int depart_role_id;
                depart_role_id = Convert.ToInt32(client.get_id_of_deparment_and_role(combo_department.SelectedItem.ToString(), combo_role.SelectedItem.ToString()).Rows[0][0]);
                if (check_new.Checked == true && check_old.Checked == true)
                {
                    MessageBox.Show("لايمكن اختيار الا نوع واحد من التآمين", "اعد المحاولة", MessageBoxButtons.OK);
                }
                else if (check_new.Checked == true && check_old.Checked == false)
                {
                    txt_emp_insurance.Text = client.getConstants(depart_role_id).Rows[0][2].ToString();
                    client.updateDeduction(dateTimePicker1.Value, Convert.ToDouble(txt_lateness.Text), Convert.ToDouble(txt_loan.Text),
                    Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][2]), Convert.ToDouble(txt_tax.Text), Convert.ToInt32(txt_absence.Text), Convert.ToInt32(txt_emp_id.Text));
                    client.updateShift(Convert.ToInt32(txt_emp_id.Text), dateTimePicker1.Value, Convert.ToInt32(txt_am_shift_number.Text), Convert.ToInt32(txt_pm_shift_number.Text), Convert.ToDouble(txt_extra.Text), Convert.ToDouble(txt_over.Text), Convert.ToDouble(txt_no_of_staying_hours.Text));
                    client.update_others(txt_type_of_adds.Text, Convert.ToDouble(txt_adds.Text), txt_type_of_fans.Text, Convert.ToDouble(txt_fans.Text), Convert.ToDouble(txt_other.Text), txt_type_of_other.Text, Convert.ToInt32(txt_emp_id.Text), dateTimePicker1.Value);
                    client.updateClinet(txt_emp_name.Text, depart_role_id, Convert.ToDouble(txt_salary.Text), combo_type_of_salary.SelectedItem.ToString(), Convert.ToDouble(txt_value_of_stay.Text), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                    dataGridView1.DataSource = client.getCleint();
                    dataGridView1.Update();
                    MessageBox.Show("تمت عملية التحديث بنجاح", "تم التحديث", MessageBoxButtons.OK);
                }
                else if (check_new.Checked == false && check_old.Checked == true)
                {
                    txt_emp_insurance.Text = client.getConstants(depart_role_id).Rows[0][3].ToString();
                    client.updateDeduction(dateTimePicker1.Value, Convert.ToDouble(txt_lateness.Text), Convert.ToDouble(txt_loan.Text),
                    Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][3]), Convert.ToDouble(txt_tax.Text), Convert.ToInt32(txt_absence.Text), Convert.ToInt32(txt_emp_id.Text));
                    client.updateShift(Convert.ToInt32(txt_emp_id.Text), dateTimePicker1.Value, Convert.ToInt32(txt_am_shift_number.Text), Convert.ToInt32(txt_pm_shift_number.Text), Convert.ToDouble(txt_extra.Text), Convert.ToDouble(txt_over.Text), Convert.ToDouble(txt_no_of_staying_hours.Text));
                    client.updateClinet(txt_emp_name.Text, depart_role_id, Convert.ToDouble(txt_salary.Text), combo_type_of_salary.SelectedItem.ToString(), Convert.ToDouble(txt_value_of_stay.Text), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                    client.update_others(txt_type_of_adds.Text, Convert.ToDouble(txt_adds.Text), txt_type_of_fans.Text, Convert.ToDouble(txt_fans.Text), Convert.ToDouble(txt_other.Text), txt_type_of_other.Text, Convert.ToInt32(txt_emp_id.Text), dateTimePicker1.Value);
                    dataGridView1.DataSource = client.getCleint();
                    dataGridView1.Update();
                    MessageBox.Show("تمت عملية التحديث بنجاح", "تم التحديث", MessageBoxButtons.OK);
                }
                else if (check_new.Checked == false && check_old.Checked == false)
                {
                    client.updateClinet(txt_emp_name.Text, depart_role_id, Convert.ToDouble(txt_salary.Text), combo_type_of_salary.SelectedItem.ToString(), Convert.ToDouble(txt_value_of_stay.Text), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    client.updateDeduction(dateTimePicker1.Value, Convert.ToDouble(txt_lateness.Text), Convert.ToDouble(txt_loan.Text),
                    0, Convert.ToDouble(txt_tax.Text), Convert.ToInt32(txt_absence.Text), Convert.ToInt32(txt_emp_id.Text));
                    //  client.updateShift(Convert.ToInt32(txt_emp_id.Text), dateTimePicker1.Value, Convert.ToInt32(txt_am_shift_number.Text), Convert.ToInt32(txt_pm_shift_number.Text),
                    //      Convert.ToDouble(txt_extra.Text) / ((Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4])) * 1.5)



                    //  , Convert.ToDouble(txt_over.Text), Convert.ToDouble(txt_no_of_staying_hours.Text)); 
                    client.updateShift(Convert.ToInt32(txt_emp_id.Text), dateTimePicker1.Value, Convert.ToInt32(txt_am_shift_number.Text), Convert.ToInt32(txt_pm_shift_number.Text), Convert.ToDouble(txt_extra.Text), Convert.ToDouble(txt_over.Text), Convert.ToDouble(txt_no_of_staying_hours.Text));
                    client.update_others(txt_type_of_adds.Text, Convert.ToDouble(txt_adds.Text), txt_type_of_fans.Text, Convert.ToDouble(txt_fans.Text), Convert.ToDouble(txt_other.Text), txt_type_of_other.Text, Convert.ToInt32(txt_emp_id.Text), dateTimePicker1.Value);
                    dataGridView1.DataSource = client.getCleint();
                    dataGridView1.Update();
                    MessageBox.Show("تمت عملية التحديث بنجاح", "تم التحديث", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("لم تتم عملية التحديث الرجاء اعادة المحاولة", "اعد المحاولة", MessageBoxButtons.OK);
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            

                clearboxees();

                txt_salary.Text = "0.0";
                txt_adds.Text = "0.0";
                int depart_role_id;
                double salary_for_tax = 0.0;
                double tax = 0.0;

            /*
             احنا عاملين الاضافي اسمه اكسترااااااااااااااا وبيضرب في واحد ونص
             */
              
             

                txt_emp_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_emp_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
                combo_role.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                combo_department.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                combo_type_of_salary.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                depart_role_id = Convert.ToInt32(client.get_id_of_deparment_and_role(combo_department.SelectedItem.ToString(), combo_role.SelectedItem.ToString()).Rows[0][0]);
                txt_am_shift_number.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txt_am_shift_value.Text = (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4]) * Convert.ToDouble(txt_am_shift_number.Text)).ToString();
                txt_pm_shift_number.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txt_pm_shift_value.Text = (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][5]) * Convert.ToDouble(txt_pm_shift_number.Text)).ToString();
                txt_extra.Text = ((Convert.ToDouble(dataGridView1.CurrentRow.Cells[11].Value)) * (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4])) * 1.5).ToString();
                txt_over.Text = ((Convert.ToDouble(dataGridView1.CurrentRow.Cells[12].Value)) * (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4]))).ToString();
                txt_Incentives.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[13].Value).ToString();
                txt_adds.Text = (dataGridView1.CurrentRow.Cells[21].Value).ToString();   //client.getCleint().Rows[Convert.ToInt32(txt_emp_id.Text+1)][21].ToString();
                txt_type_of_adds.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
                txt_fans.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
                txt_type_of_fans.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();
                txt_other.Text = dataGridView1.CurrentRow.Cells[25].Value.ToString();
                txt_type_of_other.Text = dataGridView1.CurrentRow.Cells[26].Value.ToString();
                txt_value_of_stay.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txt_lateness.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                txt_no_of_staying_hours.Text = (Convert.ToDouble(dataGridView1.CurrentRow.Cells[8].Value)).ToString();

                if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "راتب")
                {



                    txt_salary.Text = client.get_sallary_with_client_id(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).Rows[0][0].ToString();
                    txt_extra.Text = ((Convert.ToDouble(dataGridView1.CurrentRow.Cells[11].Value)) * (Convert.ToDouble(txt_salary.Text) / 30) * 1.5).ToString();
                    txt_over.Text = ((Convert.ToDouble(dataGridView1.CurrentRow.Cells[12].Value)) * (Convert.ToDouble(txt_salary.Text) / 30)).ToString();
                    txt_all_merit.Text = (Convert.ToDouble(txt_over.Text) + Convert.ToDouble(txt_extra.Text) + Convert.ToDouble(txt_am_shift_value.Text) +
                        Convert.ToDouble(txt_pm_shift_value.Text) + Convert.ToDouble(txt_Incentives.Text) + Convert.ToDouble(txt_salary.Text) + Convert.ToDouble(txt_adds.Text)
                        ).ToString();


                    txt_lateness_value.Text = (((Convert.ToDouble(txt_salary.Text) / 30) / 8) * (Convert.ToDouble(dataGridView1.CurrentRow.Cells[14].Value))).ToString();
                    txt_absence.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[18].Value).ToString();
                    txt_absence_value.Text = ((Convert.ToDouble(txt_salary.Text) / 30) * Convert.ToDouble(dataGridView1.CurrentRow.Cells[18].Value)).ToString();

                    salary_for_tax = Convert.ToDouble(txt_salary.Text);
                    if (Convert.ToDouble(txt_salary.Text) >= 1250)
                    {
                        tax = Math.Round(((((salary_for_tax * 12) - 15000.0) / 12) * 0.015));
                        txt_tax.Text = Math.Round(tax).ToString();
                    }
                    else
                    {
                        txt_tax.Text = "0";
                    }

                }
                else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "مقيم")
                {

                   // txt_salary.Text = (Convert.ToDouble(txt_value_of_stay.Text) * Convert.ToDouble(txt_no_of_staying_hours.Text)).ToString();

                    //txt_extra.Text = ((Convert.ToDouble(dataGridView1.CurrentRow.Cells[11].Value)) * (Convert.ToDouble(txt_salary.Text) / 30) * 1.5).ToString();
                    //txt_over.Text = ((Convert.ToDouble(dataGridView1.CurrentRow.Cells[12].Value)) * (Convert.ToDouble(txt_salary.Text) / 30)).ToString();



                    txt_lateness_value.Text = "0";
                    txt_all_merit.Text = 
                        ( Convert.ToDouble(txt_Incentives.Text) + Convert.ToDouble(txt_value_of_stay.Text) * Convert.ToDouble(txt_no_of_staying_hours.Text) + Convert.ToDouble(txt_adds.Text)).ToString();

                    txt_absence.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[18].Value).ToString();
                    txt_absence_value.Text = ((Convert.ToDouble(txt_salary.Text) / 30) * Convert.ToDouble(dataGridView1.CurrentRow.Cells[18].Value)).ToString();

                    salary_for_tax = Convert.ToDouble(txt_value_of_stay.Text) * Convert.ToDouble(txt_no_of_staying_hours.Text);
                  
                        tax = Math.Round(salary_for_tax*0.1);
                        txt_tax.Text = Math.Round(tax).ToString();
                 
                  
                   
                }
                else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "شيفت")
                {
                    txt_all_merit.Text = (Convert.ToDouble(txt_over.Text) + Convert.ToDouble(txt_extra.Text) + Convert.ToDouble(txt_am_shift_value.Text) +
                   Convert.ToDouble(txt_pm_shift_value.Text) + Convert.ToDouble(txt_Incentives.Text) + Convert.ToDouble(txt_adds.Text)).ToString();


                    txt_lateness_value.Text = ((Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4]) / 8) * (Convert.ToDouble(dataGridView1.CurrentRow.Cells[14].Value))).ToString();
                    txt_absence.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[18].Value).ToString();
                    txt_absence_value.Text = (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4]) * Convert.ToDouble(dataGridView1.CurrentRow.Cells[18].Value)).ToString();
                    salary_for_tax = ((Convert.ToDouble(txt_am_shift_value.Text) + Convert.ToDouble(txt_pm_shift_value.Text)));
              
                    if (salary_for_tax >= 1250)
                    {
                        tax = Math.Round(((((salary_for_tax * 12) - 15000.0) / 12) * 0.015));
                        txt_tax.Text = Math.Round(tax).ToString();
                    }
                    else
                    {
                        txt_tax.Text = "0";
                    }
                }

                txt_loan.Text = (Convert.ToDouble(dataGridView1.CurrentRow.Cells[16].Value)).ToString();
                txt_emp_insurance.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[20].Value).ToString();

               



                txt_all_deduction.Text = (Convert.ToDouble(txt_lateness_value.Text) + Convert.ToDouble(txt_absence_value.Text) + Convert.ToDouble(txt_tax.Text) +
                   +Convert.ToDouble(txt_loan.Text) + Convert.ToDouble(txt_emp_insurance.Text) + Convert.ToDouble(txt_fans.Text)).ToString();
                 
                if (rd_fans.Checked)
                {
                    txt_last_salary.Text = (Convert.ToDouble(txt_all_merit.Text) - Convert.ToDouble(txt_all_deduction.Text) - Convert.ToDouble(txt_other.Text)).ToString();
                }
                else if (rd_add.Checked)
                {
                    txt_last_salary.Text = (Convert.ToDouble(txt_all_merit.Text) - Convert.ToDouble(txt_all_deduction.Text) + Convert.ToDouble(txt_other.Text)).ToString();

                }
                else
                {
                    txt_last_salary.Text = (Convert.ToDouble(txt_all_merit.Text) - Convert.ToDouble(txt_all_deduction.Text)).ToString();
                }
            
          

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_all_merit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_am_shift_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_am_shift_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tax_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                client.deleteclinet(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                dataGridView1.DataSource = client.getCleint();
                dataGridView1.Update();
                MessageBox.Show("تمت عملية الحذف بنجاح", "تم الحذف", MessageBoxButtons.OK);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("رجاء حدد الصف الذي تريد حذفه", "لم يتم الحذف", MessageBoxButtons.OK);
      
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
            }catch(NullReferenceException)
            {
                MessageBox.Show("انت تحاول ان تقوم بعرض بيانات غير موجودة الرجاء التأكد انك قمت بإضافة حركات الموظفين", "اعد المحاولة", MessageBoxButtons.OK);
               
            }
        }

        private void check_old_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_emp_insurance_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_client_search.Text != string.Empty)
            {
                dataGridView1.DataSource = client.search_in_clients(txt_client_search.Text);
            }
            else
                dataGridView1.DataSource = client.getCleint();

        }

        private void combo_department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_emp_id_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_emp_name_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_reports frm = new frm_reports();
            frm.ShowDialog();

           






        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل تريد مسح جميع الموظفين لا يمكن التراجع", "تنبيه مسح", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                client.deleteAllClients();
                dataGridView1.DataSource = client.getCleint();
                dataGridView1.Update();
                MessageBox.Show("تمت عملية الحذف بنجاح", "تم الحذف", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();

            frm.state = "confirm_sallary";

            if (MessageBox.Show(" هل تريد حفظ المرتبات لهذا الشهر", "حفظ المرتبات", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

       
                frm.ShowDialog();
                if (frm.state == "confirm_sallary")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    
                    ///////////////////////////////////////////////////////////////////////////////
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        


                        clearboxees();

                txt_salary.Text = "0.0";
                txt_adds.Text = "0.0";
                int depart_role_id;
                double salary_for_tax = 0.0;
                double tax = 0.0;

            /*
             احنا عاملين الاضافي اسمه اكسترااااااااااااااا وبيضرب في واحد ونص
             */
              
             

                txt_emp_id.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txt_emp_name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            
                combo_role.SelectedItem = dataGridView1.Rows[i].Cells[2].Value.ToString();
                combo_department.SelectedItem = dataGridView1.Rows[i].Cells[3].Value.ToString();
                combo_type_of_salary.SelectedItem = dataGridView1.Rows[i].Cells[4].Value.ToString();
                depart_role_id = Convert.ToInt32(client.get_id_of_deparment_and_role(combo_department.SelectedItem.ToString(), combo_role.SelectedItem.ToString()).Rows[0][0]);
                txt_am_shift_number.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
                txt_am_shift_value.Text = (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4]) * Convert.ToDouble(txt_am_shift_number.Text)).ToString();
                txt_pm_shift_number.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                txt_pm_shift_value.Text = (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][5]) * Convert.ToDouble(txt_pm_shift_number.Text)).ToString();
                txt_extra.Text = ((Convert.ToDouble(dataGridView1.Rows[i].Cells[11].Value)) * (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4])) * 1.5).ToString();
                txt_over.Text = ((Convert.ToDouble(dataGridView1.Rows[i].Cells[12].Value)) * (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4]))).ToString();
                txt_Incentives.Text = Convert.ToDouble(dataGridView1.Rows[i].Cells[13].Value).ToString();
                txt_adds.Text = (dataGridView1.Rows[i].Cells[21].Value).ToString();   //client.getCleint().Rows[Convert.ToInt32(txt_emp_id.Text+1)][21].ToString();
                txt_type_of_adds.Text = dataGridView1.Rows[i].Cells[22].Value.ToString();
                txt_fans.Text = dataGridView1.Rows[i].Cells[23].Value.ToString();
                txt_type_of_fans.Text = dataGridView1.Rows[i].Cells[24].Value.ToString();
                txt_other.Text = dataGridView1.Rows[i].Cells[25].Value.ToString();
                txt_type_of_other.Text = dataGridView1.Rows[i].Cells[26].Value.ToString();
                txt_value_of_stay.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                txt_lateness.Text = dataGridView1.Rows[i].Cells[14].Value.ToString();
                txt_no_of_staying_hours.Text = (Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value)).ToString();

                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "راتب")
                {



                    txt_salary.Text = client.get_sallary_with_client_id(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)).Rows[0][0].ToString();
                    txt_extra.Text = ((Convert.ToDouble(dataGridView1.Rows[i].Cells[11].Value)) * (Convert.ToDouble(txt_salary.Text) / 30) * 1.5).ToString();
                    txt_over.Text = ((Convert.ToDouble(dataGridView1.Rows[i].Cells[12].Value)) * (Convert.ToDouble(txt_salary.Text) / 30)).ToString();
                    txt_all_merit.Text = (Convert.ToDouble(txt_over.Text) + Convert.ToDouble(txt_extra.Text) + Convert.ToDouble(txt_am_shift_value.Text) +
                        Convert.ToDouble(txt_pm_shift_value.Text) + Convert.ToDouble(txt_Incentives.Text) + Convert.ToDouble(txt_salary.Text) + Convert.ToDouble(txt_adds.Text)
                        ).ToString();


                    txt_lateness_value.Text = (((Convert.ToDouble(txt_salary.Text) / 30) / 8) * (Convert.ToDouble(dataGridView1.Rows[i].Cells[14].Value))).ToString();
                    txt_absence.Text = Convert.ToDouble(dataGridView1.Rows[i].Cells[18].Value).ToString();
                    txt_absence_value.Text = ((Convert.ToDouble(txt_salary.Text) / 30) * Convert.ToDouble(dataGridView1.Rows[i].Cells[18].Value)).ToString();

                    salary_for_tax = Convert.ToDouble(txt_salary.Text);
                    if (Convert.ToDouble(txt_salary.Text) >= 1250)
                    {
                        tax = Math.Round(((((salary_for_tax * 12) - 15000.0) / 12) * 0.015));
                        txt_tax.Text = Math.Round(tax).ToString();
                    }
                    else
                    {
                        txt_tax.Text = "0";
                    }

                }
                else if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "مقيم")
                {

                   // txt_salary.Text = (Convert.ToDouble(txt_value_of_stay.Text) * Convert.ToDouble(txt_no_of_staying_hours.Text)).ToString();

                    //txt_extra.Text = ((Convert.ToDouble(dataGridView1.Rows[i].Cells[11].Value)) * (Convert.ToDouble(txt_salary.Text) / 30) * 1.5).ToString();
                    //txt_over.Text = ((Convert.ToDouble(dataGridView1.Rows[i].Cells[12].Value)) * (Convert.ToDouble(txt_salary.Text) / 30)).ToString();



                    txt_lateness_value.Text = "0";
                    txt_all_merit.Text = 
                        ( Convert.ToDouble(txt_Incentives.Text) + Convert.ToDouble(txt_value_of_stay.Text) * Convert.ToDouble(txt_no_of_staying_hours.Text) + Convert.ToDouble(txt_adds.Text)).ToString();

                    txt_absence.Text = Convert.ToDouble(dataGridView1.Rows[i].Cells[18].Value).ToString();
                    txt_absence_value.Text = ((Convert.ToDouble(txt_salary.Text) / 30) * Convert.ToDouble(dataGridView1.Rows[i].Cells[18].Value)).ToString();

                    salary_for_tax = Convert.ToDouble(txt_value_of_stay.Text) * Convert.ToDouble(txt_no_of_staying_hours.Text);
                    tax = Math.Round(salary_for_tax * 0.1);
                    txt_tax.Text = Math.Round(tax).ToString();
                }
                else if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "شيفت")
                {
                    txt_all_merit.Text = (Convert.ToDouble(txt_over.Text) + Convert.ToDouble(txt_extra.Text) + Convert.ToDouble(txt_am_shift_value.Text) +
                   Convert.ToDouble(txt_pm_shift_value.Text) + Convert.ToDouble(txt_Incentives.Text) + Convert.ToDouble(txt_adds.Text)).ToString();


                     txt_lateness_value.Text = ((Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4]) / 8) * (Convert.ToDouble(dataGridView1.Rows[i].Cells[14].Value))).ToString();
                    txt_absence.Text = Convert.ToDouble(dataGridView1.Rows[i].Cells[18].Value).ToString();
                    txt_absence_value.Text = (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4]) * Convert.ToDouble(dataGridView1.Rows[i].Cells[18].Value)).ToString();
                    salary_for_tax = ((Convert.ToDouble(txt_am_shift_value.Text) + Convert.ToDouble(txt_pm_shift_value.Text)));
              
                    if (salary_for_tax >= 1250)
                    {
                        tax = Math.Round(((((salary_for_tax * 12) - 15000.0) / 12) * 0.015));
                        txt_tax.Text = Math.Round(tax).ToString();
                    }
                    else
                    {
                        txt_tax.Text = "0";
                    }
                }

                txt_loan.Text = (Convert.ToDouble(dataGridView1.Rows[i].Cells[16].Value)).ToString();
                txt_emp_insurance.Text = Convert.ToDouble(dataGridView1.Rows[i].Cells[20].Value).ToString();

               



                txt_all_deduction.Text = (Convert.ToDouble(txt_lateness_value.Text) + Convert.ToDouble(txt_absence_value.Text) + Convert.ToDouble(txt_tax.Text) +
                   +Convert.ToDouble(txt_loan.Text) + Convert.ToDouble(txt_emp_insurance.Text) + Convert.ToDouble(txt_fans.Text)).ToString();
                 
                if (rd_fans.Checked)
                {
                    txt_last_salary.Text = (Convert.ToDouble(txt_all_merit.Text) - Convert.ToDouble(txt_all_deduction.Text) - Convert.ToDouble(txt_other.Text)).ToString();
                }
                else if (rd_add.Checked)
                {
                    txt_last_salary.Text = (Convert.ToDouble(txt_all_merit.Text) - Convert.ToDouble(txt_all_deduction.Text) + Convert.ToDouble(txt_other.Text)).ToString();

                }
                else
                {
                    txt_last_salary.Text = (Convert.ToDouble(txt_all_merit.Text) - Convert.ToDouble(txt_all_deduction.Text)).ToString();
                }
            

                        client.add_overall(Convert.ToInt32(txt_emp_id.Text), 
                            txt_emp_name.Text, combo_department.SelectedItem.ToString(),
                            dateTimePicker1.Value
                            , Convert.ToDouble(txt_last_salary.Text),Convert.ToDouble(txt_am_shift_number.Text),
                            Convert.ToDouble(txt_am_shift_value.Text),
                            Convert.ToDouble(txt_pm_shift_number.Text), Convert.ToDouble(txt_pm_shift_value.Text),
                            Convert.ToDouble(txt_extra.Text), Convert.ToDouble(txt_over.Text),
                            Convert.ToDouble(txt_Incentives.Text),
                            Convert.ToDouble(txt_all_merit.Text), Convert.ToDouble(txt_lateness.Text), 
                            Convert.ToDouble(txt_lateness_value.Text),
                            Convert.ToInt32(txt_absence.Text), Convert.ToDouble(txt_absence_value.Text),
                            Convert.ToDouble(txt_tax.Text),
                            Convert.ToDouble(txt_emp_insurance.Text), Convert.ToDouble(txt_loan.Text),
                            depart_role_id, Convert.ToDouble(txt_all_deduction.Text), txt_month.Text, txt_year.Text, "not received");

                        clearboxees();

                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("تم الحفظ بنجاح");
                  
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                }
                else 
                {
                    MessageBox.Show("تم الغاء العملية بنجاح");
                        
                }
            }
        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            piad_sallary frm = new piad_sallary();
            frm.dataGridView1.DataSource = client.get_clints_that_not_received_them_salary_for_month_and_year(txt_month.Text, txt_year.Text, "not received");
            for (int i = 0; i < client.get_month_and_year().Rows.Count; i++)
            {
                frm.comb_month.Items.Add(client.get_month_and_year().Rows[i][0]);
                frm.combo_year.Items.Add(client.get_month_and_year().Rows[i][1]);
            }
          
            frm.ShowDialog();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_month.Text = dateTimePicker1.Value.Month.ToString();
            txt_year.Text = dateTimePicker1.Value.Year.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_month.Text = dateTimePicker1.Value.Month.ToString();
            txt_year.Text = dateTimePicker1.Value.Year.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            clients_that_recived_sallary frm = new clients_that_recived_sallary();
            frm.dataGridView1.DataSource = client.get_clints_that_received_them_salary_for_month_and_year(txt_month.Text, txt_year.Text);
            for (int i = 0; i < client.get_month_and_year().Rows.Count; i++)
            {
                frm.comb_month.Items.Add(client.get_month_and_year().Rows[i][0]);
                frm.combo_year.Items.Add(client.get_month_and_year().Rows[i][1]);
            }

            frm.comb_month.SelectedItem = txt_month.Text;
            frm.combo_year.SelectedItem = txt_year.Text;
            frm.ShowDialog();
        }

        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void combo_type_of_salary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_value_of_stay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_salary_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txt_emp_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_absence_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox11_Resize(object sender, EventArgs e)
        {
           
        }

        private void frm_employee_Resize(object sender, EventArgs e)
        {
            //resizeControlers();
        }
     

        private void frm_employee_ResizeBegin(object sender, EventArgs e)
        {
        }

        private void frm_employee_ResizeEnd(object sender, EventArgs e)
        {
            
        }
    }
}
