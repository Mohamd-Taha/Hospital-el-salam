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
    public partial class select_depart : Form
    {
        BL.Client client = new BL.Client();
        public select_depart()
        {
          
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RPT.print_sallary_of_depart all = new RPT.print_sallary_of_depart();

            RPT.from_print frm = new RPT.from_print();

           all.SetDataSource(client.print_sallary_of_depart(comboBox1.SelectedText.ToString()));
            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // gg.SetParameterValue("@id", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            this.Cursor = Cursors.WaitCursor;

            RPT.print_sallary_of_depart all = new RPT.print_sallary_of_depart();

            RPT.from_print frm = new RPT.from_print();
            all.SetParameterValue("@department",comboBox1.SelectedItem.ToString());
         //   all.SetDataSource(client.print_sallary_of_depart(comboBox1.SelectedText.ToString()));
            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void select_depart_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
