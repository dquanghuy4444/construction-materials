
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
            this.tabC_Main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabC_Main
            // 
            this.tabC_Main.Controls.Add(this.tabPage1);
            this.tabC_Main.Controls.Add(this.tabPage3);
            this.tabC_Main.Controls.Add(this.tabPage4);
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
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1477, 728);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kho";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabC_Main;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel_Dashboard;
        private System.Windows.Forms.Panel panel_Supplier;
    }
}