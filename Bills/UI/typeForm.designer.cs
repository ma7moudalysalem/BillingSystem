namespace Bills.UI
{
    partial class typeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_typename = new System.Windows.Forms.TextBox();
            this.rtxt_typenote = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_companyname = new System.Windows.Forms.ComboBox();
            this.lab_typeerror = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type Data Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notes :";
            // 
            // txt_typename
            // 
            this.txt_typename.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_typename.Location = new System.Drawing.Point(224, 150);
            this.txt_typename.Name = "txt_typename";
            this.txt_typename.Size = new System.Drawing.Size(276, 27);
            this.txt_typename.TabIndex = 5;
            this.txt_typename.TabStop = false;
            this.txt_typename.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_typename_MouseDown);
            // 
            // rtxt_typenote
            // 
            this.rtxt_typenote.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_typenote.Location = new System.Drawing.Point(224, 190);
            this.rtxt_typenote.Name = "rtxt_typenote";
            this.rtxt_typenote.Size = new System.Drawing.Size(276, 96);
            this.rtxt_typenote.TabIndex = 6;
            this.rtxt_typenote.Text = "";
            this.rtxt_typenote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtxt_typenote_MouseDown);
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Image = global::Bills.Properties.Resources.save;
            this.btn_save.Location = new System.Drawing.Point(320, 323);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(93, 39);
            this.btn_save.TabIndex = 7;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::Bills.Properties.Resources.cancle;
            this.button2.Location = new System.Drawing.Point(145, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 39);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type Name :";
            // 
            // cb_companyname
            // 
            this.cb_companyname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_companyname.FormattingEnabled = true;
            this.cb_companyname.Location = new System.Drawing.Point(224, 106);
            this.cb_companyname.Margin = new System.Windows.Forms.Padding(2);
            this.cb_companyname.Name = "cb_companyname";
            this.cb_companyname.Size = new System.Drawing.Size(276, 27);
            this.cb_companyname.TabIndex = 10;
            this.cb_companyname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cb_companyname_MouseDown);
            // 
            // lab_typeerror
            // 
            this.lab_typeerror.AutoSize = true;
            this.lab_typeerror.Location = new System.Drawing.Point(226, 298);
            this.lab_typeerror.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_typeerror.Name = "lab_typeerror";
            this.lab_typeerror.Size = new System.Drawing.Size(0, 13);
            this.lab_typeerror.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 38);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // typeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(585, 374);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lab_typeerror);
            this.Controls.Add(this.cb_companyname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.rtxt_typenote);
            this.Controls.Add(this.txt_typename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "typeForm";
            this.Text = "type";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_typename;
        private System.Windows.Forms.RichTextBox rtxt_typenote;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_companyname;
        private System.Windows.Forms.Label lab_typeerror;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}