namespace GiaoDien
{
    partial class FHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEmployeeID = new System.Windows.Forms.TextBox();
            this.cbbCustomerID = new System.Windows.Forms.ComboBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbAddressCustomer = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.tbInvoiceDate = new System.Windows.Forms.TextBox();
            this.tbInvoiceID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTotalAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtgvInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.tbSalePrice = new System.Windows.Forms.TextBox();
            this.tbSale = new System.Windows.Forms.TextBox();
            this.tbQuantityProduct = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.cbbProductID = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbbInvoiceID = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btChecking = new System.Windows.Forms.Button();
            this.btPrintInvoice = new System.Windows.Forms.Button();
            this.btExitInvoice = new System.Windows.Forms.Button();
            this.btUpdateInvoice = new System.Windows.Forms.Button();
            this.btSaveInvoice = new System.Windows.Forms.Button();
            this.btAddInvoice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInvoiceDetail)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEmployeeID);
            this.groupBox1.Controls.Add(this.cbbCustomerID);
            this.groupBox1.Controls.Add(this.tbPhoneNumber);
            this.groupBox1.Controls.Add(this.tbAddressCustomer);
            this.groupBox1.Controls.Add(this.tbCustomerName);
            this.groupBox1.Controls.Add(this.tbEmployeeName);
            this.groupBox1.Controls.Add(this.tbInvoiceDate);
            this.groupBox1.Controls.Add(this.tbInvoiceID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1149, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // tbEmployeeID
            // 
            this.tbEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeeID.Location = new System.Drawing.Point(196, 106);
            this.tbEmployeeID.Name = "tbEmployeeID";
            this.tbEmployeeID.Size = new System.Drawing.Size(299, 27);
            this.tbEmployeeID.TabIndex = 16;
            // 
            // cbbCustomerID
            // 
            this.cbbCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbbCustomerID.FormattingEnabled = true;
            this.cbbCustomerID.Location = new System.Drawing.Point(798, 26);
            this.cbbCustomerID.Name = "cbbCustomerID";
            this.cbbCustomerID.Size = new System.Drawing.Size(323, 28);
            this.cbbCustomerID.TabIndex = 15;
            this.cbbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cbbCustomerID_SelectedIndexChanged);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbPhoneNumber.Location = new System.Drawing.Point(798, 143);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(323, 27);
            this.tbPhoneNumber.TabIndex = 13;
            // 
            // tbAddressCustomer
            // 
            this.tbAddressCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbAddressCustomer.Location = new System.Drawing.Point(798, 104);
            this.tbAddressCustomer.Name = "tbAddressCustomer";
            this.tbAddressCustomer.Size = new System.Drawing.Size(323, 27);
            this.tbAddressCustomer.TabIndex = 12;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCustomerName.Location = new System.Drawing.Point(798, 63);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(323, 27);
            this.tbCustomerName.TabIndex = 11;
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbEmployeeName.Location = new System.Drawing.Point(196, 143);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(299, 27);
            this.tbEmployeeName.TabIndex = 10;
            // 
            // tbInvoiceDate
            // 
            this.tbInvoiceDate.Enabled = false;
            this.tbInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbInvoiceDate.Location = new System.Drawing.Point(196, 63);
            this.tbInvoiceDate.Name = "tbInvoiceDate";
            this.tbInvoiceDate.Size = new System.Drawing.Size(299, 27);
            this.tbInvoiceDate.TabIndex = 9;
            // 
            // tbInvoiceID
            // 
            this.tbInvoiceID.Enabled = false;
            this.tbInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbInvoiceID.Location = new System.Drawing.Point(196, 27);
            this.tbInvoiceID.Name = "tbInvoiceID";
            this.tbInvoiceID.Size = new System.Drawing.Size(299, 27);
            this.tbInvoiceID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(656, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số Điện Thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(656, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(656, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTotalAmount);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dtgvInvoiceDetail);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.tbSalePrice);
            this.groupBox2.Controls.Add(this.tbSale);
            this.groupBox2.Controls.Add(this.tbQuantityProduct);
            this.groupBox2.Controls.Add(this.tbProductName);
            this.groupBox2.Controls.Add(this.cbbProductID);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1149, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Mặt Hàng";
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount.Enabled = false;
            this.tbTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbTotalAmount.Location = new System.Drawing.Point(975, 285);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.Size = new System.Drawing.Size(146, 27);
            this.tbTotalAmount.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label15.Location = new System.Drawing.Point(880, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Tổng Tiền";
            // 
            // dtgvInvoiceDetail
            // 
            this.dtgvInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInvoiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvInvoiceDetail.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvInvoiceDetail.Location = new System.Drawing.Point(32, 117);
            this.dtgvInvoiceDetail.Name = "dtgvInvoiceDetail";
            this.dtgvInvoiceDetail.RowHeadersWidth = 51;
            this.dtgvInvoiceDetail.RowTemplate.Height = 24;
            this.dtgvInvoiceDetail.Size = new System.Drawing.Size(1089, 150);
            this.dtgvInvoiceDetail.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên điện thoại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Giá";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giảm Giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 180;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox11.Location = new System.Drawing.Point(920, 72);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(201, 27);
            this.textBox11.TabIndex = 27;
            // 
            // tbSalePrice
            // 
            this.tbSalePrice.Enabled = false;
            this.tbSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbSalePrice.Location = new System.Drawing.Point(920, 27);
            this.tbSalePrice.Name = "tbSalePrice";
            this.tbSalePrice.Size = new System.Drawing.Size(201, 27);
            this.tbSalePrice.TabIndex = 26;
            // 
            // tbSale
            // 
            this.tbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbSale.Location = new System.Drawing.Point(553, 72);
            this.tbSale.Name = "tbSale";
            this.tbSale.Size = new System.Drawing.Size(201, 27);
            this.tbSale.TabIndex = 25;
            // 
            // tbQuantityProduct
            // 
            this.tbQuantityProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbQuantityProduct.Location = new System.Drawing.Point(553, 26);
            this.tbQuantityProduct.Name = "tbQuantityProduct";
            this.tbQuantityProduct.Size = new System.Drawing.Size(201, 27);
            this.tbQuantityProduct.TabIndex = 24;
            // 
            // tbProductName
            // 
            this.tbProductName.Enabled = false;
            this.tbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbProductName.Location = new System.Drawing.Point(165, 72);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(201, 27);
            this.tbProductName.TabIndex = 23;
            // 
            // cbbProductID
            // 
            this.cbbProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbbProductID.FormattingEnabled = true;
            this.cbbProductID.Location = new System.Drawing.Point(165, 27);
            this.cbbProductID.Name = "cbbProductID";
            this.cbbProductID.Size = new System.Drawing.Size(201, 28);
            this.cbbProductID.TabIndex = 22;
            this.cbbProductID.SelectedIndexChanged += new System.EventHandler(this.cbbProductID_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(811, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Thành Tiền";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(811, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Đơn Giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(474, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Giảm Giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(473, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Số Lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tên Điện Thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mã Điện Thoại";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbbInvoiceID);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.btChecking);
            this.groupBox7.Controls.Add(this.btPrintInvoice);
            this.groupBox7.Controls.Add(this.btExitInvoice);
            this.groupBox7.Controls.Add(this.btUpdateInvoice);
            this.groupBox7.Controls.Add(this.btSaveInvoice);
            this.groupBox7.Controls.Add(this.btAddInvoice);
            this.groupBox7.Location = new System.Drawing.Point(22, 531);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1149, 108);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tác Vụ";
            // 
            // cbbInvoiceID
            // 
            this.cbbInvoiceID.FormattingEnabled = true;
            this.cbbInvoiceID.Location = new System.Drawing.Point(833, 59);
            this.cbbInvoiceID.Name = "cbbInvoiceID";
            this.cbbInvoiceID.Size = new System.Drawing.Size(163, 24);
            this.cbbInvoiceID.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(719, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "Mã Hóa Đơn";
            // 
            // btChecking
            // 
            this.btChecking.Location = new System.Drawing.Point(1017, 33);
            this.btChecking.Name = "btChecking";
            this.btChecking.Size = new System.Drawing.Size(117, 50);
            this.btChecking.TabIndex = 5;
            this.btChecking.Text = "Chọn";
            this.btChecking.UseVisualStyleBackColor = true;
            // 
            // btPrintInvoice
            // 
            this.btPrintInvoice.Location = new System.Drawing.Point(553, 33);
            this.btPrintInvoice.Name = "btPrintInvoice";
            this.btPrintInvoice.Size = new System.Drawing.Size(117, 50);
            this.btPrintInvoice.TabIndex = 4;
            this.btPrintInvoice.Text = "In Hóa Đơn";
            this.btPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // btExitInvoice
            // 
            this.btExitInvoice.Location = new System.Drawing.Point(420, 33);
            this.btExitInvoice.Name = "btExitInvoice";
            this.btExitInvoice.Size = new System.Drawing.Size(117, 50);
            this.btExitInvoice.TabIndex = 3;
            this.btExitInvoice.Text = "Hủy";
            this.btExitInvoice.UseVisualStyleBackColor = true;
            this.btExitInvoice.Click += new System.EventHandler(this.btExitInvoice_Click);
            // 
            // btUpdateInvoice
            // 
            this.btUpdateInvoice.Location = new System.Drawing.Point(287, 33);
            this.btUpdateInvoice.Name = "btUpdateInvoice";
            this.btUpdateInvoice.Size = new System.Drawing.Size(117, 50);
            this.btUpdateInvoice.TabIndex = 2;
            this.btUpdateInvoice.Text = "Sửa";
            this.btUpdateInvoice.UseVisualStyleBackColor = true;
            this.btUpdateInvoice.Click += new System.EventHandler(this.btUpdateInvoice_Click);
            // 
            // btSaveInvoice
            // 
            this.btSaveInvoice.Location = new System.Drawing.Point(149, 33);
            this.btSaveInvoice.Name = "btSaveInvoice";
            this.btSaveInvoice.Size = new System.Drawing.Size(117, 50);
            this.btSaveInvoice.TabIndex = 1;
            this.btSaveInvoice.Text = "Lưu";
            this.btSaveInvoice.UseVisualStyleBackColor = true;
            this.btSaveInvoice.Click += new System.EventHandler(this.btSaveInvoice_Click);
            // 
            // btAddInvoice
            // 
            this.btAddInvoice.Location = new System.Drawing.Point(10, 33);
            this.btAddInvoice.Name = "btAddInvoice";
            this.btAddInvoice.Size = new System.Drawing.Size(117, 50);
            this.btAddInvoice.TabIndex = 0;
            this.btAddInvoice.Text = "Thêm";
            this.btAddInvoice.UseVisualStyleBackColor = true;
            this.btAddInvoice.Click += new System.EventHandler(this.btAddInvoice_Click);
            // 
            // FHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 651);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FHoaDon";
            this.Text = "FHoaDon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInvoiceDetail)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbCustomerID;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbAddressCustomer;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.TextBox tbInvoiceDate;
        private System.Windows.Forms.TextBox tbInvoiceID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvInvoiceDetail;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox tbSalePrice;
        private System.Windows.Forms.TextBox tbSale;
        private System.Windows.Forms.TextBox tbQuantityProduct;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btChecking;
        private System.Windows.Forms.Button btPrintInvoice;
        private System.Windows.Forms.Button btExitInvoice;
        private System.Windows.Forms.Button btUpdateInvoice;
        private System.Windows.Forms.Button btSaveInvoice;
        private System.Windows.Forms.Button btAddInvoice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTotalAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbbInvoiceID;
        private System.Windows.Forms.TextBox tbEmployeeID;
        private System.Windows.Forms.ComboBox cbbProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}