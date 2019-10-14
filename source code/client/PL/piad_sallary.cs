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
    public partial class piad_sallary : Form
    {
        BL.Client client = new BL.Client();

        public piad_sallary()
        {

            InitializeComponent();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void txt_client_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_client_search.Text != string.Empty)
            {
                dataGridView1.DataSource = client.search_in_clients(txt_client_search.Text);
            }
            else
                dataGridView1.DataSource = client.getCleint();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                bool is_checked = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                if (is_checked == true)
                {
                    client.add_piad_sallary(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), dateTimePicker1.Value, Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value), comb_month.SelectedItem.ToString(), combo_year.SelectedItem.ToString());
                    client.update_client_sallary_state(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), dateTimePicker1.Value.Month.ToString(), dateTimePicker1.Value.Year.ToString(), "received");
                }

            }
            MessageBox.Show("تم");

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            frm_employee frm = new frm_employee();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                bool is_checked = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                if (is_checked == true)
                {
                    client.add_piad_sallary(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), dateTimePicker1.Value, Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value), comb_month.SelectedItem.ToString(), combo_year.SelectedItem.ToString());
                    client.update_client_sallary_state(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), dateTimePicker1.Value.Month.ToString(), dateTimePicker1.Value.Year.ToString(), "received");
                }

            }

            dataGridView1.Update();
            MessageBox.Show("تم التسليم بنجاح");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void piad_sallary_Load(object sender, EventArgs e)
        {
            orginalSize = this.Size;
            groupBox12OriginalArea = new Rectangle(groupBox12.Location.X, groupBox12.Location.Y, groupBox12.Width, groupBox12.Height);
            label10OriginalArea = new Rectangle(label10.Location.X, label10.Location.Y, label10.Width, label10.Height);
            txt_client_searchOriginalArea = new Rectangle(txt_client_search.Location.X, txt_client_search.Location.Y, txt_client_search.Width, txt_client_search.Height);
            groupBox3OriginalArea = new Rectangle(groupBox3.Location.X, groupBox3.Location.Y, groupBox3.Width, groupBox3.Height);
            label3OriginalArea = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            combo_yearOriginalArea = new Rectangle(combo_year.Location.X, combo_year.Location.Y, combo_year.Width, combo_year.Height);
            groupBox2OriginalArea = new Rectangle(groupBox2.Location.X, groupBox2.Location.Y, groupBox2.Width, groupBox2.Height);
            label2OriginalArea = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            comb_monthOriginalArea = new Rectangle(comb_month.Location.X, comb_month.Location.Y, comb_month.Width, comb_month.Height);
            groupBox1OriginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            label1OriginalArea = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            dateTimePicker1OriginalArea = new Rectangle(dateTimePicker1.Location.X, dateTimePicker1.Location.Y, dateTimePicker1.Width, dateTimePicker1.Height);
            groupBox11OriginalArea = new Rectangle(groupBox11.Location.X, groupBox11.Location.Y, groupBox11.Width, groupBox11.Height);
            dataGridView1OriginalArea = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);
            groupBox4OriginalArea = new Rectangle(groupBox4.Location.X, groupBox4.Location.Y, groupBox4.Width, groupBox4.Height);
            button1OriginalArea = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            btn_exitOriginalArea = new Rectangle(btn_exit.Location.X, btn_exit.Location.Y, btn_exit.Width, btn_exit.Height);

        }
        private Rectangle groupBox12OriginalArea;
        private Rectangle label10OriginalArea;
        private Rectangle txt_client_searchOriginalArea;
        private Rectangle groupBox3OriginalArea;
        private Rectangle label3OriginalArea;
        private Rectangle combo_yearOriginalArea;
        private Rectangle groupBox2OriginalArea;
        private Rectangle label2OriginalArea;
        private Rectangle comb_monthOriginalArea;
        private Rectangle groupBox1OriginalArea;
        private Rectangle label1OriginalArea;
        private Rectangle dateTimePicker1OriginalArea;
        private Rectangle groupBox11OriginalArea;
        private Rectangle dataGridView1OriginalArea;
        private Rectangle groupBox4OriginalArea;
        private Rectangle button1OriginalArea;
        private Rectangle btn_exitOriginalArea;
        private Size orginalSize;
        private void resizeControlers()
        {
            resizeControler(groupBox12OriginalArea, groupBox12);
            resizeControler(label10OriginalArea, label10);
            resizeControler(txt_client_searchOriginalArea, txt_client_search);
            resizeControler(groupBox3OriginalArea, groupBox3);
            resizeControler(label3OriginalArea, label3);
            resizeControler(combo_yearOriginalArea, combo_year);
            resizeControler(groupBox2OriginalArea, groupBox2);
            resizeControler(label2OriginalArea, label2);
            resizeControler(comb_monthOriginalArea, comb_month);
            resizeControler(groupBox1OriginalArea, groupBox1);
            resizeControler(label1OriginalArea, label1);
            resizeControler(dateTimePicker1OriginalArea, dateTimePicker1);
            resizeControler(groupBox11OriginalArea, groupBox11);
            resizeControler(dataGridView1OriginalArea, dataGridView1);
            resizeControler(groupBox4OriginalArea, groupBox4);
            resizeControler(button1OriginalArea, button1);
            resizeControler(btn_exitOriginalArea, btn_exit);

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

        private void piad_sallary_Resize(object sender, EventArgs e)
        {
            //resizeControlers();
        }
    }

}

