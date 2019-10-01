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
using System.Data.SqlClient;
namespace client.PL
{
    public partial class client_motion : Form
    {
        public string state;
        public double number_of_staying_hours = 0;

        public DataRow r;

        public int number_of_selected_clients = 0;
        BL.motions motions = new BL.motions();
        BL.Client client = new BL.Client();
      public  DataTable dt = new DataTable();
      public DataTable dt1 = new DataTable();
      public DataTable dt2= new DataTable();


        void createdatatable()
        {
            dt.Columns.Add("الاسم");
            dt.Columns.Add("القسم");
            dt.Columns.Add("الدور");
            dt.Columns.Add("نوع الراتب");
            dt.Columns.Add("كود الوظيفه");
            dt.Columns.Add("كود الموظف");
            dt.Columns.Add("ساعات التأخير");
          

        }
        void createdatatable_staying()
        {
            
            dt1.Columns.Add("الاسم");
            dt1.Columns.Add("القسم");
            dt1.Columns.Add("الدور");
            dt1.Columns.Add("نوع الراتب");
            dt1.Columns.Add("كود الوظيفه");
            dt1.Columns.Add("كود الموظف");
            dt1.Columns.Add("عدد ساعات الاقامه");
            dt1.Columns.Add("ساعات التأخير");
          
        }


        void createdatatable_salary()
        {

            dt2.Columns.Add("الاسم");
            dt2.Columns.Add("القسم");
            dt2.Columns.Add("الراتب الاساسي");
            dt2.Columns.Add("نوع الراتب");
            dt2.Columns.Add("كود الوظيفه");
            dt2.Columns.Add("كود الموظف");
            dt2.Columns.Add("ساعات التأخير");
       
        }




        public client_motion()
        {


            InitializeComponent();
            createdatatable();
            createdatatable_staying();
            createdatatable_salary();

          

          
        }

        private void client_motion_Load(object sender, EventArgs e)
        {
            orginalSize = this.Size;
            data_all_clientsOriginalArea = new Rectangle(data_all_clients.Location.X, data_all_clients.Location.Y, data_all_clients.Width, data_all_clients.Height);
            data_selected_clientOriginalArea = new Rectangle(data_selected_client.Location.X, data_selected_client.Location.Y, data_selected_client.Width, data_selected_client.Height);
            dateTimePicker1OriginalArea = new Rectangle(dateTimePicker1.Location.X, dateTimePicker1.Location.Y, dateTimePicker1.Width, dateTimePicker1.Height);
            label2OriginalArea = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            combo_catOriginalArea = new Rectangle(combo_cat.Location.X, combo_cat.Location.Y, combo_cat.Width, combo_cat.Height);
            txt_dely_minuteOriginalArea = new Rectangle(txt_dely_minute.Location.X, txt_dely_minute.Location.Y, txt_dely_minute.Width, txt_dely_minute.Height);
            groupBox4OriginalArea = new Rectangle(groupBox4.Location.X, groupBox4.Location.Y, groupBox4.Width, groupBox4.Height);
            radio_doctorsOriginal = new Rectangle(radio_doctors.Location.X, radio_doctors.Location.Y, radio_doctors.Width, radio_doctors.Height);
            txt_monthOriginalArea = new Rectangle(txt_month.Location.X, txt_month.Location.Y, txt_month.Width, txt_month.Height);
            txt_yearOriginalArea = new Rectangle(txt_year.Location.X, txt_year.Location.Y, txt_year.Width, txt_year.Height);
            txt_dayOriginalArea = new Rectangle(txt_day.Location.X, txt_day.Location.Y, txt_day.Width, txt_day.Height);
            txt_hoursOriginalArea = new Rectangle(txt_hours.Location.X, txt_hours.Location.Y, txt_hours.Width, txt_hours.Height);
            radio_nursingOriginalArea = new Rectangle(radio_nursing.Location.X, radio_nursing.Location.Y, radio_nursing.Width, radio_nursing.Height);
            radio_salaryOriginalArea = new Rectangle(radio_salary.Location.X, radio_salary.Location.Y, radio_salary.Width, radio_salary.Height);
            radio_allOriginalArea = new Rectangle(radio_all.Location.X, radio_all.Location.Y, radio_all.Width, radio_all.Height);
            groupBox2OriginalArea = new Rectangle(groupBox2.Location.X, groupBox2.Location.Y, groupBox2.Width, groupBox2.Height);
            label1OriginalArea = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            txt_searchOriginalArea = new Rectangle(txt_search.Location.X, txt_search.Location.Y, txt_search.Width, txt_search.Height);
            groupBox1OriginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            groupBox3OriginalArea = new Rectangle(groupBox3.Location.X, groupBox3.Location.Y, groupBox3.Width, groupBox3.Height);
            label3OriginalArea = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            lab_number_of_selectedOriginalArea = new Rectangle(lab_number_of_selected.Location.X, lab_number_of_selected.Location.Y, lab_number_of_selected.Width, lab_number_of_selected.Height);
            //label4OriginalArea = new Rectangle(label4.Location.X, label4.Location.Y, label4.Width, label4.Height);
            button3OriginalArea = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            button2OriginalArea = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);

            groupBox5OriginalArea = new Rectangle(groupBox5.Location.X, groupBox5.Location.Y, groupBox5.Width, groupBox5.Height);
            groupBox6OriginalArea = new Rectangle(groupBox6.Location.X, groupBox6.Location.Y, groupBox6.Width, groupBox6.Height);
            
           
        }

        private Rectangle txt_dely_minuteOriginalArea;
        private Rectangle groupBox6OriginalArea;
        private Rectangle groupBox5OriginalArea;
        private Rectangle data_all_clientsOriginalArea;
        private Rectangle data_selected_clientOriginalArea;
        private Rectangle dateTimePicker1OriginalArea;
        private Rectangle label2OriginalArea;
        private Rectangle combo_catOriginalArea;
        private Rectangle txt_hoursOriginalArea;
        private Rectangle groupBox4OriginalArea;
        private Rectangle radio_doctorsOriginal;
        private Rectangle txt_monthOriginalArea;
        private Rectangle txt_yearOriginalArea;
        private Rectangle txt_dayOriginalArea;
       
        private Rectangle radio_nursingOriginalArea;
        private Rectangle radio_salaryOriginalArea;
        private Rectangle radio_allOriginalArea;
        private Rectangle groupBox2OriginalArea;
        private Rectangle label1OriginalArea;
        private Rectangle txt_searchOriginalArea;
        private Rectangle groupBox1OriginalArea;
        private Rectangle groupBox3OriginalArea;
        private Rectangle label3OriginalArea;
        private Rectangle lab_number_of_selectedOriginalArea;
        //private Rectangle label4OriginalArea;
        private Rectangle button3OriginalArea;
        private Rectangle button2OriginalArea;
        private Size orginalSize;


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



        private void resizeControlers()
        {


    

            resizeControler(txt_hoursOriginalArea, txt_hours);
          
            resizeControler(txt_dely_minuteOriginalArea, txt_dely_minute);
            resizeControler(groupBox6OriginalArea, groupBox6);
            resizeControler(groupBox5OriginalArea, groupBox5);
            resizeControler(data_all_clientsOriginalArea, data_all_clients);
            resizeControler(data_selected_clientOriginalArea, data_selected_client);
            resizeControler(dateTimePicker1OriginalArea, dateTimePicker1);
            resizeControler(label2OriginalArea, label2);
            resizeControler(combo_catOriginalArea, combo_cat);
            //resizeControler(textBox2OriginalArea, textBox2);
            resizeControler(groupBox4OriginalArea, groupBox4);
            resizeControler(radio_doctorsOriginal, radio_doctors);
            resizeControler(txt_monthOriginalArea, txt_month);
            resizeControler(txt_yearOriginalArea, txt_year);
            resizeControler(txt_dayOriginalArea, txt_day);
            //resizeControler(textBox1OriginalArea, textBox1);
            resizeControler(radio_nursingOriginalArea, radio_nursing);
            resizeControler(radio_salaryOriginalArea, radio_salary);
            resizeControler(radio_allOriginalArea, radio_all);
            resizeControler(groupBox2OriginalArea, groupBox2);
            resizeControler(label1OriginalArea, label1);
            resizeControler(label3OriginalArea, label3);
            resizeControler(txt_searchOriginalArea, txt_search);
            resizeControler(groupBox1OriginalArea, groupBox1);
            resizeControler(groupBox3OriginalArea, groupBox3);
            resizeControler(lab_number_of_selectedOriginalArea, lab_number_of_selected);
            //resizeControler(label4OriginalArea, label4);
            resizeControler(button3OriginalArea, button3);
            resizeControler(button2OriginalArea, button2);

        }

        private void data_all_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void data_all_clients_DoubleClick(object sender, System.EventArgs e)
        {
            add_dely_minute frm_minute = new add_dely_minute();



            //لو شفت
            if (radio_nursing.Checked == true)
            {

                number_of_selected_clients++;
                lab_number_of_selected.Text = number_of_selected_clients.ToString();

                DataRow r = dt.NewRow();

                r[0] = this.data_all_clients.CurrentRow.Cells[0].Value;

                r[1] = this.data_all_clients.CurrentRow.Cells[1].Value;
                r[2] = this.data_all_clients.CurrentRow.Cells[2].Value;
                r[3] = this.data_all_clients.CurrentRow.Cells[3].Value;
                r[4] = this.data_all_clients.CurrentRow.Cells[4].Value;
                r[5] = this.data_all_clients.CurrentRow.Cells[5].Value;
                r[6] = this.txt_dely_minute.Text;
                dt.Rows.Add(r);

                data_selected_client.DataSource = dt;

                this.data_all_clients.Rows.RemoveAt(this.data_all_clients.CurrentRow.Index);
            }
            /////////////////////////////////////


            //لو مقيم
            else if (radio_doctors.Checked == true)
            {
                    add_staying_hours frm = new add_staying_hours();
                    frm.txt_dr_name.Text = this.data_all_clients.CurrentRow.Cells[0].Value.ToString();
              

                    frm.txt_number_of_staying_hours.Focus();
                    frm.ShowDialog();

                    {
                       // if (state == "data")
                     //   {
                        number_of_selected_clients++;

                        r = dt1.NewRow();

                        r[0] = this.data_all_clients.CurrentRow.Cells[0].Value;
                        r[1] = this.data_all_clients.CurrentRow.Cells[1].Value;
                        r[2] = this.data_all_clients.CurrentRow.Cells[2].Value;
                        r[3] = this.data_all_clients.CurrentRow.Cells[3].Value;
                        r[4] = this.data_all_clients.CurrentRow.Cells[4].Value;
                        r[5] = this.data_all_clients.CurrentRow.Cells[5].Value;
                        r[6] = frm.txt_number_of_staying_hours.Text;

                        r[7] = "0";


                        dt1.Rows.Add(r);

                        data_selected_client.DataSource = dt1;

                        this.data_all_clients.Rows.RemoveAt(this.data_all_clients.CurrentRow.Index);
                   // }


                }
            }

            //لو راتب
            else if (radio_salary.Checked)
            {
               
                number_of_selected_clients++;

                r = dt2.NewRow();

                r[0] = this.data_all_clients.CurrentRow.Cells[0].Value;
                r[1] = this.data_all_clients.CurrentRow.Cells[1].Value;
                r[2] = client.get_sallary_with_client_id(Convert.ToInt32(data_all_clients.CurrentRow.Cells[5].Value)).Rows[0][0];
                r[3] = this.data_all_clients.CurrentRow.Cells[3].Value;
                r[4] = this.data_all_clients.CurrentRow.Cells[4].Value;
                r[5] = this.data_all_clients.CurrentRow.Cells[5].Value;
                r[6] = txt_dely_minute.Text;
             
                dt2.Rows.Add(r);

                data_selected_client.DataSource = dt2;

                this.data_all_clients.Rows.RemoveAt(this.data_all_clients.CurrentRow.Index);




            }




        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {




            data_all_clients.DataSource = motions.search_cleint_name_id_department_role(txt_search.Text);

            //حذف الموظفين المختارين قبل او بعد عمليه البحث لمنع التكرار

            for (int i = 0; i < data_all_clients.Rows.Count - 1; i++)
            {
                for (int x = 0; x < data_selected_client.Rows.Count - 1; x++)
                {
                    if (Convert.ToInt32(data_all_clients.Rows[i].Cells[5].Value) == Convert.ToInt32(data_selected_client.Rows[x].Cells[5].Value))
                    {
                        data_all_clients.Rows.RemoveAt(i);
                    }
                
                }

              




            }
        }

        private void data_selected_client_DoubleClick(object sender, EventArgs e)
        {

            this.data_selected_client.Rows.RemoveAt(this.data_all_clients.CurrentRow.Index);

            number_of_selected_clients--;
            lab_number_of_selected.Text = number_of_selected_clients.ToString();


        }

        private void radio_doctors_CheckedChanged(object sender, EventArgs e)
        {

            if (radio_doctors.Checked == true)
            {
               txt_search.Text = "مقيم";
                data_selected_client.DataSource = dt1;
             

                combo_cat.SelectedIndex = 3;


            }



        }

        private void radio_nursing_CheckedChanged(object sender, EventArgs e)
        {
            data_selected_client.DataSource = dt;
          
          txt_search.Text = "شيفت";

         combo_cat.SelectedIndex = 0;
        }

        private void radio_salary_CheckedChanged(object sender, EventArgs e)
        {

            txt_search.Text = "راتب";
            data_selected_client.DataSource = dt2;
            combo_cat.SelectedIndex =2;
        }

        private void radio_all_CheckedChanged(object sender, EventArgs e)
        {
            txt_search.Text = "";
            combo_cat.SelectedItem = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //لو كان شيفت
            if (radio_nursing.Checked)
            {
                for (int i = 0; i < data_selected_client.Rows.Count - 1; i++)
                {
                    motions.add_client_motion(Convert.ToInt32(data_selected_client.Rows[i].Cells[5].Value), Convert.ToInt32(combo_cat.SelectedIndex), dateTimePicker1.Value, txt_month.Text, txt_year.Text, txt_day.Text, Convert.ToInt32(data_selected_client.Rows[i].Cells[4].Value), Convert.ToInt32(data_selected_client.Rows[i].Cells[6].Value));

                }
            }
            //لو كان مقيم تم تخزين عدد ساعات الاقامه في جدول اخر
            if (radio_doctors.Checked)
            {
                for (int i = 0; i < data_selected_client.Rows.Count - 1; i++)
                {
                    motions.add_client_motion(Convert.ToInt32(data_selected_client.Rows[i].Cells[5].Value), Convert.ToInt32(combo_cat.SelectedIndex), dateTimePicker1.Value, txt_month.Text, txt_year.Text, txt_day.Text, Convert.ToInt32(data_selected_client.Rows[i].Cells[4].Value), Convert.ToInt32(data_selected_client.Rows[i].Cells[7].Value));

                    motions.add_staying_houres(Convert.ToInt32(data_selected_client.Rows[i].Cells[5].Value), Convert.ToDouble(data_selected_client.Rows[i].Cells[6].Value), txt_month.Text, txt_year.Text, txt_day.Text);


                    motions.update_total_staying_if_not_exist(Convert.ToInt32(data_selected_client.Rows[i].Cells[5].Value), Convert.ToDouble(data_selected_client.Rows[i].Cells[6].Value), Convert.ToInt32(txt_day.Text), Convert.ToInt32(txt_month.Text), Convert.ToInt32(txt_year.Text));


                }
            }

            //لو كان راتب

            if (radio_salary.Checked)
            {
                for (int i = 0; i < data_selected_client.Rows.Count - 1; i++)
                {
                    motions.add_client_motion(Convert.ToInt32(data_selected_client.Rows[i].Cells[5].Value), Convert.ToInt32(combo_cat.SelectedIndex), dateTimePicker1.Value, txt_month.Text, txt_year.Text, txt_day.Text, Convert.ToInt32(data_selected_client.Rows[i].Cells[4].Value), Convert.ToInt32(data_selected_client.Rows[i].Cells[6].Value));

                    motions.add_salary_motion(Convert.ToInt32(data_selected_client.Rows[i].Cells[5].Value), txt_month.Text, txt_year.Text, txt_day.Text);
                }
            }


            MessageBox.Show("تم الحفظ", "تم حفظ الحركه بنجاح", MessageBoxButtons.OK);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           txt_month.Text = dateTimePicker1.Value.Month.ToString();
            txt_year.Text = dateTimePicker1.Value.Year.ToString();
            txt_day.Text = dateTimePicker1.Value.Day.ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void data_selected_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combo_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radio_nursing.Checked)
            {
                if (combo_cat.SelectedItem.ToString() == "شيفت صباحي")
                {
                    //ظهر 
                    if (Convert.ToInt32(dateTimePicker1.Value.Hour) > 13)
                    {
                        int dely_hour = Convert.ToInt32(dateTimePicker1.Value.Hour) - 13;

                        int dely_minute = Convert.ToInt32(dateTimePicker1.Value.Minute);


                        if (dely_hour < 0)
                        {

                            dely_hour = dely_hour * -1;
                        }
                        if (dely_minute < 0)
                        {
                            dely_minute = dely_minute * -1;
                        }



                        txt_dely_minute.Text = (dely_hour*60 + dely_minute).ToString();
                        txt_hours.Text = Math.Round((Convert.ToDouble(txt_dely_minute.Text) / 60.0)).ToString();
                    }
                    else
                    {

                        int dely_hour = Convert.ToInt32(dateTimePicker1.Value.Hour) - 8;

                        int dely_minute = Convert.ToInt32(dateTimePicker1.Value.Minute);


                        if (dely_hour < 0)
                        {

                            dely_hour = dely_hour * -1;
                        }
                        if (dely_minute < 0)
                        {
                            dely_minute = dely_minute * -1;
                        }

                        txt_dely_minute.Text = (dely_hour*60 + dely_minute).ToString();
                        txt_hours.Text =  Math.Round( (Convert.ToDouble(txt_dely_minute.Text) / 60.0)).ToString();
                    }


                  
                 
                }


               

                if (combo_cat.SelectedItem.ToString() == "شيفت مسائي")
                {

                    int dely_hour = Convert.ToInt32(dateTimePicker1.Value.Hour) -20;
                  
                    int dely_minute = Convert.ToInt32(dateTimePicker1.Value.Minute);


                    if (dely_hour < 0)
                    {

                        dely_hour = dely_hour * -1;
                    }
                    if (dely_minute < 0)
                    {
                        dely_minute = dely_minute * -1;
                    }




                    txt_dely_minute.Text = (dely_hour*60 + dely_minute).ToString();
                    txt_hours.Text = Math.Round((Convert.ToDouble(txt_dely_minute.Text) / 60.0)).ToString();
                }
            }












        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lab_number_of_selected_Click(object sender, EventArgs e)
        {

        }

        private void txt_day_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_year_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_month_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //لو شفت
            if (radio_nursing.Checked == true)
            {
                number_of_selected_clients++;
                lab_number_of_selected.Text = number_of_selected_clients.ToString();

                DataRow r = dt.NewRow();

                r[0] = this.data_all_clients.CurrentRow.Cells[0].Value;

                r[1] = this.data_all_clients.CurrentRow.Cells[1].Value;
                r[2] = this.data_all_clients.CurrentRow.Cells[2].Value;
                r[3] = this.data_all_clients.CurrentRow.Cells[3].Value;
                r[4] = this.data_all_clients.CurrentRow.Cells[4].Value;
                r[5] = this.data_all_clients.CurrentRow.Cells[5].Value;

                dt.Rows.Add(r);

                data_selected_client.DataSource = dt;

                this.data_all_clients.Rows.RemoveAt(this.data_all_clients.CurrentRow.Index);
            }
            /////////////////////////////////////
            //لو مقيم
            else if (radio_doctors.Checked == true)
            {


                add_staying_hours frm = new add_staying_hours();
                frm.txt_dr_name.Text = this.data_all_clients.CurrentRow.Cells[0].Value.ToString();
                frm.txt_number_of_staying_hours.Focus();
                frm.ShowDialog();

                {

                    number_of_selected_clients++;

                    r = dt1.NewRow();

                    r[0] = this.data_all_clients.CurrentRow.Cells[0].Value;

                    r[1] = this.data_all_clients.CurrentRow.Cells[1].Value;
                    r[2] = this.data_all_clients.CurrentRow.Cells[2].Value;
                    r[3] = this.data_all_clients.CurrentRow.Cells[3].Value;
                    r[4] = this.data_all_clients.CurrentRow.Cells[4].Value;
                    r[5] = this.data_all_clients.CurrentRow.Cells[5].Value;

                    r[6] = frm.txt_number_of_staying_hours.Text;
                    dt1.Rows.Add(r);

                    data_selected_client.DataSource = dt1;

                    this.data_all_clients.Rows.RemoveAt(this.data_all_clients.CurrentRow.Index);
                }



            }

            //لو راتب
            else if (radio_salary.Checked)
            {
                number_of_selected_clients++;

                r = dt2.NewRow();

                r[0] = this.data_all_clients.CurrentRow.Cells[0].Value;
                r[1] = this.data_all_clients.CurrentRow.Cells[1].Value;
                r[2] = client.get_sallary_with_client_id(Convert.ToInt32(data_all_clients.CurrentRow.Cells[5].Value)).Rows[0][0];
                r[3] = this.data_all_clients.CurrentRow.Cells[3].Value;
                r[4] = this.data_all_clients.CurrentRow.Cells[4].Value;
                r[5] = this.data_all_clients.CurrentRow.Cells[5].Value;


                dt2.Rows.Add(r);

                data_selected_client.DataSource = dt2;

                this.data_all_clients.Rows.RemoveAt(this.data_all_clients.CurrentRow.Index);




            }


        }

        private void client_motion_Resize(object sender, EventArgs e)
        {
            //resizeControlers();
        }
    }
}
