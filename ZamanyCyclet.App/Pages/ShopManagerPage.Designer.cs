namespace ZamanyCyclet.App.Pages
{
    partial class ShopManagerPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnCreateShop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnEditShop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.datagridShops = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridShops)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolBtnCreateShop,
            this.toolStripSeparator2,
            this.toolBtnEditShop,
            this.toolStripSeparator3});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(933, 78);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(20, 1, 30, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 65);
            this.toolStripLabel1.Text = "مدیریت شعبه ها";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // toolBtnCreateShop
            // 
            this.toolBtnCreateShop.AutoSize = false;
            this.toolBtnCreateShop.Image = global::ZamanyCyclet.App.Properties.Resources.exterior_80px;
            this.toolBtnCreateShop.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolBtnCreateShop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnCreateShop.Name = "toolBtnCreateShop";
            this.toolBtnCreateShop.Size = new System.Drawing.Size(55, 65);
            this.toolBtnCreateShop.Text = "شعبه جدید";
            this.toolBtnCreateShop.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolBtnCreateShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // toolBtnEditShop
            // 
            this.toolBtnEditShop.AutoSize = false;
            this.toolBtnEditShop.Image = global::ZamanyCyclet.App.Properties.Resources.ball_point_pen_80px;
            this.toolBtnEditShop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEditShop.Name = "toolBtnEditShop";
            this.toolBtnEditShop.Size = new System.Drawing.Size(55, 65);
            this.toolBtnEditShop.Text = "ویرایش";
            this.toolBtnEditShop.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolBtnEditShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 48);
            // 
            // datagridShops
            // 
            this.datagridShops.AllowUserToAddRows = false;
            this.datagridShops.AllowUserToDeleteRows = false;
            this.datagridShops.AllowUserToOrderColumns = true;
            this.datagridShops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridShops.BackgroundColor = System.Drawing.SystemColors.Info;
            this.datagridShops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridShops.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridShops.ColumnHeadersHeight = 35;
            this.datagridShops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Code,
            this.NameA,
            this.Description,
            this.PhoneNumber,
            this.Address,
            this.PostalCode,
            this.CreatedAt,
            this.UpdatedAt});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridShops.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagridShops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridShops.GridColor = System.Drawing.SystemColors.Control;
            this.datagridShops.Location = new System.Drawing.Point(0, 78);
            this.datagridShops.MultiSelect = false;
            this.datagridShops.Name = "datagridShops";
            this.datagridShops.ReadOnly = true;
            this.datagridShops.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagridShops.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.datagridShops.RowHeadersWidth = 40;
            this.datagridShops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridShops.Size = new System.Drawing.Size(933, 730);
            this.datagridShops.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 47.44983F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.FillWeight = 80F;
            this.Code.HeaderText = "کد شعبه";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // NameA
            // 
            this.NameA.DataPropertyName = "Name";
            this.NameA.FillWeight = 74.15133F;
            this.NameA.HeaderText = "اسم شعبه";
            this.NameA.Name = "NameA";
            this.NameA.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "شماره تماس";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 74.15133F;
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // PostalCode
            // 
            this.PostalCode.DataPropertyName = "PostalCode";
            this.PostalCode.FillWeight = 74.15133F;
            this.PostalCode.HeaderText = "کد پستی";
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.FillWeight = 74.15133F;
            this.CreatedAt.HeaderText = "تاریخ ثبت";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            this.UpdatedAt.HeaderText = "آخرین ویرایش";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;
            // 
            // ShopManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.datagridShops);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ShopManagerPage";
            this.Size = new System.Drawing.Size(933, 808);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridShops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
           private System.Windows.Forms.DataGridView datagridShops;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolBtnCreateShop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolBtnEditShop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
    }
}
