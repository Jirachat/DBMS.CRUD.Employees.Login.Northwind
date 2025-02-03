using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS.CRUD.Employees.Login.Northwind
{
    public partial class frmChangePassword : Form
    {
        SqlConnection conn;
        private int employeeID;
        public frmChangePassword(int empID, SqlConnection connection)
        {
            InitializeComponent();
            if (this.employeeID == 0)
            {
                MessageBox.Show("รหัสพนักงานไม่ถูกต้อง!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.conn = connection ?? throw new ArgumentNullException(nameof(connection)); // ตรวจสอบว่า conn ไม่เป็น null
        }
        

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("รหัสผ่านใหม่ไม่ตรงกัน!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (conn == null) // ป้องกันปัญหา NullReferenceException
            {
                MessageBox.Show("ไม่สามารถเชื่อมต่อฐานข้อมูลได้!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "UPDATE Employees SET Password = @newPassword WHERE EmployeeID = @empID AND Password = @oldPassword";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@newPassword", txtNewPassword.Text);
            cmd.Parameters.AddWithValue("@oldPassword", txtOldPassword.Text);
            cmd.Parameters.AddWithValue("@empID", this.employeeID);

            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("เปลี่ยนรหัสผ่านสำเร็จ!", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("รหัสผ่านเก่าไม่ถูกต้อง!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
