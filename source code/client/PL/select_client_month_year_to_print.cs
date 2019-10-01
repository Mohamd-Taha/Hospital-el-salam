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
            orginalSize = this.Size;
            groupBox1OriginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            label3OriginalArea = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            txt_searchOriginalArea = new Rectangle(txt_search.Location.X, txt_search.Location.Y, txt_search.Width, txt_search.Height);
            dataGridView1OriginalArea = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);
            groupBox2OriginalArea = new Rectangle(groupBox2.Location.X, groupBox2.Location.Y, groupBox2.Width, groupBox2.Height);
            label1OriginalArea = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            txt_monthOriginalArea = new Rectangle(txt_month.Location.X, txt_month.Location.Y, txt_month.Width, txt_month.Height);
            label2OriginalArea = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            txt_yearOriginalArea = new Rectangle(txt_year.Location.X, txt_year.Location.Y, txt_year.Width, txt_year.Height);
            label4OriginalArea = new Rectangle(label4.Location.X, label4.Location.Y, label4.Width, label4.Height);
            dateTimePicker1OriginalArea = new Rectangle(dateTimePicker1.Location.X, dateTimePicker1.Location.Y, dateTimePicker1.Width, dateTimePicker1.Height);
                    }
        private Rectangle groupBox1OriginalArea;
        private Rectangle label3OriginalArea;
        private Rectangle txt_searchOriginalArea;
        private Rectangle dataGridView1OriginalArea;
        private Rectangle groupBox2OriginalArea;
        private Rectangle label1OriginalArea;
        private Rectangle txt_monthOriginalArea;
        private Rectangle label2OriginalArea;
        private Rectangle txt_yearOriginalArea;
        private Rectangle label4OriginalArea;
        private Rectangle dateTimePicker1OriginalArea;
        private Size orginalSize;

        private void resizeControlers()
        {
            resizeControler(groupBox1OriginalArea, groupBox1);
            resizeControler(label3OriginalArea, label3);
            resizeControler(txt_searchOriginalArea, txt_search);
            resizeControler(dataGridView1OriginalArea, dataGridView1);
            resizeControler(groupBox2OriginalArea, groupBox2);
            resizeControler(label1OriginalArea, label1);
            resizeControler(txt_monthOriginalArea, txt_month);
            resizeControler(label2OriginalArea, label2);
            resizeControler(txt_yearOriginalArea, txt_year);
            resizeControler(label4OriginalArea, label4);
            resizeControler(dateTimePicker1OriginalArea, dateTimePicker1);
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
