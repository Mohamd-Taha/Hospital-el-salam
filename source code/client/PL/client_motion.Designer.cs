namespace client.PL
{
    partial class client_motion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.data_all_clients = new System.Windows.Forms.DataGridView();
            this.data_selected_client = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_cat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_number_of_selected = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_doctors = new System.Windows.Forms.RadioButton();
            this.radio_nursing = new System.Windows.Forms.RadioButton();
            this.radio_salary = new System.Windows.Forms.RadioButton();
            this.radio_all = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_dely_minute = new System.Windows.Forms.TextBox();
            this.txt_hours = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_all_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_selected_client)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(38, 701);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "الغاء";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Location = new System.Drawing.Point(434, 701);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "حفظ الحركه";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // data_all_clients
            // 
            this.data_all_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_all_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_all_clients.Location = new System.Drawing.Point(6, 56);
            this.data_all_clients.Name = "data_all_clients";
            this.data_all_clients.Size = new System.Drawing.Size(571, 209);
            this.data_all_clients.TabIndex = 3;
            this.data_all_clients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_all_clients_CellContentClick);
            this.data_all_clients.DoubleClick += new System.EventHandler(this.data_all_clients_DoubleClick);
            // 
            // data_selected_client
            // 
            this.data_selected_client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_selected_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_selected_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_selected_client.Location = new System.Drawing.Point(3, 23);
            this.data_selected_client.Name = "data_selected_client";
            this.data_selected_client.Size = new System.Drawing.Size(583, 322);
            this.data_selected_client.TabIndex = 4;
            this.data_selected_client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_selected_client_CellContentClick);
            this.data_selected_client.DoubleClick += new System.EventHandler(this.data_selected_client_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_selected_client);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(9, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(589, 348);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.data_all_clients);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(15, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(583, 276);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.Location = new System.Drawing.Point(59, 18);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(302, 32);
            this.txt_search.TabIndex = 8;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "دقائق";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // combo_cat
            // 
            this.combo_cat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_cat.FormattingEnabled = true;
            this.combo_cat.Location = new System.Drawing.Point(92, 22);
            this.combo_cat.Name = "combo_cat";
            this.combo_cat.Size = new System.Drawing.Size(353, 32);
            this.combo_cat.TabIndex = 5;
            this.combo_cat.SelectedIndexChanged += new System.EventHandler(this.combo_cat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(464, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "نوع الحركه";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lab_number_of_selected
            // 
            this.lab_number_of_selected.AutoSize = true;
            this.lab_number_of_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lab_number_of_selected.Location = new System.Drawing.Point(36, 126);
            this.lab_number_of_selected.Name = "lab_number_of_selected";
            this.lab_number_of_selected.Size = new System.Drawing.Size(85, 25);
            this.lab_number_of_selected.TabIndex = 10;
            this.lab_number_of_selected.Text = "غير محدد";
            this.lab_number_of_selected.Click += new System.EventHandler(this.lab_number_of_selected_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lab_number_of_selected);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(613, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(268, 301);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(137, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "عدد المختارين";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // radio_doctors
            // 
            this.radio_doctors.AutoSize = true;
            this.radio_doctors.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_doctors.Location = new System.Drawing.Point(109, 143);
            this.radio_doctors.Name = "radio_doctors";
            this.radio_doctors.Size = new System.Drawing.Size(156, 27);
            this.radio_doctors.TabIndex = 13;
            this.radio_doctors.TabStop = true;
            this.radio_doctors.Text = "الاطباء المقيمين";
            this.radio_doctors.UseVisualStyleBackColor = true;
            this.radio_doctors.CheckedChanged += new System.EventHandler(this.radio_doctors_CheckedChanged);
            // 
            // radio_nursing
            // 
            this.radio_nursing.AutoSize = true;
            this.radio_nursing.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_nursing.Location = new System.Drawing.Point(173, 101);
            this.radio_nursing.Name = "radio_nursing";
            this.radio_nursing.Size = new System.Drawing.Size(92, 27);
            this.radio_nursing.TabIndex = 14;
            this.radio_nursing.TabStop = true;
            this.radio_nursing.Text = "التمريض";
            this.radio_nursing.UseVisualStyleBackColor = true;
            this.radio_nursing.CheckedChanged += new System.EventHandler(this.radio_nursing_CheckedChanged);
            // 
            // radio_salary
            // 
            this.radio_salary.AutoSize = true;
            this.radio_salary.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_salary.Location = new System.Drawing.Point(191, 42);
            this.radio_salary.Name = "radio_salary";
            this.radio_salary.Size = new System.Drawing.Size(74, 27);
            this.radio_salary.TabIndex = 15;
            this.radio_salary.TabStop = true;
            this.radio_salary.Text = "الراتب";
            this.radio_salary.UseVisualStyleBackColor = true;
            this.radio_salary.CheckedChanged += new System.EventHandler(this.radio_salary_CheckedChanged);
            // 
            // radio_all
            // 
            this.radio_all.AutoSize = true;
            this.radio_all.Location = new System.Drawing.Point(77, 538);
            this.radio_all.Name = "radio_all";
            this.radio_all.Size = new System.Drawing.Size(48, 24);
            this.radio_all.TabIndex = 16;
            this.radio_all.TabStop = true;
            this.radio_all.Text = "الكل";
            this.radio_all.UseVisualStyleBackColor = true;
            this.radio_all.CheckedChanged += new System.EventHandler(this.radio_all_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radio_all);
            this.groupBox4.Controls.Add(this.radio_doctors);
            this.groupBox4.Controls.Add(this.radio_salary);
            this.groupBox4.Controls.Add(this.radio_nursing);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(610, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(282, 199);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تحديد نوع";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txt_day
            // 
            this.txt_day.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_day.ForeColor = System.Drawing.Color.Black;
            this.txt_day.Location = new System.Drawing.Point(161, 86);
            this.txt_day.Name = "txt_day";
            this.txt_day.ReadOnly = true;
            this.txt_day.Size = new System.Drawing.Size(67, 32);
            this.txt_day.TabIndex = 21;
            this.txt_day.TextChanged += new System.EventHandler(this.txt_day_TextChanged);
            // 
            // txt_year
            // 
            this.txt_year.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_year.ForeColor = System.Drawing.Color.Black;
            this.txt_year.Location = new System.Drawing.Point(6, 86);
            this.txt_year.Name = "txt_year";
            this.txt_year.ReadOnly = true;
            this.txt_year.Size = new System.Drawing.Size(66, 32);
            this.txt_year.TabIndex = 19;
            this.txt_year.TextChanged += new System.EventHandler(this.txt_year_TextChanged);
            // 
            // txt_month
            // 
            this.txt_month.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_month.ForeColor = System.Drawing.Color.Black;
            this.txt_month.Location = new System.Drawing.Point(88, 86);
            this.txt_month.Name = "txt_month";
            this.txt_month.ReadOnly = true;
            this.txt_month.Size = new System.Drawing.Size(67, 32);
            this.txt_month.TabIndex = 20;
            this.txt_month.TextChanged += new System.EventHandler(this.txt_month_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 30);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(5, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 0;
            this.button1.Text = "اضافه ساعات العمل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(185, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "يوم";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(104, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "شهر";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "سنه";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txt_month);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txt_day);
            this.groupBox5.Controls.Add(this.txt_year);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(613, 37);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(279, 124);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "التاريخ";
            // 
            // txt_dely_minute
            // 
            this.txt_dely_minute.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dely_minute.ForeColor = System.Drawing.Color.Black;
            this.txt_dely_minute.Location = new System.Drawing.Point(129, 32);
            this.txt_dely_minute.Name = "txt_dely_minute";
            this.txt_dely_minute.Size = new System.Drawing.Size(128, 32);
            this.txt_dely_minute.TabIndex = 27;
            // 
            // txt_hours
            // 
            this.txt_hours.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hours.ForeColor = System.Drawing.Color.Black;
            this.txt_hours.Location = new System.Drawing.Point(36, 32);
            this.txt_hours.Name = "txt_hours";
            this.txt_hours.Size = new System.Drawing.Size(87, 32);
            this.txt_hours.TabIndex = 28;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txt_hours);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.txt_dely_minute);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(876, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(10, 10);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "التأخير";
            this.groupBox6.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(62, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "ساعات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(374, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "بحث عن";
            // 
            // client_motion
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 759);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_cat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "client_motion";
            this.Text = "client_motion";
            this.Load += new System.EventHandler(this.client_motion_Load);
            this.Resize += new System.EventHandler(this.client_motion_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.data_all_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_selected_client)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView data_all_clients;
        public System.Windows.Forms.DataGridView data_selected_client;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox combo_cat;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_search;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lab_number_of_selected;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton radio_doctors;
        public System.Windows.Forms.RadioButton radio_nursing;
        public System.Windows.Forms.RadioButton radio_salary;
        public System.Windows.Forms.RadioButton radio_all;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox txt_year;
        public System.Windows.Forms.TextBox txt_month;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txt_day;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox txt_dely_minute;
        public System.Windows.Forms.TextBox txt_hours;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;

    }
}