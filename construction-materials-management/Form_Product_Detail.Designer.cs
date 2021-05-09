
namespace construction_materials_management
{
    partial class Form_Product_Detail
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
            this.grb_Option = new System.Windows.Forms.GroupBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cbb_Group = new System.Windows.Forms.ComboBox();
            this.lbl_SelectedId = new System.Windows.Forms.Label();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Fullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ExportExcel = new System.Windows.Forms.Button();
            this.treeV_Main = new System.Windows.Forms.TreeView();
            this.grb_Option.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Option
            // 
            this.grb_Option.Controls.Add(this.btn_Return);
            this.grb_Option.Controls.Add(this.btn_Add);
            this.grb_Option.Controls.Add(this.cbb_Group);
            this.grb_Option.Controls.Add(this.lbl_SelectedId);
            this.grb_Option.Controls.Add(this.rtb_Description);
            this.grb_Option.Controls.Add(this.btn_Change);
            this.grb_Option.Controls.Add(this.label4);
            this.grb_Option.Controls.Add(this.label2);
            this.grb_Option.Controls.Add(this.txt_Fullname);
            this.grb_Option.Controls.Add(this.label1);
            this.grb_Option.Location = new System.Drawing.Point(341, 12);
            this.grb_Option.Name = "grb_Option";
            this.grb_Option.Size = new System.Drawing.Size(478, 313);
            this.grb_Option.TabIndex = 1;
            this.grb_Option.TabStop = false;
            this.grb_Option.Text = "Thay đổi thông tin khách hàng";
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(188, 246);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(150, 56);
            this.btn_Return.TabIndex = 23;
            this.btn_Return.Text = "Trở lại";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Lime;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(20, 246);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 56);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "Thêm mới";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cbb_Group
            // 
            this.cbb_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Group.FormattingEnabled = true;
            this.cbb_Group.Location = new System.Drawing.Point(136, 62);
            this.cbb_Group.Name = "cbb_Group";
            this.cbb_Group.Size = new System.Drawing.Size(308, 24);
            this.cbb_Group.TabIndex = 21;
            // 
            // lbl_SelectedId
            // 
            this.lbl_SelectedId.AutoSize = true;
            this.lbl_SelectedId.Location = new System.Drawing.Point(418, -3);
            this.lbl_SelectedId.Name = "lbl_SelectedId";
            this.lbl_SelectedId.Size = new System.Drawing.Size(26, 17);
            this.lbl_SelectedId.TabIndex = 18;
            this.lbl_SelectedId.Text = "xxx";
            this.lbl_SelectedId.Visible = false;
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(136, 102);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(308, 114);
            this.rtb_Description.TabIndex = 10;
            this.rtb_Description.Text = "";
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.Location = new System.Drawing.Point(20, 245);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(150, 56);
            this.btn_Change.TabIndex = 16;
            this.btn_Change.Text = "Thay đổi";
            this.btn_Change.UseVisualStyleBackColor = false;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhóm sản phẩm";
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.Location = new System.Drawing.Point(136, 25);
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.Size = new System.Drawing.Size(308, 22);
            this.txt_Fullname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm";
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportExcel.Location = new System.Drawing.Point(341, 633);
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.Size = new System.Drawing.Size(150, 56);
            this.btn_ExportExcel.TabIndex = 18;
            this.btn_ExportExcel.Text = "Xuất File Excel";
            this.btn_ExportExcel.UseVisualStyleBackColor = false;
            this.btn_ExportExcel.Click += new System.EventHandler(this.btn_ExportExcel_Click);
            // 
            // treeV_Main
            // 
            this.treeV_Main.Location = new System.Drawing.Point(0, 0);
            this.treeV_Main.Name = "treeV_Main";
            this.treeV_Main.Size = new System.Drawing.Size(319, 689);
            this.treeV_Main.TabIndex = 20;
            this.treeV_Main.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeV_Main_NodeMouseClick);
            // 
            // Form_Product_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1473, 701);
            this.Controls.Add(this.treeV_Main);
            this.Controls.Add(this.btn_ExportExcel);
            this.Controls.Add(this.grb_Option);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Product_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Supplier";
            this.grb_Option.ResumeLayout(false);
            this.grb_Option.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_Option;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Fullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Label lbl_SelectedId;
        private System.Windows.Forms.Button btn_ExportExcel;
        private System.Windows.Forms.TreeView treeV_Main;
        private System.Windows.Forms.ComboBox cbb_Group;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Add;
    }
}