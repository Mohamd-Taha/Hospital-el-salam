namespace client.PL
{
    partial class frm_type_of_add_employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_type_of_add_employee));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add_new_employee = new System.Windows.Forms.Button();
            this.btn_add_exel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add_exel);
            this.groupBox1.Controls.Add(this.btn_add_new_employee);
            this.groupBox1.Location = new System.Drawing.Point(71, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_add_new_employee
            // 
            this.btn_add_new_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new_employee.FlatAppearance.BorderSize = 0;
            this.btn_add_new_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_new_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_add_new_employee.ForeColor = System.Drawing.Color.White;
            this.btn_add_new_employee.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_new_employee.Image")));
            this.btn_add_new_employee.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add_new_employee.Location = new System.Drawing.Point(24, 37);
            this.btn_add_new_employee.Name = "btn_add_new_employee";
            this.btn_add_new_employee.Size = new System.Drawing.Size(369, 141);
            this.btn_add_new_employee.TabIndex = 4;
            this.btn_add_new_employee.Text = "اضافة موظف واحد يدويا";
            this.btn_add_new_employee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add_new_employee.UseVisualStyleBackColor = true;
            this.btn_add_new_employee.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_add_exel
            // 
            this.btn_add_exel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_exel.FlatAppearance.BorderSize = 0;
            this.btn_add_exel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_exel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_add_exel.ForeColor = System.Drawing.Color.White;
            this.btn_add_exel.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_exel.Image")));
            this.btn_add_exel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add_exel.Location = new System.Drawing.Point(24, 184);
            this.btn_add_exel.Name = "btn_add_exel";
            this.btn_add_exel.Size = new System.Drawing.Size(369, 144);
            this.btn_add_exel.TabIndex = 3;
            this.btn_add_exel.Text = "اضافة البيانات الاساسية لجميع الموظفين عن طريق ملف اكسيل";
            this.btn_add_exel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add_exel.UseVisualStyleBackColor = true;
            this.btn_add_exel.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_type_of_add_employee
            // 
            this.AcceptButton = this.btn_add_exel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 469);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_type_of_add_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طريقة اضافة الموظفين الجدد";
            this.Load += new System.EventHandler(this.frm_type_of_add_employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add_new_employee;
        private System.Windows.Forms.Button btn_add_exel;
    }
}