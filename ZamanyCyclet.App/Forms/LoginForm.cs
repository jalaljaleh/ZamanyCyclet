using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZamanyCyclet.App.Helpers;
using ZamanyCyclet.Common;
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
            this.btnLogin.KeyDown += (s, e) => { if (e.KeyData == Keys.Enter) BtnLogin_Click(s, e); };
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
            this.btnLogin.Focus();

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

                    db.Users.Add(UsersHelper.GetDeveloperUser());
                    db.ProductUnit.AddRange(ProductUnitsHelper.GetProductUnits());

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