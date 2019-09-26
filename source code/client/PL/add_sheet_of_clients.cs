using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Data.OleDb;

namespace client.PL
{
    public partial class add_sheet_of_clients : Form
    {
        BL.Client client = new BL.Client();
        OleDbConnection con;
        OleDbDataAdapter da;
        DataTable dt;
        public add_sheet_of_clients()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //الاتصال بالاكسيل وقراءه البيانات


            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ALL Files |*.*| Excel Files |*.XLSX";
            if (op.ShowDialog() == DialogResult.OK)
            {

                con = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source =" + op.FileName + "; Extended Properties = Excel 12.0");

                da = new OleDbDataAdapter("select * from [MH$]", con);

                dt = new DataTable();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                client.addClient(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),Convert.ToString( dataGridView1.Rows[i].Cells[1].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value),Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value), Convert.ToString( dataGridView1.Rows[i].Cells[4].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value));
            }
            MessageBox.Show("تم اضافه الموظفين");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_sheet_of_clients_Load(object sender, EventArgs e)
        {
            orginalSize = this.Size;
            dataGridView1OrginalArea = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);
            groupBox1OrginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            btn_saveOrginalArea = new Rectangle(btn_save.Location.X, btn_save.Location.Y, btn_save.Width, btn_save.Height);
            btn_add_new_exelOrginalArea = new Rectangle(btn_add_new_exel.Location.X, btn_add_new_exel.Location.Y, btn_add_new_exel.Width, btn_add_new_exel.Height);
            btn_closeOrginalArea = new Rectangle(btn_close.Location.X, btn_close.Location.Y, btn_close.Width, btn_close.Height);
        
        }

        private Rectangle dataGridView1OrginalArea;
        private Rectangle groupBox1OrginalArea;
        private Rectangle btn_saveOrginalArea;
        private Rectangle btn_add_new_exelOrginalArea;
        private Rectangle btn_closeOrginalArea;

        private Size orginalSize;
        private void resizeControlers()
        {
            resizeControler(dataGridView1OrginalArea, dataGridView1);
            resizeControler(groupBox1OrginalArea, groupBox1);
            resizeControler(btn_saveOrginalArea, btn_save);
            resizeControler(btn_add_new_exelOrginalArea, btn_add_new_exel);
            resizeControler(btn_closeOrginalArea, btn_close);


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

        private void add_sheet_of_clients_Resize(object sender, EventArgs e)
        {
            resizeControlers();
        }
    }
}
