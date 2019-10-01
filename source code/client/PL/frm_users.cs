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
            orginalSize = this.Size;
            groupBox3OriginalArea = new Rectangle(groupBox3.Location.X, groupBox3.Location.Y, groupBox3.Width, groupBox3.Height);
            label9OriginalArea = new Rectangle(label9.Location.X, label9.Location.Y, label9.Width, label9.Height);
            groupBox1OriginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            label3OriginalArea = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            label8OriginalArea = new Rectangle(label8.Location.X, label8.Location.Y, label8.Width, label8.Height);
            label7OriginalArea = new Rectangle(label7.Location.X, label7.Location.Y, label7.Width, label7.Height);
            label5OriginalArea = new Rectangle(label5.Location.X, label5.Location.Y, label5.Width, label5.Height);
            groupBox2OriginalArea = new Rectangle(groupBox2.Location.X, groupBox2.Location.Y, groupBox2.Width, groupBox2.Height);
            txt_user_fullnameOriginalArea = new Rectangle(txt_user_fullname.Location.X, txt_user_fullname.Location.Y, txt_user_fullname.Width, txt_user_fullname.Height);
            txt_user_nameOriginalArea = new Rectangle(txt_user_name.Location.X, txt_user_name.Location.Y, txt_user_name.Width, txt_user_name.Height);
            txt_user_passwordOriginalArea = new Rectangle(txt_user_password.Location.X, txt_user_password.Location.Y, txt_user_password.Width, txt_user_password.Height);
            cmobo_accessiblityOriginalArea = new Rectangle(cmobo_accessiblity.Location.X, cmobo_accessiblity.Location.Y, cmobo_accessiblity.Width, cmobo_accessiblity.Height);
            groupBox11OriginalArea = new Rectangle(groupBox11.Location.X, groupBox11.Location.Y, groupBox11.Width, groupBox11.Height);
            dataGridView1OriginalArea = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);
            groupBox4OriginalArea = new Rectangle(groupBox4.Location.X, groupBox4.Location.Y, groupBox4.Width, groupBox4.Height);
            btn_addOriginalArea = new Rectangle(btn_add.Location.X, btn_add.Location.Y, btn_add.Width, btn_add.Height);
            btn_saveOriginalArea = new Rectangle(btn_save.Location.X, btn_save.Location.Y, btn_save.Width, btn_save.Height);
            btn_editOriginalArea = new Rectangle(btn_edit.Location.X, btn_edit.Location.Y, btn_edit.Width, btn_edit.Height);
            btn_deleteOriginalArea = new Rectangle(btn_delete.Location.X, btn_delete.Location.Y, btn_delete.Width, btn_delete.Height);
            btn_exitOriginalArea = new Rectangle(btn_exit.Location.X, btn_exit.Location.Y, btn_exit.Width, btn_exit.Height);
                    }
        private Size orginalSize;
        private Rectangle groupBox3OriginalArea;
        private Rectangle label9OriginalArea;
        private Rectangle groupBox1OriginalArea;
        private Rectangle label3OriginalArea;
        private Rectangle label8OriginalArea;
        private Rectangle label7OriginalArea;
        private Rectangle label5OriginalArea;
        private Rectangle groupBox2OriginalArea;
        private Rectangle txt_user_fullnameOriginalArea;
        private Rectangle txt_user_nameOriginalArea;
        private Rectangle txt_user_passwordOriginalArea;
        private Rectangle cmobo_accessiblityOriginalArea;
        private Rectangle groupBox11OriginalArea;
        private Rectangle dataGridView1OriginalArea;
        private Rectangle groupBox4OriginalArea;
        private Rectangle btn_addOriginalArea;
        private Rectangle btn_saveOriginalArea;
        private Rectangle btn_editOriginalArea;
        private Rectangle btn_deleteOriginalArea;
        private Rectangle btn_exitOriginalArea;
        private void resizeControlers()
        {
            resizeControler(groupBox3OriginalArea, groupBox3);
            resizeControler(label9OriginalArea, label9);
            resizeControler(groupBox1OriginalArea, groupBox1);
            resizeControler(label3OriginalArea, label3);
            resizeControler(label8OriginalArea, label8);
            resizeControler(label7OriginalArea, label7);
            resizeControler(label5OriginalArea, label5);
            resizeControler(groupBox2OriginalArea, groupBox2);
            resizeControler(txt_user_fullnameOriginalArea, txt_user_fullname);
            resizeControler(txt_user_nameOriginalArea, txt_user_name);
            resizeControler(txt_user_passwordOriginalArea, txt_user_password);
            resizeControler(cmobo_accessiblityOriginalArea, cmobo_accessiblity);
            resizeControler(groupBox11OriginalArea, groupBox11);
            resizeControler(dataGridView1OriginalArea, dataGridView1);
            resizeControler(groupBox4OriginalArea, groupBox4);
            resizeControler(btn_addOriginalArea, btn_add);
            resizeControler(btn_saveOriginalArea, btn_save);
            resizeControler(btn_editOriginalArea, btn_edit);
            resizeControler(btn_deleteOriginalArea, btn_delete);
            resizeControler(btn_exitOriginalArea, btn_exit);
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
