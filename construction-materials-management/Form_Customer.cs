using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace construction_materials_management
{
    public partial class Form_Customer : Form
    {
        public Form formMain;
        public DataTable dt;

        public int selectedId;

        public Form_Customer(Form frmMain)
        {
            InitializeComponent();

            formMain = frmMain;

            InitialData();

            InitialContext();
        }

        public void InitialData()
        {
            string query = "SELECT * FROM material.customer";
            dt = ConnectionDatabase.GetData(query);
        }

        public void InitialContext()
        {
            dgv_Customers.Enabled = true;
            dgv_Customers.Rows.Clear();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_Customers.Rows.Add();
                    dgv_Customers.AllowUserToAddRows = false;

                    dgv_Customers.Rows[i].Cells[0].Value = (i + 1).ToString();
                    dgv_Customers.Rows[i].Cells[1].Value = dt.Rows[i]["id"].ToString();
                    dgv_Customers.Rows[i].Cells[2].Value = dt.Rows[i]["fullname"].ToString();
                    dgv_Customers.Rows[i].Cells[3].Value = dt.Rows[i]["phone"].ToString();
                    dgv_Customers.Rows[i].Cells[4].Value = dt.Rows[i]["address"].ToString();
                    dgv_Customers.Rows[i].Cells[5].Value = dt.Rows[i]["email"].ToString();
                    dgv_Customers.Rows[i].Cells[6].Value = dt.Rows[i]["description"].ToString();
                }
            }

            btn_ShowAll.Visible = false;

        }

        public void RefreshForm()
        {
            txt_Fullname.Text = "";
            txt_Phone.Text = "";
            txt_Email.Text = "";
            rtb_Address.Text = "";
            rtb_Description.Text = "";
        }

        public bool ValidateForm(bool hasCheckNotId = false)
        {
            if (txt_Fullname.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên công ty", "Cảnh báo");
                txt_Fullname.Focus();
                return false;
            }
            if (txt_Fullname.Text.Length > 40)
            {
                MessageBox.Show("Chỉ được tối đa 40 kí tự", "Cảnh báo");
                txt_Fullname.Focus();
                return false;
            }

            if (txt_Phone.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Cảnh báo");
                txt_Phone.Focus();
                return false;
            }

            if (!Common.IsVietNamPhone(txt_Phone.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại đúng định dạng", "Cảnh báo");
                txt_Phone.Focus();
                return false;
            }

            if (txt_Email.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập email", "Cảnh báo");
                txt_Phone.Focus();
                return false;
            }
            if (!Common.IsEmail(txt_Email.Text))
            {
                MessageBox.Show("Không phải định dạng email", "Cảnh báo");
                txt_Email.Focus();
                return false;
            }

            if (rtb_Address.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Cảnh báo");
                rtb_Address.Focus();
                return false;
            }

            string queryNotId = "";
            if (hasCheckNotId)
            {
                string id = lbl_SelectedId.Text;
                queryNotId = "and id <> \'" + id + "\'";
            }

            string query = "SELECT * FROM material.customer where email = \'" + txt_Email.Text + "\' " + queryNotId;
            dt = ConnectionDatabase.GetData(query);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Email khách hàng này đã có trong CSDL . Xin mời nhập lại", "Cảnh báo");
                return false;
            }

            query = "SELECT * FROM material.customer where phone = \'" + txt_Phone.Text + "\' " + queryNotId;
            dt = ConnectionDatabase.GetData(query);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Số điện thoại khách hàng này đã có trong CSDL . Xin mời nhập lại", "Cảnh báo");
                return false;
            }

            return true;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(true))
            {
                return;
            }

            string query = "";
            string fullName = txt_Fullname.Text;
            string phone = txt_Phone.Text;
            string email = txt_Email.Text;
            string address = rtb_Address.Text;
            string description = rtb_Description.Text;
            string id = lbl_SelectedId.Text;
            query = "UPDATE material.customer " +
                "SET " +
                "fullname = \'" + fullName + "\' ," +
                "phone = \'" + phone + "\' ," +
                "address = \'" + address + "\' ," +
                "email = \'" + email + "\' ," +
                "description = \'" + description + "\' " +
                "WHERE id = \'" + id + "\'";

            bool success = ConnectionDatabase.QueryData(query);
            if (success)
            {
                MessageBox.Show("Thay đổi thông tin khách hàng thành công !!!", "Thông báo");

                InitialData();

                InitialContext();

                RefreshForm();
            }

        }

        private void dgv_Suppliers_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void dgv_Suppliers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgv_Customers.CurrentCell = dgv_Customers.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv_Customers.Rows[e.RowIndex].Selected = true;
                    dgv_Customers.Focus();

                    selectedId = Convert.ToInt32(dgv_Customers.Rows[e.RowIndex].Cells[1].Value);

                }
                catch (Exception)
                {

                }
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbl_SelectedId.Text = selectedId.ToString();

            string query = "SELECT * FROM material.customer where id = \'" + selectedId + "\'";
            DataTable dt = ConnectionDatabase.GetData(query);

            if(dt.Rows.Count > 0)
            {
                txt_Fullname.Text = dt.Rows[0]["fullname"].ToString();
                txt_Phone.Text = dt.Rows[0]["phone"].ToString();
                txt_Email.Text = dt.Rows[0]["email"].ToString();
                rtb_Address.Text = dt.Rows[0]["address"].ToString();
                rtb_Description.Text = dt.Rows[0]["description"].ToString();
            }
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            InitialData();

            InitialContext();

            if (dt.Rows.Count > 0)
            {
                Common.ExportDatatableToExcel(dt);
            }
        }

        private void btn_SearchPhoneNum_Click(object sender, EventArgs e)
        {
            string phoneNum = txt_SearchPhoneNum.Text;

            if (phoneNum == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Cảnh báo");
                txt_Phone.Focus();
                return;
            }

            if (!Common.IsVietNamPhone(phoneNum))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại đúng định dạng", "Cảnh báo");
                txt_Phone.Focus();
                return;
            }

            string query = "SELECT * FROM material.customer where phone = \'" + phoneNum + "\'";
            dt = ConnectionDatabase.GetData(query);

            if(dt.Rows.Count == 0)
            {
                dgv_Customers.Enabled = false;
            }
            InitialContext();

            btn_ShowAll.Visible = true;
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            InitialData();

            InitialContext();

            txt_SearchPhoneNum.Text = "";
        }
    }
}
