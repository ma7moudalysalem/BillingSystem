namespace Bills.UI
{
    partial class clients
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clients));
            this.clientslbl = new System.Windows.Forms.Label();
            this.client_name_lbl = new System.Windows.Forms.Label();
            this.client_phone_lbl = new System.Windows.Forms.Label();
            this.client_phone_num = new System.Windows.Forms.Label();
            this.client_add_lbl = new System.Windows.Forms.Label();
            this.txt_client_name = new System.Windows.Forms.TextBox();
            this.txt_client_num = new System.Windows.Forms.TextBox();
            this.txt_client_address = new System.Windows.Forms.TextBox();
            this.txt_client_phone = new System.Windows.Forms.TextBox();
            this.lab_typeerror_client = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_client_cancel = new System.Windows.Forms.Button();
            this.btn_client_save = new System.Windows.Forms.Button();
            this.ep_client = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_correct = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_correct)).BeginInit();
            this.SuspendLayout();
            // 
            // clientslbl
            // 
            this.clientslbl.AutoSize = true;
            this.clientslbl.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientslbl.Location = new System.Drawing.Point(19, 37);
            this.clientslbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.clientslbl.Name = "clientslbl";
            this.clientslbl.Size = new System.Drawing.Size(130, 38);
            this.clientslbl.TabIndex = 0;
            this.clientslbl.Text = "Clients";
            // 
            // client_name_lbl
            // 
            this.client_name_lbl.AutoSize = true;
            this.client_name_lbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_name_lbl.Location = new System.Drawing.Point(60, 89);
            this.client_name_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.client_name_lbl.Name = "client_name_lbl";
            this.client_name_lbl.Size = new System.Drawing.Size(124, 23);
            this.client_name_lbl.TabIndex = 1;
            this.client_name_lbl.Text = "Client Name :";
            // 
            // client_phone_lbl
            // 
            this.client_phone_lbl.AutoSize = true;
            this.client_phone_lbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_phone_lbl.Location = new System.Drawing.Point(109, 149);
            this.client_phone_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.client_phone_lbl.Name = "client_phone_lbl";
            this.client_phone_lbl.Size = new System.Drawing.Size(75, 23);
            this.client_phone_lbl.TabIndex = 2;
            this.client_phone_lbl.Text = "Phone :";
            // 
            // client_phone_num
            // 
            this.client_phone_num.AutoSize = true;
            this.client_phone_num.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_phone_num.Location = new System.Drawing.Point(93, 203);
            this.client_phone_num.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.client_phone_num.Name = "client_phone_num";
            this.client_phone_num.Size = new System.Drawing.Size(91, 23);
            this.client_phone_num.TabIndex = 3;
            this.client_phone_num.Text = "Number :";
            // 
            // client_add_lbl
            // 
            this.client_add_lbl.AutoSize = true;
            this.client_add_lbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_add_lbl.Location = new System.Drawing.Point(95, 261);
            this.client_add_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.client_add_lbl.Name = "client_add_lbl";
            this.client_add_lbl.Size = new System.Drawing.Size(89, 23);
            this.client_add_lbl.TabIndex = 4;
            this.client_add_lbl.Text = "Address :";
            // 
            // txt_client_name
            // 
            this.txt_client_name.Location = new System.Drawing.Point(194, 89);
            this.txt_client_name.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_client_name.Name = "txt_client_name";
            this.txt_client_name.Size = new System.Drawing.Size(310, 29);
            this.txt_client_name.TabIndex = 5;
            // 
            // txt_client_num
            // 
            this.txt_client_num.Enabled = false;
            this.txt_client_num.Location = new System.Drawing.Point(194, 203);
            this.txt_client_num.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_client_num.Name = "txt_client_num";
            this.txt_client_num.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_client_num.Size = new System.Drawing.Size(310, 29);
            this.txt_client_num.TabIndex = 7;
            // 
            // txt_client_address
            // 
            this.txt_client_address.Location = new System.Drawing.Point(194, 259);
            this.txt_client_address.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_client_address.Name = "txt_client_address";
            this.txt_client_address.Size = new System.Drawing.Size(310, 29);
            this.txt_client_address.TabIndex = 8;
            // 
            // txt_client_phone
            // 
            this.txt_client_phone.Location = new System.Drawing.Point(194, 149);
            this.txt_client_phone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_client_phone.Name = "txt_client_phone";
            this.txt_client_phone.Size = new System.Drawing.Size(310, 29);
            this.txt_client_phone.TabIndex = 9;
            // 
            // lab_typeerror_client
            // 
            this.lab_typeerror_client.AutoSize = true;
            this.lab_typeerror_client.Location = new System.Drawing.Point(190, 372);
            this.lab_typeerror_client.Name = "lab_typeerror_client";
            this.lab_typeerror_client.Size = new System.Drawing.Size(0, 22);
            this.lab_typeerror_client.TabIndex = 48;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 38);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // btn_client_cancel
            // 
            this.btn_client_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_client_cancel.Image = global::Bills.Properties.Resources.cancle;
            this.btn_client_cancel.Location = new System.Drawing.Point(140, 318);
            this.btn_client_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_client_cancel.Name = "btn_client_cancel";
            this.btn_client_cancel.Size = new System.Drawing.Size(122, 43);
            this.btn_client_cancel.TabIndex = 13;
            this.btn_client_cancel.UseVisualStyleBackColor = true;
            this.btn_client_cancel.Click += new System.EventHandler(this.btn_client_cancel_Click);
            // 
            // btn_client_save
            // 
            this.btn_client_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_client_save.Image = global::Bills.Properties.Resources.save;
            this.btn_client_save.Location = new System.Drawing.Point(332, 318);
            this.btn_client_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_client_save.Name = "btn_client_save";
            this.btn_client_save.Size = new System.Drawing.Size(101, 43);
            this.btn_client_save.TabIndex = 12;
            this.btn_client_save.UseVisualStyleBackColor = true;
            this.btn_client_save.Click += new System.EventHandler(this.btn_client_save_Click);
            // 
            // ep_client
            // 
            this.ep_client.ContainerControl = this;
            // 
            // ep_correct
            // 
            this.ep_correct.ContainerControl = this;
            this.ep_correct.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_correct.Icon")));
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(585, 404);
            this.Controls.Add(this.lab_typeerror_client);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_client_cancel);
            this.Controls.Add(this.btn_client_save);
            this.Controls.Add(this.txt_client_phone);
            this.Controls.Add(this.txt_client_address);
            this.Controls.Add(this.txt_client_num);
            this.Controls.Add(this.txt_client_name);
            this.Controls.Add(this.client_add_lbl);
            this.Controls.Add(this.client_phone_num);
            this.Controls.Add(this.client_phone_lbl);
            this.Controls.Add(this.client_name_lbl);
            this.Controls.Add(this.clientslbl);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "clients";
            this.Text = "clients";
            this.Load += new System.EventHandler(this.clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_correct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientslbl;
        private System.Windows.Forms.Label client_name_lbl;
        private System.Windows.Forms.Label client_phone_lbl;
        private System.Windows.Forms.Label client_phone_num;
        private System.Windows.Forms.Label client_add_lbl;
        private System.Windows.Forms.TextBox txt_client_name;
        private System.Windows.Forms.TextBox txt_client_num;
        private System.Windows.Forms.TextBox txt_client_address;
        private System.Windows.Forms.TextBox txt_client_phone;
        private System.Windows.Forms.Button btn_client_cancel;
        private System.Windows.Forms.Button btn_client_save;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lab_typeerror_client;
        private System.Windows.Forms.ErrorProvider ep_client;
        private System.Windows.Forms.ErrorProvider ep_correct;
    }
}