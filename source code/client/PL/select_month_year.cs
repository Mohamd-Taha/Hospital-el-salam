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
    public partial class select_month_year : Form
    {
        public select_month_year()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_client_managment frm = new frm_client_managment();
            frm.txt_user.Text = Program.user_name;
            frm.txt_month_visiable.Text = combo_month.SelectedItem.ToString();
            frm.txt_month.Text = ((combo_month.SelectedIndex)+1).ToString();
            frm.txt_year.Text = combo_year.SelectedItem.ToString();
            frm.ShowDialog();
        }
    }
}
