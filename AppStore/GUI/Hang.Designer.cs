namespace GiaoDien
{
    partial class Hang
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
            this.gb_HangSX = new System.Windows.Forms.GroupBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_DSHSX = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btExitDT = new System.Windows.Forms.Button();
            this.btDel_DT = new System.Windows.Forms.Button();
            this.btEdit_DT = new System.Windows.Forms.Button();
            this.btSave_DT = new System.Windows.Forms.Button();
            this.btAdd_DT = new System.Windows.Forms.Button();
            this.gb_HangSX.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSHSX)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_HangSX
            // 
            this.gb_HangSX.Controls.Add(this.txt_DiaChi);
            this.gb_HangSX.Controls.Add(this.txt_TenHang);
            this.gb_HangSX.Controls.Add(this.label3);
            this.gb_HangSX.Controls.Add(this.label2);
            this.gb_HangSX.Controls.Add(this.label1);
            this.gb_HangSX.Controls.Add(this.txt_MaHang);
            this.gb_HangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.gb_HangSX.Location = new System.Drawing.Point(12, 12);
            this.gb_HangSX.Name = "gb_HangSX";
            this.gb_HangSX.Size = new System.Drawing.Size(1055, 155);
            this.gb_HangSX.TabIndex = 0;
            this.gb_HangSX.TabStop = false;
            this.gb_HangSX.Text = "Thông Tin Hãng Sản Xuất";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(515, 112);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(241, 24);
            this.txt_DiaChi.TabIndex = 5;
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.Location = new System.Drawing.Point(515, 71);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(241, 24);
            this.txt_TenHang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Hãng Sản Xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hãng Sản Xuất";
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.Enabled = false;
            this.txt_MaHang.Location = new System.Drawing.Point(515, 32);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.Size = new System.Drawing.Size(241, 24);
            this.txt_MaHang.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_DSHSX);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1055, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Hãng Sản Xuất";
            // 
            // dtgv_DSHSX
            // 
            this.dtgv_DSHSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DSHSX.Location = new System.Drawing.Point(247, 23);
            this.dtgv_DSHSX.Name = "dtgv_DSHSX";
            this.dtgv_DSHSX.RowHeadersWidth = 51;
            this.dtgv_DSHSX.RowTemplate.Height = 24;
            this.dtgv_DSHSX.Size = new System.Drawing.Size(633, 126);
            this.dtgv_DSHSX.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btExitDT);
            this.groupBox3.Controls.Add(this.btDel_DT);
            this.groupBox3.Controls.Add(this.btEdit_DT);
            this.groupBox3.Controls.Add(this.btSave_DT);
            this.groupBox3.Controls.Add(this.btAdd_DT);
            this.groupBox3.Location = new System.Drawing.Point(12, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1055, 93);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác Vụ";
            // 
            // btExitDT
            // 
            this.btExitDT.Location = new System.Drawing.Point(921, 33);
            this.btExitDT.Name = "btExitDT";
            this.btExitDT.Size = new System.Drawing.Size(117, 50);
            this.btExitDT.TabIndex = 4;
            this.btExitDT.Text = "Bỏ Qua";
            this.btExitDT.UseVisualStyleBackColor = true;
            // 
            // btDel_DT
            // 
            this.btDel_DT.Location = new System.Drawing.Point(726, 33);
            this.btDel_DT.Name = "btDel_DT";
            this.btDel_DT.Size = new System.Drawing.Size(117, 50);
            this.btDel_DT.TabIndex = 3;
            this.btDel_DT.Text = "Xóa";
            this.btDel_DT.UseVisualStyleBackColor = true;
            this.btDel_DT.Click += new System.EventHandler(this.btDel_DT_Click);
            // 
            // btEdit_DT
            // 
            this.btEdit_DT.Location = new System.Drawing.Point(485, 33);
            this.btEdit_DT.Name = "btEdit_DT";
            this.btEdit_DT.Size = new System.Drawing.Size(117, 50);
            this.btEdit_DT.TabIndex = 2;
            this.btEdit_DT.Text = "Sửa";
            this.btEdit_DT.UseVisualStyleBackColor = true;
            this.btEdit_DT.Click += new System.EventHandler(this.btEdit_DT_Click);
            // 
            // btSave_DT
            // 
            this.btSave_DT.Location = new System.Drawing.Point(260, 33);
            this.btSave_DT.Name = "btSave_DT";
            this.btSave_DT.Size = new System.Drawing.Size(117, 50);
            this.btSave_DT.TabIndex = 1;
            this.btSave_DT.Text = "Lưu";
            this.btSave_DT.UseVisualStyleBackColor = true;
            this.btSave_DT.Click += new System.EventHandler(this.btSave_DT_Click);
            // 
            // btAdd_DT
            // 
            this.btAdd_DT.Location = new System.Drawing.Point(58, 33);
            this.btAdd_DT.Name = "btAdd_DT";
            this.btAdd_DT.Size = new System.Drawing.Size(117, 50);
            this.btAdd_DT.TabIndex = 0;
            this.btAdd_DT.Text = "Thêm";
            this.btAdd_DT.UseVisualStyleBackColor = true;
            this.btAdd_DT.Click += new System.EventHandler(this.btAdd_DT_Click);
            // 
            // Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_HangSX);
            this.Name = "Hang";
            this.Text = "Hang";
            this.gb_HangSX.ResumeLayout(false);
            this.gb_HangSX.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSHSX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_HangSX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btExitDT;
        private System.Windows.Forms.Button btDel_DT;
        private System.Windows.Forms.Button btEdit_DT;
        private System.Windows.Forms.Button btSave_DT;
        private System.Windows.Forms.Button btAdd_DT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.DataGridView dtgv_DSHSX;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_TenHang;
    }
}