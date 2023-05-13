namespace GiaoDien
{
    partial class FTheLoai
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btExitDT = new System.Windows.Forms.Button();
            this.btDel_DT = new System.Windows.Forms.Button();
            this.btEdit_DT = new System.Windows.Forms.Button();
            this.btSave_TL = new System.Windows.Forms.Button();
            this.btAdd_TL = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_DSTL = new System.Windows.Forms.DataGridView();
            this.gbTTTL = new System.Windows.Forms.GroupBox();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSTL)).BeginInit();
            this.gbTTTL.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btExitDT);
            this.groupBox3.Controls.Add(this.btDel_DT);
            this.groupBox3.Controls.Add(this.btEdit_DT);
            this.groupBox3.Controls.Add(this.btSave_TL);
            this.groupBox3.Controls.Add(this.btAdd_TL);
            this.groupBox3.Location = new System.Drawing.Point(12, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1055, 93);
            this.groupBox3.TabIndex = 8;
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
            this.btExitDT.Click += new System.EventHandler(this.btExitDT_Click);
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
            // btSave_TL
            // 
            this.btSave_TL.Location = new System.Drawing.Point(260, 33);
            this.btSave_TL.Name = "btSave_TL";
            this.btSave_TL.Size = new System.Drawing.Size(117, 50);
            this.btSave_TL.TabIndex = 1;
            this.btSave_TL.Text = "Lưu";
            this.btSave_TL.UseVisualStyleBackColor = true;
            this.btSave_TL.Click += new System.EventHandler(this.btSave_DT_Click);
            // 
            // btAdd_TL
            // 
            this.btAdd_TL.Location = new System.Drawing.Point(58, 33);
            this.btAdd_TL.Name = "btAdd_TL";
            this.btAdd_TL.Size = new System.Drawing.Size(117, 50);
            this.btAdd_TL.TabIndex = 0;
            this.btAdd_TL.Text = "Thêm";
            this.btAdd_TL.UseVisualStyleBackColor = true;
            this.btAdd_TL.Click += new System.EventHandler(this.btAdd_TL_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_DSTL);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1055, 155);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Thể Loại Điện Thoại";
            // 
            // dtgv_DSTL
            // 
            this.dtgv_DSTL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_DSTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DSTL.Location = new System.Drawing.Point(217, 23);
            this.dtgv_DSTL.Name = "dtgv_DSTL";
            this.dtgv_DSTL.RowHeadersWidth = 51;
            this.dtgv_DSTL.RowTemplate.Height = 24;
            this.dtgv_DSTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_DSTL.Size = new System.Drawing.Size(642, 126);
            this.dtgv_DSTL.TabIndex = 0;
            // 
            // gbTTTL
            // 
            this.gbTTTL.Controls.Add(this.txtTenTL);
            this.gbTTTL.Controls.Add(this.label2);
            this.gbTTTL.Controls.Add(this.label1);
            this.gbTTTL.Controls.Add(this.txtMaTL);
            this.gbTTTL.Enabled = false;
            this.gbTTTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.gbTTTL.Location = new System.Drawing.Point(12, 12);
            this.gbTTTL.Name = "gbTTTL";
            this.gbTTTL.Size = new System.Drawing.Size(1055, 155);
            this.gbTTTL.TabIndex = 6;
            this.gbTTTL.TabStop = false;
            this.gbTTTL.Text = "Thông Tin Thể Loại Điện Thoại";
            // 
            // txtTenTL
            // 
            this.txtTenTL.Location = new System.Drawing.Point(453, 94);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(241, 24);
            this.txtTenTL.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Thể loại";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Enabled = false;
            this.txtMaTL.Location = new System.Drawing.Point(453, 56);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(241, 24);
            this.txtMaTL.TabIndex = 0;
            // 
            // FTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbTTTL);
            this.Name = "FTheLoai";
            this.Text = "FTheLoai";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSTL)).EndInit();
            this.gbTTTL.ResumeLayout(false);
            this.gbTTTL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btExitDT;
        private System.Windows.Forms.Button btDel_DT;
        private System.Windows.Forms.Button btEdit_DT;
        private System.Windows.Forms.Button btSave_TL;
        private System.Windows.Forms.Button btAdd_TL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv_DSTL;
        private System.Windows.Forms.GroupBox gbTTTL;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTL;
    }
}