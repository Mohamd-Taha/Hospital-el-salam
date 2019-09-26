namespace client.PL
{
    partial class add_dely_minute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_dely_minute));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_number_of_dely_minute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dr_name = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(238, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "عدد دقائق التأخير";
            // 
            // txt_number_of_dely_minute
            // 
            this.txt_number_of_dely_minute.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number_of_dely_minute.Location = new System.Drawing.Point(12, 50);
            this.txt_number_of_dely_minute.Name = "txt_number_of_dely_minute";
            this.txt_number_of_dely_minute.Size = new System.Drawing.Size(206, 39);
            this.txt_number_of_dely_minute.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "اسم الدكتور";
            // 
            // txt_dr_name
            // 
            this.txt_dr_name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dr_name.Location = new System.Drawing.Point(12, 12);
            this.txt_dr_name.Name = "txt_dr_name";
            this.txt_dr_name.ReadOnly = true;
            this.txt_dr_name.Size = new System.Drawing.Size(206, 32);
            this.txt_dr_name.TabIndex = 8;
            // 
            // btn_ok
            // 
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_ok.Image")));
            this.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ok.Location = new System.Drawing.Point(238, 95);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(151, 61);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "تأكيد";
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
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
            this.btn_exit.Location = new System.Drawing.Point(12, 95);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(151, 61);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "الغاء";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // add_dely_minute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 157);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_number_of_dely_minute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dr_name);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_exit);
            this.Name = "add_dely_minute";
            this.Text = "add_dely_minute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_number_of_dely_minute;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_dr_name;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_exit;
    }
}