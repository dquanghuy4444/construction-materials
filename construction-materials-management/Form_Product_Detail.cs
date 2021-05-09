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
    public partial class Form_Product_Detail : Form
    {
        public Form formMain;
        public DataTable dt;

        public string selectedId;

        public Form_Product_Detail(Form frmMain)
        {
            InitializeComponent();

            formMain = frmMain;

            InitialContext();

            ChangeContext(true);
        }

        public void InitialContext()
        {
            string query = "SELECT * FROM material.product";
            DataTable dtProduct = ConnectionDatabase.GetData(query);
            
            query = "SELECT * FROM material.product_group";
            DataTable dtPrpductGroup = ConnectionDatabase.GetData(query);

            treeV_Main.Nodes.Clear();
            
            for(int i = 0 ; i < dtPrpductGroup.Rows.Count ; i++)
            {
                treeV_Main.Nodes.Add(dtPrpductGroup.Rows[i]["fullname"].ToString());

                for (int j = 0; j < dtProduct.Rows.Count; j++)
                {
                    if (dtPrpductGroup.Rows[i]["id"].ToString() == dtProduct.Rows[j]["group_id"].ToString())
                    {
                        TreeNode tNode = new TreeNode(dtProduct.Rows[j]["fullname"].ToString());
                        tNode.Tag = dtProduct.Rows[j]["id"].ToString();
                        treeV_Main.Nodes[i].Nodes.Add(tNode);
                    }
                }
            }

            query = "SELECT * FROM material.product_group";
            dt = ConnectionDatabase.GetData(query);
            cbb_Group.DataSource = dt;
            cbb_Group.DisplayMember = "fullname";
            cbb_Group.ValueMember = "id";
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
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Cảnh báo");
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
                if(selectedId == "")
                {
                    return true;
                }

                queryNotId = "and id <> \'" + selectedId + "\'";
            }

            string query = "SELECT * FROM material.product where fullname = \'" + txt_Fullname.Text + "\' " + queryNotId;
            dt = ConnectionDatabase.GetData(query);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tên sản phẩm này đã có trong CSDL . Xin mời nhập lại", "Cảnh báo");
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
            string groupId = cbb_Group.SelectedValue.ToString();

            query = "UPDATE material.product " +
                "SET " +
                "fullname = \'" + fullName + "\' ," +
                "group_id = \'" + groupId + "\' ," +
                "description = \'" + description + "\' " +
                "WHERE id = \'" + selectedId + "\'";

            bool success = ConnectionDatabase.QueryData(query);
            if (success)
            {
                MessageBox.Show("Thay đổi thông tin sản phẩm thành công !!!", "Thông báo");

                InitialContext();

                RefreshForm();

            }
        }
        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {

            string query = "select p.id , p.fullname , p.description , pg.id as id_group ,  pg.fullname as fullname_group , pu.fullname as fullname_unit ,  pg.description as description_group from material.product as p left join material.product_group as pg on p.group_id = pg.id left join material.product_unit as pu on pg.unit_id = pu.id";
            dt = ConnectionDatabase.GetData(query);

            if (dt.Rows.Count > 0)
            {
                Common.ExportDatatableToExcel(dt, "san pham");
            }
        }


        private void treeV_Main_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Level == 1)
            {
                var node = e.Node;
                selectedId = node.Tag.ToString();

                if(selectedId == "")
                {
                    return;
                }

                string query = "SELECT * FROM material.product where id = \' " + selectedId + "\'";
                DataTable dtProduct = ConnectionDatabase.GetData(query);


                if (dtProduct.Rows.Count > 0)
                {
                    txt_Fullname.Text = dtProduct.Rows[0]["fullname"].ToString();
                    rtb_Description.Text = dtProduct.Rows[0]["description"].ToString();
                    cbb_Group.SelectedValue = (int)dtProduct.Rows[0]["group_id"];
                }

                ChangeContext(false);
            }
        }

        private void ChangeContext(bool status)
        {
            btn_Add.Visible = status;
            btn_Change.Visible = !status;

            grb_Option.Text = status ? "Thêm mới sản phẩm" : "Sửa thông tin sản phẩm";

            btn_Return.Visible = !status;

            if (status)
            {
                selectedId = "";
                RefreshForm();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            string query = "";
            string fullName = txt_Fullname.Text;
            string description = rtb_Description.Text;
            string groupId = cbb_Group.SelectedValue.ToString();

            query = "INSERT INTO material.product " +
                "(fullname,description,group_id) VALUES " +
                "(" +
                "\'" + fullName + "\' , " +
                "\'" + description + "\' , " +
                "\'" + groupId + "\' " +
                ")";

            bool success = ConnectionDatabase.QueryData(query);
            if (success)
            {
                MessageBox.Show("Tạo mới thông tin sản phẩm thành công !!!", "Thông báo");

                InitialContext();

                RefreshForm();
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            ChangeContext(true);
        }
    }
}
