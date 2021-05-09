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
            LIST_SUPPLIERS = 1,
            LIST_CUSTOMERS = 2,
            LIST_PRODUCTS = 3,
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
            
            Form_Customer formCustomer = new Form_Customer(this);
            formCustomer.TopLevel = false;
            formCustomer.AutoScroll = true;
            this.panel_Customer.Controls.Add(formCustomer);
            formCustomer.Show(); 
            
            Form_Product formProduct = new Form_Product(this);
            formProduct.TopLevel = false;
            formProduct.AutoScroll = true;
            this.panel_Product.Controls.Add(formProduct);
            formProduct.Show();
        }

        public void ChangeTabPage(int indexTabPage)
        {
            this.tabC_Main.SelectedIndex = indexTabPage;
        }
    }
}
