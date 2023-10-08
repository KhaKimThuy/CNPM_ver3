namespace CNPM_ver3
{
    partial class ManageRequestForm
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
            this.dataGridView_req = new System.Windows.Forms.DataGridView();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_subject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_content = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_sender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_accept = new System.Windows.Forms.Button();
            this.button_reject = new System.Windows.Forms.Button();
            this.dateTimePicker_sentDay = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_files = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_req)).BeginInit();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_files)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_req
            // 
            this.dataGridView_req.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_req.Location = new System.Drawing.Point(12, 96);
            this.dataGridView_req.Name = "dataGridView_req";
            this.dataGridView_req.RowHeadersWidth = 62;
            this.dataGridView_req.RowTemplate.Height = 28;
            this.dataGridView_req.Size = new System.Drawing.Size(1566, 414);
            this.dataGridView_req.TabIndex = 0;
            this.dataGridView_req.Click += new System.EventHandler(this.dataGridView_req_Click);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.Firebrick;
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1590, 88);
            this.panel_header.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(549, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Management";
            // 
            // textBox_subject
            // 
            this.textBox_subject.Location = new System.Drawing.Point(174, 628);
            this.textBox_subject.Name = "textBox_subject";
            this.textBox_subject.Size = new System.Drawing.Size(244, 26);
            this.textBox_subject.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 682);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Content";
            // 
            // textBox_content
            // 
            this.textBox_content.Location = new System.Drawing.Point(174, 677);
            this.textBox_content.Multiline = true;
            this.textBox_content.Name = "textBox_content";
            this.textBox_content.Size = new System.Drawing.Size(727, 158);
            this.textBox_content.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(933, 677);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Attach file";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sent by";
            // 
            // textBox_sender
            // 
            this.textBox_sender.Location = new System.Drawing.Point(174, 576);
            this.textBox_sender.Name = "textBox_sender";
            this.textBox_sender.Size = new System.Drawing.Size(244, 26);
            this.textBox_sender.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(943, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Send Day ";
            // 
            // button_accept
            // 
            this.button_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_accept.Location = new System.Drawing.Point(1225, 885);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(135, 46);
            this.button_accept.TabIndex = 12;
            this.button_accept.Text = "Accept";
            this.button_accept.UseVisualStyleBackColor = false;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // button_reject
            // 
            this.button_reject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_reject.Location = new System.Drawing.Point(1384, 885);
            this.button_reject.Name = "button_reject";
            this.button_reject.Size = new System.Drawing.Size(135, 46);
            this.button_reject.TabIndex = 13;
            this.button_reject.Text = "Reject";
            this.button_reject.UseVisualStyleBackColor = false;
            this.button_reject.Click += new System.EventHandler(this.button_reject_Click);
            // 
            // dateTimePicker_sentDay
            // 
            this.dateTimePicker_sentDay.Location = new System.Drawing.Point(1032, 582);
            this.dateTimePicker_sentDay.Name = "dateTimePicker_sentDay";
            this.dateTimePicker_sentDay.Size = new System.Drawing.Size(506, 26);
            this.dateTimePicker_sentDay.TabIndex = 14;
            // 
            // dataGridView_files
            // 
            this.dataGridView_files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_files.Location = new System.Drawing.Point(1032, 677);
            this.dataGridView_files.Name = "dataGridView_files";
            this.dataGridView_files.RowHeadersWidth = 62;
            this.dataGridView_files.RowTemplate.Height = 28;
            this.dataGridView_files.Size = new System.Drawing.Size(506, 150);
            this.dataGridView_files.TabIndex = 15;
            this.dataGridView_files.Click += new System.EventHandler(this.dataGridView_files_Click);
            // 
            // ManageRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 994);
            this.Controls.Add(this.dataGridView_files);
            this.Controls.Add(this.dateTimePicker_sentDay);
            this.Controls.Add(this.button_reject);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_sender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_content);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_subject);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.dataGridView_req);
            this.Name = "ManageRequestForm";
            this.Text = " n, ygjv n";
            this.Load += new System.EventHandler(this.ManageRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_req)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_files)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_req;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_content;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_sender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Button button_reject;
        private System.Windows.Forms.DateTimePicker dateTimePicker_sentDay;
        private System.Windows.Forms.DataGridView dataGridView_files;
    }
}