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
    public partial class frm_add_user : Form
    {
        BL.User user = new BL.User();
        public frm_add_user()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_add_user_Load(object sender, EventArgs e)
        {
            orginalSize = this.Size;
            groupBox3OriginalArea = new Rectangle(groupBox3.Location.X, groupBox3.Location.Y, groupBox3.Width, groupBox3.Height);
            label9OriginalArea = new Rectangle(label9.Location.X, label9.Location.Y, label9.Width, label9.Height);
            groupBox1OriginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            label3OriginalArea = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            label8OriginalArea = new Rectangle(label8.Location.X, label8.Location.Y, label8.Width, label8.Height);
            label7OriginalArea = new Rectangle(label7.Location.X, label7.Location.Y, label7.Width, label7.Height);
            label5OriginalArea = new Rectangle(label5.Location.X, label5.Location.Y, label5.Width, label5.Height);
            groupBox2OriginalArea = new Rectangle(groupBox2.Location.X, groupBox2.Location.Y, groupBox2.Width, groupBox2.Height);
            txt_user_fullnameOriginalArea = new Rectangle(txt_user_fullname.Location.X, txt_user_fullname.Location.Y, txt_user_fullname.Width, txt_user_fullname.Height);
            txt_user_nameOriginalArea = new Rectangle(txt_user_name.Location.X, txt_user_name.Location.Y, txt_user_name.Width, txt_user_name.Height);
            txt_user_passwordOriginalArea = new Rectangle(txt_user_password.Location.X, txt_user_password.Location.Y, txt_user_password.Width, txt_user_password.Height);
            cmobo_accessiblityOriginalArea = new Rectangle(cmobo_accessiblity.Location.X, cmobo_accessiblity.Location.Y, cmobo_accessiblity.Width, cmobo_accessiblity.Height);
            groupBox4OriginalArea = new Rectangle(groupBox4.Location.X, groupBox4.Location.Y, groupBox4.Width, groupBox4.Height);
            button1OriginalArea = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            btn_exitOriginalArea = new Rectangle(btn_exit.Location.X, btn_exit.Location.Y, btn_exit.Width, btn_exit.Height);

        }

        public Rectangle groupBox3OriginalArea;
        public Rectangle label9OriginalArea;
        public Rectangle groupBox1OriginalArea;
        public Rectangle label3OriginalArea;
        public Rectangle label8OriginalArea;
        public Rectangle label7OriginalArea;
        public Rectangle label5OriginalArea;
        public Rectangle groupBox2OriginalArea;
        private Rectangle txt_user_fullnameOriginalArea;
        private Rectangle txt_user_nameOriginalArea;
        private Rectangle txt_user_passwordOriginalArea;
        private Rectangle cmobo_accessiblityOriginalArea;
        private Rectangle groupBox4OriginalArea;
        private Rectangle button1OriginalArea;
        private Rectangle btn_exitOriginalArea;
        private Size orginalSize;

        private void resizeControlers()
        {


            resizeControler(groupBox3OriginalArea, groupBox3);
            resizeControler(label9OriginalArea, label9);
            resizeControler(groupBox1OriginalArea, groupBox1);
            resizeControler(label3OriginalArea, label3);
            resizeControler(label8OriginalArea, label8);
            resizeControler(label3OriginalArea, label3);
            resizeControler(label7OriginalArea, label7);
            resizeControler(label5OriginalArea, label5);
            resizeControler(groupBox2OriginalArea, groupBox2);
            resizeControler(txt_user_fullnameOriginalArea, txt_user_fullname);
            resizeControler(txt_user_nameOriginalArea, txt_user_name);
            resizeControler(txt_user_passwordOriginalArea, txt_user_password);
            resizeControler(cmobo_accessiblityOriginalArea, cmobo_accessiblity);
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

        private void button1_Click(object sender, EventArgs e)
        {
            frm_users frm = new frm_users();
            try
            {
                user.addUser(txt_user_fullname.Text, txt_user_name.Text, txt_user_password.Text, cmobo_accessiblity.SelectedItem.ToString());
                MessageBox.Show("تمت عملية الاضافة بنجاح", "تم الحفظ", MessageBoxButtons.OK);
                this.Close();
            }catch (NullReferenceException)
            {
                MessageBox.Show("الرجاء التأكد ان كل الخانات بها بيانات", "يوجد خانة فارغة", MessageBoxButtons.OK);
            }   
            frm_users.myform.dataGridView1.DataSource = user.getUser();
            frm_users.myform.dataGridView1.Update();
          
           

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frm_add_user_Resize(object sender, EventArgs e)
        {
            resizeControlers();
        }
    }
}
