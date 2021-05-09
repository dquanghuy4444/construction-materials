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
    public partial class Form_Supplier : Form
    {
        public Form formMain;
        public DataTable dt;

        public int status;
        public int selectedId;

        public Form_Supplier(Form frmMain)
        {
            InitializeComponent();

            formMain = frmMain;

            InitialData();

            InitialContext();
        }

        public void InitialData()
        {
            string query = "SELECT * FROM material.supplier";
            dt = ConnectionDatabase.GetData(query);

            status = (int)Variables.ENUM_STATUS.ACTIVE;
        }

        public void InitialContext()
        {
            dgv_Suppliers.Rows.Clear();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_Suppliers.Rows.Add();
                    dgv_Suppliers.AllowUserToAddRows = false;

                    dgv_Suppliers.Rows[i].Cells[0].Value = (i + 1).ToString();
                    dgv_Suppliers.Rows[i].Cells[1].Value = dt.Rows[i]["id"].ToString();
                    dgv_Suppliers.Rows[i].Cells[2].Value = dt.Rows[i]["fullname"].ToString();
                    dgv_Suppliers.Rows[i].Cells[3].Value = dt.Rows[i]["phone"].ToString();
                    dgv_Suppliers.Rows[i].Cells[4].Value = dt.Rows[i]["address"].ToString();
                    dgv_Suppliers.Rows[i].Cells[5].Value = dt.Rows[i]["email"].ToString();
                    dgv_Suppliers.Rows[i].Cells[6].Value = dt.Rows[i]["description"].ToString();
                }
            }

            ChangeContextByStatus();
        }

        public void ChangeContextByStatus()
        {
            if (status == (int)Variables.ENUM_STATUS.ACTIVE)
            {
                btn_Create.Visible = true;
                btn_Change.Visible = false;
                btn_Exit.Visible = false;

                grb_Option.Text = "Tạo mới nhà cung cấp";
            }
            else
            {
                btn_Create.Visible = false;
                btn_Change.Visible = true;
                btn_Exit.Visible = true;

                grb_Option.Text = "Sửa thông tin nhà cung cấp";
            }
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

            string query = "SELECT * FROM material.supplier where fullname = \'" + txt_Fullname.Text + "\' " + queryNotId;
            DataTable dt = ConnectionDatabase.GetData(query);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tên công ty này đã có trong CSDL . Xin mời nhập lại", "Cảnh báo");
                return false;
            }

            query = "SELECT * FROM material.supplier where email = \'" + txt_Email.Text + "\' " + queryNotId;
            dt = ConnectionDatabase.GetData(query);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Email công ty này đã có trong CSDL . Xin mời nhập lại", "Cảnh báo");
                return false;
            }

            query = "SELECT * FROM material.supplier where phone = \'" + txt_Phone.Text + "\' " + queryNotId;
            dt = ConnectionDatabase.GetData(query);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Số điện thoại công ty này đã có trong CSDL . Xin mời nhập lại", "Cảnh báo");
                return false;
            }

            return true;
        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            string query = "";
            string fullName = txt_Fullname.Text;
            string phone = txt_Phone.Text;
            string email = txt_Email.Text;
            string address = rtb_Address.Text;
            string description = rtb_Description.Text;

            query = "INSERT INTO material.supplier " +
                "(fullname,description,phone,address,email) VALUES " +
                "(" +
                "\'" + fullName + "\' , " +
                "\'" + description + "\' , " +
                "\'" + phone + "\' , " +
                "\'" + address + "\' , " +
                "\'" + email + "\'" +
                ")";

            bool success = ConnectionDatabase.QueryData(query);
            if (success)
            {
                MessageBox.Show("Tạo mới nhà cung cấp thành công !!!", "Thông báo");

                InitialData();

                InitialContext();

                RefreshForm();
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            status = (int)Variables.ENUM_STATUS.ACTIVE;

            ChangeContextByStatus();

            RefreshForm();
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
            query = "UPDATE material.supplier " +
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
                MessageBox.Show("Thay đổi thông tin nhà cung cấp thành công !!!", "Thông báo");

                status = (int)Variables.ENUM_STATUS.ACTIVE;
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
                    dgv_Suppliers.CurrentCell = dgv_Suppliers.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv_Suppliers.Rows[e.RowIndex].Selected = true;
                    dgv_Suppliers.Focus();

                    selectedId = Convert.ToInt32(dgv_Suppliers.Rows[e.RowIndex].Cells[1].Value);

                }
                catch (Exception)
                {

                }
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbl_SelectedId.Text = selectedId.ToString();

            status = (int)Variables.ENUM_STATUS.INACTIVE;
            ChangeContextByStatus();

            string query = "SELECT * FROM material.supplier where id = \'" + selectedId + "\'";
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

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        //    DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp (ID : " + selectedId + ") này không ?", "Thông báo", MessageBoxButtons.YesNoCancel,
        //MessageBoxIcon.Information);

        //    if (dr == DialogResult.Yes)
        //    {
        //        string query = "DELETE FROM material.supplier where id = \'" + selectedId + "\'";
        //        bool success = ConnectionDatabase.QueryData(query);
        //        if (success)
        //        {
        //            status = (int)Variables.ENUM_STATUS.ACTIVE;

        //            InitialData();
        //            InitialContext();
        //            RefreshForm();
        //        }

        //    }
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                Common.ExportDatatableToExcel(dt);
            }
        }

    }
}
