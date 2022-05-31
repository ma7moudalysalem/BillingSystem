namespace Bills.UI
{
    partial class unitform
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
            this.txt_unitName = new System.Windows.Forms.TextBox();
            this.txt_unitNotes = new System.Windows.Forms.RichTextBox();
            this.btn_unitCancel = new System.Windows.Forms.Button();
            this.btn_unitsave = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Units Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unit Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notes :";
            // 
            // txt_unitName
            // 
            this.txt_unitName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unitName.Location = new System.Drawing.Point(210, 106);
            this.txt_unitName.Name = "txt_unitName";
            this.txt_unitName.Size = new System.Drawing.Size(259, 27);
            this.txt_unitName.TabIndex = 5;
            // 
            // txt_unitNotes
            // 
            this.txt_unitNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unitNotes.Location = new System.Drawing.Point(210, 149);
            this.txt_unitNotes.Name = "txt_unitNotes";
            this.txt_unitNotes.Size = new System.Drawing.Size(259, 97);
            this.txt_unitNotes.TabIndex = 6;
            this.txt_unitNotes.Text = "";
            // 
            // btn_unitCancel
            // 
            this.btn_unitCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_unitCancel.Image = global::Bills.Properties.Resources.cancle;
            this.btn_unitCancel.Location = new System.Drawing.Point(110, 304);
            this.btn_unitCancel.Name = "btn_unitCancel";
            this.btn_unitCancel.Size = new System.Drawing.Size(113, 40);
            this.btn_unitCancel.TabIndex = 8;
            this.btn_unitCancel.UseVisualStyleBackColor = true;
            this.btn_unitCancel.Click += new System.EventHandler(this.btn_unitCancel_Click);
            // 
            // btn_unitsave
            // 
            this.btn_unitsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_unitsave.Image = global::Bills.Properties.Resources.save;
            this.btn_unitsave.Location = new System.Drawing.Point(369, 304);
            this.btn_unitsave.Name = "btn_unitsave";
            this.btn_unitsave.Size = new System.Drawing.Size(87, 40);
            this.btn_unitsave.TabIndex = 10;
            this.btn_unitsave.UseVisualStyleBackColor = true;
            this.btn_unitsave.Click += new System.EventHandler(this.btn_unitsave_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(216, 281);
            this.label_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 13);
            this.label_error.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(0, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 38);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // unitform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.btn_unitsave);
            this.Controls.Add(this.btn_unitCancel);
            this.Controls.Add(this.txt_unitNotes);
            this.Controls.Add(this.txt_unitName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "unitform";
            this.Text = "unitform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_unitName;
        private System.Windows.Forms.RichTextBox txt_unitNotes;
        private System.Windows.Forms.Button btn_unitCancel;
        private System.Windows.Forms.Button btn_unitsave;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}