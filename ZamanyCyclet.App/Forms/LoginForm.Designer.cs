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
            this.LabelDatetime = new System.Windows.Forms.Label();
            this.GroupBoxLogin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.CbUsers = new System.Windows.Forms.ComboBox();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBackground)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.PanelTabs.SuspendLayout();
            this.GroupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageBackground
            // 
            this.ImageBackground.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImageBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageBackground.ErrorImage = null;
            this.ImageBackground.Image = ((System.Drawing.Image)(resources.GetObject("ImageBackground.Image")));
            this.ImageBackground.Location = new System.Drawing.Point(0, 0);
            this.ImageBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ImageBackground.Name = "ImageBackground";
            this.ImageBackground.Size = new System.Drawing.Size(538, 728);
            this.ImageBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBackground.TabIndex = 9;
            this.ImageBackground.TabStop = false;
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.PanelTabs);
            this.PanelMain.Controls.Add(this.LabelCopyright);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelMain.Location = new System.Drawing.Point(538, 0);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(399, 728);
            this.PanelMain.TabIndex = 10;
            // 
            // PanelTabs
            // 
            this.PanelTabs.BackColor = System.Drawing.Color.Transparent;
            this.PanelTabs.Controls.Add(this.LabelTitle);
            this.PanelTabs.Controls.Add(this.LabelTittleDescription);
            this.PanelTabs.Controls.Add(this.LabelDatetime);
            this.PanelTabs.Controls.Add(this.GroupBoxLogin);
            this.PanelTabs.Controls.Add(this.labelVersion);
            this.PanelTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTabs.Location = new System.Drawing.Point(0, 0);
            this.PanelTabs.Name = "PanelTabs";
            this.PanelTabs.Padding = new System.Windows.Forms.Padding(20);
            this.PanelTabs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanelTabs.Size = new System.Drawing.Size(399, 667);
            this.PanelTabs.TabIndex = 9;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(114, 20);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(242, 25);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "سیستم حسابداری زمانی‌سیکلت";
            // 
            // LabelTittleDescription
            // 
            this.LabelTittleDescription.AutoSize = true;
            this.LabelTittleDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTittleDescription.Location = new System.Drawing.Point(53, 55);
            this.LabelTittleDescription.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LabelTittleDescription.Name = "LabelTittleDescription";
            this.LabelTittleDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelTittleDescription.Size = new System.Drawing.Size(303, 19);
            this.LabelTittleDescription.TabIndex = 4;
            this.LabelTittleDescription.Text = "به نرم افزار حساب داری زمانی‌سیکلت خوش آمدید !";
            // 
            // LabelDatetime
            // 
            this.LabelDatetime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDatetime.Location = new System.Drawing.Point(63, 89);
            this.LabelDatetime.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.LabelDatetime.Name = "LabelDatetime";
            this.LabelDatetime.Size = new System.Drawing.Size(286, 26);
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
            this.GroupBoxLogin.Location = new System.Drawing.Point(53, 130);
            this.GroupBoxLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.GroupBoxLogin.Name = "GroupBoxLogin";
            this.GroupBoxLogin.Size = new System.Drawing.Size(303, 231);
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
            this.InputPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // labelVersion
            // 
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(64, 374);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(10);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(285, 29);
            this.labelVersion.TabIndex = 10;
            this.labelVersion.Text = "[نسخه]";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelCopyright.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCopyright.Location = new System.Drawing.Point(0, 693);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelCopyright.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelCopyright.Size = new System.Drawing.Size(399, 35);
            this.LabelCopyright.TabIndex = 7;
            this.LabelCopyright.Text = "طراحی و توسعه شرکت خدمات نرم افزاری Haluntm";
            this.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(937, 728);
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
        private System.Windows.Forms.FlowLayoutPanel PanelTabs;
        private System.Windows.Forms.Label labelVersion;
    }
}