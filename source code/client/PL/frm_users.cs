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
    public partial  class frm_users : Form
    {
        private static frm_users users;
        static void usersClosed(object sender, FormClosedEventArgs e)
        {
            users = null;
        
        }
        public static frm_users myform
        {
            get 
            {
                if (users == null)
                {
                    users.FormClosed += new FormClosedEventHandler(usersClosed);
                }
                return users;
            }
        
        }
        BL.Client client = new BL.Client();
        BL.User user = new BL.User();
        public frm_users()
        {
            InitializeComponent();
            cmobo_accessiblity.SelectedIndex = 0;
            if (users == null)
            {
                users = this;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
  

        }

        private void txt_user_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
      


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_users_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = user.getUser();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_add_user frm = new frm_add_user();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_user_fullname.ReadOnly)
            {
                txt_user_fullname.ReadOnly = false;
                txt_user_name.ReadOnly = false;
                txt_user_password.ReadOnly = false;
                btn_save.Enabled = true;
                cmobo_accessiblity.Enabled = true;
            }
            else
            {
                txt_user_fullname.ReadOnly = true;
                txt_user_name.ReadOnly = true;
                txt_user_password.ReadOnly = true;
                btn_save.Enabled = false;
                cmobo_accessiblity.Enabled = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_user_fullname.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_user_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_user_password.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmobo_accessiblity.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            user.updateUser(txt_user_fullname.Text, txt_user_name.Text, txt_user_password.Text, cmobo_accessiblity.SelectedItem.ToString());
            dataGridView1.DataSource = user.getUser();
            dataGridView1.Update();
            MessageBox.Show("تمت عملية التحديث بنجاح", "تم التحديث", MessageBoxButtons.OK);
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            user.deleteUser(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            dataGridView1.DataSource = user.getUser();
            dataGridView1.Update();
            MessageBox.Show("تمت عملية الحذف بنجاح", "تم الحذف", MessageBoxButtons.OK);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
        }

        private void cmobo_accessiblity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
