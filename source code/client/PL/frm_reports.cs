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
    public partial class frm_reports : Form
    {
        BL.Client client = new BL.Client();
        public frm_reports()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RPT.rpt_all_we_need_about_client all = new RPT.rpt_all_we_need_about_client();
     
            RPT.from_print frm = new RPT.from_print();

            //all.SetDataSource(order.get_order_diatels(id_order));
            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void frm_reports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RPT.print_AllClients all = new RPT.print_AllClients();

            RPT.from_print frm = new RPT.from_print();

            //all.SetDataSource(order.get_order_diatels(id_order));
            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select_depart frm = new select_depart();
            for (int i = 0; i < client.get_role_and_department().Rows.Count; i++)
            {



                frm.comboBox1.Items.Add(client.get_role_and_department().Rows[i][2]);


            }


            List<object> departments = new List<object>();
            foreach (object o in frm.comboBox1.Items)
            {
                if (!departments.Contains(o))
                {
                    departments.Add(o);
                }
            }
            frm.comboBox1.Items.Clear();
            frm.comboBox1.Items.AddRange(departments.ToArray());
            frm.comboBox1.SelectedIndex = 0;
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            select_client_month_year_to_print frm = new select_client_month_year_to_print();
            frm.dataGridView1.DataSource = client.get_client();
            frm.txt_month.Text = dateTimePicker1.Value.Month.ToString();
            frm.txt_year.Text = dateTimePicker1.Value.Year.ToString();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RPT.print_all_clients all = new RPT.print_all_clients();

            RPT.from_print frm = new RPT.from_print();

            
            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RPT.print_shift_sallary all = new RPT.print_shift_sallary();



            all.SetParameterValue(0, Convert.ToString(dateTimePicker1.Value.Month));
            all.SetParameterValue(1,Convert.ToString(dateTimePicker1.Value.Year));



            RPT.from_print frm = new RPT.from_print();


            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RPT.print_sallary_sallary all = new RPT.print_sallary_sallary();



            all.SetParameterValue(0, Convert.ToString(dateTimePicker1.Value.Month));
            all.SetParameterValue(1, Convert.ToString(dateTimePicker1.Value.Year));



            RPT.from_print frm = new RPT.from_print();


            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RPT.print_sallary_stay all = new RPT.print_sallary_stay();



            all.SetParameterValue(0, Convert.ToString(dateTimePicker1.Value.Month));
            all.SetParameterValue(1, Convert.ToString(dateTimePicker1.Value.Year));



            RPT.from_print frm = new RPT.from_print();


            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RPT.get_data_about_shiftes_to_print all = new RPT.get_data_about_shiftes_to_print();



            all.SetParameterValue(0, Convert.ToString(dateTimePicker1.Value.Month));
            all.SetParameterValue(1, Convert.ToString(dateTimePicker1.Value.Year));



            RPT.from_print frm = new RPT.from_print();


            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            RPT.get_data_about_salary_to_print all = new RPT.get_data_about_salary_to_print();



            all.SetParameterValue(0, Convert.ToString(dateTimePicker1.Value.Month));
            all.SetParameterValue(1, Convert.ToString(dateTimePicker1.Value.Year));



            RPT.from_print frm = new RPT.from_print();


            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RPT.get_data_about_staying_to_print all = new RPT.get_data_about_staying_to_print();



            all.SetParameterValue(0, Convert.ToString(dateTimePicker1.Value.Month));
            all.SetParameterValue(1, Convert.ToString(dateTimePicker1.Value.Year));



            RPT.from_print frm = new RPT.from_print();


            frm.crystalReportViewer1.ReportSource = all;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }
    }
}
  