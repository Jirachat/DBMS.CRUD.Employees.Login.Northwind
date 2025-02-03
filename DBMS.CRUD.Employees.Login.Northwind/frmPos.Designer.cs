namespace DBMS.CRUD.Employees.Login.Northwind
{
    partial class frmPos
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
            label1 = new Label();
            label2 = new Label();
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            GroupBox1 = new GroupBox();
            lsvProducts = new ListView();
            txtTotal = new TextBox();
            txtQuantity = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtUnitPrice = new TextBox();
            label5 = new Label();
            txtProductName = new TextBox();
            label4 = new Label();
            txtProductID = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            label8 = new Label();
            lblNetPrice = new Label();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 40);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "ชื่อ-สกุล";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(82, 37);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(100, 23);
            txtEmployeeID.TabIndex = 2;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(288, 37);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(176, 23);
            txtEmployeeName.TabIndex = 3;
            txtEmployeeName.KeyDown += txtEmployeeName_KeyDown;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(lsvProducts);
            GroupBox1.Controls.Add(txtTotal);
            GroupBox1.Controls.Add(txtQuantity);
            GroupBox1.Controls.Add(label7);
            GroupBox1.Controls.Add(label6);
            GroupBox1.Controls.Add(txtUnitPrice);
            GroupBox1.Controls.Add(label5);
            GroupBox1.Controls.Add(txtProductName);
            GroupBox1.Controls.Add(label4);
            GroupBox1.Controls.Add(txtProductID);
            GroupBox1.Controls.Add(label3);
            GroupBox1.Location = new Point(12, 162);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(610, 276);
            GroupBox1.TabIndex = 4;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "รายการสั่งซื้อสินค้า";
            // 
            // lsvProducts
            // 
            lsvProducts.Location = new Point(6, 66);
            lsvProducts.Name = "lsvProducts";
            lsvProducts.Size = new Size(598, 204);
            lsvProducts.TabIndex = 10;
            lsvProducts.UseCompatibleStateImageBehavior = false;
            lsvProducts.DoubleClick += lsvProducts_DoubleClick;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(499, 37);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(91, 23);
            txtTotal.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(421, 37);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(55, 23);
            txtQuantity.TabIndex = 8;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(499, 19);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 7;
            label7.Text = "รวมเป็นเงิน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 19);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 6;
            label6.Text = "จำนวน";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(302, 37);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(100, 23);
            txtUnitPrice.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 19);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 4;
            label5.Text = "ราคาขาย";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(129, 37);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(167, 23);
            txtProductName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 19);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 2;
            label4.Text = "ชื่อสินค้า";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(6, 37);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(100, 23);
            txtProductID.TabIndex = 1;
            txtProductID.KeyDown += txtProductID_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "รหัสสินค้า";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(628, 190);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 32);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "เพิ่มรายการ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(628, 228);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(91, 32);
            btnClear.TabIndex = 6;
            btnClear.Text = "ล้างข้อมูล";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(628, 345);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 32);
            btnSave.TabIndex = 7;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(628, 400);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 32);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "ยกเลิกการ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(680, 9);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 9;
            label8.Text = "รวมเป็นเงิน";
            // 
            // lblNetPrice
            // 
            lblNetPrice.AutoSize = true;
            lblNetPrice.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNetPrice.Location = new Point(559, 24);
            lblNetPrice.Name = "lblNetPrice";
            lblNetPrice.Size = new Size(176, 45);
            lblNetPrice.TabIndex = 10;
            lblNetPrice.Text = "lblNetPrice";
            // 
            // frmPos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNetPrice);
            Controls.Add(label8);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(GroupBox1);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPos";
            Text = "frmPos";
            Load += frmPos_Load;
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private GroupBox GroupBox1;
        private TextBox txtProductName;
        private Label label4;
        private TextBox txtProductID;
        private Label label3;
        private ListView lsvProducts;
        private TextBox txtTotal;
        private TextBox txtQuantity;
        private Label label7;
        private Label label6;
        private TextBox txtUnitPrice;
        private Label label5;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSave;
        private Button btnCancel;
        private Label label8;
        private Label lblNetPrice;
    }
}