namespace CNPM_ver3
{
    partial class ForgetPassForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bt_next_forget0 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tb_email_form = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 81);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(740, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "FORGOT PASSWORD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bt_next_forget0);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(129, 99);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 248);
            this.panel5.TabIndex = 2;
            // 
            // bt_next_forget0
            // 
            this.bt_next_forget0.BackColor = System.Drawing.Color.IndianRed;
            this.bt_next_forget0.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_next_forget0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_next_forget0.Location = new System.Drawing.Point(3, 164);
            this.bt_next_forget0.Name = "bt_next_forget0";
            this.bt_next_forget0.Size = new System.Drawing.Size(494, 78);
            this.bt_next_forget0.TabIndex = 3;
            this.bt_next_forget0.Text = "NEXT";
            this.bt_next_forget0.UseVisualStyleBackColor = false;
            this.bt_next_forget0.Click += new System.EventHandler(this.bt_next_forget0_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tb_email_form);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(6, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(491, 74);
            this.panel6.TabIndex = 1;
            // 
            // tb_email_form
            // 
            this.tb_email_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email_form.Location = new System.Drawing.Point(210, 42);
            this.tb_email_form.Name = "tb_email_form";
            this.tb_email_form.Size = new System.Drawing.Size(278, 27);
            this.tb_email_form.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter your email";
            // 
            // ForgetPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 356);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "ForgetPassForm";
            this.Text = "ForgetPassForm";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bt_next_forget0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tb_email_form;
        private System.Windows.Forms.Label label5;
    }
}