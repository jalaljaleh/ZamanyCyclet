namespace ZamanyCyclet.App.Pages
{
    partial class InventoryManagerPage
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
            this.menu = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_BtnNewProduct = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_BtnEditProduct = new System.Windows.Forms.ToolStripButton();
            this.datagridProducts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menu.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.menu_BtnNewProduct,
            this.toolStripSeparator2,
            this.menu_BtnEditProduct});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5);
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(1050, 87);
            this.menu.TabIndex = 6;
            this.menu.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(20, 1, 30, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(82, 74);
            this.toolStripLabel1.Text = "مدیریت انبار";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // menu_BtnNewProduct
            // 
            this.menu_BtnNewProduct.AutoSize = false;
            this.menu_BtnNewProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menu_BtnNewProduct.Image = global::ZamanyCyclet.App.Properties.Resources.add_new_80px;
            this.menu_BtnNewProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_BtnNewProduct.Name = "menu_BtnNewProduct";
            this.menu_BtnNewProduct.Size = new System.Drawing.Size(60, 74);
            this.menu_BtnNewProduct.Text = "کالای جدید";
            this.menu_BtnNewProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // menu_BtnEditProduct
            // 
            this.menu_BtnEditProduct.AutoSize = false;
            this.menu_BtnEditProduct.Image = global::ZamanyCyclet.App.Properties.Resources.edit_80px;
            this.menu_BtnEditProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_BtnEditProduct.Name = "menu_BtnEditProduct";
            this.menu_BtnEditProduct.Size = new System.Drawing.Size(60, 74);
            this.menu_BtnEditProduct.Text = "ویرایش";
            this.menu_BtnEditProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // datagridProducts
            // 
            this.datagridProducts.AllowUserToAddRows = false;
            this.datagridProducts.AllowUserToDeleteRows = false;
            this.datagridProducts.AllowUserToOrderColumns = true;
            this.datagridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridProducts.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.datagridProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagridProducts.ColumnHeadersHeight = 35;
            this.datagridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Code,
            this.ProductName,
            this.Description,
            this.Category,
            this.Brand,
            this.SalePrice,
            this.PurchasePrice,
            this.Unit,
            this.CreatedAt,
            this.UpdatedAt});
            this.datagridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridProducts.GridColor = System.Drawing.SystemColors.Control;
            this.datagridProducts.Location = new System.Drawing.Point(0, 87);
            this.datagridProducts.MultiSelect = false;
            this.datagridProducts.Name = "datagridProducts";
            this.datagridProducts.ReadOnly = true;
            this.datagridProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagridProducts.RowHeadersWidth = 40;
            this.datagridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridProducts.Size = new System.Drawing.Size(1050, 721);
            this.datagridProducts.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 47.44983F;
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "کد کالا";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "Name";
            this.ProductName.HeaderText = "نام";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "دسته";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "برند";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "قیمت فروش";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.HeaderText = "قیمت خرید";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "واحد";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
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
            // InventoryManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.datagridProducts);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InventoryManagerPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1050, 808);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton menu_BtnEditProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton menu_BtnNewProduct;
        private System.Windows.Forms.DataGridView datagridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
    }
}
