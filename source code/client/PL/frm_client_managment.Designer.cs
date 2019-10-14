namespace client.PL
{
    partial class frm_client_managment
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
            this.data_clients = new System.Windows.Forms.DataGridView();
            this.data_filltered = new System.Windows.Forms.DataGridView();
            this.radio_doctors = new System.Windows.Forms.RadioButton();
            this.radio_salary = new System.Windows.Forms.RadioButton();
            this.radio_nursing = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_month_visiable = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nursing = new System.Windows.Forms.TextBox();
            this.txt_staying = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_shearch = new System.Windows.Forms.TextBox();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.label_type = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_filltered)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_clients
            // 
            this.data_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_clients.Location = new System.Drawing.Point(11, 279);
            this.data_clients.Name = "data_clients";
            this.data_clients.Size = new System.Drawing.Size(10, 10);
            this.data_clients.TabIndex = 0;
            this.data_clients.Visible = false;
            // 
            // data_filltered
            // 
            this.data_filltered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_filltered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_filltered.Location = new System.Drawing.Point(15, 295);
            this.data_filltered.Name = "data_filltered";
            this.data_filltered.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.data_filltered.Size = new System.Drawing.Size(1060, 266);
            this.data_filltered.TabIndex = 21;
            this.data_filltered.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_filltered_CellClick);
            this.data_filltered.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_filltered_CellContentDoubleClick);
            this.data_filltered.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_filltered_CellValueChanged);
            // 
            // radio_doctors
            // 
            this.radio_doctors.AutoSize = true;
            this.radio_doctors.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_doctors.ForeColor = System.Drawing.Color.Green;
            this.radio_doctors.Location = new System.Drawing.Point(773, 32);
            this.radio_doctors.Name = "radio_doctors";
            this.radio_doctors.Size = new System.Drawing.Size(184, 29);
            this.radio_doctors.TabIndex = 17;
            this.radio_doctors.TabStop = true;
            this.radio_doctors.Text = "الاطباء المقيمين";
            this.radio_doctors.UseVisualStyleBackColor = true;
            this.radio_doctors.CheckedChanged += new System.EventHandler(this.radio_doctors_CheckedChanged);
            // 
            // radio_salary
            // 
            this.radio_salary.AutoSize = true;
            this.radio_salary.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_salary.ForeColor = System.Drawing.Color.Green;
            this.radio_salary.Location = new System.Drawing.Point(39, 32);
            this.radio_salary.Name = "radio_salary";
            this.radio_salary.Size = new System.Drawing.Size(89, 29);
            this.radio_salary.TabIndex = 19;
            this.radio_salary.TabStop = true;
            this.radio_salary.Text = "الراتب";
            this.radio_salary.UseVisualStyleBackColor = true;
            this.radio_salary.CheckedChanged += new System.EventHandler(this.radio_salary_CheckedChanged);
            // 
            // radio_nursing
            // 
            this.radio_nursing.AutoSize = true;
            this.radio_nursing.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_nursing.ForeColor = System.Drawing.Color.Green;
            this.radio_nursing.Location = new System.Drawing.Point(425, 32);
            this.radio_nursing.Name = "radio_nursing";
            this.radio_nursing.Size = new System.Drawing.Size(114, 29);
            this.radio_nursing.TabIndex = 18;
            this.radio_nursing.TabStop = true;
            this.radio_nursing.Text = "التمريض";
            this.radio_nursing.UseVisualStyleBackColor = true;
            this.radio_nursing.CheckedChanged += new System.EventHandler(this.radio_nursing_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_year);
            this.groupBox1.Controls.Add(this.txt_month_visiable);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(848, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(238, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مرتبات شهر/سنة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "شهر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "سنة";
            // 
            // txt_year
            // 
            this.txt_year.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_year.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_year.Location = new System.Drawing.Point(6, 114);
            this.txt_year.Name = "txt_year";
            this.txt_year.ReadOnly = true;
            this.txt_year.Size = new System.Drawing.Size(140, 27);
            this.txt_year.TabIndex = 1;
            // 
            // txt_month_visiable
            // 
            this.txt_month_visiable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_month_visiable.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_month_visiable.Location = new System.Drawing.Point(6, 38);
            this.txt_month_visiable.Name = "txt_month_visiable";
            this.txt_month_visiable.ReadOnly = true;
            this.txt_month_visiable.Size = new System.Drawing.Size(140, 27);
            this.txt_month_visiable.TabIndex = 0;
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.Blue;
            this.txt_user.Location = new System.Drawing.Point(376, 74);
            this.txt_user.Name = "txt_user";
            this.txt_user.ReadOnly = true;
            this.txt_user.Size = new System.Drawing.Size(303, 27);
            this.txt_user.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(692, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "مرحبا بك";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_nursing);
            this.groupBox2.Controls.Add(this.radio_salary);
            this.groupBox2.Controls.Add(this.radio_doctors);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(11, 567);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1064, 77);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اختيار نوع";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txt_total);
            this.groupBox4.Controls.Add(this.btn_save);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txt_salary);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_nursing);
            this.groupBox4.Controls.Add(this.txt_staying);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(9, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(349, 261);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "اجمالي المرتبات";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "الاجمالي";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.Red;
            this.txt_total.Location = new System.Drawing.Point(6, 156);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(143, 33);
            this.txt_total.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(6, 195);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(328, 57);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "حفظ المرتبات";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "الراتب";
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_salary.Location = new System.Drawing.Point(6, 104);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.ReadOnly = true;
            this.txt_salary.Size = new System.Drawing.Size(140, 27);
            this.txt_salary.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "الاطباء المقيمين";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "التمريض";
            // 
            // txt_nursing
            // 
            this.txt_nursing.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nursing.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_nursing.Location = new System.Drawing.Point(6, 71);
            this.txt_nursing.Name = "txt_nursing";
            this.txt_nursing.ReadOnly = true;
            this.txt_nursing.Size = new System.Drawing.Size(140, 27);
            this.txt_nursing.TabIndex = 1;
            // 
            // txt_staying
            // 
            this.txt_staying.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staying.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_staying.Location = new System.Drawing.Point(6, 38);
            this.txt_staying.Name = "txt_staying";
            this.txt_staying.ReadOnly = true;
            this.txt_staying.Size = new System.Drawing.Size(140, 27);
            this.txt_staying.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(506, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 33);
            this.label8.TabIndex = 23;
            this.label8.Text = "مراجعة المرتبات";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(745, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "بحث عن";
            // 
            // txt_shearch
            // 
            this.txt_shearch.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_shearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_shearch.Location = new System.Drawing.Point(376, 223);
            this.txt_shearch.Name = "txt_shearch";
            this.txt_shearch.Size = new System.Drawing.Size(363, 33);
            this.txt_shearch.TabIndex = 25;
            this.txt_shearch.TextChanged += new System.EventHandler(this.txt_shearch_TextChanged);
            // 
            // txt_month
            // 
            this.txt_month.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_month.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_month.Location = new System.Drawing.Point(809, 12);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(33, 27);
            this.txt_month.TabIndex = 5;
            this.txt_month.Visible = false;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.ForeColor = System.Drawing.Color.Maroon;
            this.label_type.Location = new System.Drawing.Point(822, 264);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(190, 25);
            this.label_type.TabIndex = 28;
            this.label_type.Text = "type_of_motions";
            // 
            // frm_client_managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 656);
            this.Controls.Add(this.data_clients);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.data_filltered);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_shearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_user);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_client_managment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_client_managment";
            this.Load += new System.EventHandler(this.frm_client_managment_Load);
            this.Resize += new System.EventHandler(this.frm_client_managment_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.data_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_filltered)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton radio_doctors;
        public System.Windows.Forms.RadioButton radio_salary;
        public System.Windows.Forms.RadioButton radio_nursing;
        public System.Windows.Forms.DataGridView data_clients;
        public System.Windows.Forms.DataGridView data_filltered;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_nursing;
        public System.Windows.Forms.TextBox txt_staying;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_shearch;
        public System.Windows.Forms.TextBox txt_year;
        public System.Windows.Forms.TextBox txt_month_visiable;
        public System.Windows.Forms.TextBox txt_user;
        public System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.Label label_type;
    }
}