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
    public partial class frm_view_role_and_department : Form
    {
        BL.Client client = new BL.Client();
        public frm_view_role_and_department()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_view_role_and_departmetn_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.get_role_and_department();
            orginalSize = this.Size;
            groupBox1OriginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            label2OriginalAre = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            label1OriginalArea = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            label3OriginalArea = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            txt_idOriginalArea = new Rectangle(txt_id.Location.X, txt_id.Location.Y, txt_id.Width, txt_id.Height);
            txt_roleOriginalArea = new Rectangle(txt_role.Location.X, txt_role.Location.Y, txt_role.Width, txt_role.Height);
            txt_departmentOriginalArea = new Rectangle(txt_department.Location.X, txt_department.Location.Y, txt_department.Width, txt_department.Height);
            groupBox2OriginalArea = new Rectangle(groupBox2.Location.X, groupBox2.Location.Y, groupBox2.Width, groupBox2.Height);
            dataGridView1OriginalArea = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);
            groupBox3OriginalArea = new Rectangle(groupBox3.Location.X, groupBox3.Location.Y, groupBox3.Width, groupBox3.Height);
            btn_saveOriginalArea = new Rectangle(btn_save.Location.X, btn_save.Location.Y, btn_save.Width, btn_save.Height);
            btn_editOriginalArea = new Rectangle(btn_edit.Location.X, btn_edit.Location.Y, btn_edit.Width, btn_edit.Height);
            btn_deleteOriginalArea = new Rectangle(btn_delete.Location.X, btn_delete.Location.Y, btn_delete.Width, btn_delete.Height);
            btn_exitOriginalArea = new Rectangle(btn_exit.Location.X, btn_exit.Location.Y, btn_exit.Width, btn_exit.Height);

        }
        private Rectangle groupBox1OriginalArea;
        private Rectangle label2OriginalAre;
        private Rectangle label1OriginalArea;
        private Rectangle label3OriginalArea;
        private Rectangle txt_idOriginalArea;
        private Rectangle txt_roleOriginalArea;
        private Rectangle txt_departmentOriginalArea;
        private Rectangle groupBox2OriginalArea;
        private Rectangle dataGridView1OriginalArea;
        private Rectangle groupBox3OriginalArea;
        private Rectangle btn_saveOriginalArea;
        private Rectangle btn_editOriginalArea;
        private Rectangle btn_deleteOriginalArea;
        private Rectangle btn_exitOriginalArea;
        private Size orginalSize;

        private void resizeControlers()
        {
            resizeControler(groupBox1OriginalArea, groupBox1);
            resizeControler(label2OriginalAre, label2);
            resizeControler(label1OriginalArea, label1);
            resizeControler(label3OriginalArea, label3);
            resizeControler(txt_idOriginalArea, txt_id);
            resizeControler(txt_roleOriginalArea, txt_role);
            resizeControler(txt_departmentOriginalArea, txt_department);
            resizeControler(groupBox2OriginalArea, groupBox2);
            resizeControler(dataGridView1OriginalArea, dataGridView1);
            resizeControler(groupBox3OriginalArea, groupBox3);
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


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_role.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_department.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dataGridView1.CurrentRow.Selected = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_department.Enabled == false)
            {
                txt_department.Enabled = true;
                txt_role.Enabled = true;
                btn_save.Enabled = true;
            }
            else
            {
                txt_department.Enabled = false;
                txt_role.Enabled = false;
                btn_save.Enabled = false;
            }

        }

        private void dataGridView1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            client.update_role_and_department(txt_role.Text, txt_department.Text, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            dataGridView1.DataSource = client.get_role_and_department();
            dataGridView1.Update();
            MessageBox.Show("تمت عملية التحديث بنجاح", "تم التحديث", MessageBoxButtons.OK);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            client.delete_role_department(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            dataGridView1.DataSource = client.get_role_and_department();
            dataGridView1.Update();
            MessageBox.Show("تمت عملية الحذف بنجاح", "تم الحذف", MessageBoxButtons.OK);
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          

        }
    }
}
