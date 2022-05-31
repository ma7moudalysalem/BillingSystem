namespace Bills.UI
{
    partial class invoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoiceForm));
            this.gb_bill = new System.Windows.Forms.GroupBox();
            this.txt_invoiceNumber = new System.Windows.Forms.TextBox();
            this.lbl_invoiceNumber = new System.Windows.Forms.Label();
            this.dtp_incoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cb_invoiceClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_invoiceDate = new System.Windows.Forms.Label();
            this.lbl_salesInvoice = new System.Windows.Forms.Label();
            this.gb_items = new System.Windows.Forms.GroupBox();
            this.lbl_addStatus = new System.Windows.Forms.Label();
            this.nud_invoiceItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.btn_invoiceAddItem = new System.Windows.Forms.Button();
            this.txt_invoiceItemTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_invoiceSellPrice = new System.Windows.Forms.TextBox();
            this.lbl_sellPrice = new System.Windows.Forms.Label();
            this.cb_ivoiceItemName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_invoiceItems = new System.Windows.Forms.DataGridView();
            this.gb_invoiceOther = new System.Windows.Forms.GroupBox();
            this.nud_billPaidUp = new System.Windows.Forms.NumericUpDown();
            this.nud_percentageDiscount = new System.Windows.Forms.NumericUpDown();
            this.txt_rest = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_invoiceTotal = new System.Windows.Forms.TextBox();
            this.txt_billNet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valueDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_invoiceTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_invoiceEmployee = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_compCancle = new System.Windows.Forms.Button();
            this.btn_compSave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_invoiceSaveStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ep_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_correct = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_bill.SuspendLayout();
            this.gb_items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_invoiceItemQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoiceItems)).BeginInit();
            this.gb_invoiceOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_billPaidUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_percentageDiscount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_correct)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_bill
            // 
            this.gb_bill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_bill.Controls.Add(this.txt_invoiceNumber);
            this.gb_bill.Controls.Add(this.lbl_invoiceNumber);
            this.gb_bill.Controls.Add(this.dtp_incoiceDate);
            this.gb_bill.Controls.Add(this.cb_invoiceClient);
            this.gb_bill.Controls.Add(this.label3);
            this.gb_bill.Controls.Add(this.lbl_invoiceDate);
            this.gb_bill.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_bill.Location = new System.Drawing.Point(32, 131);
            this.gb_bill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_bill.Name = "gb_bill";
            this.gb_bill.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_bill.Size = new System.Drawing.Size(554, 296);
            this.gb_bill.TabIndex = 48;
            this.gb_bill.TabStop = false;
            this.gb_bill.Text = "Bill Detail";
            // 
            // txt_invoiceNumber
            // 
            this.txt_invoiceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_invoiceNumber.Enabled = false;
            this.txt_invoiceNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceNumber.Location = new System.Drawing.Point(235, 145);
            this.txt_invoiceNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_invoiceNumber.Name = "txt_invoiceNumber";
            this.txt_invoiceNumber.Size = new System.Drawing.Size(281, 32);
            this.txt_invoiceNumber.TabIndex = 43;
            // 
            // lbl_invoiceNumber
            // 
            this.lbl_invoiceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_invoiceNumber.AutoSize = true;
            this.lbl_invoiceNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoiceNumber.Location = new System.Drawing.Point(64, 150);
            this.lbl_invoiceNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_invoiceNumber.Name = "lbl_invoiceNumber";
            this.lbl_invoiceNumber.Size = new System.Drawing.Size(158, 29);
            this.lbl_invoiceNumber.TabIndex = 42;
            this.lbl_invoiceNumber.Text = "Bill Number  :";
            // 
            // dtp_incoiceDate
            // 
            this.dtp_incoiceDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_incoiceDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_incoiceDate.Location = new System.Drawing.Point(235, 74);
            this.dtp_incoiceDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_incoiceDate.Name = "dtp_incoiceDate";
            this.dtp_incoiceDate.Size = new System.Drawing.Size(281, 32);
            this.dtp_incoiceDate.TabIndex = 41;
            // 
            // cb_invoiceClient
            // 
            this.cb_invoiceClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_invoiceClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_invoiceClient.FormattingEnabled = true;
            this.cb_invoiceClient.Location = new System.Drawing.Point(235, 219);
            this.cb_invoiceClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_invoiceClient.Name = "cb_invoiceClient";
            this.cb_invoiceClient.Size = new System.Drawing.Size(281, 32);
            this.cb_invoiceClient.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Client Name :";
            // 
            // lbl_invoiceDate
            // 
            this.lbl_invoiceDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_invoiceDate.AutoSize = true;
            this.lbl_invoiceDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoiceDate.Location = new System.Drawing.Point(108, 70);
            this.lbl_invoiceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_invoiceDate.Name = "lbl_invoiceDate";
            this.lbl_invoiceDate.Size = new System.Drawing.Size(116, 29);
            this.lbl_invoiceDate.TabIndex = 38;
            this.lbl_invoiceDate.Text = "Bill Date :";
            // 
            // lbl_salesInvoice
            // 
            this.lbl_salesInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_salesInvoice.AutoSize = true;
            this.lbl_salesInvoice.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salesInvoice.Location = new System.Drawing.Point(21, 46);
            this.lbl_salesInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_salesInvoice.Name = "lbl_salesInvoice";
            this.lbl_salesInvoice.Size = new System.Drawing.Size(275, 47);
            this.lbl_salesInvoice.TabIndex = 47;
            this.lbl_salesInvoice.Text = "Sales Invoice";
            // 
            // gb_items
            // 
            this.gb_items.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_items.Controls.Add(this.lbl_addStatus);
            this.gb_items.Controls.Add(this.nud_invoiceItemQuantity);
            this.gb_items.Controls.Add(this.btn_invoiceAddItem);
            this.gb_items.Controls.Add(this.txt_invoiceItemTotal);
            this.gb_items.Controls.Add(this.label4);
            this.gb_items.Controls.Add(this.label2);
            this.gb_items.Controls.Add(this.txt_invoiceSellPrice);
            this.gb_items.Controls.Add(this.lbl_sellPrice);
            this.gb_items.Controls.Add(this.cb_ivoiceItemName);
            this.gb_items.Controls.Add(this.label5);
            this.gb_items.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_items.Location = new System.Drawing.Point(32, 452);
            this.gb_items.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_items.Name = "gb_items";
            this.gb_items.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_items.Size = new System.Drawing.Size(554, 410);
            this.gb_items.TabIndex = 49;
            this.gb_items.TabStop = false;
            this.gb_items.Text = "Items Details";
            // 
            // lbl_addStatus
            // 
            this.lbl_addStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_addStatus.AutoSize = true;
            this.lbl_addStatus.Location = new System.Drawing.Point(230, 311);
            this.lbl_addStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addStatus.Name = "lbl_addStatus";
            this.lbl_addStatus.Size = new System.Drawing.Size(0, 29);
            this.lbl_addStatus.TabIndex = 50;
            // 
            // nud_invoiceItemQuantity
            // 
            this.nud_invoiceItemQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_invoiceItemQuantity.Location = new System.Drawing.Point(235, 198);
            this.nud_invoiceItemQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_invoiceItemQuantity.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_invoiceItemQuantity.Name = "nud_invoiceItemQuantity";
            this.nud_invoiceItemQuantity.Size = new System.Drawing.Size(281, 36);
            this.nud_invoiceItemQuantity.TabIndex = 49;
            this.nud_invoiceItemQuantity.ValueChanged += new System.EventHandler(this.nud_invoiceItemQuantity_ValueChanged);
            // 
            // btn_invoiceAddItem
            // 
            this.btn_invoiceAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_invoiceAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_invoiceAddItem.Image = global::Bills.Properties.Resources.add1;
            this.btn_invoiceAddItem.Location = new System.Drawing.Point(210, 369);
            this.btn_invoiceAddItem.Margin = new System.Windows.Forms.Padding(0);
            this.btn_invoiceAddItem.Name = "btn_invoiceAddItem";
            this.btn_invoiceAddItem.Size = new System.Drawing.Size(114, 38);
            this.btn_invoiceAddItem.TabIndex = 48;
            this.btn_invoiceAddItem.UseVisualStyleBackColor = true;
            this.btn_invoiceAddItem.Click += new System.EventHandler(this.btn_invoiceAddItem_Click);
            // 
            // txt_invoiceItemTotal
            // 
            this.txt_invoiceItemTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_invoiceItemTotal.Enabled = false;
            this.txt_invoiceItemTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceItemTotal.Location = new System.Drawing.Point(235, 259);
            this.txt_invoiceItemTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_invoiceItemTotal.Name = "txt_invoiceItemTotal";
            this.txt_invoiceItemTotal.Size = new System.Drawing.Size(281, 32);
            this.txt_invoiceItemTotal.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "Total :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 44;
            this.label2.Text = "Quantity :";
            // 
            // txt_invoiceSellPrice
            // 
            this.txt_invoiceSellPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_invoiceSellPrice.Enabled = false;
            this.txt_invoiceSellPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceSellPrice.Location = new System.Drawing.Point(235, 119);
            this.txt_invoiceSellPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_invoiceSellPrice.Name = "txt_invoiceSellPrice";
            this.txt_invoiceSellPrice.Size = new System.Drawing.Size(281, 32);
            this.txt_invoiceSellPrice.TabIndex = 43;
            // 
            // lbl_sellPrice
            // 
            this.lbl_sellPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sellPrice.AutoSize = true;
            this.lbl_sellPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sellPrice.Location = new System.Drawing.Point(64, 124);
            this.lbl_sellPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sellPrice.Name = "lbl_sellPrice";
            this.lbl_sellPrice.Size = new System.Drawing.Size(155, 29);
            this.lbl_sellPrice.TabIndex = 42;
            this.lbl_sellPrice.Text = "Selling Price :";
            // 
            // cb_ivoiceItemName
            // 
            this.cb_ivoiceItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ivoiceItemName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ivoiceItemName.FormattingEnabled = true;
            this.cb_ivoiceItemName.Location = new System.Drawing.Point(235, 51);
            this.cb_ivoiceItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_ivoiceItemName.Name = "cb_ivoiceItemName";
            this.cb_ivoiceItemName.Size = new System.Drawing.Size(281, 32);
            this.cb_ivoiceItemName.TabIndex = 40;
            this.cb_ivoiceItemName.SelectionChangeCommitted += new System.EventHandler(this.cb_ivoiceItemName_SelectionChangeCommitted);
            this.cb_ivoiceItemName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cb_ivoiceItemName_MouseDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "Item Name :";
            // 
            // dgv_invoiceItems
            // 
            this.dgv_invoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_invoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoiceItems.Location = new System.Drawing.Point(32, 890);
            this.dgv_invoiceItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_invoiceItems.Name = "dgv_invoiceItems";
            this.dgv_invoiceItems.ReadOnly = true;
            this.dgv_invoiceItems.RowHeadersWidth = 51;
            this.dgv_invoiceItems.Size = new System.Drawing.Size(554, 255);
            this.dgv_invoiceItems.TabIndex = 50;
            // 
            // gb_invoiceOther
            // 
            this.gb_invoiceOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_invoiceOther.Controls.Add(this.nud_billPaidUp);
            this.gb_invoiceOther.Controls.Add(this.nud_percentageDiscount);
            this.gb_invoiceOther.Controls.Add(this.txt_rest);
            this.gb_invoiceOther.Controls.Add(this.label9);
            this.gb_invoiceOther.Controls.Add(this.label10);
            this.gb_invoiceOther.Controls.Add(this.txt_invoiceTotal);
            this.gb_invoiceOther.Controls.Add(this.txt_billNet);
            this.gb_invoiceOther.Controls.Add(this.label1);
            this.gb_invoiceOther.Controls.Add(this.txt_valueDiscount);
            this.gb_invoiceOther.Controls.Add(this.label6);
            this.gb_invoiceOther.Controls.Add(this.label7);
            this.gb_invoiceOther.Controls.Add(this.label8);
            this.gb_invoiceOther.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_invoiceOther.Location = new System.Drawing.Point(32, 1185);
            this.gb_invoiceOther.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_invoiceOther.Name = "gb_invoiceOther";
            this.gb_invoiceOther.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_invoiceOther.Size = new System.Drawing.Size(554, 504);
            this.gb_invoiceOther.TabIndex = 53;
            this.gb_invoiceOther.TabStop = false;
            this.gb_invoiceOther.Text = "Other Details";
            // 
            // nud_billPaidUp
            // 
            this.nud_billPaidUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_billPaidUp.DecimalPlaces = 2;
            this.nud_billPaidUp.Location = new System.Drawing.Point(265, 342);
            this.nud_billPaidUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_billPaidUp.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_billPaidUp.Name = "nud_billPaidUp";
            this.nud_billPaidUp.Size = new System.Drawing.Size(281, 36);
            this.nud_billPaidUp.TabIndex = 55;
            this.nud_billPaidUp.ValueChanged += new System.EventHandler(this.nud_billPaidUp_ValueChanged);
            // 
            // nud_percentageDiscount
            // 
            this.nud_percentageDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_percentageDiscount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_percentageDiscount.Location = new System.Drawing.Point(265, 136);
            this.nud_percentageDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_percentageDiscount.Name = "nud_percentageDiscount";
            this.nud_percentageDiscount.Size = new System.Drawing.Size(281, 32);
            this.nud_percentageDiscount.TabIndex = 54;
            this.nud_percentageDiscount.ValueChanged += new System.EventHandler(this.nud_percentageDiscount_ValueChanged);
            // 
            // txt_rest
            // 
            this.txt_rest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_rest.Enabled = false;
            this.txt_rest.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rest.Location = new System.Drawing.Point(265, 406);
            this.txt_rest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_rest.Name = "txt_rest";
            this.txt_rest.Size = new System.Drawing.Size(281, 32);
            this.txt_rest.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 411);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 29);
            this.label9.TabIndex = 52;
            this.label9.Text = "The Rest :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(149, 342);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 29);
            this.label10.TabIndex = 50;
            this.label10.Text = "Paid Up :";
            // 
            // txt_invoiceTotal
            // 
            this.txt_invoiceTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_invoiceTotal.Enabled = false;
            this.txt_invoiceTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceTotal.Location = new System.Drawing.Point(265, 65);
            this.txt_invoiceTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_invoiceTotal.Name = "txt_invoiceTotal";
            this.txt_invoiceTotal.Size = new System.Drawing.Size(281, 32);
            this.txt_invoiceTotal.TabIndex = 49;
            // 
            // txt_billNet
            // 
            this.txt_billNet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_billNet.Enabled = false;
            this.txt_billNet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_billNet.Location = new System.Drawing.Point(265, 268);
            this.txt_billNet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_billNet.Name = "txt_billNet";
            this.txt_billNet.Size = new System.Drawing.Size(281, 32);
            this.txt_billNet.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "The Net :";
            // 
            // txt_valueDiscount
            // 
            this.txt_valueDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_valueDiscount.Enabled = false;
            this.txt_valueDiscount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valueDiscount.Location = new System.Drawing.Point(265, 199);
            this.txt_valueDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_valueDiscount.Name = "txt_valueDiscount";
            this.txt_valueDiscount.Size = new System.Drawing.Size(281, 32);
            this.txt_valueDiscount.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 29);
            this.label6.TabIndex = 44;
            this.label6.Text = "Value Discount :";
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "Percentage Discount :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(141, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "Bill Total :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtp_invoiceTime);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cb_invoiceEmployee);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 1728);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(554, 229);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request A Form";
            // 
            // dtp_invoiceTime
            // 
            this.dtp_invoiceTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_invoiceTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_invoiceTime.Location = new System.Drawing.Point(246, 156);
            this.dtp_invoiceTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_invoiceTime.Name = "dtp_invoiceTime";
            this.dtp_invoiceTime.Size = new System.Drawing.Size(281, 32);
            this.dtp_invoiceTime.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(152, 160);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 29);
            this.label12.TabIndex = 44;
            this.label12.Text = "Time :";
            // 
            // cb_invoiceEmployee
            // 
            this.cb_invoiceEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_invoiceEmployee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_invoiceEmployee.FormattingEnabled = true;
            this.cb_invoiceEmployee.Location = new System.Drawing.Point(246, 72);
            this.cb_invoiceEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_invoiceEmployee.Name = "cb_invoiceEmployee";
            this.cb_invoiceEmployee.Size = new System.Drawing.Size(281, 32);
            this.cb_invoiceEmployee.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 78);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(201, 29);
            this.label14.TabIndex = 39;
            this.label14.Text = "Employee Name :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 2095);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 55;
            // 
            // btn_compCancle
            // 
            this.btn_compCancle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_compCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_compCancle.Image = global::Bills.Properties.Resources.cancle;
            this.btn_compCancle.Location = new System.Drawing.Point(176, 2015);
            this.btn_compCancle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_compCancle.Name = "btn_compCancle";
            this.btn_compCancle.Size = new System.Drawing.Size(159, 49);
            this.btn_compCancle.TabIndex = 52;
            this.btn_compCancle.UseVisualStyleBackColor = true;
            this.btn_compCancle.Click += new System.EventHandler(this.btn_compCancle_Click);
            // 
            // btn_compSave
            // 
            this.btn_compSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_compSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_compSave.Image = global::Bills.Properties.Resources.save;
            this.btn_compSave.Location = new System.Drawing.Point(389, 2015);
            this.btn_compSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_compSave.Name = "btn_compSave";
            this.btn_compSave.Size = new System.Drawing.Size(143, 49);
            this.btn_compSave.TabIndex = 51;
            this.btn_compSave.UseVisualStyleBackColor = true;
            this.btn_compSave.Click += new System.EventHandler(this.btn_compSave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 48);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_invoiceSaveStatus
            // 
            this.lbl_invoiceSaveStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_invoiceSaveStatus.AutoSize = true;
            this.lbl_invoiceSaveStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoiceSaveStatus.Location = new System.Drawing.Point(284, 1981);
            this.lbl_invoiceSaveStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_invoiceSaveStatus.Name = "lbl_invoiceSaveStatus";
            this.lbl_invoiceSaveStatus.Size = new System.Drawing.Size(0, 24);
            this.lbl_invoiceSaveStatus.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 48);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // ep_error
            // 
            this.ep_error.ContainerControl = this;
            // 
            // ep_correct
            // 
            this.ep_correct.ContainerControl = this;
            this.ep_correct.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_correct.Icon")));
            // 
            // invoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(786, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_invoiceSaveStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_invoiceOther);
            this.Controls.Add(this.btn_compCancle);
            this.Controls.Add(this.btn_compSave);
            this.Controls.Add(this.dgv_invoiceItems);
            this.Controls.Add(this.gb_items);
            this.Controls.Add(this.gb_bill);
            this.Controls.Add(this.lbl_salesInvoice);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "invoiceForm";
            this.Text = "invoiceForm";
            this.Load += new System.EventHandler(this.invoiceForm_Load);
            this.gb_bill.ResumeLayout(false);
            this.gb_bill.PerformLayout();
            this.gb_items.ResumeLayout(false);
            this.gb_items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_invoiceItemQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoiceItems)).EndInit();
            this.gb_invoiceOther.ResumeLayout(false);
            this.gb_invoiceOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_billPaidUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_percentageDiscount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_correct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_bill;
        private System.Windows.Forms.TextBox txt_invoiceNumber;
        private System.Windows.Forms.Label lbl_invoiceNumber;
        private System.Windows.Forms.DateTimePicker dtp_incoiceDate;
        private System.Windows.Forms.ComboBox cb_invoiceClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_invoiceDate;
        private System.Windows.Forms.Label lbl_salesInvoice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gb_items;
        private System.Windows.Forms.Button btn_invoiceAddItem;
        private System.Windows.Forms.TextBox txt_invoiceItemTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_invoiceSellPrice;
        private System.Windows.Forms.Label lbl_sellPrice;
        private System.Windows.Forms.ComboBox cb_ivoiceItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_invoiceItems;
        private System.Windows.Forms.Button btn_compCancle;
        private System.Windows.Forms.Button btn_compSave;
        private System.Windows.Forms.GroupBox gb_invoiceOther;
        private System.Windows.Forms.TextBox txt_invoiceTotal;
        private System.Windows.Forms.TextBox txt_billNet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valueDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_rest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_invoiceEmployee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_invoiceTime;
        private System.Windows.Forms.NumericUpDown nud_invoiceItemQuantity;
        private System.Windows.Forms.NumericUpDown nud_percentageDiscount;
        private System.Windows.Forms.Label lbl_addStatus;
        private System.Windows.Forms.NumericUpDown nud_billPaidUp;
        private System.Windows.Forms.Label lbl_invoiceSaveStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider ep_error;
        private System.Windows.Forms.ErrorProvider ep_correct;
    }
}