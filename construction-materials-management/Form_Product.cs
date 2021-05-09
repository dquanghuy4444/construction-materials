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
    public partial class Form_Product : Form
    {
        public Form formMain;
        public DataTable dt;

        public int selectedId;

        public Form_Product(Form frmMain)
        {
            InitializeComponent();

            formMain = frmMain;

            InitialFormInPanel();
        }

        public void InitialFormInPanel()
        {
            Form_Product_Detail formProductDetail = new Form_Product_Detail(this);
            formProductDetail.Name = "form1";
            formProductDetail.TopLevel = false;
            formProductDetail.AutoScroll = true;
            this.panel_Product_Detail.Controls.Add(formProductDetail);
            formProductDetail.Show();
                        
            Form_Product_Group formProductGroup = new Form_Product_Group(this);
            formProductGroup.Name = "form2";
            formProductGroup.TopLevel = false;
            formProductGroup.AutoScroll = true;
            this.panel_Product_Group.Controls.Add(formProductGroup);
            formProductGroup.Show();

        }


        public void ChangeTabPage(int indexTabPage)
        {
            this.tabC_Main.SelectedIndex = indexTabPage;
        }

        private void tabC_Main_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabC_Main.SelectedIndex == 0)
            {
                Form_Product_Detail find = (Form_Product_Detail)this.panel_Product_Detail.Controls.Find("form1", true).FirstOrDefault();
                if (find != null)
                {
                    find.InitialContext();
                }
            }
            else
            {
                Form_Product_Group find = (Form_Product_Group)this.panel_Product_Group.Controls.Find("form2", true).FirstOrDefault();
                if (find != null)
                {
                    find.InitialContext();
                }
            }
        }
    }
}
