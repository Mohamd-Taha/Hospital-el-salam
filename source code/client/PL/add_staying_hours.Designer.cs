namespace client.PL
{
    partial class add_staying_hours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_staying_hours));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_dr_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_number_of_staying_hours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Image = global::client.Properties.Resources.icons8_exit_64;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(12, 107);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(151, 61);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "الغاء";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_ok.Image")));
            this.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ok.Location = new System.Drawing.Point(238, 107);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(151, 61);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "تأكيد";
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_dr_name
            // 
            this.txt_dr_name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dr_name.Location = new System.Drawing.Point(12, 12);
            this.txt_dr_name.Name = "txt_dr_name";
            this.txt_dr_name.ReadOnly = true;
            this.txt_dr_name.Size = new System.Drawing.Size(206, 32);
            this.txt_dr_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم الدكتور";
            // 
            // txt_number_of_staying_hours
            // 
            this.txt_number_of_staying_hours.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number_of_staying_hours.Location = new System.Drawing.Point(12, 54);
            this.txt_number_of_staying_hours.Name = "txt_number_of_staying_hours";
            this.txt_number_of_staying_hours.Size = new System.Drawing.Size(206, 39);
            this.txt_number_of_staying_hours.TabIndex = 0;
            this.txt_number_of_staying_hours.TextChanged += new System.EventHandler(this.txt_number_of_staying_hours_TextChanged);
            this.txt_number_of_staying_hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_of_staying_hours_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "عدد ساعات الاقامه";
            // 
            // add_staying_hours
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(401, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_number_of_staying_hours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dr_name);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_exit);
            this.Name = "add_staying_hours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه ساعات العمل";
            this.Load += new System.EventHandler(this.add_staying_hours_Load);
            this.Resize += new System.EventHandler(this.add_staying_hours_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_dr_name;
        public System.Windows.Forms.TextBox txt_number_of_staying_hours;
    }
}