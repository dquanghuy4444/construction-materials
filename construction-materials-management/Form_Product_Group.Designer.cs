
namespace construction_materials_management
{
    partial class Form_Product_Group
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
            this.dgv_Main = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_Option_Group = new System.Windows.Forms.GroupBox();
            this.btn_Return_Group = new System.Windows.Forms.Button();
            this.btn_Add_Group = new System.Windows.Forms.Button();
            this.cbb_Unit = new System.Windows.Forms.ComboBox();
            this.lbl_SelectedId = new System.Windows.Forms.Label();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Fullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ExportExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grb_Option_Unit = new System.Windows.Forms.GroupBox();
            this.btn_Return_Unit = new System.Windows.Forms.Button();
            this.btn_Add_Unit = new System.Windows.Forms.Button();
            this.lbl_SelectedId_Unit = new System.Windows.Forms.Label();
            this.rtb_Description_Unit = new System.Windows.Forms.RichTextBox();
            this.btn_Change_Unit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Fullname_Unit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_Unit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).BeginInit();
            this.grb_Option_Group.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grb_Option_Unit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Unit)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Main
            // 
            this.dgv_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgv_Main.Location = new System.Drawing.Point(0, 0);
            this.dgv_Main.MultiSelect = false;
            this.dgv_Main.Name = "dgv_Main";
            this.dgv_Main.ReadOnly = true;
            this.dgv_Main.RowHeadersWidth = 51;
            this.dgv_Main.RowTemplate.Height = 24;
            this.dgv_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Main.Size = new System.Drawing.Size(963, 409);
            this.dgv_Main.TabIndex = 0;
            this.dgv_Main.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Suppliers_CellMouseDown);
            this.dgv_Main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Suppliers_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên nhóm sản phẩm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đơn vị";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Chi tiết";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // grb_Option_Group
            // 
            this.grb_Option_Group.Controls.Add(this.btn_Return_Group);
            this.grb_Option_Group.Controls.Add(this.btn_Add_Group);
            this.grb_Option_Group.Controls.Add(this.cbb_Unit);
            this.grb_Option_Group.Controls.Add(this.lbl_SelectedId);
            this.grb_Option_Group.Controls.Add(this.rtb_Description);
            this.grb_Option_Group.Controls.Add(this.btn_Change);
            this.grb_Option_Group.Controls.Add(this.label5);
            this.grb_Option_Group.Controls.Add(this.label4);
            this.grb_Option_Group.Controls.Add(this.txt_Fullname);
            this.grb_Option_Group.Controls.Add(this.label1);
            this.grb_Option_Group.Location = new System.Drawing.Point(969, 12);
            this.grb_Option_Group.Name = "grb_Option_Group";
            this.grb_Option_Group.Size = new System.Drawing.Size(478, 316);
            this.grb_Option_Group.TabIndex = 1;
            this.grb_Option_Group.TabStop = false;
            this.grb_Option_Group.Text = "Thay đổi thông tin nhóm sản phẩm";
            // 
            // btn_Return_Group
            // 
            this.btn_Return_Group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Return_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return_Group.Location = new System.Drawing.Point(188, 254);
            this.btn_Return_Group.Name = "btn_Return_Group";
            this.btn_Return_Group.Size = new System.Drawing.Size(150, 56);
            this.btn_Return_Group.TabIndex = 21;
            this.btn_Return_Group.Text = "Trở lại";
            this.btn_Return_Group.UseVisualStyleBackColor = false;
            this.btn_Return_Group.Click += new System.EventHandler(this.btn_Return_Group_Click);
            // 
            // btn_Add_Group
            // 
            this.btn_Add_Group.BackColor = System.Drawing.Color.Lime;
            this.btn_Add_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Group.Location = new System.Drawing.Point(20, 253);
            this.btn_Add_Group.Name = "btn_Add_Group";
            this.btn_Add_Group.Size = new System.Drawing.Size(150, 56);
            this.btn_Add_Group.TabIndex = 20;
            this.btn_Add_Group.Text = "Thêm mới";
            this.btn_Add_Group.UseVisualStyleBackColor = false;
            this.btn_Add_Group.Click += new System.EventHandler(this.btn_Add_Group_Click);
            // 
            // cbb_Unit
            // 
            this.cbb_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Unit.Location = new System.Drawing.Point(164, 67);
            this.cbb_Unit.Name = "cbb_Unit";
            this.cbb_Unit.Size = new System.Drawing.Size(280, 24);
            this.cbb_Unit.TabIndex = 19;
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
            this.rtb_Description.Location = new System.Drawing.Point(164, 105);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(280, 114);
            this.rtb_Description.TabIndex = 10;
            this.rtb_Description.Text = "";
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.Location = new System.Drawing.Point(20, 253);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(150, 56);
            this.btn_Change.TabIndex = 16;
            this.btn_Change.Text = "Thay đổi";
            this.btn_Change.UseVisualStyleBackColor = false;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn vị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chi tiết";
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.Location = new System.Drawing.Point(164, 25);
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.Size = new System.Drawing.Size(280, 22);
            this.txt_Fullname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm sản phẩm";
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
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.ToolStripMenuItem1.Text = "Sửa thông tin";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportExcel.Location = new System.Drawing.Point(969, 353);
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.Size = new System.Drawing.Size(150, 56);
            this.btn_ExportExcel.TabIndex = 18;
            this.btn_ExportExcel.Text = "Xuất File Excel";
            this.btn_ExportExcel.UseVisualStyleBackColor = false;
            this.btn_ExportExcel.Click += new System.EventHandler(this.btn_ExportExcel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grb_Option_Unit);
            this.groupBox1.Controls.Add(this.dgv_Unit);
            this.groupBox1.Location = new System.Drawing.Point(0, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1447, 298);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí đơn vị sản phẩm";
            // 
            // grb_Option_Unit
            // 
            this.grb_Option_Unit.Controls.Add(this.btn_Return_Unit);
            this.grb_Option_Unit.Controls.Add(this.btn_Add_Unit);
            this.grb_Option_Unit.Controls.Add(this.lbl_SelectedId_Unit);
            this.grb_Option_Unit.Controls.Add(this.rtb_Description_Unit);
            this.grb_Option_Unit.Controls.Add(this.btn_Change_Unit);
            this.grb_Option_Unit.Controls.Add(this.label6);
            this.grb_Option_Unit.Controls.Add(this.txt_Fullname_Unit);
            this.grb_Option_Unit.Controls.Add(this.label7);
            this.grb_Option_Unit.Location = new System.Drawing.Point(969, 21);
            this.grb_Option_Unit.Name = "grb_Option_Unit";
            this.grb_Option_Unit.Size = new System.Drawing.Size(478, 250);
            this.grb_Option_Unit.TabIndex = 2;
            this.grb_Option_Unit.TabStop = false;
            this.grb_Option_Unit.Text = "Thay đổi thông tin đơn vị";
            // 
            // btn_Return_Unit
            // 
            this.btn_Return_Unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Return_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return_Unit.Location = new System.Drawing.Point(188, 187);
            this.btn_Return_Unit.Name = "btn_Return_Unit";
            this.btn_Return_Unit.Size = new System.Drawing.Size(150, 56);
            this.btn_Return_Unit.TabIndex = 22;
            this.btn_Return_Unit.Text = "Trở lại";
            this.btn_Return_Unit.UseVisualStyleBackColor = false;
            this.btn_Return_Unit.Click += new System.EventHandler(this.btn_Return_Unit_Click);
            // 
            // btn_Add_Unit
            // 
            this.btn_Add_Unit.BackColor = System.Drawing.Color.Lime;
            this.btn_Add_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Unit.Location = new System.Drawing.Point(20, 188);
            this.btn_Add_Unit.Name = "btn_Add_Unit";
            this.btn_Add_Unit.Size = new System.Drawing.Size(150, 56);
            this.btn_Add_Unit.TabIndex = 21;
            this.btn_Add_Unit.Text = "Thêm mới";
            this.btn_Add_Unit.UseVisualStyleBackColor = false;
            this.btn_Add_Unit.Click += new System.EventHandler(this.btn_Add_Unit_Click);
            // 
            // lbl_SelectedId_Unit
            // 
            this.lbl_SelectedId_Unit.AutoSize = true;
            this.lbl_SelectedId_Unit.Location = new System.Drawing.Point(418, -3);
            this.lbl_SelectedId_Unit.Name = "lbl_SelectedId_Unit";
            this.lbl_SelectedId_Unit.Size = new System.Drawing.Size(26, 17);
            this.lbl_SelectedId_Unit.TabIndex = 18;
            this.lbl_SelectedId_Unit.Text = "xxx";
            this.lbl_SelectedId_Unit.Visible = false;
            // 
            // rtb_Description_Unit
            // 
            this.rtb_Description_Unit.Location = new System.Drawing.Point(164, 63);
            this.rtb_Description_Unit.Name = "rtb_Description_Unit";
            this.rtb_Description_Unit.Size = new System.Drawing.Size(280, 114);
            this.rtb_Description_Unit.TabIndex = 10;
            this.rtb_Description_Unit.Text = "";
            // 
            // btn_Change_Unit
            // 
            this.btn_Change_Unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Change_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change_Unit.Location = new System.Drawing.Point(20, 187);
            this.btn_Change_Unit.Name = "btn_Change_Unit";
            this.btn_Change_Unit.Size = new System.Drawing.Size(150, 56);
            this.btn_Change_Unit.TabIndex = 16;
            this.btn_Change_Unit.Text = "Thay đổi";
            this.btn_Change_Unit.UseVisualStyleBackColor = false;
            this.btn_Change_Unit.Click += new System.EventHandler(this.btn_Change_Unit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chi tiết";
            // 
            // txt_Fullname_Unit
            // 
            this.txt_Fullname_Unit.Location = new System.Drawing.Point(164, 25);
            this.txt_Fullname_Unit.Name = "txt_Fullname_Unit";
            this.txt_Fullname_Unit.Size = new System.Drawing.Size(280, 22);
            this.txt_Fullname_Unit.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên đơn vị sản phẩm";
            // 
            // dgv_Unit
            // 
            this.dgv_Unit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Unit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.dgv_Unit.Location = new System.Drawing.Point(6, 21);
            this.dgv_Unit.MultiSelect = false;
            this.dgv_Unit.Name = "dgv_Unit";
            this.dgv_Unit.ReadOnly = true;
            this.dgv_Unit.RowHeadersWidth = 51;
            this.dgv_Unit.RowTemplate.Height = 24;
            this.dgv_Unit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Unit.Size = new System.Drawing.Size(957, 250);
            this.dgv_Unit.TabIndex = 1;
            this.dgv_Unit.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Unit_CellMouseDown);
            this.dgv_Unit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Unit_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên đơn vị";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Chi tiết";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(168, 28);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 24);
            this.toolStripMenuItem2.Text = "Sửa thông tin";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form_Product_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1481, 734);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ExportExcel);
            this.Controls.Add(this.grb_Option_Group);
            this.Controls.Add(this.dgv_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Product_Group";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).EndInit();
            this.grb_Option_Group.ResumeLayout(false);
            this.grb_Option_Group.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grb_Option_Unit.ResumeLayout(false);
            this.grb_Option_Unit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Unit)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Main;
        private System.Windows.Forms.GroupBox grb_Option_Group;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Fullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_SelectedId;
        private System.Windows.Forms.Button btn_ExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbb_Unit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grb_Option_Unit;
        private System.Windows.Forms.Label lbl_SelectedId_Unit;
        private System.Windows.Forms.RichTextBox rtb_Description_Unit;
        private System.Windows.Forms.Button btn_Change_Unit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Fullname_Unit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btn_Add_Group;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Add_Unit;
        private System.Windows.Forms.Button btn_Return_Group;
        private System.Windows.Forms.Button btn_Return_Unit;
    }
}