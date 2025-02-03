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
    public partial class frmPos : Form
    {
        public frmPos()
        {
            InitializeComponent();
        }
        public int empID { get; set; }
        public string empName { get; set; }
        public string position { get; set; }
        public string userName { get; set; }
        //ประกาศตัวแปรเชอื่ มต่อ
        SqlConnection conn;
        SqlTransaction tr;

        private void frmPos_Load(object sender, EventArgs e)
        {
            hideRedLabel(); //ซอ่ น labelสแีดง
            conn =  connectDB.ConnectNorthwind();
            ListViewFormat();
            ClearProductData();
        }

        private void ClearProductData()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtUnitPrice.Text = "0";
            txtQuantity.Text = "1";
            txtTotal.Text = "0";
        }

        private void ListViewFormat()
        {
            lsvProducts.Columns.Add("รหัสสินค้า", 100, HorizontalAlignment.Left);
            lsvProducts.Columns.Add("สินค้า", 150, HorizontalAlignment.Left);
            lsvProducts.Columns.Add("ราคา", 65, HorizontalAlignment.Right);
            lsvProducts.Columns.Add("จำนวน", 50, HorizontalAlignment.Right);
            lsvProducts.Columns.Add("รวมเป็นเงิน", 70, HorizontalAlignment.Right);
            lsvProducts.View = View.Details;
            lsvProducts.GridLines = true;
            lsvProducts.FullRowSelect = true;
        }
        private void ClearEmployeeData() //เคลยี รช์ อื่ และรหัสพนักงาน
        {
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
        }
        private void CalculateTotal() //เอาไว้ค านวณราคารวมของแต่ละรายการ
        {
            double total = Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text);
            txtTotal.Text = total.ToString("#,##0.00");
            txtProductID.Focus();
        }
        private void CalculateNetPrice() //เอาไว้ค านวณราคารวมทั้งหมด
        {
            int i = 0;
            double tmpNetPrice = 0.0;
            for (i = 0; i <= lsvProducts.Items.Count - 1; i++)
            {
                tmpNetPrice += Convert.ToDouble(lsvProducts.Items[i].SubItems[4].Text);
            }
            lblNetPrice.Text = tmpNetPrice.ToString("#,##0.00");
        }
        private void hideRedLabel()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    if (c.ForeColor == Color.Red)
                        c.Visible = false;
                }
            }
            foreach (Control c in this.GroupBox1.Controls)
            {
                if (c is Label)
                {
                    if (c.ForeColor == Color.Red)
                        c.Visible = false;
                }
            }
        }

        private void txtEmployeeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "Select EmployeeID,titleOfCourtesy+FirstName+ SPACE(2)+ LastName as empName"
                + " , Title from employees where employeeID = @employeeID";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@employeeID", txtEmployeeID.Text);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    txtEmployeeID.Text = dt.Rows[0][0].ToString();
                    txtEmployeeName.Text = dt.Rows[0][1].ToString();
                    txtProductID.Focus();
                }
                else
                {
                    ClearEmployeeData();
                    txtEmployeeName.Focus();
                }
                dr.Close();
                conn.Close();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() == "") txtQuantity.Text = "1";
            if (Convert.ToInt16(txtQuantity.Text) == 0) txtQuantity.Text = "1";
            CalculateTotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text.Trim() == "" || txtProductName.Text.Trim() == "")
            {
                txtProductID.Focus(); return;
            }
            if (Convert.ToInt16(txtQuantity.Text) == 0)
            {
                txtProductID.Focus(); return;
            }
            ListViewItem lvi;
            int i = 0; string tmpProductID = "";
            for (i = 0; i <= lsvProducts.Items.Count - 1; i++)
            {
                tmpProductID = lsvProducts.Items[i].SubItems[0].Text;
                if (txtProductID.Text.Trim() == tmpProductID)
                {
                    int qty = Convert.ToInt16(lsvProducts.Items[i].SubItems[3].Text)
                    + Convert.ToInt16(txtQuantity.Text);
                    double newTotal = Convert.ToDouble(lsvProducts.Items[i].SubItems[4].Text)
                    + Convert.ToDouble(txtTotal.Text); //**
                    lsvProducts.Items[i].SubItems[3].Text = qty.ToString();
                    lsvProducts.Items[i].SubItems[4].Text = newTotal.ToString("#,##0.00");
                    ClearProductData();
                    CalculateTotal();
                    CalculateNetPrice();
                    return;
                }
            }
            string[] anyData;
            anyData = new string[] { txtProductID.Text, txtProductName.Text,
            txtUnitPrice.Text, txtQuantity.Text, txtTotal.Text };
            lvi = new ListViewItem(anyData);
            lsvProducts.Items.Add(lvi);
            CalculateNetPrice(); ClearProductData(); btnSave.Enabled = true;
            txtProductID.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearProductData();
        }

        private void lsvProducts_DoubleClick(object sender, EventArgs e)
        {
            //เมื่อ Double click บนขอ้มลู สนิ คา้จะลบสนิ คา้ออกจากรายการ
            int i = 0;
            for (i = 0; i <= lsvProducts.SelectedItems.Count - 1; i++)
            {
                ListViewItem lvi = lsvProducts.SelectedItems[i];
                lsvProducts.Items.Remove(lvi);
            }
            CalculateNetPrice();
            txtProductID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lsvProducts.Clear(); //เคลยี รร์ ํายกํารสนิคํา้ในหนํา้จอ
            ClearEmployeeData(); //เคลยี รร์ ํายชอื่ พนักงํานขําย (อนั นี้ถํา้มกี ําร Login มําก่อนจะไม่ต ้องเคลียร์)
            ClearProductData(); //เคลยี รร์ ํายชอื่ สนิคํา้ในรํายกํารคน้หําสนิคํา้
            ListViewFormat(); //จัดรูปแบบ ListView อีกครั้ง
            lblNetPrice.Text = "0.00"; //ปรับรําคํารวมให ้เป็น 0 อีกครั้ง
            txtEmployeeID.Focus(); //น ํา Cursor ไปวํางที่ รหัสพนักงําน
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int lastOrderID = 0; //จะเอําไว้เก็บรหัสที่ใหม่ที่สุดตอนที่ insert order แล ้ว
            if (txtEmployeeID.Text.Trim() == "")
            {
                MessageBox.Show("โปรดระบผุ ูข้ ํายสนิคํา้กอ่ น", "มีข ้อผิดพลําด");
                txtEmployeeID.Focus();
                return;
            }
            if (lsvProducts.Items.Count > 0) //ตรวจสอบวํา่ เลอื กสนิคํา้ไวห้ รอื ยัง
            {
                if (MessageBox.Show("ตอ้ งกํารบันทกึ รํายกํารสั่งซอื้ หรอื ไม", "กรุณํายืนยัน", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
                {
                    //ประกําศเริ่ม Transaction
                    conn.Open();
                    tr = conn.BeginTransaction();
                    string sql = "insert into Orders(OrderDate,EmployeeID)"
                    + " values (getdate(),@EmployeeID)";
                    SqlCommand comm = new SqlCommand(sql, conn, tr);
                    comm.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim());
                    
                    comm.ExecuteNonQuery();
                    //อ่ําน OrderID ลํา่ สดุ ใสไ่ วใ้นตัวแปร lastOrderID
                    string sql1 = "select Top 1 OrderID from Orders order by  OrderID DESC";
                    SqlCommand comm1 = new SqlCommand(sql1, conn, tr);
                    SqlDataReader dr = comm1.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        lastOrderID = dr.GetInt32(dr.GetOrdinal("OrderID"));
                    }
                    dr.Close();
                    //เพมิ่ ขอ้มลู รํายกํารสนิคํา้ OrderDetail ที่ตรงกับ lastOrderID
                    for (int i = 0; i <= lsvProducts.Items.Count - 1; i++)
                    {
                        string sql2 = "insert into [Order Details](OrderID,ProductID,UnitPrice,Quantity)"
                        + " values(@OrderID,@ProductID,@UnitPrice,@Quantity)";
                        SqlCommand comm3 = new SqlCommand(sql2, conn, tr);
                        comm3.Parameters.AddWithValue("@OrderID", lastOrderID);
                        comm3.Parameters.AddWithValue("@ProductID", lsvProducts.Items[i].SubItems[0].Text);
                        comm3.Parameters.AddWithValue("@UnitPrice", lsvProducts.Items[i].SubItems[2].Text);
                        comm3.Parameters.AddWithValue("@Quantity", lsvProducts.Items[i].SubItems[3].Text);
                        comm3.ExecuteNonQuery();
                    }
                    tr.Commit();
                    conn.Close();
                    MessageBox.Show("บันทึกรํายกํารขํายเรียบร้อยแล ้ว", "ผลกํารท ํางําน");
                }
                btnCancel.PerformClick(); //สั่งใหไ้ปกดป่ม ุ cancel เคลีย์หน้ําจอทั้งหมดใหม่เพื่อเริ่มรํายกํารใหม่
            }
        }
        private void txtProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "Select ProductID, ProductName,unitPrice"
                + " from products where productID = @ProductID";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)

                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    txtProductID.Text = dt.Rows[0][0].ToString();
                    txtProductName.Text = dt.Rows[0][1].ToString();
                    txtUnitPrice.Text = dt.Rows[0][2].ToString();
                    CalculateTotal();
                    txtProductID.Focus();
                }
                else
                {
                    MessageBox.Show("ไมพ่ บสนิคํา้นี้", "ผิดพลําด");
                    ClearProductData();
                    txtProductID.Focus();
                }
                dr.Close();
                conn.Close();
            }
        }
    }
}
