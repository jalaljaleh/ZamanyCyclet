using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZamanyCyclet.Common;
using ZamanyCyclet.Domain;
using ZamanyCyclet.Infrastructure;

namespace ZamanyCyclet.App.Forms
{
    public partial class CreateProductForm : Form
    {
        private readonly Product _product;
        private readonly bool _isEdit;

        public CreateProductForm(Product product = null)
        {
            InitializeComponent();

            using (HalunDbContext db = new HalunDbContext())
            {
                cboxUnits.DataSource = db.ProductUnit.ToList();
            }

            _isEdit = product != null;

            if (_isEdit)
            {
                _product = product;

                InputId.Text = _product.Id.ToString();
                InputCreatedAt.Text = _product.CreatedAt.ToString("yyyy/MM/dd HH:mm");

                InputName.Text = _product.Name;
                InputCode.Text = _product.Code;
                InputDescription.Text = _product.Description;
                InputBrand.Text = _product.Brand;
                InputCategory.Text = _product.Category;

                InputPurchasePrice.Value = _product.PurchasePrice;
                InputSalePrice.Value = _product.SalePrice;
                cboxUnits.SelectedItem = _product.Unit;

                this.Text = "ویرایش کالا " + _product.Name;
            }
            else
            {
                _product = new Product();
                this.Text = "ایجاد کالا";
            }

            btnConfirm.Text = this.Text;

            this.InputPurchasePrice.ValueChanged += InputPurchasePrice_ValueChanged;
            this.InputSalePrice.ValueChanged += InputPurchasePrice_ValueChanged;


            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += (s, e) => Close();
        }

        private void InputPurchasePrice_ValueChanged(object sender, EventArgs e)
        {          
            decimal salePrice = InputSalePrice.Value;
            decimal purchasePrice = InputPurchasePrice.Value;
          
            decimal profit = ProductHelper.CalculateProfit(salePrice, purchasePrice);
            decimal markup = ProductHelper.CalculateMarkupPercent(salePrice, purchasePrice);
            decimal margin = ProductHelper.CalculateMarginPercent(salePrice, purchasePrice);
            bool isProfitable = ProductHelper.IsProfitable(salePrice, purchasePrice);

            string summary;
            string status;
            Color color;

            if (isProfitable)
            {
                summary = $"این کالا با {profit:N0} تومان سود فروخته می‌شود.";   
                status = $"درصد سود: {markup:N2}%        |         حاشیه سود: {margin:N2}%";
                color = Color.PaleGoldenrod;
            }
            else
            {            
                summary = $"⚠ هشدار: این کالا با {Math.Abs(profit):N0} تومان زیان فروخته می‌شود!";
                status = $"درصد زیان: {Math.Abs(markup):N2}%        |         حاشیه زیان: {Math.Abs(margin):N2}%";
                color = Color.Salmon;
            }

            // Update UI Elements
            LabelAccountingSummary.Text = summary;
            LabelAccountingSummary.BackColor = color;

            labelAccountingStatus.Text = status;
            labelAccountingStatus.BackColor = color;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputName.Text))
            {
                MessageBox.Show("نام کالا الزامی است");
                return;
            }

            if (InputSalePrice.Value <= 0)
            {
                MessageBox.Show("قیمت فروش باید بیشتر از صفر باشد");
                return;
            }

            using (HalunDbContext db = new HalunDbContext())
            {
                if (_isEdit)
                {
                    var productInDb = db.Products.Find(_product.Id);
                    if (productInDb == null)
                    {
                        MessageBox.Show("رکورد یافت نشد");
                        return;
                    }

                    productInDb.Name = InputName.Text.Trim();
                    productInDb.Code = InputCode.Text.Trim();
                    productInDb.Description = InputDescription.Text.Trim();
                    productInDb.Brand = InputBrand.Text.Trim();
                    productInDb.Category = InputCategory.Text.Trim();
                    productInDb.PurchasePrice = InputPurchasePrice.Value;
                    productInDb.SalePrice = InputSalePrice.Value;

                    productInDb.UnitId = (cboxUnits.SelectedItem as ProductUnit).Id;
                }
                else
                {
                    _product.Name = InputName.Text.Trim();
                    _product.Code = InputCode.Text.Trim();
                    _product.Description = InputDescription.Text.Trim();
                    _product.Brand = InputBrand.Text.Trim();
                    _product.Category = InputCategory.Text.Trim();
                    _product.PurchasePrice = InputPurchasePrice.Value;
                    _product.SalePrice = InputSalePrice.Value;
                    _product.CreatedAt = DateTime.Now;

                    _product.UnitId = (cboxUnits.SelectedItem as ProductUnit).Id;

                    db.Products.Add(_product);
                }

                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}