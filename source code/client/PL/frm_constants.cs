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
    public partial class frm_constants : Form
    {
        BL.Client client = new BL.Client();
        public frm_constants()
        {

            InitializeComponent();

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           if (client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows.Count == 0)
            {
               client.addConstants(Convert.ToInt32(txt_role_dept_id.Text), Convert.ToDouble(txt_new_insurance.Text), Convert.ToDouble(txt_old_insurance.Text), Convert.ToDouble(txt_morning_shift_value.Text), Convert.ToDouble(txt_night_shift_value.Text),Convert.ToDouble(txt_Incentives.Text));
            
          }

            else
           {
               client.update_consatant(Convert.ToDouble(txt_new_insurance.Text), Convert.ToDouble(txt_old_insurance.Text), Convert.ToDouble(txt_morning_shift_value.Text), Convert.ToDouble(txt_night_shift_value.Text), Convert.ToDouble(txt_Incentives.Text), Convert.ToInt32(txt_role_dept_id.Text));

            }
           combo_role.ResetText();
           combo_department.ResetText();
           MessageBox.Show("تمت عملية إضافة الثوابت بنجاح", "تم الحفظ", MessageBoxButtons.OK);
            
        }

        private void frm_constants_Load(object sender, EventArgs e)
        {
    
            for (int i = 0; i < client.get_role_and_department().Rows.Count; i++)
            {

              
                    combo_role.Items.Add(client.get_role_and_department().Rows[i][1]);
                    combo_department.Items.Add(client.get_role_and_department().Rows[i][2]);
                

            }


            List<object> departments = new List<object>();
            foreach (object o in combo_department.Items)
            {
                if (!departments.Contains(o))
                {
                    departments.Add(o);
                }
            }
            combo_department.Items.Clear();
            combo_department.Items.AddRange(departments.ToArray());

            List<object> roles = new List<object>();
            foreach (object o in combo_role.Items)
            {
                if (!roles.Contains(o))
                {
                    roles.Add(o);
                }
            }
            combo_role.Items.Clear();
            combo_role.Items.AddRange(roles.ToArray());

            
        }
        private void txt_qouta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

     
        private void combo_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_old_insurance_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void combo_role_SelectedIndexChanged_1(object sender, EventArgs e)
        {txt_role_dept_id.Clear();
                     
            if (Convert.ToString( combo_department.Text) != string.Empty)
            {


                if (Convert.ToInt32(client.get_id_of_deparment_and_role(combo_department.SelectedItem.ToString(), combo_role.SelectedItem.ToString()).Rows.Count) == 1)
                    txt_role_dept_id.Text = (client.get_id_of_deparment_and_role(combo_department.SelectedItem.ToString(), combo_role.SelectedItem.ToString())).Rows[0][0].ToString();
         
                    if ( client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows.Count != 0)
                    {
                        txt_morning_shift_value.Text = client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows[0][4].ToString();
                        txt_night_shift_value.Text = client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows[0][5].ToString();
                        txt_new_insurance.Text = client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows[0][2].ToString();
                        txt_old_insurance.Text = client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows[0][3].ToString();
                    }

            }


        }

        private void combo_role_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void combo_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_role_dept_id.Clear();

            if (Convert.ToString(combo_role.Text) != string.Empty)
            {

                txt_role_dept_id.Text = (client.get_id_of_deparment_and_role(combo_department.SelectedItem.ToString(), combo_role.SelectedItem.ToString())).Rows[0][0].ToString();

                if (Convert.ToInt32(client.get_id_of_deparment_and_role(combo_department.SelectedItem.ToString(), combo_role.SelectedItem.ToString()).Rows.Count) == 1)
                    if (client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows.Count != 0)
                    { txt_morning_shift_value.Text = client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows[0][4].ToString();
                        txt_night_shift_value.Text = client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows[0][5].ToString();
                        txt_new_insurance.Text = client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows[0][2].ToString();
                        txt_old_insurance.Text = client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows[0][3].ToString();
                    }

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_view_constants frm = new frm_view_constants();
            frm.ShowDialog();
        }

        private void combo_department_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void combo_department_Validating(object sender, CancelEventArgs e)
        {
           
        }
    }
}
