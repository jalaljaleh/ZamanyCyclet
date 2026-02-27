using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZamanyCyclet.App.Helpers;
using ZamanyCyclet.Domain;
using ZamanyCyclet.Infrastructure;

namespace ZamanyCyclet.App.Forms
{
    public partial class CreateShopForm : Form
    {
        private readonly Shop _shop;
        private readonly bool _isEdit;

        public CreateShopForm(Shop shop = null)
        {
            InitializeComponent();

            _isEdit = shop != null;

            if (_isEdit)
            {
                _shop = shop;

                InputId.Text = _shop.Id.ToString();
                InputCreatedAt.Text = PersianDateHelper.ToShortDate(_shop.CreatedAt);
                InputName.Text = _shop.Name;
                InputCode.Text = _shop.Code;
                InputAddress.Text = _shop.Address;
                InputPostalCode.Text = _shop.PostalCode;

                InputCode.Enabled = false;
                this.Text = "ویرایش شعبه " + _shop.Name;
            }
            else
            {
                _shop = new Shop();
                this.Text = "ایجاد شعبه";
            }

            btnConfirm.Text = this.Text;
            groupBoxInfo.Text = this.Text;

            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputName.Text))
            {
                MessageBox.Show("نام شعبه الزامی است");
                return;
            }

            using (HalunDbContext db = new HalunDbContext())
            {
                if (_isEdit)
                {
                    var shopInDb = db.Shops.Find(_shop.Id);
                    if (shopInDb == null)
                    {
                        MessageBox.Show("رکورد یافت نشد");
                        return;
                    }

                    shopInDb.Name = InputName.Text.Trim();
                    shopInDb.Address = InputAddress.Text.Trim();
                    shopInDb.PostalCode = InputPostalCode.Text.Trim();
                }
                else
                {
                    if (db.Shops.Any(x => x.Code == InputCode.Text && x.Id != _shop.Id))
                    {
                        MessageBox.Show("کد شعبه تکراری است");
                        return;
                    }

                    _shop.Name = InputName.Text.Trim();
                    _shop.Code = InputCode.Text.Trim();
                    _shop.Address = InputAddress.Text.Trim();
                    _shop.PostalCode = InputPostalCode.Text.Trim();
                    _shop.CreatedAt = DateTime.Now;

                    db.Shops.Add(_shop);
                }

                db.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
