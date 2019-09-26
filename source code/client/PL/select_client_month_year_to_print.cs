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
    public partial class select_client_month_year_to_print : Form
    {
        BL.Client client = new BL.Client();
        public select_client_month_year_to_print()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

       
            this.Cursor = Cursors.WaitCursor;

            RPT.print_details_about_sallary_of_client all = new RPT.print_details_about_sallary_of_client();

            RPT.from_print frm = new RPT.from_print();
            all.SetParameterValue(0,Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
          all.SetParameterValue(1, txt_month.Text);
          all.SetParameterValue(2,txt_year.Text);
           
         
            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;









        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_month.Text = dateTimePicker1.Value.Month.ToString();
            txt_year.Text = dateTimePicker1.Value.Year.ToString();
        }

        private void select_client_month_year_to_print_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != string.Empty)
            {
                dataGridView1.DataSource = client.search_in_client(txt_search.Text);
            }
            else
                dataGridView1.DataSource = client.get_client();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RPT.print_details_about_sallary_of_client all = new RPT.print_details_about_sallary_of_client();

            RPT.from_print frm = new RPT.from_print();
            all.SetParameterValue(0, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            all.SetParameterValue(1, txt_month.Text);
            all.SetParameterValue(2, txt_year.Text);


            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
