
namespace construction_materials_management
{
    partial class Form_Product
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
            this.components = new System.ComponentModel.Container();
            this.tabC_Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_Product_Detail = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_ProductGroups = new System.Windows.Forms.Panel();
            this.panel_Product_Group = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabC_Main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_ProductGroups.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabC_Main
            // 
            this.tabC_Main.AllowDrop = true;
            this.tabC_Main.Controls.Add(this.tabPage1);
            this.tabC_Main.Controls.Add(this.tabPage2);
            this.tabC_Main.Location = new System.Drawing.Point(0, 0);
            this.tabC_Main.Name = "tabC_Main";
            this.tabC_Main.SelectedIndex = 0;
            this.tabC_Main.Size = new System.Drawing.Size(1481, 730);
            this.tabC_Main.TabIndex = 21;
            this.tabC_Main.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabC_Main_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_Product_Detail);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1473, 701);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_Product_Detail
            // 
            this.panel_Product_Detail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_Product_Detail.Location = new System.Drawing.Point(0, 0);
            this.panel_Product_Detail.Name = "panel_Product_Detail";
            this.panel_Product_Detail.Size = new System.Drawing.Size(1473, 701);
            this.panel_Product_Detail.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_ProductGroups);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1473, 701);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhóm sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_ProductGroups
            // 
            this.panel_ProductGroups.Controls.Add(this.panel_Product_Group);
            this.panel_ProductGroups.Location = new System.Drawing.Point(0, 0);
            this.panel_ProductGroups.Name = "panel_ProductGroups";
            this.panel_ProductGroups.Size = new System.Drawing.Size(1473, 701);
            this.panel_ProductGroups.TabIndex = 1;
            // 
            // panel_Product_Group
            // 
            this.panel_Product_Group.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_Product_Group.Location = new System.Drawing.Point(0, 0);
            this.panel_Product_Group.Name = "panel_Product_Group";
            this.panel_Product_Group.Size = new System.Drawing.Size(1473, 701);
            this.panel_Product_Group.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 28);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(167, 24);
            this.ToolStripMenuItem1.Text = "Sửa thông tin";
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1481, 734);
            this.Controls.Add(this.tabC_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Supplier";
            this.tabC_Main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel_ProductGroups.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabC_Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel_Product_Detail;
        private System.Windows.Forms.Panel panel_ProductGroups;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.Panel panel_Product_Group;
    }
}