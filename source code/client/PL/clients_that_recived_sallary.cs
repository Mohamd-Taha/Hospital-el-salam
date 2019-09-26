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
    public partial class clients_that_recived_sallary : Form
    {
        BL.Client client = new BL.Client();
        public clients_that_recived_sallary()
        {
            InitializeComponent();
        }

        private void txt_client_search_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void combo_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(comb_month.Text) != string.Empty)
            {
                
                dataGridView1.DataSource = client.get_clints_that_received_them_salary_for_month_and_year(comb_month.SelectedItem.ToString(), combo_year.SelectedItem.ToString());
            }
        }

        private void comb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(combo_year.Text) != string.Empty)
            {

                dataGridView1.DataSource = client.get_clints_that_received_them_salary_for_month_and_year(comb_month.SelectedItem.ToString(), combo_year.SelectedItem.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clients_that_recived_sallary_Load(object sender, EventArgs e)
        {
            orginalSize = this.Size;
            groupBox12OrginalArea = new Rectangle(groupBox12.Location.X, groupBox12.Location.Y, groupBox12.Width, groupBox12.Height);
            label10rginalArea = new Rectangle(label10.Location.X, label10.Location.Y, label10.Width, label10.Height);
            txt_client_searchOrginalArea = new Rectangle(txt_client_search.Location.X, txt_client_search.Location.Y, txt_client_search.Width, txt_client_search.Height);
            groupBox3OrginalArea = new Rectangle(groupBox3.Location.X, groupBox3.Location.Y, groupBox3.Width, groupBox3.Height);
            label3OrginalArea = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            combo_yearOrginalArea = new Rectangle(combo_year.Location.X, combo_year.Location.Y, combo_year.Width, combo_year.Height);
            groupBox2OrginalArea = new Rectangle(groupBox2.Location.X, groupBox2.Location.Y, groupBox2.Width, groupBox2.Height);


            label2OrginalArea = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);

            comb_monthOrginalArea = new Rectangle(comb_month.Location.X, comb_month.Location.Y, comb_month.Width, comb_month.Height);
            groupBox11OrginalArea = new Rectangle(groupBox11.Location.X, groupBox11.Location.Y, groupBox11.Width, groupBox11.Height);

            dataGridView1OrginalArea = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);
            groupBox1OrginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            btn_exitOrginalArea = new Rectangle(btn_exit.Location.X, btn_exit.Location.Y, btn_exit.Width, btn_exit.Height);
        }

        private Rectangle groupBox12OrginalArea;
        private Rectangle label10rginalArea;
        private Rectangle txt_client_searchOrginalArea;
        private Rectangle groupBox3OrginalArea;
        private Rectangle label3OrginalArea;
        private Rectangle combo_yearOrginalArea;
        private Rectangle groupBox2OrginalArea;
        private Rectangle label2OrginalArea;
        private Rectangle comb_monthOrginalArea;
        private Rectangle groupBox11OrginalArea;
        private Rectangle dataGridView1OrginalArea;
        private Rectangle groupBox1OrginalArea;
        private Rectangle btn_exitOrginalArea;

        private Size orginalSize;

        private void resizeControlers()
        {
            resizeControler(groupBox12OrginalArea, groupBox12);
            resizeControler(label10rginalArea, label10);
            resizeControler(txt_client_searchOrginalArea, txt_client_search);
            resizeControler(groupBox3OrginalArea, groupBox3);
            resizeControler(label3OrginalArea, label3);
            resizeControler(combo_yearOrginalArea, combo_year);
            resizeControler(groupBox2OrginalArea, groupBox2);
            resizeControler(groupBox11OrginalArea, groupBox11);
            resizeControler(label2OrginalArea, label2);
            resizeControler(comb_monthOrginalArea, comb_month);
            resizeControler(dataGridView1OrginalArea, dataGridView1);
            resizeControler(groupBox1OrginalArea, groupBox1);
            resizeControler(btn_exitOrginalArea, btn_exit);
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

        private void clients_that_recived_sallary_Resize(object sender, EventArgs e)
        {

            resizeControlers();
        }



    }
}
