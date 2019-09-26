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
    public partial class frm_settings : Form
    {
        BL.Client client = new BL.Client();

        public frm_settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           frm_constants frm = new frm_constants();

           frm.txt_morning_shift_value.Text = "0";
           frm.txt_night_shift_value.Text = "0";
           frm.txt_new_insurance.Text = "0";
           frm.txt_old_insurance.Text = "0";
           frm.txt_Incentives.Text = "0";
            

          
            frm.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_config frm = new frm_config();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_role_and_department frm = new frm_role_and_department();
            frm.ShowDialog();
        }

        private void frm_settings_Load(object sender, EventArgs e)
        {

        }
    }
}
