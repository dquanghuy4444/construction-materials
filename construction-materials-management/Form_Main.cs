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
    public partial class Form_Main : Form
    {
        public string userId;
        public enum ENUM_TABPAGE
        {
            LIST_PRODUCTS = 1,
            LIST_SUPPLIER = 2,
        }
        public Form_Main(string id)
        {
            InitializeComponent();

            userId = id;

            InitialFormInPanel();

        }

        public void InitialFormInPanel()
        {
            Form_Dashboard formDashboard = new Form_Dashboard(this);
            formDashboard.TopLevel = false;
            formDashboard.AutoScroll = true;
            this.panel_Dashboard.Controls.Add(formDashboard);
            formDashboard.Show();  
            
            Form_Supplier formSupplier = new Form_Supplier(this);
            formSupplier.TopLevel = false;
            formSupplier.AutoScroll = true;
            this.panel_Supplier.Controls.Add(formSupplier);
            formSupplier.Show();
        }

        public void ChangeTabPage(int indexTabPage)
        {
            this.tabC_Main.SelectedIndex = indexTabPage;
        }
    }
}
