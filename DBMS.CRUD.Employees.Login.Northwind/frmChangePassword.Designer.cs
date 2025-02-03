namespace DBMS.CRUD.Employees.Login.Northwind
{
    partial class frmChangePassword
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
            btnChangePassword = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            employeeID = new TextBox();
            txtOldPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            SuspendLayout();
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(133, 293);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(88, 62);
            btnChangePassword.TabIndex = 0;
            btnChangePassword.Text = "เปลี่ยนรหัส";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(337, 293);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 62);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 68);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 120);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "รหัสผ่านเดิม";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 171);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "รหัสผ่านใหม่";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 225);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 5;
            label4.Text = "ยืนยันรหัสผ่าน";
            // 
            // employeeID
            // 
            employeeID.Location = new Point(200, 65);
            employeeID.Name = "employeeID";
            employeeID.Size = new Size(245, 23);
            employeeID.TabIndex = 6;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(200, 117);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(245, 23);
            txtOldPassword.TabIndex = 7;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(200, 168);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(245, 23);
            txtNewPassword.TabIndex = 8;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(200, 222);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(245, 23);
            txtConfirmPassword.TabIndex = 9;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 413);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(employeeID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnChangePassword);
            Name = "frmChangePassword";
            Text = "frmChangePassword";
            Load += frmChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangePassword;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox employeeID;
        private TextBox txtOldPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
    }
}