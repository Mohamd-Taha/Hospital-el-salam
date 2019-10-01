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
    public partial class frm_view_constants : Form
    {
        BL.Client client = new BL.Client();
        public frm_view_constants()
        {
            InitializeComponent();
        }

        private void frm_view_constants_Load(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = client.get_all_Constants();
            for (int i = 0; i < client.get_role_and_department().Rows.Count; i++)
            {

                if (!combo_role.Items.Contains(client.get_role_and_department().Rows[i][1].ToString()))
                {
                    combo_role.Items.Add(client.get_role_and_department().Rows[i][1]);
                }
                if (!combo_department.Items.Contains(client.get_role_and_department().Rows[i][1].ToString()))
                {
                    combo_department.Items.Add(client.get_role_and_department().Rows[i][2]);
                }

            }
            orginalSize = this.Size;
            groupBox1OriginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            label8OriginalArea = new Rectangle(label8.Location.X, label8.Location.Y, label8.Width, label8.Height);
            label3OriginalArea = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            label1OriginalArea = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            label4OriginalArea = new Rectangle(label4.Location.X, label4.Location.Y, label4.Width, label4.Height);
            txt_idOriginalArea = new Rectangle(txt_id.Location.X, txt_id.Location.Y, txt_id.Width, txt_id.Height);
            combo_departmentOriginalArea = new Rectangle(combo_department.Location.X, combo_department.Location.Y, combo_department.Width, combo_department.Height);
            combo_roleOriginalArea = new Rectangle(combo_role.Location.X, combo_role.Location.Y, combo_role.Width, combo_role.Height);
            txt_old_insuranceOriginalArea = new Rectangle(txt_old_insurance.Location.X, txt_old_insurance.Location.Y, txt_old_insurance.Width, txt_old_insurance.Height);
            label6OriginalArea =new Rectangle (label6.Location.X,label6.Location.Y,label6.Width,label6.Height);
            label2OriginalArea=new Rectangle (label2.Location.X,label2.Location.Y,label2.Width,label2.Height);
            label5OriginalArea=new Rectangle (label5.Location.X,label5.Location.Y,label5.Width,label5.Height);
            label7OriginalArea=new Rectangle(label7.Location.X,label7.Location.Y,label7.Width,label7.Height);
            txt_new_insuranceOriginalArea=new Rectangle(txt_new_insurance.Location.X,txt_new_insurance.Location.Y,txt_new_insurance.Width,txt_new_insurance.Height);
         //   txt_new_insuranceOriginalArea=new Rectangle(txt_new_insurance.Location.X,txt_new_insurance.Location.Y,txt_new_insurance.Width,txt_new_insurance.Height);
            txt_morning_shift_valueOriginalArea=new Rectangle (txt_morning_shift_value.Location.X,txt_morning_shift_value.Location.Y,txt_morning_shift_value.Width,txt_morning_shift_value.Height);
            txt_night_shift_valueOriginalArea=new Rectangle(txt_night_shift_value.Location.X,txt_night_shift_value.Location.Y,txt_night_shift_value.Width,txt_night_shift_value.Height);
            txt_IncentivesOriginalArea=new Rectangle(txt_Incentives.Location.X,txt_Incentives.Location.Y,txt_Incentives.Width,txt_Incentives.Height);
            groupBox2OriginalArea=new Rectangle (groupBox2.Location.X,groupBox2.Location.Y,groupBox2.Width,groupBox2.Height);
            dataGridView1OriginalArea=new Rectangle(dataGridView1.Location.X,dataGridView1.Location.Y,dataGridView1.Width,dataGridView1.Height);
            groupBox3OriginalArea=new Rectangle (groupBox3.Location.X,groupBox3.Location.Y,groupBox3.Width,groupBox3.Height);
            btn_saveOriginalArea=new Rectangle (btn_save.Location.X,btn_save.Location.Y,btn_save.Width,btn_save.Height);
            btn_deleteOriginalArea=new Rectangle(btn_delete.Location.X,btn_delete.Location.Y,btn_delete.Width,btn_delete.Height);
            btn_editOriginalArea=new Rectangle (btn_edit.Location.X,btn_edit.Location.Y,btn_edit.Width,btn_edit.Height);
            btn_exitOriginalArea=new Rectangle(btn_exit.Location.X,btn_exit.Location.Y,btn_exit.Width,btn_exit.Height);
                    }

        private Rectangle groupBox1OriginalArea;
        private Rectangle label8OriginalArea;
        private Rectangle label3OriginalArea;
        private Rectangle label1OriginalArea;
        private Rectangle label4OriginalArea;
        private Rectangle txt_idOriginalArea;
        private Rectangle combo_departmentOriginalArea;
        private Rectangle combo_roleOriginalArea;
        private Rectangle txt_old_insuranceOriginalArea;
        private Rectangle label6OriginalArea;
        private Rectangle label2OriginalArea;
        private Rectangle label5OriginalArea;
        private Rectangle label7OriginalArea;
        private Rectangle txt_new_insuranceOriginalArea;
        private Rectangle txt_morning_shift_valueOriginalArea;
        private Rectangle txt_night_shift_valueOriginalArea;
        private Rectangle txt_IncentivesOriginalArea;
        private Rectangle groupBox2OriginalArea;
        private Rectangle dataGridView1OriginalArea;
        private Rectangle groupBox3OriginalArea;
        private Rectangle btn_saveOriginalArea;
        private Rectangle btn_deleteOriginalArea;
        private Rectangle btn_editOriginalArea;
        private Rectangle btn_exitOriginalArea;
         private Size orginalSize;

         private void resizeControlers()
         {
             resizeControler(groupBox1OriginalArea, groupBox1);
             resizeControler(label8OriginalArea, label8);
             resizeControler(label3OriginalArea, label3);
             resizeControler(label1OriginalArea, label1);
             resizeControler(label4OriginalArea, label4);
             resizeControler(txt_idOriginalArea, txt_id);
             resizeControler(combo_departmentOriginalArea, combo_department);
             resizeControler(combo_roleOriginalArea, combo_role);
             resizeControler(txt_old_insuranceOriginalArea, txt_old_insurance);
             resizeControler(label6OriginalArea, label6);
             resizeControler(label2OriginalArea, label2);
             resizeControler(label5OriginalArea, label5);
             resizeControler(label7OriginalArea, label7);
             resizeControler(txt_new_insuranceOriginalArea, txt_new_insurance);
             resizeControler(txt_morning_shift_valueOriginalArea, txt_morning_shift_value);
             resizeControler(txt_night_shift_valueOriginalArea, txt_night_shift_value);
             resizeControler(txt_IncentivesOriginalArea, txt_Incentives);
             resizeControler(groupBox2OriginalArea, groupBox2);
             resizeControler(dataGridView1OriginalArea, dataGridView1);
             resizeControler(groupBox3OriginalArea, groupBox3);
             resizeControler(btn_deleteOriginalArea, btn_delete);
             resizeControler(btn_editOriginalArea, btn_edit);
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
              
           dataGridView1.CurrentRow.Selected = true;
           txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           combo_department.SelectedItem = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           combo_role.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           txt_new_insurance.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           txt_old_insurance.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           txt_morning_shift_value.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           txt_night_shift_value.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
           txt_Incentives.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
         
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_id.Enabled == false)
            {
                txt_id.Enabled = true;
                txt_Incentives.Enabled = true;
                txt_morning_shift_value.Enabled = true;
                txt_new_insurance.Enabled = true;
                txt_night_shift_value.Enabled = true;
                txt_old_insurance.Enabled = true;
                combo_department.Enabled = true;
                combo_role.Enabled = true;
                btn_save.Enabled = true;

            }
            else
            {
                
                    txt_id.Enabled = false;
                    txt_Incentives.Enabled = false;
                    txt_morning_shift_value.Enabled = false;
                    txt_new_insurance.Enabled = false;
                    txt_night_shift_value.Enabled = false;
                    txt_old_insurance.Enabled = false;
                    combo_department.Enabled = false;
                    combo_role.Enabled = false;
                    btn_save.Enabled = false;


                
            
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            client.update_consatant(Convert.ToDouble(txt_new_insurance.Text), Convert.ToDouble(txt_old_insurance.Text),
                Convert.ToDouble(txt_morning_shift_value.Text), Convert.ToDouble(txt_night_shift_value.Text), Convert.ToDouble(txt_Incentives.Text), Convert.ToInt32(txt_id.Text));
            dataGridView1.DataSource = client.get_all_Constants();
            dataGridView1.Update();
               
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            client.delete_constant(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            dataGridView1.DataSource = client.get_all_Constants();
            dataGridView1.Update();
            MessageBox.Show("تمت عملية الحذف بنجاح", "تم الحذف", MessageBoxButtons.OK);
        }

        private void txt_new_insurance_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}
