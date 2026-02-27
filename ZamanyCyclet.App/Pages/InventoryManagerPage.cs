using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZamanyCyclet.App.Forms;
using ZamanyCyclet.Infrastructure;

namespace ZamanyCyclet.App.Pages
{
    public partial class InventoryManagerPage : UserControl
    {
        public InventoryManagerPage()
        {
            InitializeComponent();
            RefreshProducts();


            this.menu_BtnNewProduct.Click += Menu_BtnNewProduct_Click;
        }

        private void Menu_BtnNewProduct_Click(object sender, EventArgs e)
        {
            var window = new CreateProductForm();
            if (window.ShowDialog() == DialogResult.OK)
            {
                RefreshProducts();
            }
        }

        void RefreshProducts()
        {
            using (HalunDbContext halunDbContext = new HalunDbContext())
            {
                datagridProducts.AutoGenerateColumns = false;
                datagridProducts.DataSource = halunDbContext.Products
                    .Select(a => new
                    {
                        a.Id,
                        a.Code,
                        a.Name,
                        a.Description,
                        a.Category,
                        a.Brand,
                        a.SalePrice,
                        a.PurchasePrice,
                        a.CreatedAt,
                        a.UpdatedAt,
                        Unit = a.Unit.Name
                    }).ToList();
            }
        }
    }
}
