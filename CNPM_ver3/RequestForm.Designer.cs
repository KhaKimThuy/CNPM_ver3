namespace CNPM_ver3
{
    partial class RequestForm
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
            this.bt_Heading = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tReq = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_Request = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Heading);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 114);
            this.panel1.TabIndex = 0;
            // 
            // bt_Heading
            // 
            this.bt_Heading.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Heading.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Heading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Heading.Location = new System.Drawing.Point(0, 0);
            this.bt_Heading.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Heading.Name = "bt_Heading";
            this.bt_Heading.Size = new System.Drawing.Size(957, 114);
            this.bt_Heading.TabIndex = 0;
            this.bt_Heading.Text = "ADD REQUEST";
            this.bt_Heading.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tReq);
            this.panel2.Location = new System.Drawing.Point(15, 136);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 406);
            this.panel2.TabIndex = 1;
            // 
            // tReq
            // 
            this.tReq.Location = new System.Drawing.Point(4, 5);
            this.tReq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tReq.Name = "tReq";
            this.tReq.Size = new System.Drawing.Size(948, 396);
            this.tReq.TabIndex = 0;
            this.tReq.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_del);
            this.panel3.Controls.Add(this.bt_Request);
            this.panel3.Location = new System.Drawing.Point(14, 550);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 110);
            this.panel3.TabIndex = 2;
            // 
            // bt_del
            // 
            this.bt_del.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_del.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_del.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_del.Location = new System.Drawing.Point(3, 4);
            this.bt_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(495, 106);
            this.bt_del.TabIndex = 0;
            this.bt_del.Text = "DELETE";
            this.bt_del.UseVisualStyleBackColor = false;
            this.bt_del.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_Request
            // 
            this.bt_Request.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_Request.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Request.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Request.Location = new System.Drawing.Point(495, 4);
            this.bt_Request.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Request.Name = "bt_Request";
            this.bt_Request.Size = new System.Drawing.Size(459, 106);
            this.bt_Request.TabIndex = 1;
            this.bt_Request.Text = "REQUEST";
            this.bt_Request.UseVisualStyleBackColor = false;
            this.bt_Request.Click += new System.EventHandler(this.bt_Request_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 686);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox tReq;
        private System.Windows.Forms.Button bt_Request;
        private System.Windows.Forms.Button bt_Heading;
    }
}