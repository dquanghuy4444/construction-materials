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
    public partial class Form_Product_Group : Form
    {
        public Form formMain;
        public DataTable dt;

        public int selectedId;
        public int selectedIdUnit;

        public Form_Product_Group(Form frmMain)
        {
            InitializeComponent();

            formMain = frmMain;


            InitialContext();
        }

        public void InitialContext()
        {
            string query = "SELECT pg.id , pg.fullname , pg.description , pu.fullname as fullname_unit FROM material.product_group as pg inner join  material.product_unit as pu on pg.unit_id = pu.id";
            dt = ConnectionDatabase.GetData(query);

            dgv_Main.Enabled = true;
            dgv_Main.Rows.Clear();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_Main.Rows.Add();
                    dgv_Main.AllowUserToAddRows = false;

                    dgv_Main.Rows[i].Cells[0].Value = (i + 1).ToString();
                    dgv_Main.Rows[i].Cells[1].Value = dt.Rows[i]["id"].ToString();
                    dgv_Main.Rows[i].Cells[2].Value = dt.Rows[i]["fullname"].ToString();
                    dgv_Main.Rows[i].Cells[3].Value = dt.Rows[i]["fullname_unit"].ToString();
                    dgv_Main.Rows[i].Cells[4].Value = dt.Rows[i]["description"].ToString();
                }
            }

            query = "SELECT * FROM material.product_unit";
            dt = ConnectionDatabase.GetData(query);
            cbb_Unit.DataSource = dt;
            cbb_Unit.DisplayMember = "fullname";
            cbb_Unit.ValueMember = "id";

            dgv_Unit.Enabled = true;
            dgv_Unit.Rows.Clear();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_Unit.Rows.Add();
                    dgv_Unit.AllowUserToAddRows = false;

                    dgv_Unit.Rows[i].Cells[0].Value = (i + 1).ToString();
                    dgv_Unit.Rows[i].Cells[1].Value = dt.Rows[i]["id"].ToString();
                    dgv_Unit.Rows[i].Cells[2].Value = dt.Rows[i]["fullname"].ToString();
                    dgv_Unit.Rows[i].Cells[3].Value = dt.Rows[i]["description"].ToString();
                }
            }

            ChangeContextUnit(true);
            ChangeContextGroup(true);
        }

        public void RefreshForm()
        {
            txt_Fullname.Text = "";
            rtb_Description.Text = "";
        }

        public bool ValidateForm(bool hasCheckNotId = false)
        {
            if (txt_Fullname.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhóm", "Cảnh báo");
                txt_Fullname.Focus();
                return false;
            }
            if (txt_Fullname.Text.Length > 40)
            {
                MessageBox.Show("Chỉ được tối đa 40 kí tự", "Cảnh báo");
                txt_Fullname.Focus();
                return false;
            }

            string queryNotId = "";
            if (hasCheckNotId)
            {
                string id = lbl_SelectedId.Text;
                queryNotId = "and id <> \'" + id + "\'";
            }

            string query = "SELECT * FROM material.product_group where fullname = \'" + txt_Fullname.Text + "\' " + queryNotId;
            dt = ConnectionDatabase.GetData(query);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tên nhóm sản phẩm này đã có trong CSDL . Xin mời nhập lại", "Cảnh báo");
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
            string description = rtb_Description.Text;
            string id = lbl_SelectedId.Text;
            string unitId = cbb_Unit.SelectedValue.ToString();
            query = "UPDATE material.product_group " +
                "SET " +
                "fullname = \'" + fullName + "\' ," +
                "description = \'" + description + "\' ," +
                "unit_id = \'" + unitId + "\' " +
                "WHERE id = \'" + id + "\'";

            bool success = ConnectionDatabase.QueryData(query);
            if (success)
            {
                MessageBox.Show("Thay đổi thông tin nhóm sản phẩm thành công !!!", "Thông báo");

                InitialContext();

                RefreshForm();

                ChangeContextGroup(true);
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
                    dgv_Main.CurrentCell = dgv_Main.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv_Main.Rows[e.RowIndex].Selected = true;
                    dgv_Main.Focus();

                    selectedId = Convert.ToInt32(dgv_Main.Rows[e.RowIndex].Cells[1].Value);

                }
                catch (Exception)
                {

                }
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbl_SelectedId.Text = selectedId.ToString();

            string query = "SELECT pg.id , pg.fullname , pg.description , pu.fullname as fullname_unit , pu.id as id_unit FROM material.product_group as pg left join  material.product_unit as pu on pg.unit_id = pu.id where pg.id = \'" + selectedId + "\'";
            DataTable dt = ConnectionDatabase.GetData(query);

            if(dt.Rows.Count > 0)
            {
                txt_Fullname.Text = dt.Rows[0]["fullname"].ToString();
                rtb_Description.Text = dt.Rows[0]["description"].ToString();
                cbb_Unit.SelectedValue = (int)dt.Rows[0]["id_unit"];
            }

            ChangeContextGroup(false);
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            string query = "SELECT pg.id , pg.fullname , pg.description , pu.fullname as fullname_unit , pu.description as description_unit  FROM material.product_group as pg inner join  material.product_unit as pu on pg.unit_id = pu.id";
            dt = ConnectionDatabase.GetData(query);

            if (dt.Rows.Count > 0)
            {
                Common.ExportDatatableToExcel(dt , "nhom san pham");
            }
        }

        public bool ValidateForm_Unit(bool hasCheckNotId = false)
        {
            if (txt_Fullname_Unit.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đơn vị", "Cảnh báo");
                txt_Fullname.Focus();
                return false;
            }
            if (txt_Fullname_Unit.Text.Length > 40)
            {
                MessageBox.Show("Chỉ được tối đa 40 kí tự", "Cảnh báo");
                txt_Fullname.Focus();
                return false;
            }

            string queryNotId = "";
            if (hasCheckNotId)
            {
                string id = lbl_SelectedId_Unit.Text;
                queryNotId = "and id <> \'" + id + "\'";
            }

            string query = "SELECT * FROM material.product_unit where fullname = \'" + txt_Fullname_Unit.Text + "\' " + queryNotId;
            dt = ConnectionDatabase.GetData(query);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tên đơn vị này đã có trong CSDL . Xin mời nhập lại", "Cảnh báo");
                return false;
            }

            return true;
        }

        public void RefreshForm_Unit()
        {
            txt_Fullname_Unit.Text = "";
            rtb_Description_Unit.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateForm_Unit(true))
            {
                return;
            }

            string query = "";
            string fullName = txt_Fullname_Unit.Text;
            string description = rtb_Description_Unit.Text;
            string id = lbl_SelectedId_Unit.Text;
            query = "UPDATE material.product_unit " +
                "SET " +
                "fullname = \'" + fullName + "\' ," +
                "description = \'" + description + "\' " +
                "WHERE id = \'" + id + "\'";

            bool success = ConnectionDatabase.QueryData(query);
            if (success)
            {
                MessageBox.Show("Thay đổi thông tin đơn vị thành công !!!", "Thông báo");

                InitialContext();

                RefreshForm_Unit();
            }
        }

        private void dgv_Unit_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgv_Unit.CurrentCell = dgv_Unit.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv_Unit.Rows[e.RowIndex].Selected = true;
                    dgv_Unit.Focus();

                    selectedIdUnit = Convert.ToInt32(dgv_Unit.Rows[e.RowIndex].Cells[1].Value);

                }
                catch (Exception)
                {

                }
            }
        }

        private void dgv_Unit_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip2.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lbl_SelectedId_Unit.Text = selectedIdUnit.ToString();

            string query = "SELECT * FROM material.product_unit where id = \'" + selectedIdUnit + "\'";
            DataTable dt = ConnectionDatabase.GetData(query);

            if (dt.Rows.Count > 0)
            {
                txt_Fullname_Unit.Text = dt.Rows[0]["fullname"].ToString();
                rtb_Description_Unit.Text = dt.Rows[0]["description"].ToString();
            }

            ChangeContextUnit(false);
        }

        private void btn_Add_Group_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            string query = "";
            string fullName = txt_Fullname.Text;
            string description = rtb_Description.Text;
            string unitId = cbb_Unit.SelectedValue.ToString();

            query = "INSERT INTO material.product_group " +
                "(fullname,description,unit_id) VALUES " +
                "(" +
                "\'" + fullName + "\' , " +
                "\'" + description + "\' , " +
                "\'" + unitId + "\' " +
                ")";

            bool success = ConnectionDatabase.QueryData(query);
            if (success)
            {
                MessageBox.Show("Tạo mới thông tin nhóm sản phẩm thành công !!!", "Thông báo");

                InitialContext();

                RefreshForm();
            }
        }

        private void btn_Add_Unit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm_Unit())
            {
                return;
            }

            string query = "";
            string fullName = txt_Fullname_Unit.Text;
            string description = rtb_Description_Unit.Text;

            query = "INSERT INTO material.product_unit " +
                "(fullname,description) VALUES " +
                "(" +
                "\'" + fullName + "\' , " +
                "\'" + description + "\' " +
                ")";

            bool success = ConnectionDatabase.QueryData(query);
            if (success)
            {
                MessageBox.Show("Tạo mới thông tin đơn vị sản phẩm thành công !!!", "Thông báo");

                InitialContext();

                RefreshForm_Unit();
            }
        }

        private void ChangeContextUnit(bool status)
        {
            btn_Add_Unit.Visible = status;
            btn_Change_Unit.Visible = !status;

            grb_Option_Unit.Text = status ? "Thêm mới đơn vị" : "Sửa thông tin đơn vị";

            btn_Return_Unit.Visible = !status;
        }

        private void ChangeContextGroup(bool status)
        {
            btn_Add_Group.Visible = status;
            btn_Change.Visible = !status;

            grb_Option_Group.Text = status ? "Thêm mới nhóm sản phẩm" : "Sửa thông tin nhóm sản phẩm";

            btn_Return_Group.Visible = !status;
        }

        private void btn_Change_Unit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm_Unit(true))
            {
                return;
            }

            string query = "";
            string fullName = txt_Fullname_Unit.Text;
            string description = rtb_Description_Unit.Text;
            string id = lbl_SelectedId_Unit.Text;
            query = "UPDATE material.product_unit " +
                "SET " +
                "fullname = \'" + fullName + "\' ," +
                "description = \'" + description + "\' " +
                "WHERE id = \'" + id + "\'";

            bool success = ConnectionDatabase.QueryData(query);
            if (success)
            {
                MessageBox.Show("Thay đổi thông tin đơn vị thành công !!!", "Thông báo");

                InitialContext();

                RefreshForm_Unit();

                ChangeContextUnit(true);
            }
        }

        private void btn_Return_Unit_Click(object sender, EventArgs e)
        {
            RefreshForm_Unit();

            ChangeContextUnit(true);

        }

        private void btn_Return_Group_Click(object sender, EventArgs e)
        {
            RefreshForm();

            ChangeContextGroup(true);
        }
    }
}
