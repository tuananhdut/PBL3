namespace GiaoDien
{
    partial class Flogin
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.cbViewPasswork = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPasswork = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Controls.Add(this.cbViewPasswork);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbPasswork);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 294);
            this.panel1.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(106, 232);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(107, 35);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Thoát";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(337, 232);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(107, 35);
            this.btOk.TabIndex = 5;
            this.btOk.Text = "Đăng Nhập";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // cbViewPasswork
            // 
            this.cbViewPasswork.AutoSize = true;
            this.cbViewPasswork.Location = new System.Drawing.Point(210, 192);
            this.cbViewPasswork.Name = "cbViewPasswork";
            this.cbViewPasswork.Size = new System.Drawing.Size(130, 20);
            this.cbViewPasswork.TabIndex = 4;
            this.cbViewPasswork.Text = "Hiển thị mật khẩu";
            this.cbViewPasswork.UseVisualStyleBackColor = true;
            this.cbViewPasswork.CheckedChanged += new System.EventHandler(this.cbViewPasswork_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // tbPasswork
            // 
            this.tbPasswork.Location = new System.Drawing.Point(210, 148);
            this.tbPasswork.Name = "tbPasswork";
            this.tbPasswork.Size = new System.Drawing.Size(202, 22);
            this.tbPasswork.TabIndex = 2;
            this.tbPasswork.Text = "123";
            this.tbPasswork.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(210, 94);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(202, 22);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "TuanAnh";
            // 
            // Flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 301);
            this.Controls.Add(this.panel1);
            this.Name = "Flogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPasswork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.CheckBox cbViewPasswork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
    }
}

