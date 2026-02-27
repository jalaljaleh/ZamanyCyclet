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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.datagridShops = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight = new System.Windows.Forms.ToolStrip();
            this.toolBtnCreateShop = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEditShop = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDeleteShop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolStripSeparator3,
            this.toolBtnDeleteShop});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(933, 93);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(20, 1, 30, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 85);
            this.toolStripLabel1.Text = "مدیریت شعبه ها";
            // 
            // datagridShops
            // 
            this.datagridShops.AllowUserToAddRows = false;
            this.datagridShops.AllowUserToDeleteRows = false;
            this.datagridShops.AllowUserToOrderColumns = true;
            this.datagridShops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridShops.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagridShops.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridShops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Code,
            this.NameA,
            this.PostalCode,
            this.Address,
            this.CreatedAt});
            this.datagridShops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridShops.GridColor = System.Drawing.SystemColors.Control;
            this.datagridShops.Location = new System.Drawing.Point(0, 93);
            this.datagridShops.MultiSelect = false;
            this.datagridShops.Name = "datagridShops";
            this.datagridShops.ReadOnly = true;
            this.datagridShops.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagridShops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridShops.Size = new System.Drawing.Size(898, 715);
            this.datagridShops.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "کد شعبه";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // NameA
            // 
            this.NameA.DataPropertyName = "Name";
            this.NameA.HeaderText = "اسم شعبه";
            this.NameA.Name = "NameA";
            this.NameA.ReadOnly = true;
            // 
            // PostalCode
            // 
            this.PostalCode.DataPropertyName = "PostalCode";
            this.PostalCode.HeaderText = "کد پستی";
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "تاریخ ثبت";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.panelRight.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.panelRight.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.panelRight.Location = new System.Drawing.Point(898, 93);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(5);
            this.panelRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelRight.Size = new System.Drawing.Size(35, 715);
            this.panelRight.TabIndex = 6;
            this.panelRight.Text = "toolStrip2";
            // 
            // toolBtnCreateShop
            // 
            this.toolBtnCreateShop.AutoSize = false;
            this.toolBtnCreateShop.Image = global::ZamanyCyclet.App.Properties.Resources.exterior_80px;
            this.toolBtnCreateShop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnCreateShop.Name = "toolBtnCreateShop";
            this.toolBtnCreateShop.Size = new System.Drawing.Size(70, 80);
            this.toolBtnCreateShop.Text = "شعبه جدید";
            this.toolBtnCreateShop.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolBtnCreateShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolBtnEditShop
            // 
            this.toolBtnEditShop.AutoSize = false;
            this.toolBtnEditShop.Image = global::ZamanyCyclet.App.Properties.Resources.ball_point_pen_80px;
            this.toolBtnEditShop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEditShop.Name = "toolBtnEditShop";
            this.toolBtnEditShop.Size = new System.Drawing.Size(65, 80);
            this.toolBtnEditShop.Text = "ویرایش";
            this.toolBtnEditShop.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolBtnEditShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolBtnDeleteShop
            // 
            this.toolBtnDeleteShop.AutoSize = false;
            this.toolBtnDeleteShop.Image = global::ZamanyCyclet.App.Properties.Resources.cancel_80px;
            this.toolBtnDeleteShop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDeleteShop.Name = "toolBtnDeleteShop";
            this.toolBtnDeleteShop.Size = new System.Drawing.Size(65, 80);
            this.toolBtnDeleteShop.Text = "حذف";
            this.toolBtnDeleteShop.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolBtnDeleteShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 68);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 68);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 68);
            // 
            // ShopManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.datagridShops);
            this.Controls.Add(this.panelRight);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.ToolStrip panelRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolBtnEditShop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolBtnDeleteShop;
    }
}
