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
    public partial class frm_view_constants : Form
    {
        BL.Client client = new BL.Client();
        public frm_view_constants()
        {
            InitializeComponent();
        }

        private void frm_view_constants_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.get_all_Constants();
            for (int i = 0; i < client.get_role_and_department().Rows.Count; i++)
            {

                if (!combo_role.Items.Contains(client.get_role_and_department().Rows[i][1].ToString()))
                {
                    combo_role.Items.Add(client.get_role_and_department().Rows[i][1]);
                }
                if (!combo_department.Items.Contains(client.get_role_and_department().Rows[i][1].ToString()))
                {
                    combo_department.Items.Add(client.get_role_and_department().Rows[i][2]);
                }

            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
              
           dataGridView1.CurrentRow.Selected = true;
           txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           combo_department.SelectedItem = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           combo_role.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           txt_new_insurance.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           txt_old_insurance.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           txt_morning_shift_value.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           txt_night_shift_value.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
           txt_Incentives.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
         
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_id.Enabled == false)
            {
                txt_id.Enabled = true;
                txt_Incentives.Enabled = true;
                txt_morning_shift_value.Enabled = true;
                txt_new_insurance.Enabled = true;
                txt_night_shift_value.Enabled = true;
                txt_old_insurance.Enabled = true;
                combo_department.Enabled = true;
                combo_role.Enabled = true;
                btn_save.Enabled = true;

            }
            else
            {
                
                    txt_id.Enabled = false;
                    txt_Incentives.Enabled = false;
                    txt_morning_shift_value.Enabled = false;
                    txt_new_insurance.Enabled = false;
                    txt_night_shift_value.Enabled = false;
                    txt_old_insurance.Enabled = false;
                    combo_department.Enabled = false;
                    combo_role.Enabled = false;
                    btn_save.Enabled = false;


                
            
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            client.update_consatant(Convert.ToDouble(txt_new_insurance.Text), Convert.ToDouble(txt_old_insurance.Text),
                Convert.ToDouble(txt_morning_shift_value.Text), Convert.ToDouble(txt_night_shift_value.Text), Convert.ToDouble(txt_Incentives.Text), Convert.ToInt32(txt_id.Text));
            dataGridView1.DataSource = client.get_all_Constants();
            dataGridView1.Update();
               
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            client.delete_constant(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            dataGridView1.DataSource = client.get_all_Constants();
            dataGridView1.Update();
            MessageBox.Show("تمت عملية الحذف بنجاح", "تم الحذف", MessageBoxButtons.OK);
        }

        private void txt_new_insurance_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}
