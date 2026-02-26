namespace ZamanyCyclet.App.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Dispose resources being used
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false</param>
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
        /// Designer method to initialize form components
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolShops = new System.Windows.Forms.ToolStrip();
            this.toolShopsBtnManage = new System.Windows.Forms.ToolStripButton();
            this.toolUser = new System.Windows.Forms.ToolStripButton();
            this.toolBuy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStock = new System.Windows.Forms.ToolStripButton();
            this.MenuMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolShops.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.BackColor = System.Drawing.Color.LightYellow;
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuMain.Size = new System.Drawing.Size(1424, 24);
            this.MenuMain.TabIndex = 1;
            this.MenuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خروجToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "فایل";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.editToolStripMenuItem.Text = "ویرایش";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.helpToolStripMenuItem.Text = "راهنما";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUser,
            this.toolStripSeparator1,
            this.toolBuy,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStock});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1424, 103);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 93);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 93);
            // 
            // toolShops
            // 
            this.toolShops.BackColor = System.Drawing.Color.LemonChiffon;
            this.toolShops.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolShops.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolShops.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolShops.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShopsBtnManage});
            this.toolShops.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolShops.Location = new System.Drawing.Point(1344, 127);
            this.toolShops.Name = "toolShops";
            this.toolShops.Padding = new System.Windows.Forms.Padding(0);
            this.toolShops.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolShops.Size = new System.Drawing.Size(80, 671);
            this.toolShops.TabIndex = 5;
            this.toolShops.Text = "toolStrip2";
            // 
            // toolShopsBtnManage
            // 
            this.toolShopsBtnManage.AutoSize = false;
            this.toolShopsBtnManage.Image = global::ZamanyCyclet.App.Properties.Resources.tools;
            this.toolShopsBtnManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolShopsBtnManage.Name = "toolShopsBtnManage";
            this.toolShopsBtnManage.Size = new System.Drawing.Size(80, 90);
            this.toolShopsBtnManage.Text = "مدیریت";
            this.toolShopsBtnManage.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolShopsBtnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolShopsBtnManage.ToolTipText = "مدیریت\r\n شعبه ها";
            // 
            // toolUser
            // 
            this.toolUser.AutoSize = false;
            this.toolUser.Image = ((System.Drawing.Image)(resources.GetObject("toolUser.Image")));
            this.toolUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUser.Name = "toolUser";
            this.toolUser.Size = new System.Drawing.Size(80, 90);
            this.toolUser.Text = "[کاربر]";
            this.toolUser.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolBuy
            // 
            this.toolBuy.AutoSize = false;
            this.toolBuy.Image = global::ZamanyCyclet.App.Properties.Resources.pos;
            this.toolBuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBuy.Name = "toolBuy";
            this.toolBuy.Size = new System.Drawing.Size(80, 90);
            this.toolBuy.Text = "خرید";
            this.toolBuy.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 90);
            this.toolStripButton1.Text = "انبار";
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStock
            // 
            this.toolStock.AutoSize = false;
            this.toolStock.Image = global::ZamanyCyclet.App.Properties.Resources.settings;
            this.toolStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStock.Name = "toolStock";
            this.toolStock.Size = new System.Drawing.Size(80, 90);
            this.toolStock.Text = "تنظیمات";
            this.toolStock.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 798);
            this.Controls.Add(this.toolShops);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MenuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(2237, 1240);
            this.MinimumSize = new System.Drawing.Size(1192, 686);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار حسابداری زمانی سیکلت";
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolShops.ResumeLayout(false);
            this.toolShops.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBuy;
        private System.Windows.Forms.ToolStripButton toolStock;
        private System.Windows.Forms.ToolStripButton toolUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolShops;
        private System.Windows.Forms.ToolStripButton toolShopsBtnManage;
    }
}