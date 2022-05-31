namespace Bills
{
    partial class Report
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
            this.sales_report_lbl = new System.Windows.Forms.Label();
            this.period_end = new System.Windows.Forms.Label();
            this.period_start = new System.Windows.Forms.Label();
            this.report_TimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.report_TimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_report_cancel = new System.Windows.Forms.Button();
            this.btn_report_save = new System.Windows.Forms.Button();
            this.dvg_report = new System.Windows.Forms.DataGridView();
            this.lable_Status = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sales_report_lbl
            // 
            this.sales_report_lbl.AutoSize = true;
            this.sales_report_lbl.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_report_lbl.Location = new System.Drawing.Point(12, 29);
            this.sales_report_lbl.Name = "sales_report_lbl";
            this.sales_report_lbl.Size = new System.Drawing.Size(216, 38);
            this.sales_report_lbl.TabIndex = 2;
            this.sales_report_lbl.Text = "Sales Report";
            // 
            // period_end
            // 
            this.period_end.AutoSize = true;
            this.period_end.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_end.Location = new System.Drawing.Point(95, 116);
            this.period_end.Name = "period_end";
            this.period_end.Size = new System.Drawing.Size(158, 23);
            this.period_end.TabIndex = 5;
            this.period_end.Text = "Choose A Period :";
            // 
            // period_start
            // 
            this.period_start.AutoSize = true;
            this.period_start.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_start.Location = new System.Drawing.Point(95, 81);
            this.period_start.Name = "period_start";
            this.period_start.Size = new System.Drawing.Size(158, 23);
            this.period_start.TabIndex = 4;
            this.period_start.Text = "Choose A Period :";
            // 
            // report_TimePicker1
            // 
            this.report_TimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_TimePicker1.Location = new System.Drawing.Point(270, 81);
            this.report_TimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.report_TimePicker1.Name = "report_TimePicker1";
            this.report_TimePicker1.Size = new System.Drawing.Size(196, 27);
            this.report_TimePicker1.TabIndex = 7;
            this.report_TimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.report_TimePicker1_MouseDown);
            // 
            // report_TimePicker2
            // 
            this.report_TimePicker2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_TimePicker2.Location = new System.Drawing.Point(270, 112);
            this.report_TimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.report_TimePicker2.Name = "report_TimePicker2";
            this.report_TimePicker2.Size = new System.Drawing.Size(196, 27);
            this.report_TimePicker2.TabIndex = 8;
            this.report_TimePicker2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.report_TimePicker2_MouseDown);
            // 
            // btn_report_cancel
            // 
            this.btn_report_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_report_cancel.Image = global::Bills.Properties.Resources.cancle;
            this.btn_report_cancel.Location = new System.Drawing.Point(169, 157);
            this.btn_report_cancel.Name = "btn_report_cancel";
            this.btn_report_cancel.Size = new System.Drawing.Size(84, 35);
            this.btn_report_cancel.TabIndex = 10;
            this.btn_report_cancel.UseVisualStyleBackColor = true;
            this.btn_report_cancel.Click += new System.EventHandler(this.btn_report_cancel_Click);
            // 
            // btn_report_save
            // 
            this.btn_report_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_report_save.Image = global::Bills.Properties.Resources.save;
            this.btn_report_save.Location = new System.Drawing.Point(302, 157);
            this.btn_report_save.Name = "btn_report_save";
            this.btn_report_save.Size = new System.Drawing.Size(75, 35);
            this.btn_report_save.TabIndex = 9;
            this.btn_report_save.UseVisualStyleBackColor = true;
            this.btn_report_save.Click += new System.EventHandler(this.btn_report_save_Click);
            // 
            // dvg_report
            // 
            this.dvg_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_report.Location = new System.Drawing.Point(11, 241);
            this.dvg_report.Margin = new System.Windows.Forms.Padding(2);
            this.dvg_report.Name = "dvg_report";
            this.dvg_report.RowHeadersWidth = 51;
            this.dvg_report.RowTemplate.Height = 24;
            this.dvg_report.Size = new System.Drawing.Size(563, 152);
            this.dvg_report.TabIndex = 11;
            // 
            // lable_Status
            // 
            this.lable_Status.AutoSize = true;
            this.lable_Status.Location = new System.Drawing.Point(212, 215);
            this.lable_Status.Name = "lable_Status";
            this.lable_Status.Size = new System.Drawing.Size(0, 13);
            this.lable_Status.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(0, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 38);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(585, 404);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lable_Status);
            this.Controls.Add(this.dvg_report);
            this.Controls.Add(this.btn_report_cancel);
            this.Controls.Add(this.btn_report_save);
            this.Controls.Add(this.report_TimePicker2);
            this.Controls.Add(this.report_TimePicker1);
            this.Controls.Add(this.period_end);
            this.Controls.Add(this.period_start);
            this.Controls.Add(this.sales_report_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sales_report_lbl;
        private System.Windows.Forms.Label period_end;
        private System.Windows.Forms.Label period_start;
        private System.Windows.Forms.DateTimePicker report_TimePicker1;
        private System.Windows.Forms.DateTimePicker report_TimePicker2;
        private System.Windows.Forms.Button btn_report_cancel;
        private System.Windows.Forms.Button btn_report_save;
        private System.Windows.Forms.DataGridView dvg_report;
        private System.Windows.Forms.Label lable_Status;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}