using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Data.OleDb;

namespace client.PL
{
    public partial class Getting_Start : Form
    {
        BL.Client client = new BL.Client();
        BL.motions motions = new BL.motions();
        OleDbConnection con;
        OleDbDataAdapter da;
        DataTable dt;
        public Getting_Start()
        {
            InitializeComponent();


        }

        private void اعدادتالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.frm_config frm = new frm_config();


            frm.ShowDialog();
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.frm_login frm = new frm_login();
            frm.ShowDialog();
        }

        private void اضافهمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
        private void اضافهموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_users frm = new frm_users();
            frm.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();
            this.Close();
            frm.Show();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm_settings frm = new frm_settings();
            frm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //الاتصال بالاكسيل وقراءه البيانات

            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "ALL Files |*.*| Excel Files |*.XLSX";
                if (op.ShowDialog() == DialogResult.OK)
                {

                    con = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source =" + op.FileName + "; Extended Properties = Excel 12.0");

                    da = new OleDbDataAdapter("select * from [MH$]", con);

                    dt = new DataTable();
                    da.Fill(dt);
                    this.dt_exel.DataSource = dt;
                }
            }catch(OleDbException)
            {
                MessageBox.Show("تأكد انك قمت بتسمية شيت الاكسل بالاسم التالي " + Environment.NewLine +"MH" +Environment.NewLine + "والا لن يستطيع البرنامج قراءة الملف", "خطأ في تسمية شيت الاكسل من الداخل", MessageBoxButtons.OK);
        
            }
        }

        private void انشاءنسخهاحتياطيهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void استعادهنسخهاحتياطهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Getting_Start_Load(object sender, EventArgs e)
        {
            //1680 1050
            orginalSize = this.Size;
            btn_add_excelOrginalArea = new Rectangle(btn_add_excel.Location.X, btn_add_excel.Location.Y, btn_add_excel.Width, btn_add_excel.Height);
            btn_usersOrginalArea = new Rectangle(btn_users.Location.X, btn_users.Location.Y, btn_users.Width, btn_users.Height);
            btn_add_to_databaseOrginalArea = new Rectangle(btn_add_to_database.Location.X, btn_add_to_database.Location.Y, btn_add_to_database.Width, btn_add_to_database.Height);
            btn_employeeOrginalArea = new Rectangle(btn_employee.Location.X, btn_employee.Location.Y, btn_employee.Width, btn_employee.Height);
            btn_add_employeeOrginalArea = new Rectangle(btn_add_employee.Location.X, btn_add_employee.Location.Y, btn_add_employee.Width, btn_add_employee.Height);
            btn_backupOrginalArea = new Rectangle(btn_backup.Location.X, btn_backup.Location.Y, btn_backup.Width, btn_backup.Height);
            btn_restore_backupOrginalArea = new Rectangle(btn_restore_backup.Location.X, btn_restore_backup.Location.Y, btn_restore_backup.Width, btn_restore_backup.Height);
            btn_reportOrginalArea = new Rectangle(btn_report.Location.X, btn_report.Location.Y, btn_report.Width, btn_report.Height);
            btn_settingsOrginalArea = new Rectangle(btn_settings.Location.X, btn_settings.Location.Y, btn_settings.Width, btn_settings.Height);
            btn_employee_motionOrginalArea = new Rectangle(btn_employee_motion.Location.X, btn_employee_motion.Location.Y, btn_employee_motion.Width, btn_employee_motion.Height);
            btn_logoutOrginalArea = new Rectangle(btn_logout.Location.X, btn_logout.Location.Y, btn_logout.Width, btn_logout.Height);
            btn_add_motionOrginalArea = new Rectangle(btn_add_motion.Location.X, btn_add_motion.Location.Y, btn_add_motion.Width, btn_add_motion.Height);
            label1OrginalArea = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            txt_user_nameOrginalArea = new Rectangle(txt_user_name.Location.X, txt_user_name.Location.Y, txt_user_name.Width, txt_user_name.Height);
            label2OrginalArea = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            txt_last_login_dateOrginalArea = new Rectangle(txt_last_login_date.Location.X, txt_last_login_date.Location.Y, txt_last_login_date.Width, txt_last_login_date.Height);
            panel1OrginalArea = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height);
            dt_exelOrginalArea = new Rectangle(dt_exel.Location.X, dt_exel.Location.Y, dt_exel.Width, dt_exel.Height);
            pictureBox1OrginalArea = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);

         


        }
   

        private Rectangle btn_add_excelOrginalArea;
        private Rectangle btn_usersOrginalArea;
        private Rectangle btn_add_to_databaseOrginalArea;
        private Rectangle btn_employeeOrginalArea;
        private Rectangle btn_add_employeeOrginalArea;
        private Rectangle btn_backupOrginalArea;
        private Rectangle btn_restore_backupOrginalArea;
        private Rectangle btn_reportOrginalArea;
        private Rectangle btn_settingsOrginalArea;
        private Rectangle btn_employee_motionOrginalArea;
        private Rectangle btn_logoutOrginalArea;
        private Rectangle btn_add_motionOrginalArea;

        private Rectangle label1OrginalArea;
        private Rectangle txt_user_nameOrginalArea;
        private Rectangle label2OrginalArea;
        private Rectangle txt_last_login_dateOrginalArea;
        private Rectangle panel1OrginalArea;
        private Rectangle dt_exelOrginalArea;
        private Rectangle pictureBox1OrginalArea;


        private Size orginalSize;
        private void resizeControlers()
        {
      


            resizeControler(btn_add_excelOrginalArea, btn_add_excel);
            resizeControler(btn_usersOrginalArea, btn_users);
            resizeControler(btn_add_to_databaseOrginalArea, btn_add_to_database);
            resizeControler(btn_employeeOrginalArea, btn_employee);
            resizeControler(btn_add_employeeOrginalArea, btn_add_employee);
            resizeControler(btn_backupOrginalArea, btn_backup);
            resizeControler(btn_reportOrginalArea, btn_report);
            resizeControler(btn_settingsOrginalArea, btn_settings);
            resizeControler(btn_restore_backupOrginalArea, btn_restore_backup);
            resizeControler(btn_employee_motionOrginalArea, btn_employee_motion);
            resizeControler(btn_logoutOrginalArea, btn_logout);
            resizeControler(btn_add_motionOrginalArea, btn_add_motion);
            resizeControler(label1OrginalArea, label1);
            resizeControler(txt_user_nameOrginalArea, txt_user_name);
            resizeControler(label2OrginalArea, label2);
            resizeControler(txt_last_login_dateOrginalArea, txt_last_login_date);
            resizeControler(panel1OrginalArea, panel1);
            resizeControler(dt_exelOrginalArea, dt_exel);
            resizeControler(pictureBox1OrginalArea, pictureBox1);


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


        private void button2_Click(object sender, EventArgs e)
        {
            frm_employee frm = new frm_employee();
            Cursor.Current = Cursors.WaitCursor;
            frm.dataGridView1.DataSource = client.getCleint();
            for (int i = 0; i < client.get_role_and_department().Rows.Count; i++)
            {


                frm.combo_role.Items.Add(client.get_role_and_department().Rows[i][1]);
                frm.combo_department.Items.Add(client.get_role_and_department().Rows[i][2]);


            }


            List<object> departments = new List<object>();
            foreach (object o in frm.combo_department.Items)
            {
                if (!departments.Contains(o))
                {
                    departments.Add(o);
                }
            }
            frm.combo_department.Items.Clear();
            frm.combo_department.Items.AddRange(departments.ToArray());

            List<object> roles = new List<object>();
            foreach (object o in frm.combo_role.Items)
            {
                if (!roles.Contains(o))
                {
                    roles.Add(o);
                }
            }
            frm.combo_role.Items.Clear();
            frm.combo_role.Items.AddRange(roles.ToArray());

            for (int i = 0; i < client.get_type_of_salary().Rows.Count; i++)
            {

                frm.combo_type_of_salary.Items.Add(client.get_type_of_salary().Rows[i][0]);
                

            }

            if (frm.combo_type_of_salary.Items.Count != 0)
            {
                frm.combo_department.SelectedIndex = 0;
                frm.combo_role.SelectedIndex = 0;
                frm.combo_type_of_salary.SelectedIndex = 0;
            }
     
            //frm.txt_am_shift_value.Text = client.getConstants(Convert.ToInt32(txt_role_dept_id.Text))().Rows[0][4].ToString();
           // frm.txt_pm_shift_value.Text = client.getConstants(Convert.ToInt32(txt_role_dept_id.Text))().Rows[0][5].ToString();
            frm.txt_month.Text = dateTimePicker1.Value.Month.ToString();
            frm.txt_year.Text = dateTimePicker1.Value.Year.ToString();
            Cursor.Current = Cursors.Default;

            frm.ShowDialog();

        }

        private void dt_exel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_type_of_add_employee frm = new frm_type_of_add_employee();

            frm.ShowDialog();
            
            
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;

         

            

          // try
           // {
                for (int i = 0; i < dt_exel.Rows.Count - 1; i++)
                {

                    //لو شفت
                    if (dt_exel.Rows[i].Cells[12].Value.ToString() == "شيفت")
                    {


                            double salary_for_tax = 0.0;
                            double tax = 0;
                            client.add_other(Convert.ToString(dt_exel.Rows[i].Cells[15].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[14].Value), Convert.ToString(dt_exel.Rows[i].Cells[17].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[16].Value), dateTimePicker1.Value, Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), 0, "");
                            int depart_role_id = Convert.ToInt32(client.get_id_of_deparment_and_role(Convert.ToString(dt_exel.Rows[i].Cells[2].Value.ToString()), Convert.ToString(dt_exel.Rows[i].Cells[3].Value)).Rows[0][0]);
                             salary_for_tax = (Convert.ToDouble(dt_exel.Rows[i].Cells[4].Value) * Convert.ToDouble(client.getConstants(Convert.ToInt32(depart_role_id)).Rows[0][4])) + (Convert.ToDouble(dt_exel.Rows[i].Cells[5].Value) * Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][5]));
                            client.addShift(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), dateTimePicker1.Value, Convert.ToDouble(dt_exel.Rows[i].Cells[4].Value),
                                Convert.ToDouble(dt_exel.Rows[i].Cells[5].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[6].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[7].Value)
                            , Convert.ToDouble(dt_exel.Rows[i].Cells[13].Value));
                            client.addDeduction(dateTimePicker1.Value, Convert.ToDouble(dt_exel.Rows[i].Cells[8].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[9].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[10].Value), Convert.ToInt32(dt_exel.Rows[i].Cells[11].Value)
                            , (Convert.ToDouble(client.getConstants(depart_role_id).Rows[0][4]) * Convert.ToInt32(dt_exel.Rows[i].Cells[11].Value)), (Convert.ToDouble(client.getConstants(Convert.ToInt32(depart_role_id)).Rows[0][4])) * Convert.ToDouble(dt_exel.Rows[i].Cells[8].Value), Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value));
                            if (salary_for_tax >= 1250)
                            {
                                tax = ((((salary_for_tax * 12) - 15000.0) / 12) * 0.015);
                                client.update_tax_for_month(dateTimePicker1.Value, Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), tax);
                            }
                            else
                            {
                                client.update_tax_for_month(dateTimePicker1.Value, Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), 0);
                            }


                            client.get_incentives(depart_role_id);

                            client.addIncentives(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), salary_for_tax * Convert.ToDouble(client.get_incentives(depart_role_id).Rows[0][0]), depart_role_id);
                          

                    }



                    //لو راتب


                    else if (dt_exel.Rows[i].Cells[12].Value.ToString() == "راتب")
                    {
                        double tax = 0;
                        int depart_role_id = Convert.ToInt32(client.get_id_of_deparment_and_role(Convert.ToString(dt_exel.Rows[i].Cells[2].Value.ToString()), Convert.ToString(dt_exel.Rows[i].Cells[3].Value)).Rows[0][0]);




                        client.add_other(Convert.ToString(dt_exel.Rows[i].Cells[15].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[14].Value), Convert.ToString(dt_exel.Rows[i].Cells[17].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[16].Value), dateTimePicker1.Value, Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), 0, "");
                        client.addShift(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), dateTimePicker1.Value, 0, 0,
                        Convert.ToDouble(dt_exel.Rows[i].Cells[6].Value),
                        Convert.ToDouble(dt_exel.Rows[i].Cells[7].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[13].Value));
                        client.addDeduction(dateTimePicker1.Value, Convert.ToDouble(dt_exel.Rows[i].Cells[8].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[9].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[10].Value), Convert.ToInt32(dt_exel.Rows[i].Cells[11].Value)
                     , ((Convert.ToDouble(client.get_sallary_with_client_id(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value)).Rows[0][0]) / 30.0) * Convert.ToInt32(dt_exel.Rows[i].Cells[11].Value)),
                        ((Convert.ToDouble(client.get_sallary_with_client_id(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value)).Rows[0][0]) / 30.0) / 8) * Convert.ToDouble(dt_exel.Rows[i].Cells[8].Value), Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value));



                         if (Convert.ToDouble(client.get_sallary_with_client_id(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value)).Rows[0][0]) >= 1250)
                        {
                            tax = ((((Convert.ToDouble(client.get_sallary_with_client_id(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value)).Rows[0][0]) * 12) - 15000) / 12) * 0.015);
                            client.update_tax_for_month(dateTimePicker1.Value, Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), tax);
                        }
                        else
                        {
                            client.update_tax_for_month(dateTimePicker1.Value, Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), 0);
                        }



                        client.get_incentives(depart_role_id);

                        client.addIncentives(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), Convert.ToDouble(client.get_sallary_with_client_id(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value)).Rows[0][0]) * Convert.ToDouble(client.get_incentives(depart_role_id).Rows[0][0]), depart_role_id);



                        // الزياده بضرب فى واحد والاضافى فى واحد ونص 


                    }

                        //لو مقيم
                    else if (dt_exel.Rows[i].Cells[12].Value.ToString() == "مقيم")
                    {
                        int depart_role_id = Convert.ToInt32(client.get_id_of_deparment_and_role(Convert.ToString(dt_exel.Rows[i].Cells[2].Value.ToString()), Convert.ToString(dt_exel.Rows[i].Cells[3].Value)).Rows[0][0]);

                        double no_of_hours = Convert.ToDouble(dt_exel.Rows[i].Cells[13].Value);
                        double value_of_stay = Convert.ToDouble(client.get_value_of_stay_with_client_id(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value)).Rows[0][0]);

                       
                        
                            double tax = 0;
                            if ((no_of_hours * value_of_stay) >= 1250)
                            {
                                tax = ((((no_of_hours * value_of_stay * 12) - 15000.0) / 12) * 0.015);
                                client.update_tax_for_month(dateTimePicker1.Value, Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), tax);
                            }
                            else
                            {
                                client.update_tax_for_month(dateTimePicker1.Value, Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), 0);
                            }
                        
                        client.addDeduction(dateTimePicker1.Value, Convert.ToDouble(dt_exel.Rows[i].Cells[8].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[9].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[10].Value), Convert.ToInt32(dt_exel.Rows[i].Cells[11].Value)
                     , ((Convert.ToDouble(client.get_value_of_stay_with_client_id(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value)).Rows[0][0]) * Convert.ToDouble(dt_exel.Rows[i].Cells[13].Value) / 30.0) * Convert.ToInt32(dt_exel.Rows[i].Cells[11].Value)),

                     (((Convert.ToDouble(client.get_value_of_stay_with_client_id(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value)).Rows[0][0]) * Convert.ToDouble(dt_exel.Rows[i].Cells[13].Value) / 30.0)) / 6) * Convert.ToDouble(dt_exel.Rows[i].Cells[8].Value), Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value));
                  client.addShift(Convert.ToInt32(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value)), dateTimePicker1.Value, 0, 0, (Convert.ToDouble(dt_exel.Rows[i].Cells[6].Value)),
                  (Convert.ToDouble(dt_exel.Rows[i].Cells[7].Value)), Convert.ToDouble(dt_exel.Rows[i].Cells[13].Value));

                        client.addIncentives(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), ((Convert.ToDouble(client.get_value_of_stay_with_client_id(Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value)).Rows[0][0]) * Convert.ToDouble(dt_exel.Rows[i].Cells[13].Value))) * Convert.ToDouble(client.get_incentives(depart_role_id).Rows[0][0]), depart_role_id);
                    }
                    client.add_other(Convert.ToString(dt_exel.Rows[i].Cells[15].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[14].Value), Convert.ToString(dt_exel.Rows[i].Cells[17].Value), Convert.ToDouble(dt_exel.Rows[i].Cells[16].Value), dateTimePicker1.Value, Convert.ToInt32(dt_exel.Rows[i].Cells[0].Value), 0, "");
                          


                }
                Cursor.Current = Cursors.Default;

           
               /*if (start == end)
                {
                    MessageBox.Show("لم يتم اضافة اي بايانات تأكد انك قمت بإضافة ملف الاكسيل", "لا توجد بايانات", MessageBoxButtons.OK);
                }
                else
                {*/
                    MessageBox.Show("تمت عملية الاضافة الي قاعدة البيانات بنجاح", "تم الاضافة", MessageBoxButtons.OK);
               //}

            /*}catch(IndexOutOfRangeException)
            {

                MessageBox.Show("تأكد انك قمت بإضافة جميع الاقسم في البرنامج وتعريف ثوابتها" , "فشلت عملية الاضافة", MessageBoxButtons.OK);
            
            }*/
      
        }

        private void dt_exel_Click(object sender, EventArgs e)
        {
            try
            {
                dt_exel.CurrentRow.Selected = true;
            }catch (NullReferenceException)
            {
                MessageBox.Show("انت تحاول ان تقوم بعرض بيانات غير موجودة الرجاء التأكد انك قمت بإضافة حركات الموظفين عن طريق زرار اضافة ملف اكسيل", "اعد المحاولة", MessageBoxButtons.OK);
            }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            backup frm = new backup();
            frm.ShowDialog();











        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            frm_reports frm = new frm_reports();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            client_motion frm = new client_motion();

            frm.txt_dely_minute.Text = "0";

            Cursor.Current = Cursors.Default;

            for (int i = 0; i < motions.get_types_of_motions().Rows.Count; i++)
            {


                frm.combo_cat.Items.Add(motions.get_types_of_motions().Rows[i][1]);
            

            }

            frm.txt_month.Text = dateTimePicker1.Value.Month.ToString();
            frm.txt_year.Text = dateTimePicker1.Value.Year.ToString();
            frm.txt_day.Text = dateTimePicker1.Value.Day.ToString();


            frm.data_all_clients.DataSource = motions.get_cleint_name_id_department_role();
            Cursor.Current = Cursors.Default;
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            select_month_year frm = new select_month_year();
            frm.combo_year.Text = dateTimePicker1.Value.Year.ToString();
            frm.combo_month.SelectedIndex = Convert.ToInt32(dateTimePicker1.Value.Month-1);
            frm.ShowDialog();
        }

        private void Getting_Start_Resize(object sender, EventArgs e)
        {
            resizeControlers();

        }
    }
}
