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
                InputPhoneNumber.Text = _shop.PhoneNumber;
                InputDescription.Text = _shop.Description;
                InputUpdatedAt.Text = PersianDateHelper.ToShortDate(_shop.UpdatedAt);

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
                    shopInDb.PhoneNumber = InputPhoneNumber.Text.Trim();
                    shopInDb.Description = InputDescription.Text;
                    shopInDb.UpdatedAt = DateTime.Now;

                    var isValid = IsValid(shopInDb);
                    if (isValid.result is false)
                    {
                        MessageBox.Show(isValid.error);
                        return;
                    }
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
                    _shop.PhoneNumber = InputPhoneNumber.Text.Trim();
                    _shop.Description = InputDescription.Text.Trim();
                    _shop.UpdatedAt = DateTime.Now;

                    var isValid = IsValid(_shop);
                    if (isValid.result is false)
                    {
                        MessageBox.Show(isValid.error);
                        return;
                    }
                    db.Shops.Add(_shop);
                }

                db.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        (bool result, string error) IsValid(Shop shop)
        {
            if (shop.Name.Length < 3) return (false, "نام فروشگاه بسیار کوتاه است.");
            if (shop.Code.Length < 3) return (false, "کد شعبه بسیار کوتاه است.");

            return (true, "");
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
