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
    public partial class frm_client_managment : Form
    {
        BL.motions motions = new BL.motions();
        BL.Client client = new BL.Client();
        public DataTable nursing = new DataTable();
        public DataTable staying = new DataTable();
        public DataTable salary = new DataTable();


        void createdatatable()
        {
            nursing.Columns.Add("كود الموظف");
            nursing.Columns.Add("اسم الموظف");
            nursing.Columns.Add("صبح/ظهر");//عدد
            nursing.Columns.Add("سهر");//عدد
            nursing.Columns.Add("صبح/ظهر1");
            nursing.Columns.Add("سهر1");
            nursing.Columns.Add("اجمالي الاستحقاق");
            nursing.Columns.Add("ضربيه كسب العمل");
            nursing.Columns.Add("التأمينات");
            nursing.Columns.Add("التأخير/الجزاء");
            nursing.Columns.Add("سلف/باقه");
            nursing.Columns.Add("اجمالي الاستقطاع");
            nursing.Columns.Add("اخري");
            nursing.Columns.Add("تفاصيل");
            nursing.Columns.Add("صافي الراتب");
        }






        void createdatatable_for_staying()
        {
            staying.Columns.Add("كود الموظف");
            staying.Columns.Add("اسم الموظف");
            staying.Columns.Add("قيمه الاقامه 24 ساعه");//عدد
            staying.Columns.Add("صافي مده العمل باليوم");//عدد
            staying.Columns.Add("صافي قيمه العمل للاقامه");
            staying.Columns.Add("اجمالي الاستحقاق");
            staying.Columns.Add("ضربيه كسب العمل");
            staying.Columns.Add("التأمينات");
            staying.Columns.Add("التأخير/الجزاء");
            staying.Columns.Add("سلف/باقه");
            staying.Columns.Add("اجمالي الاستقطاع");
            staying.Columns.Add("اخري");
            staying.Columns.Add("تفاصيل");
            staying.Columns.Add("صافي الراتب");

        }

        void createdatatable_for_salary()
        {
            salary.Columns.Add("كود الموظف");
            salary.Columns.Add("اسم الموظف");
            salary.Columns.Add("المرتب");
            salary.Columns.Add("اجمالي الاستحقاق");
            salary.Columns.Add("ضربيه كسب العمل");
            salary.Columns.Add("التأمينات");
            salary.Columns.Add("التأخير/الجزاء");
            salary.Columns.Add("سلف/باقه");
            salary.Columns.Add("اجمالي الاستقطاع");
            salary.Columns.Add("اخري");
            salary.Columns.Add("تفاصيل");
            salary.Columns.Add("صافي الراتب");

        }





        public frm_client_managment()
        {
            InitializeComponent();
            createdatatable();
            createdatatable_for_staying();
            createdatatable_for_salary();
            txt_nursing.Text = "0.0";
            txt_salary.Text = "0.0";
            txt_staying.Text = "0.0";
            txt_total.Text = "0.0";

        }

        private void data_filltered_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {//لو دكتور
            if (radio_doctors.Checked)
            {

                if (e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 6 || e.ColumnIndex == 8 || +e.ColumnIndex == 9 || + +e.ColumnIndex == 11 ||+ e.ColumnIndex == 13)
                {
                    //قيمة الاستحقاق القديمه
                    double old_merit = Convert.ToDouble(data_filltered.CurrentRow.Cells[5].Value);

                //  (Program.copy_of_last_salary
                        //ضريبه كسب العمل

                    double new_tax = Convert.ToDouble(data_filltered.CurrentRow.Cells[6].Value);

                    // التأمينات 

                    double new_insuracne = Convert.ToDouble(data_filltered.CurrentRow.Cells[7].Value);

                    //الجزا او الغياب


                    double  new_dely= Convert.ToDouble(data_filltered.CurrentRow.Cells[8].Value);

                    //السلف
                    double new_loan = Convert.ToDouble(data_filltered.CurrentRow.Cells[9].Value);
                    //الاستقطاع
                    double new_deduction = new_tax + new_insuracne + new_dely + new_loan;
                    //الاخري
                    double new_other = Convert.ToDouble(data_filltered.CurrentRow.Cells[11].Value);


                    //الراتب الجديد

                    data_filltered.Rows[e.RowIndex].Cells[13].Value = (old_merit + new_other - new_deduction).ToString();
                }
            }

                //لو ممضرض
            else if (radio_nursing.Checked)
            {

                if (e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 6 || e.ColumnIndex == 8 || +e.ColumnIndex == 9 || + +e.ColumnIndex == 11 || +e.ColumnIndex ==12 || +e.ColumnIndex == 14)
                {
                    //قيمة الاستحقاق القديمه
                    double old_merit = Convert.ToDouble(data_filltered.CurrentRow.Cells[6].Value);

                    //  (Program.copy_of_last_salary
                    //ضريبه كسب العمل

                    double new_tax = Convert.ToDouble(data_filltered.CurrentRow.Cells[7].Value);

                    // التأمينات 

                    double new_insuracne = Convert.ToDouble(data_filltered.CurrentRow.Cells[8].Value);

                    //الجزا او الغياب


                    double new_dely = Convert.ToDouble(data_filltered.CurrentRow.Cells[9].Value);

                    //السلف
                    double new_loan = Convert.ToDouble(data_filltered.CurrentRow.Cells[10].Value);
                    //الاستقطاع
                    double new_deduction = new_tax + new_insuracne + new_dely + new_loan;
                    //الاخري
                    double new_other = Convert.ToDouble(data_filltered.CurrentRow.Cells[12].Value);


                    //الراتب الجديد

                    data_filltered.Rows[e.RowIndex].Cells[14].Value = (old_merit + new_other - new_deduction).ToString();
                }

            }
            //لو راتب

            else
            {

                if (e.ColumnIndex == 4 || e.ColumnIndex == 7 || e.ColumnIndex == 5 || e.ColumnIndex == 8 || +e.ColumnIndex == 9 || +e.ColumnIndex == 11 || +e.ColumnIndex ==6 || + e.ColumnIndex == 11)
                {
                    //قيمة الاستحقاق القديمه
                    double old_merit = Convert.ToDouble(data_filltered.CurrentRow.Cells[3].Value);

                    //  (Program.copy_of_last_salary
                    //ضريبه كسب العمل

                    double new_tax = Convert.ToDouble(data_filltered.CurrentRow.Cells[4].Value);

                    // التأمينات 

                    double new_insuracne = Convert.ToDouble(data_filltered.CurrentRow.Cells[5].Value);

                    //الجزا او الغياب


                    double new_dely = Convert.ToDouble(data_filltered.CurrentRow.Cells[6].Value);

                    //السلف
                    double new_loan = Convert.ToDouble(data_filltered.CurrentRow.Cells[7].Value);
                    //الاستقطاع
                    double new_deduction = new_tax + new_insuracne + new_dely + new_loan;
                    //الاخري
                    double new_other = Convert.ToDouble(data_filltered.CurrentRow.Cells[9].Value);


                    //الراتب الجديد

                    data_filltered.Rows[e.RowIndex].Cells[11].Value = (old_merit + new_other - new_deduction).ToString();
                }

            }



        }

        private void radio_doctors_CheckedChanged(object sender, EventArgs e)
        {


            if (radio_doctors.Checked)
            {

                data_filltered.DataSource = null;

                double staying_salary = 0;
                label_type.Text = "الاطباء المقيمين بالمستشفي";

                nursing.Rows.Clear();
                salary.Rows.Clear();




                data_clients.DataSource = motions.get_staying_motions(txt_month.Text, txt_year.Text);
                double value_of_stauing_hours = 0;
                double number_of_staying_days = 0;
                







                for (int i = 0; i < data_clients.Rows.Count - 1; i++)
                {



                    if (Convert.ToInt32(data_clients.Rows[i].Cells[0].Value) == Convert.ToInt32(data_clients.Rows[i + 1].Cells[0].Value))
                    {


                        number_of_staying_days++;

                    }



                    value_of_stauing_hours = Convert.ToDouble(client.get_value_of_stay_with_client_id(Convert.ToInt32(data_clients.Rows[i].Cells[0].Value)).Rows[0][0]);





                    DataRow r = staying.NewRow();
                    r[0] = data_clients.Rows[i].Cells[0].Value;
                    r[1] = data_clients.Rows[i].Cells[1].Value;
                    r[2] = value_of_stauing_hours;
                    //عمود عدد ساعات الاقامه خلال شهر
                    r[3] =  Convert.ToDouble( Convert.ToDouble( motions.get_number_of_staying_and_number_of_dasy(Convert.ToInt32(data_clients.Rows[i].Cells[0].Value), Convert.ToInt32(data_clients.Rows[i].Cells[4].Value), Convert.ToInt32(data_clients.Rows[i].Cells[5].Value)).Rows[0][0]))/24 ;


                    r[4] = (value_of_stauing_hours ) * Convert.ToDouble(r[3]);

                    double total_merit = value_of_stauing_hours * Convert.ToDouble(r[3]);
                    r[5] = r[4];

                    if (total_merit >= 1250)
                    {

                        r[6] = Math.Round(((((total_merit * 12) - 15000) / 12) * 0.015));

                    }
                    else
                    {
                        r[6] = 0.0;
                    }

                    double total_deduction = (26 - number_of_staying_days) * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][4]) + Convert.ToDouble(r[5]);

                    r[7] = 0;
                    //   number_of_dely_minute = Convert.ToDouble(  r[3])- (number_of_dely_minute / 60.0) ;
                    r[8] = (26 - number_of_staying_days) * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][4]);
                    r[9] = 0;

                    r[10] = Convert.ToDouble(r[6]) + Convert.ToDouble(r[7]) + Convert.ToDouble(r[8]) + Convert.ToDouble(r[9]);
                    r[11] = 0.0;
                    r[12] = "لا توجد تفاصيل";
                    r[13] = Convert.ToDouble(r[5]) - Convert.ToDouble(r[10]); //صافي الراتب
                    staying.Rows.Add(r);
                    total_merit = 0;


                }

                data_filltered.DataSource = staying;


                //حذف المكرر


                for (int h = 0; h < 10; h++)
                {
                    for (int y = 0; y < data_filltered.Rows.Count - 1; y++)
                    {
                        if (Convert.ToInt32(data_filltered.Rows[y].Cells[0].Value) == Convert.ToInt32(data_filltered.Rows[y + 1].Cells[0].Value))
                        {
                            data_filltered.Rows.RemoveAt(y + 1);
                        }
                    }
                }


                //حساب صافي الراتب

                for (int i = 0; i < data_filltered.Rows.Count - 1; i++)
                {
                    staying_salary = staying_salary + Convert.ToDouble(data_filltered.Rows[i].Cells[13].Value);
                }


                txt_staying.Text = staying_salary.ToString();
                txt_total.Text = (Convert.ToDouble(txt_nursing.Text) + Convert.ToDouble(txt_staying.Text) + Convert.ToDouble(txt_salary.Text)).ToString();


                nursing.Rows.Clear();
                salary.Rows.Clear();
                // staying.Rows.Clear();





            }

        }

        private void frm_client_managment_Load(object sender, EventArgs e)
        {
            orginalSize = this.Size;
            groupBox1OriginalArea = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Width, groupBox1.Height);
            label2OriginalArea = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            label1OriginalArea = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            txt_month_visiableOriginalArea = new Rectangle(txt_month_visiable.Location.X, txt_month_visiable.Location.Y, txt_month_visiable.Width, txt_month_visiable.Height);
            txt_yearOriginalArea = new Rectangle(txt_year.Location.X, txt_year.Location.Y, txt_year.Width, txt_year.Height);
            label8OriginalArea = new Rectangle(label8.Location.X, label8.Location.Y, label8.Width, label8.Height);
            label3OriginalArea = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            txt_userOriginalArea = new Rectangle(txt_user.Location.X, txt_user.Location.Y, txt_user.Width, txt_user.Height);
            label9OriginalArea = new Rectangle(label9.Location.X, label9.Location.Y, label9.Width, label9.Height);
            txt_shearchOriginalArea = new Rectangle(txt_shearch.Location.X, txt_shearch.Location.Y, txt_shearch.Width, txt_shearch.Height);
            label_typeOriginalArea = new Rectangle(label_type.Location.X, label_type.Location.Y, label_type.Width, label_type.Height);
            groupBox4OriginalArea = new Rectangle(groupBox4.Location.X, groupBox4.Location.Y, groupBox4.Width, groupBox4.Height);
            label4OriginalArea = new Rectangle(label4.Location.X, label4.Location.Y, label4.Width, label4.Height);
            label5OriginalArea=new Rectangle (label5.Location.X,label5.Location.Y,label5.Width,label5.Height);
            label6OriginalArea=new Rectangle(label6.Location.X,label6.Location.Y,label6.Width,label6.Height);
            label7OriginalArea=new Rectangle(label7.Location.X,label7.Location.Y,label7.Width,label7.Height);
            txt_stayingOriginalArea = new Rectangle(txt_staying.Location.X, txt_staying.Location.Y, txt_staying.Width, txt_staying.Height);
            txt_nursingOriginalArea = new Rectangle(txt_nursing.Location.X, txt_nursing.Location.Y, txt_nursing.Width, txt_nursing.Height);
            txt_salaryOriginalArea = new Rectangle(txt_salary.Location.X, txt_salary.Location.Y, txt_salary.Width, txt_salary.Height);
            txt_totalOriginalArea = new Rectangle(txt_total.Location.X, txt_total.Location.Y, txt_total.Width, txt_total.Height);
            btn_saveOriginalArea = new Rectangle(btn_save.Location.X, btn_save.Location.Y, btn_save.Width, btn_save.Height);
            data_fillteredOriginalArea = new Rectangle(data_filltered.Location.X, data_filltered.Location.Y, data_filltered.Width, data_filltered.Height);

        }
        private Rectangle groupBox1OriginalArea;
        private Rectangle label2OriginalArea;
        private Rectangle label1OriginalArea;
        private Rectangle txt_month_visiableOriginalArea;
        private Rectangle txt_yearOriginalArea;
        private Rectangle label8OriginalArea;
        private Rectangle label3OriginalArea;
        private Rectangle txt_userOriginalArea;
        private Rectangle label9OriginalArea;
        private Rectangle txt_shearchOriginalArea;
        private Rectangle label_typeOriginalArea;
        private Rectangle groupBox4OriginalArea;
        private Rectangle label4OriginalArea;
        private Rectangle label5OriginalArea;
        private Rectangle label6OriginalArea;
        private Rectangle label7OriginalArea;
        private Rectangle txt_stayingOriginalArea;
        private Rectangle txt_nursingOriginalArea;
        private Rectangle txt_salaryOriginalArea;
        private Rectangle txt_totalOriginalArea;
        private Rectangle btn_saveOriginalArea;
        private Rectangle data_fillteredOriginalArea;
        private Size orginalSize;


        private void resizeControlers()
        {


            resizeControler(groupBox1OriginalArea, groupBox1);
            resizeControler(label2OriginalArea, label2);
            resizeControler(label1OriginalArea, label1);
            resizeControler(txt_month_visiableOriginalArea, txt_month_visiable);
            resizeControler(txt_yearOriginalArea, txt_year);
            resizeControler(label8OriginalArea, label8);
            resizeControler(label3OriginalArea, label3);
            resizeControler(txt_userOriginalArea, txt_user);
            resizeControler(label9OriginalArea, label9);
            resizeControler(txt_shearchOriginalArea, txt_shearch);
            resizeControler(label_typeOriginalArea, label_type);
            resizeControler(groupBox4OriginalArea, groupBox4);
            resizeControler(label4OriginalArea, label4);
            resizeControler(label5OriginalArea, label5);
            resizeControler(label6OriginalArea, label6);
            resizeControler(label7OriginalArea, label7);
            resizeControler(txt_stayingOriginalArea, txt_staying);
            resizeControler(txt_nursingOriginalArea, txt_nursing);
            resizeControler(txt_salaryOriginalArea, txt_salary);
            resizeControler(txt_totalOriginalArea, txt_total);
            resizeControler(btn_saveOriginalArea, btn_save);
            resizeControler(data_fillteredOriginalArea, data_filltered);
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
        private void radio_salary_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_salary.Checked)
            {
                data_filltered.DataSource = null;
                double salary_salary = 0;


                label_type.Text = "الموظفين اصحاب الرواتب";




                data_clients.DataSource = motions.get_salary_motins(txt_month.Text, txt_year.Text);



                for (int i = 0; i < data_clients.Rows.Count - 1; i++)
                {
                    //عدد ايام الحضور
                    int number_of_attenndence_days = 0;

                    for (int x = 0; x < data_clients.Rows.Count - 1; x++)


                        if (Convert.ToInt32(data_clients.Rows[x].Cells[0].Value) == Convert.ToInt32(data_clients.Rows[i].Cells[0].Value))
                        {
                            number_of_attenndence_days++;
                        }






                    DataRow r = salary.NewRow();
                    r[0] = data_clients.Rows[i].Cells[0].Value;
                    r[1] = data_clients.Rows[i].Cells[1].Value;
                    r[2] = client.get_sallary_with_client_id(Convert.ToInt32(r[0])).Rows[0][0];



                    r[3] = r[2];//اجمالي الاستحقاق


                    double total_merit = Convert.ToDouble(r[3].ToString());




                    if (total_merit >= 1250)
                    {

                        r[4] = Math.Round(((((total_merit * 12) - 15000) / 12) * 0.015));

                    }
                    else
                    {
                        r[4] = 0.0;
                    }
                    double value_of_hour = Convert.ToDouble(client.get_sallary_with_client_id(Convert.ToInt32(r[0])).Rows[0][0]) / 720.0;


                    double dely_hours = Convert.ToDouble(motions.get_dely_hours(Convert.ToInt32(r[0]), Convert.ToInt32(txt_month.Text), Convert.ToInt32(txt_year.Text)).Rows[0][0]);

                    //  double total_deduction = (26 - number_of_attenndence_days) * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][4]) + Convert.ToDouble(r[5]);
                    r[5] = client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][2];
                    r[6] = (value_of_hour * dely_hours) + (Convert.ToDouble(client.get_sallary_with_client_id(Convert.ToInt32(r[0])).Rows[0][0]) / 30.0) * (26.0 - number_of_attenndence_days);





                    r[7] = 0;
                    r[8] = Convert.ToDouble(r[4]) + Convert.ToDouble(r[5]) + Convert.ToDouble(r[6]) + Convert.ToDouble(r[7]);
                    r[9] = 0;

                    r[10] = "لا توجد تفاصيل";
                    r[11] = Convert.ToDouble(r[3]) - Convert.ToDouble(r[8]);


                    salary.Rows.Add(r);
                    total_merit = 0;


                }

                data_filltered.DataSource = salary;


                //حذف المكرر


                for (int h = 0; h < 10; h++)
                {
                    for (int y = 0; y < data_filltered.Rows.Count - 1; y++)
                    {
                        if (Convert.ToInt32(data_filltered.Rows[y].Cells[0].Value) == Convert.ToInt32(data_filltered.Rows[y + 1].Cells[0].Value))
                        {
                            data_filltered.Rows.RemoveAt(y + 1);
                        }
                    }
                }
                nursing.Rows.Clear();
                //       salary.Rows.Clear();
                staying.Rows.Clear();


                //حساب صافي الراتب

                for (int i = 0; i < data_filltered.Rows.Count - 1; i++)
                {
                    salary_salary = salary_salary + Convert.ToDouble(data_filltered.Rows[i].Cells[11].Value);
                }
                txt_salary.Text = salary_salary.ToString();
                txt_total.Text = (Convert.ToDouble(txt_nursing.Text) + Convert.ToDouble(txt_staying.Text) + Convert.ToDouble(txt_salary.Text)).ToString();






            }
        }

        private void radio_nursing_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nursing.Checked)
            {
                data_filltered.DataSource = null;

                data_clients.DataSource = motions.get_shites_motions(txt_month.Text, txt_year.Text);

                double nursing_salary = 0;

                label_type.Text = "شفتات التمريض";

                staying.Rows.Clear();

                salary.Rows.Clear();






                //لو شفت

                //حذف المكرر مع جمع عدد الشيفات

                for (int i = 0; i < data_clients.Rows.Count - 1; i++)
                {
                    int number_of_night_shift = 0;
                    int nummber_of_morining_shift = 0;



                    if (Convert.ToInt32(data_clients.Rows[i].Cells[0].Value) == Convert.ToInt32(data_clients.Rows[i + 1].Cells[0].Value))
                    {

                        for (int x = 0; x < data_clients.Rows.Count - 1; x++)
                        {
                            if (Convert.ToString(data_clients.Rows[x].Cells[2].Value) == "شيفت مسائي" && Convert.ToInt32(data_clients.Rows[x].Cells[0].Value) == Convert.ToInt32(data_clients.Rows[i].Cells[0].Value))
                            {

                                number_of_night_shift++;

                            }

                            else if (Convert.ToString(data_clients.Rows[x].Cells[2].Value) == "شيفت صباحي" && Convert.ToInt32(data_clients.Rows[x].Cells[0].Value) == Convert.ToInt32(data_clients.Rows[i].Cells[0].Value))
                            {
                                nummber_of_morining_shift++;


                            }


                        }


                    }

                    //اسناد القيم
                    DataRow r = nursing.NewRow();
                    r[0] = data_clients.Rows[i].Cells[0].Value;//كود الموظف
                    r[1] = data_clients.Rows[i].Cells[1].Value;//اسم الموظف
                    r[2] = nummber_of_morining_shift;//عدد الشفتات الصباحيه
                    r[3] = number_of_night_shift;//عدد الشفتات المسائيه
                    r[4] = (nummber_of_morining_shift * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][4]));//قيمه الشفت الصباحي
                    r[5] = (number_of_night_shift * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][5]));//قيمه الشفت المسائي
                    r[6] = Convert.ToDouble(r[5]) + Convert.ToDouble(r[4]);//اجمالي الاستحقاق
                    double total_merit = Convert.ToDouble(r[6]);

                    //ضربيه كسب العمل
                    if (total_merit >= 1250)
                    {

                        r[7] = Math.Round(((((total_merit * 12) - 15000) / 12) * 0.015));

                    }
                    else
                    {
                        r[7] = 0.0;
                    }

                    double value_of_hour = (Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][4]) / 6.0);


                    double dely_hours = Convert.ToDouble(motions.get_dely_hours(Convert.ToInt32(r[0]), Convert.ToInt32(txt_month.Text), Convert.ToInt32(txt_year.Text)).Rows[0][0]);


                    r[8] = client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][2]; //التأمين تأمين جديد 140


                    r[9] = Convert.ToDouble(dely_hours * value_of_hour) + (26 - nummber_of_morining_shift) * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][4]);//الغياب
                    r[10] = 0;//السلف او الباقه

                    r[11] = Convert.ToDouble(r[8]) + Convert.ToDouble(r[9]) + Convert.ToDouble(r[10]);//اجمالي الاستقطاع
                    r[12] = 0.0;//اخري
                    r[13] = "لا توجد تفاصيل";
                    r[14] = Convert.ToDouble(r[6]) + Convert.ToDouble(r[11]);//صافي الراتب
                    nursing.Rows.Add(r);

                    total_merit = 0;


                }

                data_filltered.DataSource = nursing;


                //حذف المكرر


                for (int h = 0; h < 10; h++)
                {
                    for (int y = 0; y < data_filltered.Rows.Count - 1; y++)
                    {
                        if (Convert.ToInt32(data_filltered.Rows[y].Cells[0].Value) == Convert.ToInt32(data_filltered.Rows[y + 1].Cells[0].Value))
                        {
                            data_filltered.Rows.RemoveAt(y + 1);
                        }
                    }
                }
                Program.copy_of_last_salary = Convert.ToDouble(data_filltered.CurrentRow.Cells[14].Value);

                // nursing.Rows.Clear();
                salary.Rows.Clear();
                staying.Rows.Clear();



                //حساب صافي الراتب

                for (int i = 0; i < data_filltered.Rows.Count - 1; i++)
                {
                    nursing_salary = nursing_salary + Convert.ToDouble(data_filltered.Rows[i].Cells[14].Value);
                }
                txt_nursing.Text = nursing_salary.ToString();
                txt_total.Text = (Convert.ToDouble(txt_nursing.Text) + Convert.ToDouble(txt_staying.Text) + Convert.ToDouble(txt_salary.Text)).ToString();








            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radio_all_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_shearch_TextChanged(object sender, EventArgs e)
        {





        }

        private void btn_save_Click(object sender, EventArgs e)
        {



            //حفظ over all_summary




            //حفظ المقيمين



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            data_filltered.DataSource = null;

            double staying_salary = 0;
            label_type.Text = "الاطباء المقيمين بالمستشفي";
            nursing.Rows.Clear();
            salary.Rows.Clear();
            data_clients.DataSource = motions.get_staying_motions(txt_month.Text, txt_year.Text);
            double value_of_stauing_hours = 0;
            double number_of_staying_days = 0;
            for (int i = 0; i < data_clients.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(data_clients.Rows[i].Cells[0].Value) == Convert.ToInt32(data_clients.Rows[i + 1].Cells[0].Value))
                {
                    number_of_staying_days++;
                }

                value_of_stauing_hours = Convert.ToDouble(client.get_value_of_stay_with_client_id(Convert.ToInt32(data_clients.Rows[i].Cells[0].Value)).Rows[0][0]);

                DataRow r = staying.NewRow();
                r[0] = data_clients.Rows[i].Cells[0].Value;
                r[1] = data_clients.Rows[i].Cells[1].Value;
                r[2] = value_of_stauing_hours;
                //عمود عدد ساعات الاقامه خلال شهر
                r[3] = motions.get_number_of_staying_and_number_of_dasy(Convert.ToInt32(data_clients.Rows[i].Cells[0].Value), Convert.ToInt32(data_clients.Rows[i].Cells[4].Value), Convert.ToInt32(data_clients.Rows[i].Cells[5].Value)).Rows[0][0];

                r[4] = value_of_stauing_hours * Convert.ToDouble(r[3]);

                double total_merit = value_of_stauing_hours * Convert.ToDouble(r[3]);
                r[5] = r[4];

                if (total_merit >= 1250)
                {

                    r[6] = Math.Round(((((total_merit * 12) - 15000) / 12) * 0.015));

                }
                else
                {
                    r[6] = 0.0;
                }

                double total_deduction = (26 - number_of_staying_days) * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][4]) + Convert.ToDouble(r[5]);

                r[7] = 0;
                r[8] = (26 - number_of_staying_days) * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][4]);
                r[9] = 0;
                r[10] = Convert.ToDouble(r[6]) + Convert.ToDouble(r[7]) + Convert.ToDouble(r[8]) + Convert.ToDouble(r[9]);
                r[11] = 0.0;
                r[12] = "لا توجد تفاصيل";
                r[13] = Convert.ToDouble(r[5]) - Convert.ToDouble(r[10]); //صافي الراتب
                staying.Rows.Add(r);
                total_merit = 0;
            }

            data_filltered.DataSource = staying;
            //حذف المكرر

            for (int h = 0; h < 10; h++)
            {
                for (int y = 0; y < data_filltered.Rows.Count - 1; y++)
                {
                    if (Convert.ToInt32(data_filltered.Rows[y].Cells[0].Value) == Convert.ToInt32(data_filltered.Rows[y + 1].Cells[0].Value))
                    {
                        data_filltered.Rows.RemoveAt(y + 1);
                    }
                }
            }


            //حساب صافي الراتب

            for (int i = 0; i < data_filltered.Rows.Count - 1; i++)
            {
                staying_salary = staying_salary + Convert.ToDouble(data_filltered.Rows[i].Cells[13].Value);
            }


            txt_staying.Text = staying_salary.ToString();
            txt_total.Text = (Convert.ToDouble(txt_nursing.Text) + Convert.ToDouble(txt_staying.Text) + Convert.ToDouble(txt_salary.Text)).ToString();
            nursing.Rows.Clear();
            salary.Rows.Clear();

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < data_filltered.Rows.Count - 1; i++)
            {
                motions.add_over_alll_staying(Convert.ToInt32(data_filltered.Rows[i].Cells[0].Value), data_filltered.Rows[i].Cells[1].Value.ToString(), Convert.ToDouble(data_filltered.Rows[i].Cells[2].Value),
  Convert.ToDouble(data_filltered.Rows[i].Cells[3].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[4].Value),

  Convert.ToDouble(data_filltered.Rows[i].Cells[5].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[6].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[7].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[8].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[9].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[10].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[11].Value), data_filltered.Rows[i].Cells[12].Value.ToString(),
  Convert.ToDouble(data_filltered.Rows[i].Cells[13].Value));


                motions.add_over_all_summary(Convert.ToInt32(data_filltered.Rows[i].Cells[0].Value), (26 - Convert.ToInt32(data_filltered.Rows[i].Cells[0].Value)), Convert.ToInt32(txt_month.Text), Convert.ToInt32(txt_year.Text), Convert.ToDouble(data_filltered.Rows[i].Cells[13].Value));


            }




            //حفظ الرواتب



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            data_filltered.DataSource = null;
            double salary_salary = 0;


            label_type.Text = "الموظفين اصحاب الرواتب";




            data_clients.DataSource = motions.get_salary_motins(txt_month.Text, txt_year.Text);



            for (int i = 0; i < data_clients.Rows.Count - 1; i++)
            {
                //عدد ايام الحضور
                int number_of_attenndence_days = 0;

                for (int x = 0; x < data_clients.Rows.Count - 1; x++)
                    if (Convert.ToInt32(data_clients.Rows[x].Cells[0].Value) == Convert.ToInt32(data_clients.Rows[i].Cells[0].Value))
                    {
                        number_of_attenndence_days++;


                    }

                DataRow r = salary.NewRow();
                r[0] = data_clients.Rows[i].Cells[0].Value;
                r[1] = data_clients.Rows[i].Cells[1].Value;
                r[2] = client.get_sallary_with_client_id(Convert.ToInt32(r[0])).Rows[0][0];



                r[3] = r[2];//اجمالي الاستحقاق


                double total_merit = Convert.ToDouble(r[3].ToString());




                if (total_merit >= 1250)
                {

                    r[4] = Math.Round(((((total_merit * 12) - 15000) / 12) * 0.015));

                }
                else
                {
                    r[4] = 0.0;
                }

                //  double total_deduction = (26 - number_of_attenndence_days) * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][4]) + Convert.ToDouble(r[5]);
                r[5] = client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][2];
                r[6] = (26 - number_of_attenndence_days) * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][4]);
                r[7] = 0;
                r[8] = Convert.ToDouble(r[4]) + Convert.ToDouble(r[5]) + Convert.ToDouble(r[6]) + Convert.ToDouble(r[7]);
                r[9] = 0;

                r[10] = "لا توجد تفاصيل";
                r[11] = Convert.ToDouble(r[3]) - Convert.ToDouble(r[8]);


                salary.Rows.Add(r);
                total_merit = 0;


            }

            data_filltered.DataSource = salary;


            //حذف المكرر


            for (int h = 0; h < 10; h++)
            {
                for (int y = 0; y < data_filltered.Rows.Count - 1; y++)
                {
                    if (Convert.ToInt32(data_filltered.Rows[y].Cells[0].Value) == Convert.ToInt32(data_filltered.Rows[y + 1].Cells[0].Value))
                    {
                        data_filltered.Rows.RemoveAt(y + 1);
                    }
                }
            }
            nursing.Rows.Clear();
            //       salary.Rows.Clear();
            staying.Rows.Clear();


            //حساب صافي الراتب

            for (int i = 0; i < data_filltered.Rows.Count - 1; i++)
            {
                salary_salary = salary_salary + Convert.ToDouble(data_filltered.Rows[i].Cells[11].Value);
            }
            txt_salary.Text = salary_salary.ToString();
            txt_total.Text = (Convert.ToDouble(txt_nursing.Text) + Convert.ToDouble(txt_staying.Text) + Convert.ToDouble(txt_salary.Text)).ToString();





            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////








            for (int i = 0; i < data_filltered.Rows.Count - 1; i++)
            {
                motions.add_over_all_salary(Convert.ToInt32(data_filltered.Rows[i].Cells[0].Value), data_filltered.Rows[i].Cells[1].Value.ToString(), Convert.ToDouble(data_filltered.Rows[i].Cells[2].Value),
  Convert.ToDouble(data_filltered.Rows[i].Cells[3].Value),


  Convert.ToDouble(data_filltered.Rows[i].Cells[4].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[5].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[6].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[7].Value),
  Convert.ToDouble(data_filltered.Rows[i].Cells[8].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[9].Value), data_filltered.Rows[i].Cells[10].Value.ToString(), Convert.ToDouble(data_filltered.Rows[i].Cells[11].Value));

                motions.add_over_all_summary(Convert.ToInt32(data_filltered.Rows[i].Cells[0].Value), (26 - Convert.ToInt32(data_filltered.Rows[i].Cells[0].Value)), Convert.ToInt32(txt_month.Text), Convert.ToInt32(txt_year.Text), Convert.ToDouble(data_filltered.Rows[i].Cells[11].Value));

            }







            //حفظ الشفتات
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            data_filltered.DataSource = null;

            double nursing_salary = 0;

            label_type.Text = "شفتات التمريض";



            staying.Rows.Clear();

            salary.Rows.Clear();



            data_clients.DataSource = motions.get_shites_motions(txt_month.Text, txt_year.Text);


            //لو شفت

            //حذف المكرر مع جمع عدد الشيفات

            for (int i = 0; i < data_clients.Rows.Count - 1; i++)
            {
                int number_of_night_shift = 0;
                int nummber_of_morining_shift = 0;



                if (Convert.ToInt32(data_clients.Rows[i].Cells[0].Value) == Convert.ToInt32(data_clients.Rows[i + 1].Cells[0].Value))
                {

                    for (int x = 0; x < data_clients.Rows.Count - 1; x++)
                    {
                        if (Convert.ToString(data_clients.Rows[x].Cells[2].Value) == "شيفت مسائي" && Convert.ToInt32(data_clients.Rows[x].Cells[0].Value) == Convert.ToInt32(data_clients.Rows[i].Cells[0].Value))
                        {
                            number_of_night_shift++;
                        }

                        else if (Convert.ToString(data_clients.Rows[x].Cells[2].Value) == "شيفت صباحي" && Convert.ToInt32(data_clients.Rows[x].Cells[0].Value) == Convert.ToInt32(data_clients.Rows[i].Cells[0].Value))
                        {
                            nummber_of_morining_shift++;


                        }
                    }


                }

                //اسناد القيم
                DataRow r = nursing.NewRow();
                r[0] = data_clients.Rows[i].Cells[0].Value;//كود الموظف
                r[1] = data_clients.Rows[i].Cells[1].Value;//اسم الموظف
                r[2] = nummber_of_morining_shift;//عدد الشفتات الصباحيه
                r[3] = number_of_night_shift;//عدد الشفتات المسائيه
                r[4] = (nummber_of_morining_shift * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][4]));//قيمه الشفت الصباحي
                r[5] = (number_of_night_shift * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][5]));//قيمه الشفت المسائي
                r[6] = Convert.ToDouble(r[5]) + Convert.ToDouble(r[4]);//اجمالي الاستحقاق
                double total_merit = Convert.ToDouble(r[6]);


                //ضربيه كسب العمل
                if (total_merit >= 1250)
                {

                    r[7] = Math.Round(((((total_merit * 12) - 15000) / 12) * 0.015));

                }
                else
                {
                    r[7] = 0.0;
                }



                r[8] = client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][2]; //التأمين تأمين جديد 140
                r[9] = (26 - nummber_of_morining_shift) * Convert.ToDouble(client.getConstants(Convert.ToInt32(data_clients.Rows[i].Cells[7].Value)).Rows[0][4]);//الغياب
                r[10] = 0;//السلف او الباقه

                r[11] = Convert.ToDouble(r[8]) + Convert.ToDouble(r[9]) + Convert.ToDouble(r[10]);//اجمالي الاستقطاع
                r[12] = 0.0;//اخري
                r[13] = "لا توجد تفاصيل";
                r[14] = Convert.ToDouble(r[6]) + Convert.ToDouble(r[11]);//صافي الراتب
                nursing.Rows.Add(r);

                total_merit = 0;


            }

            data_filltered.DataSource = nursing;


            //حذف المكرر


            for (int h = 0; h < 10; h++)
            {
                for (int y = 0; y < data_filltered.Rows.Count - 1; y++)
                {
                    if (Convert.ToInt32(data_filltered.Rows[y].Cells[0].Value) == Convert.ToInt32(data_filltered.Rows[y + 1].Cells[0].Value))
                    {
                        data_filltered.Rows.RemoveAt(y + 1);
                    }
                }
            }
            Program.copy_of_last_salary = Convert.ToDouble(data_filltered.CurrentRow.Cells[14].Value);

            // nursing.Rows.Clear();
            salary.Rows.Clear();
            staying.Rows.Clear();



            //حساب صافي الراتب

            for (int i = 0; i < data_filltered.Rows.Count - 1; i++)
            {
                nursing_salary = nursing_salary + Convert.ToDouble(data_filltered.Rows[i].Cells[14].Value);
            }
            txt_nursing.Text = nursing_salary.ToString();
            txt_total.Text = (Convert.ToDouble(txt_nursing.Text) + Convert.ToDouble(txt_staying.Text) + Convert.ToDouble(txt_salary.Text)).ToString();




            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < data_filltered.Rows.Count - 1; i++)
            {
                motions.add_over_shift(Convert.ToInt32(data_filltered.Rows[i].Cells[0].Value), data_filltered.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(data_filltered.Rows[i].Cells[2].Value),
               Convert.ToInt32(data_filltered.Rows[i].Cells[3].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[4].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[5].Value),
               Convert.ToDouble(data_filltered.Rows[i].Cells[6].Value),
               Convert.ToDouble(data_filltered.Rows[i].Cells[4].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[5].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[6].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[7].Value),
               Convert.ToDouble(data_filltered.Rows[i].Cells[8].Value), Convert.ToDouble(data_filltered.Rows[i].Cells[9].Value), data_filltered.Rows[i].Cells[10].Value.ToString(), Convert.ToDouble(data_filltered.Rows[i].Cells[11].Value));

                motions.add_over_all_summary(Convert.ToInt32(data_filltered.Rows[i].Cells[0].Value), (26 - Convert.ToInt32(data_filltered.Rows[i].Cells[0].Value)), Convert.ToInt32(txt_month.Text), Convert.ToInt32(txt_year.Text), Convert.ToDouble(data_filltered.Rows[i].Cells[14].Value));

            }

            MessageBox.Show("تم حفظ المرتبات", "تم الحفظ", MessageBoxButtons.OK);

        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void data_filltered_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_filltered_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //لو كان مقيم

            if (radio_doctors.Checked)
            {
                if (data_filltered.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
                {
                    double value_of_days = Convert.ToDouble(data_filltered.CurrentRow.Cells[3].Value);
                    MessageBox.Show("عدد ساعات الاقامة خلال الشهر" + "      " + value_of_days * 24 + "      " + "ساعه", "تافصيل ", MessageBoxButtons.OK);
                }
            }



            //لو كان تمريض



            if (radio_nursing.Checked)
            {

                int number_of_dely_hours = Convert.ToInt32(motions.get_dely_hours(Convert.ToInt32(data_filltered.CurrentRow.Cells[0].Value), Convert.ToInt32(txt_month.Text), Convert.ToInt32(txt_year.Text)).Rows[0][0]);
                int number_of_absence_day = 26 - Convert.ToInt32(data_filltered.CurrentRow.Cells[2].Value);
                if (data_filltered.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
                {

                    if (data_filltered.CurrentCell != null && data_filltered.CurrentCell.Value != null)
                        MessageBox.Show("عدد ساعات التأخير خلال الشهر" + "      " + number_of_dely_hours + "  " + "ساعة" + "      " + "عدد ايام الغياب خلال الشهر" + "      " + number_of_absence_day + "    " + "يوم", "تافصيل ", MessageBoxButtons.OK);
                }
            }
            //لو كان راتب
            else if (radio_salary.Checked)
            {

                double value_of_hour = Convert.ToDouble(client.get_sallary_with_client_id(Convert.ToInt32(data_filltered.CurrentRow.Cells[0].Value)).Rows[0][0]) / 720.0;


                double dely_hours = Convert.ToDouble(motions.get_dely_hours(Convert.ToInt32(data_filltered.CurrentRow.Cells[0].Value), Convert.ToInt32(txt_month.Text), Convert.ToInt32(txt_year.Text)).Rows[0][0]);

                double salary_for_day = (Convert.ToDouble(client.get_sallary_with_client_id(Convert.ToInt32(data_filltered.CurrentRow.Cells[0].Value)).Rows[0][0]) / 26.0);

                int number_of_dely_hours = Convert.ToInt32(motions.get_dely_hours(Convert.ToInt32(data_filltered.CurrentRow.Cells[0].Value), Convert.ToInt32(txt_month.Text), Convert.ToInt32(txt_year.Text)).Rows[0][0]);
                double number_of_absence_day = (Convert.ToDouble(data_filltered.CurrentRow.Cells[6].Value) - value_of_hour * dely_hours) / salary_for_day;

                if (data_filltered.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
                {

                    if (data_filltered.CurrentCell != null && data_filltered.CurrentCell.Value != null)
                        MessageBox.Show("عدد ساعات التأخير خلال الشهر" + "      " + number_of_dely_hours + "  " + "ساعة" + "      " + "عدد ايام الغياب خلال الشهر" + "      " + number_of_absence_day + "    " + "يوم", "تافصيل ", MessageBoxButtons.OK);
                }


            }


        }

    }
}
