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
    public partial class frm_role_and_department : Form
    {
        BL.Client client = new BL.Client();
        public frm_role_and_department()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            client.add_role_and_department(Convert.ToInt32(txt_id.Text),txt_role.Text, txt_department.Text);
            MessageBox.Show("تمت عملية الاضافة بنجاح", "تم الحفظ", MessageBoxButtons.OK);
            txt_department.Clear();
            txt_role.Clear();
            txt_id.Text = (Convert.ToInt32(txt_id.Text) + 1).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_view_role_and_department frm = new frm_view_role_and_department();
            frm.ShowDialog();
        }

        private void frm_role_and_department_Load(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}
