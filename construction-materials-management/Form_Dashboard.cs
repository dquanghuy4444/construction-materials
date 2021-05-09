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
    public partial class Form_Dashboard : Form
    {
        public Form_Main formMain;

        public string fullName = "Đặng Quang Huy";

        public DataRow dr;

        public Form_Dashboard(Form_Main frmMain)
        {
            InitializeComponent();

            formMain = frmMain;

            InitialData();

            InitialContext();
        }

        public void InitialData()
        {
            if(formMain.userId != "")
            {
                string query = "SELECT * FROM material.user where id = \'" + formMain.userId + "\'";

                DataTable dt = ConnectionDatabase.GetData(query);

                if(dt.Rows.Count > 0)
                {
                    dr = dt.Rows[0];
                }
            }

        }
        public void InitialContext()
        {
            label_Welcome.Text = "Xin chào , " + dr["fullname"];
        }

        private void btn_ShowInfor_Click(object sender, EventArgs e)
        {
            Form_UserInfor formUserInfor = new Form_UserInfor(this);
            formUserInfor.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            formMain.Hide();
            Form_Login formLogin = new Form_Login();
            formLogin.Show();
        }

        private void btn_ShowListSuppliers_Click(object sender, EventArgs e)
        {
            formMain.ChangeTabPage((int)Form_Main.ENUM_TABPAGE.LIST_SUPPLIERS);
        }

        private void btn_ShowListCustomers_Click(object sender, EventArgs e)
        {
            formMain.ChangeTabPage((int)Form_Main.ENUM_TABPAGE.LIST_CUSTOMERS);
        }

        private void btn_ShowProducts_Click(object sender, EventArgs e)
        {
            formMain.ChangeTabPage((int)Form_Main.ENUM_TABPAGE.LIST_PRODUCTS);
        }
    }
}
