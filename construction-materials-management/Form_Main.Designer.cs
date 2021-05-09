
namespace construction_materials_management
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabC_Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_Dashboard = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel_Supplier = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel_Customer = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_Product = new System.Windows.Forms.Panel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel_Repository = new System.Windows.Forms.Panel();
            this.tabC_Main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabC_Main
            // 
            this.tabC_Main.Controls.Add(this.tabPage1);
            this.tabC_Main.Controls.Add(this.tabPage3);
            this.tabC_Main.Controls.Add(this.tabPage4);
            this.tabC_Main.Controls.Add(this.tabPage2);
            this.tabC_Main.Controls.Add(this.tabPage6);
            this.tabC_Main.Controls.Add(this.tabPage5);
            this.tabC_Main.Location = new System.Drawing.Point(0, 0);
            this.tabC_Main.Name = "tabC_Main";
            this.tabC_Main.SelectedIndex = 0;
            this.tabC_Main.Size = new System.Drawing.Size(1485, 757);
            this.tabC_Main.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_Dashboard);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1477, 728);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Quản trị";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_Dashboard
            // 
            this.panel_Dashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.panel_Dashboard.Name = "panel_Dashboard";
            this.panel_Dashboard.Size = new System.Drawing.Size(1481, 734);
            this.panel_Dashboard.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel_Supplier);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1477, 728);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhà cung cấp";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel_Supplier
            // 
            this.panel_Supplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Supplier.Location = new System.Drawing.Point(0, 0);
            this.panel_Supplier.Name = "panel_Supplier";
            this.panel_Supplier.Size = new System.Drawing.Size(1477, 728);
            this.panel_Supplier.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel_Customer);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1477, 728);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Khách hàng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel_Customer
            // 
            this.panel_Customer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Customer.Location = new System.Drawing.Point(0, 0);
            this.panel_Customer.Name = "panel_Customer";
            this.panel_Customer.Size = new System.Drawing.Size(1481, 734);
            this.panel_Customer.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_Product);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1477, 728);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_Product
            // 
            this.panel_Product.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Product.Location = new System.Drawing.Point(0, 0);
            this.panel_Product.Name = "panel_Product";
            this.panel_Product.Size = new System.Drawing.Size(1481, 734);
            this.panel_Product.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1477, 728);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Giới thiệu công ty";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 728);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1477, 728);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.fico.com.vn/", System.UriKind.Absolute);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.panel_Repository);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1477, 728);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "Kho hàng";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel_Repository
            // 
            this.panel_Repository.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Repository.Location = new System.Drawing.Point(0, 0);
            this.panel_Repository.Name = "panel_Repository";
            this.panel_Repository.Size = new System.Drawing.Size(1481, 734);
            this.panel_Repository.TabIndex = 3;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1486, 759);
            this.Controls.Add(this.tabC_Main);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.Text = "Phần mềm quản trị vật liệu xây dựng";
            this.tabC_Main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabC_Main;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel_Dashboard;
        private System.Windows.Forms.Panel panel_Supplier;
        private System.Windows.Forms.Panel panel_Customer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel_Product;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel panel_Repository;
    }
}