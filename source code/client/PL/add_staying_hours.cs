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
    public partial class add_staying_hours : Form
    {
        public double number_of_staying_hours;
        public add_staying_hours()
        {
            InitializeComponent();
            txt_number_of_staying_hours.Focus();
        }

        private void add_staying_hours_Load(object sender, EventArgs e)
        {




            orginalSize = this.Size;
            label1OrginalArea = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            label2OrginalArea = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            txt_dr_nameOrginalArea = new Rectangle(txt_dr_name.Location.X, txt_dr_name.Location.Y, txt_dr_name.Width, txt_dr_name.Height);
            txt_number_of_staying_hoursOrginalArea = new Rectangle(txt_number_of_staying_hours.Location.X, txt_number_of_staying_hours.Location.Y, txt_number_of_staying_hours.Width, txt_number_of_staying_hours.Height);
            btn_okOrginalArea = new Rectangle(btn_ok.Location.X, btn_ok.Location.Y, btn_ok.Width, btn_ok.Height);
            btn_exitOrginalArea = new Rectangle(btn_exit.Location.X, btn_exit.Location.Y, btn_exit.Width, btn_exit.Height);


        }

        private Rectangle label1OrginalArea;
        private Rectangle label2OrginalArea;
        private Rectangle txt_dr_nameOrginalArea;
        private Rectangle txt_number_of_staying_hoursOrginalArea;
        private Rectangle btn_okOrginalArea;
        private Rectangle btn_exitOrginalArea;
        private Size orginalSize;


        private void resizeControlers()
        {
            resizeControler(label1OrginalArea, label1);
            resizeControler(label2OrginalArea, label2);
            resizeControler(txt_dr_nameOrginalArea, txt_dr_name);
            resizeControler(txt_number_of_staying_hoursOrginalArea, txt_number_of_staying_hours);
            resizeControler(btn_okOrginalArea, btn_ok);
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


        private void button1_Click(object sender, EventArgs e)
        {
            client_motion frm = new client_motion();
            frm.state = "close";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client_motion frm = new client_motion();
            if (txt_number_of_staying_hours.Text == string.Empty)
            {
                MessageBox.Show("يرجي ادخال عدد ساعات العمل", "فشل", MessageBoxButtons.OK);
            
            }
            number_of_staying_hours = Convert.ToDouble(txt_number_of_staying_hours.Text);
          
            frm.state = "data";
           
            this.Close();













        }

        private void txt_number_of_staying_hours_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txt_number_of_staying_hours_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_staying_hours_Resize(object sender, EventArgs e)
        {
            resizeControlers();
        }
    }
















           
        
    }
