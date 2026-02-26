namespace ZamanyCyclet.App.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ImageBackground = new System.Windows.Forms.PictureBox();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelTabs = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelTittleDescription = new System.Windows.Forms.Label();
            this.GroupBoxTime = new System.Windows.Forms.GroupBox();
            this.LabelDatetime = new System.Windows.Forms.Label();
            this.GroupBoxLogin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.CbUsers = new System.Windows.Forms.ComboBox();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBackground)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.PanelTabs.SuspendLayout();
            this.GroupBoxTime.SuspendLayout();
            this.GroupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageBackground
            // 
            this.ImageBackground.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImageBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageBackground.Image = global::ZamanyCyclet.App.Properties.Resources.background;
            this.ImageBackground.Location = new System.Drawing.Point(0, 0);
            this.ImageBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ImageBackground.Name = "ImageBackground";
            this.ImageBackground.Size = new System.Drawing.Size(526, 656);
            this.ImageBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBackground.TabIndex = 9;
            this.ImageBackground.TabStop = false;
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.PanelTabs);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelMain.Location = new System.Drawing.Point(526, 0);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(319, 656);
            this.PanelMain.TabIndex = 10;
            // 
            // PanelTabs
            // 
            this.PanelTabs.BackColor = System.Drawing.Color.FloralWhite;
            this.PanelTabs.Controls.Add(this.LabelTitle);
            this.PanelTabs.Controls.Add(this.LabelTittleDescription);
            this.PanelTabs.Controls.Add(this.GroupBoxTime);
            this.PanelTabs.Controls.Add(this.GroupBoxLogin);
            this.PanelTabs.Controls.Add(this.groupBox1);
            this.PanelTabs.Controls.Add(this.LabelCopyright);
            this.PanelTabs.Controls.Add(this.labelVersion);
            this.PanelTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTabs.Location = new System.Drawing.Point(0, 0);
            this.PanelTabs.Name = "PanelTabs";
            this.PanelTabs.Padding = new System.Windows.Forms.Padding(8, 20, 8, 8);
            this.PanelTabs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanelTabs.Size = new System.Drawing.Size(319, 656);
            this.PanelTabs.TabIndex = 9;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(97, 20);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(203, 21);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "سیستم حسابداری آراس‌سیکلت";
            // 
            // LabelTittleDescription
            // 
            this.LabelTittleDescription.AutoSize = true;
            this.LabelTittleDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTittleDescription.Location = new System.Drawing.Point(55, 51);
            this.LabelTittleDescription.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LabelTittleDescription.Name = "LabelTittleDescription";
            this.LabelTittleDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelTittleDescription.Size = new System.Drawing.Size(245, 15);
            this.LabelTittleDescription.TabIndex = 4;
            this.LabelTittleDescription.Text = "به نرم افزار حساب داری آراس‌سیکلت خوش آمدید !";
            // 
            // GroupBoxTime
            // 
            this.GroupBoxTime.Controls.Add(this.LabelDatetime);
            this.GroupBoxTime.Location = new System.Drawing.Point(9, 86);
            this.GroupBoxTime.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.GroupBoxTime.Name = "GroupBoxTime";
            this.GroupBoxTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBoxTime.Size = new System.Drawing.Size(291, 48);
            this.GroupBoxTime.TabIndex = 8;
            this.GroupBoxTime.TabStop = false;
            this.GroupBoxTime.Text = "تاریخ";
            // 
            // LabelDatetime
            // 
            this.LabelDatetime.AutoSize = true;
            this.LabelDatetime.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelDatetime.Location = new System.Drawing.Point(221, 19);
            this.LabelDatetime.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDatetime.Name = "LabelDatetime";
            this.LabelDatetime.Size = new System.Drawing.Size(67, 15);
            this.LabelDatetime.TabIndex = 6;
            this.LabelDatetime.Text = "[تاریخ امروز]";
            // 
            // GroupBoxLogin
            // 
            this.GroupBoxLogin.Controls.Add(this.label4);
            this.GroupBoxLogin.Controls.Add(this.btnLogin);
            this.GroupBoxLogin.Controls.Add(this.CbUsers);
            this.GroupBoxLogin.Controls.Add(this.InputPassword);
            this.GroupBoxLogin.Controls.Add(this.label1);
            this.GroupBoxLogin.Location = new System.Drawing.Point(9, 142);
            this.GroupBoxLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.GroupBoxLogin.Name = "GroupBoxLogin";
            this.GroupBoxLogin.Size = new System.Drawing.Size(291, 231);
            this.GroupBoxLogin.TabIndex = 5;
            this.GroupBoxLogin.TabStop = false;
            this.GroupBoxLogin.Text = "ورود";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 193);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(253, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "در صورت فراموشی رمز عبور، با پشتیبان تماس بگیرید.";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(168, 147);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 31);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "ورود";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // CbUsers
            // 
            this.CbUsers.DisplayMember = "DisplayName";
            this.CbUsers.FormattingEnabled = true;
            this.CbUsers.Location = new System.Drawing.Point(28, 37);
            this.CbUsers.Name = "CbUsers";
            this.CbUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CbUsers.Size = new System.Drawing.Size(242, 23);
            this.CbUsers.TabIndex = 3;
            // 
            // InputPassword
            // 
            this.InputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPassword.Location = new System.Drawing.Point(28, 100);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '*';
            this.InputPassword.Size = new System.Drawing.Size(242, 23);
            this.InputPassword.TabIndex = 0;
            this.InputPassword.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 74);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "رمز عبور:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 386);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(291, 203);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCopyright.AutoSize = true;
            this.LabelCopyright.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCopyright.Location = new System.Drawing.Point(59, 592);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelCopyright.Size = new System.Drawing.Size(241, 13);
            this.LabelCopyright.TabIndex = 7;
            this.LabelCopyright.Text = "طراحی و توسعه شرکت خدمات نرم افزاری Haluntm";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(251, 615);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(10);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 15);
            this.labelVersion.TabIndex = 10;
            this.labelVersion.Text = "[نسخه]";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 656);
            this.Controls.Add(this.ImageBackground);
            this.Controls.Add(this.PanelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم حسابداری آراس سیکلت";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBackground)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelTabs.ResumeLayout(false);
            this.PanelTabs.PerformLayout();
            this.GroupBoxTime.ResumeLayout(false);
            this.GroupBoxTime.PerformLayout();
            this.GroupBoxLogin.ResumeLayout(false);
            this.GroupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ImageBackground;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.GroupBox GroupBoxLogin;
        private System.Windows.Forms.ComboBox CbUsers;
        private System.Windows.Forms.Label LabelTittleDescription;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelCopyright;
        private System.Windows.Forms.Label LabelDatetime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox GroupBoxTime;
        private System.Windows.Forms.FlowLayoutPanel PanelTabs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelVersion;
    }
}