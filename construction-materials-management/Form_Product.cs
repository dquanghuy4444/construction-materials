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
            formProductDetail.TopLevel = false;
            formProductDetail.AutoScroll = true;
            this.panel_Product_Detail.Controls.Add(formProductDetail);
            formProductDetail.Show();
                        
            Form_Product_Group formProductGroup = new Form_Product_Group(this);
            formProductGroup.TopLevel = false;
            formProductGroup.AutoScroll = true;
            this.panel_Product_Group.Controls.Add(formProductGroup);
            formProductGroup.Show();

        }
    }
}
