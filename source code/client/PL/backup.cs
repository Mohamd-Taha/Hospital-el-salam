using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace client.PL
{
    public partial class backup : Form
    {
        SqlConnection con = new SqlConnection(@"server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.DataBase + ";Integrated security = true ");


        SqlCommand cmd;

        public backup()
        {
            InitializeComponent();
        }


        // انشاء نسخه احتياطية
        private void btn_ok_Click(object sender, EventArgs e)
        {
            string file_name = txt_path.Text + "\\hospital" + DateTime.Now.ToShortDateString().Replace('/', '_') + " _" + DateTime.Now.ToLongTimeString().Replace(':', '_');

            string strQuery = "Backup Database Client to Disk='" + file_name + ".baK'";
            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم انشاء نسخه احتياطية بنجاح", "انشاء نسخه احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void txt_browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = folderBrowserDialog1.SelectedPath;


            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backup_Load(object sender, EventArgs e)
        {

            orginalSize = this.Size;
            groupBox1OrginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            label1OrginalArea = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            txt_browseOrginalArea = new Rectangle(txt_browse.Location.X, txt_browse.Location.Y, txt_browse.Width, txt_browse.Height);
            txt_pathOrginalArea = new Rectangle(txt_path.Location.X, txt_path.Location.Y, txt_path.Width, txt_path.Height);
            groupBox2OrginalArea = new Rectangle(groupBox2.Location.X, groupBox2.Location.Y, groupBox2.Width, groupBox2.Height);
            groupBox3OrginalArea = new Rectangle(groupBox3.Location.X, groupBox3.Location.Y, groupBox3.Width, groupBox3.Height);
            btn_okOrginalArea = new Rectangle(btn_ok.Location.X, btn_ok.Location.Y, btn_ok.Width, btn_ok.Height);
            btn_closeOrginalArea = new Rectangle(btn_close.Location.X, btn_close.Location.Y, btn_close.Width, btn_close.Height);
        }

        private Rectangle groupBox1OrginalArea;
        private Rectangle label1OrginalArea;
        private Rectangle txt_browseOrginalArea;
        private Rectangle txt_pathOrginalArea;
        private Rectangle groupBox2OrginalArea;
        private Rectangle groupBox3OrginalArea;
        private Rectangle btn_okOrginalArea;
        private Rectangle btn_closeOrginalArea;

        private Size orginalSize;


        private void resizeControlers()
        {
            resizeControler(groupBox1OrginalArea, groupBox1);
            resizeControler(label1OrginalArea, label1);
            resizeControler(txt_browseOrginalArea, txt_browse);
            resizeControler(txt_pathOrginalArea, txt_path);
            resizeControler(groupBox2OrginalArea, groupBox2);
            resizeControler(groupBox3OrginalArea, groupBox3);
            resizeControler(btn_okOrginalArea, btn_ok);
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

        private void backup_Resize(object sender, EventArgs e)
        {
            resizeControlers();
        }
    }
}