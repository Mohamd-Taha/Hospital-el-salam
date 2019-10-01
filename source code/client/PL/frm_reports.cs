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
            orginalSize = this.Size;
            button11OriginalArea = new Rectangle(button11.Location.X, button11.Location.Y, button11.Width, button11.Height);
            button10OriginalArea = new Rectangle(button10.Location.X, button10.Location.Y, button10.Width, button10.Height);
            button9OriginalArea = new Rectangle(button9.Location.X, button9.Location.Y, button9.Width, button9.Height);
            label1OriginalArea = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            dateTimePicker1OriginalArea = new Rectangle(dateTimePicker1.Location.X, dateTimePicker1.Location.Y, dateTimePicker1.Width, dateTimePicker1.Height);
            button1OriginalArea = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            button3OriginalArea = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            button2OriginalArea = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            button4OriginalArea = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
            button5OriginalArea=new Rectangle( button5.Location.X,button5.Location.Y,button5.Width,button5.Height);
            button6OriginalArea=new Rectangle (button6.Location.X,button6.Location.Y,button6.Width,button6.Height);
            button7OriginalArea=new Rectangle ( button7.Location.X,button7.Location.Y,button7.Width,button7.Height);
            button8OriginalArea=new Rectangle(button8.Location.X,button8.Location.Y,button8.Width,button8.Height);

        }
        private Size orginalSize;
        private Rectangle button11OriginalArea;
        private Rectangle button10OriginalArea;
        private Rectangle button9OriginalArea;
        private Rectangle label1OriginalArea;
        private Rectangle dateTimePicker1OriginalArea;
        private Rectangle button1OriginalArea;
        private Rectangle button3OriginalArea;
        private Rectangle button2OriginalArea;
        private Rectangle button4OriginalArea;
        private Rectangle button5OriginalArea;
        private Rectangle button6OriginalArea;
        private Rectangle button7OriginalArea;
        private Rectangle button8OriginalArea;

        private void resizeControlers()
        {
            resizeControler(button11OriginalArea, button11);
            resizeControler(button10OriginalArea, button10);
            resizeControler(button9OriginalArea, button9);
            resizeControler(label1OriginalArea, label1);
            resizeControler(dateTimePicker1OriginalArea, dateTimePicker1);
            resizeControler(button1OriginalArea, button1);
            resizeControler(button3OriginalArea, button3);
            resizeControler(button2OriginalArea, button2);
            resizeControler(button4OriginalArea, button4);
            resizeControler(button5OriginalArea, button5);
            resizeControler(button6OriginalArea, button6);
            resizeControler(button7OriginalArea, button7);
            resizeControler(button8OriginalArea, button8);

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

         private void button5_Resize(object sender, EventArgs e)
          {
           
          }

        private void frm_reports_Resize(object sender, EventArgs e)
        {
            resizeControlers();
        }
    }
}
  