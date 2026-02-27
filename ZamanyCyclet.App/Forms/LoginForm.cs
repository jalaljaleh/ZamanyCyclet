using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZamanyCyclet.App.Helpers;
using ZamanyCyclet.Domain;
using ZamanyCyclet.Infrastructure;

namespace ZamanyCyclet.App.Forms
{
    public partial class LoginForm : Form
    {
        public User Operator { get; set; }
        public LoginForm()
        {
            InitializeComponent();

            this.Shown += LoginForm_Shown;
            this.btnLogin.Click += BtnLogin_Click;
        }

        private async void LoginForm_Shown(object sender, EventArgs e)
        {
            PanelMain.Enabled = false;

            InitializeUi();

            // Run database initialization in background thread
            var users = await Task.Run(() => InitializeDatabase());

            CbUsers.DataSource = users;

            PanelMain.Enabled = true;
        }

        private void InitializeUi()
        {
            LabelDatetime.Text = PersianDateHelper.GetTodayLongDate();
            labelVersion.Text = Program.Version;
        }

        private List<User> InitializeDatabase()
        {
            using (var db = new HalunDbContext())
            {
                if (Program.IsDebugMode() && db.Database.Exists())
                    db.Database.Delete();

                if (!db.Database.Exists())
                {
                    db.Database.Create();

                    db.Users.Add(new User
                    {
                        Username = "Developer",
                        DisplayName = "توسعه دهنده",
                        Password = "654321",
                        CreatedAt = DateTime.Now,
                        Permissions = UserPermissions.None
                    });
                    db.Users.Add(new User
                    {
                        Username = "ArasZamany",
                        DisplayName = "آراس زمانی",
                        Password = "654321",
                        CreatedAt = DateTime.Now,
                        Permissions = UserPermissions.None
                    });

                    db.Shops.Add(new Shop()
                    {
                        Name = "سیروس",
                        Code = "CYR",
                        Address = "خیابان سیروس",
                        
                    });

                    db.Shops.Add(new Shop()
                    {
                        Name = "دوشان",
                        Code = "CYR1",
                        Address = "خیابان سیروس",

                    });
                    db.SaveChanges();
                }

                return db.Users.ToList();
            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (DateTime.UtcNow.Year < 2026)
            {
                MessageBox.Show("تاریخ سیستم تنظیم نیست؛");
                return;
            }

            var target = CbUsers.SelectedItem as User;
            if (target == null || InputPassword.Text != target.Password)
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه می‌باشد.");
                return;
            }

            this.Operator = target;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}