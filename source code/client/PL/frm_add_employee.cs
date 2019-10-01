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
    public partial class frm_add_employee : Form
    {
        
        BL.Client client =  new BL.Client();
        public frm_add_employee()
        {
          
            InitializeComponent();
            
        }
        private frm_employee mainForm = null;
        public frm_add_employee(Form callingForm)
        {
            mainForm = callingForm as frm_employee;
           
            InitializeComponent();
        }

        private void rd_new_employee_CheckedChanged(object sender, EventArgs e)
        {
            combo_role.Enabled = true;
            combo_department.Enabled = true;
            combo_department.SelectedIndex = 0;
            combo_role.SelectedIndex = 0;
            txt_emp_id.Enabled = true;
            txt_emp_name.Enabled = true;
            combo_department.Enabled = true;
            combo_role.Enabled = true;
            combo_type_of_salary.Enabled = true;
            txt_salary.Enabled = true;
            txt_value_of_stay.Enabled = true;

            txt_lateness.Enabled = false;
            txt_pm_shift_number.Enabled = false;
            txt_am_shift_number.Enabled = false;
            txt_Loan.Enabled = false;
            txt_absence.Enabled = false;
            txt_extra.Enabled = false;
            txt_over.Enabled = false;
            txt_Insurance.Enabled = false;
            txt_adds.Enabled = false;
            txt_fans.Enabled = false;
            txt_type_of_adds.Enabled = false;
            txt_type_of_discounts.Enabled = false;
            txt_type_of_other.Enabled = false;
            combo_type_of_salary.Enabled = true;
            txt_salary.Enabled = true;
            txt_value_of_stay.Enabled = true;
            txt_other.Enabled = false;
            rd_add.Enabled = false;
            rd_discount.Enabled = false;
            txt_no_of_staying_hours.Enabled = false;

        }

        private void rd_old_employee_CheckedChanged(object sender, EventArgs e)
        {
            combo_role.Enabled = false;
            combo_department.Enabled = false;
            combo_department.SelectedIndex = 0;
            combo_role.SelectedIndex = 0;
            txt_emp_id.Enabled = true;
            txt_emp_name.Enabled = true;
            combo_department.Enabled = true;
            combo_role.Enabled = true;
            combo_type_of_salary.Enabled = true;
            txt_salary.Enabled = true;
            txt_value_of_stay.Enabled = true;

            txt_lateness.Enabled = true;
            txt_pm_shift_number.Enabled = true;
            txt_am_shift_number.Enabled = true;
            txt_Loan.Enabled = true;
            txt_absence.Enabled = true;
            txt_extra.Enabled = true;
            txt_over.Enabled = true;
            txt_Insurance.Enabled = true;
            txt_adds.Enabled = true;
            txt_fans.Enabled = true;
            txt_type_of_adds.Enabled = true;
            txt_type_of_discounts.Enabled = true;
            txt_type_of_other.Enabled = true;
            combo_type_of_salary.Enabled = true;
            txt_salary.Enabled = true;
            txt_value_of_stay.Enabled = true;
            txt_other.Enabled = true;
            rd_add.Enabled = true;
            rd_discount.Enabled = true;
            txt_no_of_staying_hours.Enabled = true;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_add_employee_Load(object sender, EventArgs e)
        {
           
            orginalSize = this.Size;
            groupBox3OriginalArea = new Rectangle(groupBox3.Location.X, groupBox3.Location.Y, groupBox3.Width, groupBox3.Height);
            rd_new_employeeOriginalArea = new Rectangle(rd_new_employee.Location.X, rd_new_employee.Location.Y, rd_new_employee.Width, rd_new_employee.Height);
            rd_old_employeeOriginalArea = new Rectangle(rd_old_employee.Location.X, rd_old_employee.Location.Y, rd_old_employee.Width, rd_old_employee.Height);
            groupBox11OriginalArea = new Rectangle(groupBox11.Location.X, groupBox11.Location.Y, groupBox11.Width, groupBox11.Height);
            label8OriginalArea = new Rectangle(label8.Location.X, label8.Location.Y, label8.Width, label8.Height);
            txt_no_of_staying_hoursOriginalArea = new Rectangle(txt_no_of_staying_hours.Location.X, txt_no_of_staying_hours.Location.Y, txt_no_of_staying_hours.Width, txt_no_of_staying_hours.Height);
            groupBox1OriginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            label2OriginalArea = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            label3OriginalArea = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            label7OriginalArea = new Rectangle(label7.Location.X, label7.Location.Y, label7.Width, label7.Height);
            label6OriginalArea = new Rectangle(label6.Location.X, label6.Location.Y, label6.Width, label6.Height);
            label10OriginalArea = new Rectangle(label10.Location.X, label10.Location.Y, label10.Width, label10.Height);
            label11OriginalArea = new Rectangle(label11.Location.X, label11.Location.Y, label11.Width, label11.Height);
            label9OriginalArea = new Rectangle(label9.Location.X, label9.Location.Y, label9.Width, label9.Height);
            groupBox2OriginalArea = new Rectangle(groupBox2.Location.X, groupBox2.Location.Y, groupBox2.Width, groupBox2.Height);
            txt_emp_idOriginalArea = new Rectangle(txt_emp_id.Location.X, txt_emp_id.Location.Y, txt_emp_id.Width, txt_emp_id.Height);
            txt_emp_nameOriginalArea = new Rectangle(txt_emp_name.Location.X, txt_emp_name.Location.Y, txt_emp_name.Width, txt_emp_name.Height);
            combo_departmentOriginalArea = new Rectangle(combo_department.Location.X, combo_department.Location.Y, combo_department.Width, combo_department.Height);
            combo_roleOriginalArea = new Rectangle(combo_role.Location.X, combo_role.Location.Y, combo_role.Width, combo_role.Height);
            combo_type_of_salaryOriginalArea = new Rectangle(combo_type_of_salary.Location.X, combo_type_of_salary.Location.Y, combo_type_of_salary.Width, combo_type_of_salary.Height);
            txt_salaryOriginalArea = new Rectangle(txt_salary.Location.X, txt_salary.Location.Y, txt_salary.Width, txt_salary.Height);
            txt_value_of_stayOriginalArea = new Rectangle(txt_value_of_stay.Location.X, txt_value_of_stay.Location.Y, txt_value_of_stay.Width, txt_value_of_stay.Height);
            groupBox10OriginalArea = new Rectangle(groupBox10.Location.X, groupBox10.Location.Y, groupBox10.Width, groupBox10.Height);
            label35OriginalArea = new Rectangle(label35.Location.X, label35.Location.Y, label35.Width, label35.Height);
            label36OriginalArea = new Rectangle(label36.Location.X, label36.Location.Y, label36.Width, label36.Height);
            label33OriginalArea = new Rectangle(label33.Location.X, label33.Location.Y, label33.Width, label33.Height);
            label34Original = new Rectangle(label34.Location.X, label34.Location.Y, label34.Width, label34.Height);
            txt_fansOriginalArea = new Rectangle(txt_fans.Location.X, txt_fans.Location.Y, txt_fans.Width, txt_fans.Height);
            txt_type_of_discountsOriginalArea = new Rectangle(txt_type_of_discounts.Location.X, txt_type_of_discounts.Location.Y, txt_type_of_discounts.Width, txt_type_of_discounts.Height);
            txt_addsOriginalArea = new Rectangle(txt_adds.Location.X, txt_adds.Location.Y, txt_adds.Width, txt_adds.Height);
            txt_type_of_addsOriginalArea = new Rectangle(txt_type_of_adds.Location.X, txt_type_of_adds.Location.Y, txt_type_of_adds.Width, txt_type_of_adds.Height);
            groupBox9OriginalArea = new Rectangle(groupBox9.Location.X, groupBox9.Location.Y, groupBox9.Width, groupBox9.Height);
            label20OriginalArea = new Rectangle(label20.Location.X, label20.Location.Y, label20.Width, label20.Height);
            label22OriginalArea = new Rectangle(label22.Location.X, label22.Location.Y, label22.Width, label22.Height);
            label23OriginalArea = new Rectangle(label23.Location.X, label23.Location.Y, label23.Width, label23.Height);
            label4OriginalArea = new Rectangle(label4.Location.X, label4.Location.Y, label4.Width, label4.Height);
            groupBox8OriginalArea = new Rectangle(groupBox8.Location.X, groupBox8.Location.Y, groupBox8.Width, groupBox8.Height);
            txt_latenessOriginalArea = new Rectangle(txt_lateness.Location.X, txt_lateness.Location.Y, txt_lateness.Width, txt_lateness.Height);
            txt_absenceOriginalArea = new Rectangle(txt_absence.Location.X, txt_absence.Location.Y, txt_absence.Width, txt_absence.Height);
            txt_LoanOriginalArea = new Rectangle(txt_Loan.Location.X, txt_Loan.Location.Y, txt_Loan.Width, txt_Loan.Height);
            txt_InsuranceOriginalArea = new Rectangle(txt_Insurance.Location.X, txt_Insurance.Location.Y, txt_Insurance.Width, txt_Insurance.Height);
            groupBox7OriginalArea = new Rectangle(groupBox7.Location.X, groupBox7.Location.Y, groupBox7.Width, groupBox7.Height);
            rd_discountOriginalArea = new Rectangle(rd_discount.Location.X, rd_discount.Location.Y, rd_discount.Width, rd_discount.Height);
            rd_addOriginalArea = new Rectangle(rd_add.Location.X, rd_add.Location.Y, rd_add.Width, rd_add.Height);
            label37OriginalArea = new Rectangle(label37.Location.X, label37.Location.Y, label37.Width, label37.Height);
            label38OriginalArea = new Rectangle(label38.Location.X, label38.Location.Y, label38.Width, label38.Height);
            txt_otherOriginalArea = new Rectangle(txt_other.Location.X, txt_other.Location.Y, txt_other.Width, txt_other.Height);
            txt_type_of_otherOriginalArea=new Rectangle(txt_type_of_other.Location.X,txt_type_of_other.Location.Y,txt_type_of_other.Width,txt_type_of_other.Height);
            pictureBox1OriginalArea=new Rectangle(pictureBox1.Location.X,pictureBox1.Location.Y,pictureBox1.Width,pictureBox1.Height);
            groupBox5OriginalArea=new Rectangle(groupBox5.Location.X,groupBox5.Location.Y,groupBox5.Width,groupBox5.Height);
            label12OriginalArea=new Rectangle(label12.Location.X,label12.Location.Y,label12.Width,label12.Height);
            label19OriginalArea=new Rectangle(label19.Location.X,label19.Location.Y,label19.Width,label19.Height);
            label1OriginalArea=new Rectangle(label1.Location.X,label1.Location.Y,label1.Width,label1.Height);
            label5OriginalArea=new Rectangle(label5.Location.X,label5.Location.Y,label5.Width,label5.Height);
            groupBox6OriginalArea=new Rectangle(groupBox6.Location.X,groupBox6.Location.Y,groupBox6.Width,groupBox6.Height);
            txt_am_shift_numberOriginalArea=new Rectangle(txt_am_shift_number.Location.X,txt_am_shift_number.Location.Y,txt_am_shift_number.Width,txt_am_shift_number.Height);
            txt_pm_shift_numberOriginalArea=new Rectangle (txt_pm_shift_number.Location.X,txt_pm_shift_number.Location.Y,txt_pm_shift_number.Width,txt_pm_shift_number.Height);
            txt_extraOriginalArea=new Rectangle(txt_extra.Location.X,txt_extra.Location.Y,txt_extra.Width,txt_extra.Height);
            txt_overOriginalArea=new Rectangle(txt_over.Location.X,txt_over.Location.Y,txt_over.Width,txt_over.Height);
            groupBox4OriginalArea=new Rectangle(groupBox4.Location.X,groupBox4.Location.Y,groupBox4.Width,groupBox4.Height);
            btn_saveOriginalArea=new Rectangle(btn_save.Location.X,btn_save.Location.Y,btn_save.Width,btn_save.Height);
            btn_exitOriginalArea=new Rectangle(btn_exit.Location.X,btn_exit.Location.Y,btn_exit.Width,btn_exit.Height);

        }
        private Rectangle groupBox3OriginalArea;
        private Rectangle rd_new_employeeOriginalArea;
        private Rectangle rd_old_employeeOriginalArea;
        private Rectangle groupBox11OriginalArea;
        private Rectangle label8OriginalArea;
        private Rectangle txt_no_of_staying_hoursOriginalArea;
        private Rectangle groupBox1OriginalArea;
        private Rectangle label2OriginalArea;
        private Rectangle label3OriginalArea;
        private Rectangle label7OriginalArea;
        private Rectangle label6OriginalArea;
        private Rectangle label10OriginalArea;
        private Rectangle label11OriginalArea;
        private Rectangle label9OriginalArea;
        private Rectangle groupBox2OriginalArea;
        private Rectangle txt_emp_idOriginalArea;
        private Rectangle txt_emp_nameOriginalArea;
        private Rectangle combo_departmentOriginalArea;
        private Rectangle combo_roleOriginalArea;
        private Rectangle combo_type_of_salaryOriginalArea;
        private Rectangle txt_salaryOriginalArea;
        private Rectangle txt_value_of_stayOriginalArea;
        private Rectangle groupBox10OriginalArea;
        private Rectangle label35OriginalArea;
        private Rectangle label36OriginalArea;
        private Rectangle label33OriginalArea;
        private Rectangle label34Original;
        private Rectangle txt_fansOriginalArea;
        private Rectangle txt_type_of_discountsOriginalArea;
        private Rectangle txt_addsOriginalArea;
        private Rectangle txt_type_of_addsOriginalArea;
        private Rectangle groupBox9OriginalArea;
        private Rectangle label20OriginalArea;
        private Rectangle label22OriginalArea;
        private Rectangle label23OriginalArea;
        private Rectangle label4OriginalArea;
        private Rectangle groupBox8OriginalArea;
        private Rectangle txt_latenessOriginalArea;
        private Rectangle txt_absenceOriginalArea;
        private Rectangle txt_LoanOriginalArea;
        private Rectangle txt_InsuranceOriginalArea;
        private Rectangle groupBox7OriginalArea;
        private Rectangle rd_discountOriginalArea;
        private Rectangle rd_addOriginalArea;
        private Rectangle label37OriginalArea;
        private Rectangle label38OriginalArea;
        private Rectangle txt_otherOriginalArea;
        private Rectangle txt_type_of_otherOriginalArea;
        private Rectangle pictureBox1OriginalArea;
        private Rectangle groupBox5OriginalArea;
        private Rectangle label12OriginalArea;
        private Rectangle label19OriginalArea;
        private Rectangle label1OriginalArea;
        private Rectangle label5OriginalArea;
        private Rectangle groupBox6OriginalArea;
        private Rectangle txt_am_shift_numberOriginalArea;
        private Rectangle txt_pm_shift_numberOriginalArea;
        private Rectangle txt_extraOriginalArea;
        private Rectangle txt_overOriginalArea;
        private Rectangle groupBox4OriginalArea;
        private Rectangle btn_saveOriginalArea;
        private Rectangle btn_exitOriginalArea;
        private Size orginalSize;

        
          private void resizeControlers()
        {

            resizeControler(combo_roleOriginalArea, combo_role);
            resizeControler(groupBox3OriginalArea, groupBox3);
            resizeControler(rd_new_employeeOriginalArea, rd_new_employee);
            resizeControler(rd_old_employeeOriginalArea, rd_old_employee);
            resizeControler(groupBox11OriginalArea, groupBox11);
            resizeControler(label8OriginalArea, label8);
            resizeControler(txt_no_of_staying_hoursOriginalArea, txt_no_of_staying_hours);
            resizeControler(groupBox1OriginalArea, groupBox1);
            resizeControler(label2OriginalArea, label2);
            resizeControler(label3OriginalArea, label3);
            resizeControler(label7OriginalArea, label7);;
            resizeControler(label6OriginalArea, label6);
            resizeControler(label10OriginalArea, label10);
            resizeControler(label11OriginalArea, label11);
            resizeControler(label9OriginalArea, label9);
            resizeControler(groupBox2OriginalArea, groupBox2);
            resizeControler(txt_emp_idOriginalArea, txt_emp_id);
            resizeControler(txt_emp_nameOriginalArea, txt_emp_name);
            resizeControler(combo_departmentOriginalArea, combo_department);
            resizeControler(txt_salaryOriginalArea , txt_salary);
            resizeControler(combo_type_of_salaryOriginalArea, combo_type_of_salary);
            resizeControler(txt_value_of_stayOriginalArea, txt_value_of_stay);
            resizeControler(groupBox10OriginalArea, groupBox10);
            resizeControler(label35OriginalArea, label35);
            resizeControler(label36OriginalArea, label36);
            resizeControler(label33OriginalArea, label33);
            resizeControler(label34Original, label34);
            resizeControler(txt_fansOriginalArea, txt_fans);
            resizeControler(txt_type_of_discountsOriginalArea, txt_type_of_discounts);
            resizeControler(txt_addsOriginalArea, txt_adds);
            resizeControler(txt_type_of_addsOriginalArea, txt_type_of_adds);
            resizeControler(groupBox9OriginalArea, groupBox9);
            resizeControler(label20OriginalArea, label20);
            resizeControler(label22OriginalArea, label22);
            resizeControler(label23OriginalArea, label23);
            resizeControler(label4OriginalArea, label4);
            resizeControler(groupBox8OriginalArea, groupBox8);
            resizeControler(txt_latenessOriginalArea, txt_lateness);
            resizeControler(txt_absenceOriginalArea, txt_absence);
            resizeControler(txt_LoanOriginalArea, txt_Loan);
            resizeControler(txt_InsuranceOriginalArea, txt_Insurance);
            resizeControler(groupBox7OriginalArea, groupBox7);
            resizeControler(rd_discountOriginalArea, rd_discount);
            resizeControler(rd_addOriginalArea, rd_add);
            resizeControler(label37OriginalArea, label37);
            resizeControler(label38OriginalArea, label38);
            resizeControler(txt_otherOriginalArea, txt_other);
            resizeControler(txt_type_of_otherOriginalArea, txt_type_of_other);
            resizeControler(pictureBox1OriginalArea, pictureBox1);
            resizeControler(groupBox5OriginalArea, groupBox5);
            resizeControler(label12OriginalArea, label12);
            resizeControler(label19OriginalArea, label19);
            resizeControler(label1OriginalArea, label1);
            resizeControler(label5OriginalArea, label5);
            resizeControler(groupBox6OriginalArea, groupBox6);
            resizeControler(txt_am_shift_numberOriginalArea, txt_am_shift_number);
            resizeControler(txt_pm_shift_numberOriginalArea, txt_pm_shift_number);
            resizeControler(txt_extraOriginalArea, txt_extra);
            resizeControler(txt_overOriginalArea, txt_over);
            resizeControler(groupBox4OriginalArea, groupBox4);
            resizeControler(btn_saveOriginalArea, btn_save);
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


        private void btn_save_Click(object sender, EventArgs e)
        {
            if (rd_new_employee.Checked == true)
            {
                if (
                 txt_emp_id.Text.Trim() == string.Empty    ||
                 txt_emp_name.Text.Trim() == string.Empty ||
                 txt_salary.Text.Trim() == string.Empty   ||
                 txt_value_of_stay.Text.Trim() == string.Empty
                 )
                {
                    
                        MessageBox.Show("يوجد حقل فارغ وهذا غير مسموح اذا كنت لا تريد وضع قيمة قم بوضع صفر اعادة المحاولة", "يوجد حقل فارغ", MessageBoxButtons.OK);
                        return;
                }
                else
                {
                client.addClient(Convert.ToInt32(txt_emp_id.Text), txt_emp_name.Text, Convert.ToInt32(txt_role_dept_id.Text), Convert.ToDouble(txt_salary.Text), combo_type_of_salary.SelectedItem.ToString(), Convert.ToDouble(txt_value_of_stay.Text));
                client.addIncentives(Convert.ToInt32(txt_emp_id.Text), 0,Convert.ToInt32( txt_role_dept_id.Text));
                client.update_tax_for_month(dateTimePicker1.Value, Convert.ToInt32(txt_emp_id.Text), 0);
                client.addDeduction(dateTimePicker1.Value, 0, 0, 0, 0, 0, 0, Convert.ToInt32(txt_emp_id.Text));
                client.addShift(Convert.ToInt32(txt_emp_id.Text), dateTimePicker1.Value, 0, 0, 0,0, 0);
                client.add_other("",0,"",0, dateTimePicker1.Value, Convert.ToInt32(txt_emp_id.Text),
                   0,"");
            MessageBox.Show("تمت عملية الاضافة بنجاح", "تم الحفظ", MessageBoxButtons.OK);
            this.Close();
                }
            }
            else if (rd_old_employee.Checked == true)
            {
                if (
                 txt_emp_id.Text.Trim() == string.Empty ||
                 txt_emp_name.Text.Trim() == string.Empty ||
                 txt_salary.Text.Trim() == string.Empty ||
                 txt_value_of_stay.Text.Trim() == string.Empty ||
                 txt_no_of_staying_hours.Text.Trim() == string.Empty ||
                 txt_adds.Text.Trim() == string.Empty ||
                 txt_fans.Text.Trim() == string.Empty ||
                 txt_other.Text.Trim() == string.Empty ||
                 txt_am_shift_number.Text.Trim() == string.Empty ||
                 txt_pm_shift_number.Text.Trim() == string.Empty ||
                 txt_extra.Text.Trim() == string.Empty ||
                 txt_over.Text.Trim() == string.Empty ||
                 txt_lateness.Text.Trim() == string.Empty ||
                 txt_absence.Text.Trim() == string.Empty ||
                 txt_Loan.Text.Trim() == string.Empty 
               
                 )
                {
                    MessageBox.Show("يوجد حقل فارغ وهذا غير مسموح اذا كنت لا تريد وضع قيمة قم بوضع صفر اعادة المحاولة", "يوجد حقل فارغ", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    double tax = 0;
                    double totalMerit_without_adds = Convert.ToDouble(txt_am_shift_number.Text) * Convert.ToDouble(client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows[0][6]) + Convert.ToDouble(txt_pm_shift_number.Text) * Convert.ToDouble(client.getConstants((Convert.ToInt32(txt_role_dept_id.Text))).Rows[0][6]);
                    if (totalMerit_without_adds >= 1200)
                    {
                        tax = ((((totalMerit_without_adds * 12) - 1500) / 12) * 0.015);
                        client.update_tax_for_month(dateTimePicker1.Value, Convert.ToInt32(txt_emp_id.Text), tax);
                    }
                    else
                    {
                        client.update_tax_for_month(dateTimePicker1.Value, Convert.ToInt32(txt_emp_id.Text), 0);
                    }

                    client.addClient(Convert.ToInt32(txt_emp_id.Text), txt_emp_name.Text, Convert.ToInt32(txt_role_dept_id.Text), Convert.ToDouble(txt_salary.Text), combo_type_of_salary.SelectedItem.ToString(), Convert.ToDouble(txt_value_of_stay.Text));
                    client.addShift(Convert.ToInt32(txt_emp_id.Text), dateTimePicker1.Value, Convert.ToDouble(txt_am_shift_number.Text), Convert.ToDouble(txt_pm_shift_number.Text), Convert.ToDouble(txt_extra.Text), Convert.ToDouble(txt_over.Text), Convert.ToDouble(txt_no_of_staying_hours));
                    client.addIncentives(Convert.ToInt32(txt_emp_id.Text), totalMerit_without_adds * Convert.ToDouble(client.get_incentives(Convert.ToInt32(txt_role_dept_id.Text))), Convert.ToInt32(txt_role_dept_id.Text));
                    client.addDeduction(dateTimePicker1.Value, Convert.ToDouble(txt_lateness.Text), Convert.ToDouble(txt_Loan.Text), Convert.ToDouble(txt_Insurance.Text), Convert.ToInt32(txt_absence.Text), (Convert.ToDouble(client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows[0][6]) * 5 * Convert.ToInt32(txt_absence.Text)), (Convert.ToDouble(client.getConstants(Convert.ToInt32(txt_role_dept_id.Text)).Rows[0][6])) * Convert.ToDouble(txt_lateness.Text), Convert.ToInt32(txt_emp_id.Text));
                    client.add_other(txt_type_of_adds.Text, Convert.ToDouble(txt_adds.Text), txt_type_of_discounts.Text, Convert.ToDouble(txt_fans.Text), dateTimePicker1.Value, Convert.ToInt32(txt_emp_id.Text),
                    Convert.ToDouble(txt_other.Text), txt_type_of_other.Text);
                    MessageBox.Show("تمت عملية الاضافة بنجاح", "تم الحفظ", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("الرجاء التحديد ما اذا كان هذا الموظف جديد ام قديم", "لم يتم تحديد نوع الموظف", MessageBoxButtons.OK);

            }
            this.mainForm.dataGridView1.DataSource = client.getCleint();
            this.mainForm.dataGridView1.Update();
            /*
            frm_employee.myform.dataGridView1.DataSource = client.getCleint();
            frm_employee.myform.dataGridView1.Update();
            */
        
        }

        private void combo_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_role_dept_id.Clear();

            if (Convert.ToString(combo_role.Text) != string.Empty)
            {
                if (Convert.ToInt32(client.get_id_of_deparment_and_role(combo_department.SelectedItem.ToString(), combo_role.SelectedItem.ToString()).Rows.Count) == 1)

                    txt_role_dept_id.Text = (client.get_id_of_deparment_and_role(combo_department.SelectedItem.ToString(), combo_role.SelectedItem.ToString())).Rows[0][0].ToString();
                        
                    

            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void txt_pm_shift_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Loan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_am_shift_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lateness_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void combo_department_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_role_dept_id.Clear();

            if (Convert.ToString(combo_department.Text) != string.Empty)
            {
                if (Convert.ToInt32(client.get_id_of_deparment_and_role(combo_department.SelectedItem.ToString(), combo_role.SelectedItem.ToString()).Rows.Count) == 1)

                    txt_role_dept_id.Text = (client.get_id_of_deparment_and_role(combo_department.SelectedItem.ToString(), combo_role.SelectedItem.ToString())).Rows[0][0].ToString();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_salary_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txt_role_dept_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void combo_type_of_salary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_add_employee_Resize(object sender, EventArgs e)
        {
            //resizeControlers();
        }
    }
}
