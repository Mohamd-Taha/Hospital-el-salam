using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.PL
{
    public partial class frm_login : Form
    {
        BL.Login log_in = new BL.Login();
        PL.Getting_Start get_start = new Getting_Start();
        public string state;
        
        public frm_login()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            state = "Closed";
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            PL.Getting_Start frm = new Getting_Start();


            if (state == "first time")
            {
                frm.Show();
            }

            else if (state == "confirm_sallary")
            {
                txt_user_name.Text = Program.user_name;
                if (txt_password.Text == Program.user_password)
                {



                    this.Close();
                
                }
            }
            else
            {

                dataGridView1.DataSource = log_in.log_in(txt_user_name.Text, txt_password.Text);



                if (txt_user_name.Text == "admin" && txt_password.Text == "password")
                {
                   
                    Program.user_name = txt_user_name.Text;
                    Program.user_id = Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value);
                    Program.last_log_in = dateTimePicker1.Value;
                    this.Hide();
                    frm.Show();

                }
                if (Convert.ToInt32(dataGridView1.Rows.Count - 1) == 0)
                {


                    if (txt_user_name.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("قم بإدخال اسم المستخدم", "حقل اسم المستخدم فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    else if (txt_password.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("قم بإدخال كلمة السر", "حقل كلمة السر فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_password.Clear();

                    }

                    else
                    {

                        MessageBox.Show("اسم المستخدم او كلمة السر خطأ", "حاول مرة اخري", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_password.Clear();
                    }







                }

                else
                {



                    Program.User_Name = txt_user_name.Text;
                    Program.last_log_in = dateTimePicker1.Value;
                    Program.user_password = this.txt_password.Text;
                    frm.txt_user_name.Text = Program.User_Name;
                    frm.txt_last_login_date.Text = Program.last_log_in.ToString();
                    Program.user_type = log_in.log_in(txt_user_name.Text, txt_password.Text).Rows[0][3].ToString();


                    if (Program.user_type == "حسابات")
                    {
                        this.Hide();
                        frm.btn_backup.Enabled = true;
                        frm.btn_employee.Enabled = true;
                        frm.btn_report.Enabled = true;
                        frm.btn_restore_backup.Enabled = true;
                        frm.btn_settings.Enabled = true;
                        frm.btn_users.Enabled = true;

                        frm.Show();
                    }

                    else
                    {
                        frm.btn_backup.Enabled = false;
                        frm.btn_employee.Enabled = false;
                        frm.btn_report.Enabled = false;
                        frm.btn_restore_backup.Enabled = false;
                        frm.btn_settings.Enabled = false;
                        frm.btn_users.Enabled = false;

                        this.Hide();
                        frm.Show();
                    }

                }
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
