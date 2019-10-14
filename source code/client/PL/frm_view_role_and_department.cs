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
    }
}
