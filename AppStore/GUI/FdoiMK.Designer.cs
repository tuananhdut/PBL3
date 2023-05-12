namespace GiaoDien
{
    partial class FdoiMK
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
            this.tbOldPasswork = new System.Windows.Forms.TextBox();
            this.tbNewPasswork = new System.Windows.Forms.TextBox();
            this.tbAgainNewPasswork = new System.Windows.Forms.TextBox();
            this.btExitForm = new System.Windows.Forms.Button();
            this.btChangPasswork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhâp lại mật khẩu";
            // 
            // tbOldPasswork
            // 
            this.tbOldPasswork.AcceptsReturn = true;
            this.tbOldPasswork.Location = new System.Drawing.Point(207, 40);
            this.tbOldPasswork.Name = "tbOldPasswork";
            this.tbOldPasswork.Size = new System.Drawing.Size(238, 22);
            this.tbOldPasswork.TabIndex = 3;
            this.tbOldPasswork.UseSystemPasswordChar = true;
            // 
            // tbNewPasswork
            // 
            this.tbNewPasswork.Location = new System.Drawing.Point(207, 85);
            this.tbNewPasswork.Name = "tbNewPasswork";
            this.tbNewPasswork.Size = new System.Drawing.Size(238, 22);
            this.tbNewPasswork.TabIndex = 4;
            this.tbNewPasswork.UseSystemPasswordChar = true;
            // 
            // tbAgainNewPasswork
            // 
            this.tbAgainNewPasswork.Location = new System.Drawing.Point(207, 131);
            this.tbAgainNewPasswork.Name = "tbAgainNewPasswork";
            this.tbAgainNewPasswork.Size = new System.Drawing.Size(238, 22);
            this.tbAgainNewPasswork.TabIndex = 5;
            this.tbAgainNewPasswork.UseSystemPasswordChar = true;
            // 
            // btExitForm
            // 
            this.btExitForm.Location = new System.Drawing.Point(105, 237);
            this.btExitForm.Name = "btExitForm";
            this.btExitForm.Size = new System.Drawing.Size(116, 23);
            this.btExitForm.TabIndex = 6;
            this.btExitForm.Text = "Thoát";
            this.btExitForm.UseVisualStyleBackColor = true;
            // 
            // btChangPasswork
            // 
            this.btChangPasswork.Location = new System.Drawing.Point(321, 237);
            this.btChangPasswork.Name = "btChangPasswork";
            this.btChangPasswork.Size = new System.Drawing.Size(112, 23);
            this.btChangPasswork.TabIndex = 7;
            this.btChangPasswork.Text = "Đổi mật khẩu";
            this.btChangPasswork.UseVisualStyleBackColor = true;
            this.btChangPasswork.Click += new System.EventHandler(this.btChangPasswork_Click);
            // 
            // FdoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 296);
            this.Controls.Add(this.btChangPasswork);
            this.Controls.Add(this.btExitForm);
            this.Controls.Add(this.tbAgainNewPasswork);
            this.Controls.Add(this.tbNewPasswork);
            this.Controls.Add(this.tbOldPasswork);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FdoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoiMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOldPasswork;
        private System.Windows.Forms.TextBox tbNewPasswork;
        private System.Windows.Forms.TextBox tbAgainNewPasswork;
        private System.Windows.Forms.Button btExitForm;
        private System.Windows.Forms.Button btChangPasswork;
    }
}