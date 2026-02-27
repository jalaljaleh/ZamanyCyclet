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
using ZamanyCyclet.Domain;
using ZamanyCyclet.Infrastructure;

namespace ZamanyCyclet.App.Pages
{
    public partial class ShopManagerPage : UserControl
    {
        public ShopManagerPage()
        {
            InitializeComponent();
            RefreshShopList();

            this.toolBtnCreateShop.Click += ToolBtnCreateShop_Click;
            this.toolBtnEditShop.Click += ToolBtnEditShop_Click;
            this.datagridShops.SelectionChanged += DatagridShops_SelectionChanged;
        }

        private void ToolBtnEditShop_Click(object sender, EventArgs e)
        {
            var createShopForm = new CreateShopForm(SelectedRow);
            if (createShopForm.ShowDialog() == DialogResult.OK)
            {
                RefreshShopList();
            }
        }

        public Shop SelectedRow => datagridShops.SelectedRows.Count > 0 ? datagridShops.SelectedRows[0].DataBoundItem as Shop : null;


        private void ToolBtnCreateShop_Click(object sender, EventArgs e)
        {
            var createShopForm = new CreateShopForm();
            if (createShopForm.ShowDialog() == DialogResult.OK)
            {
                RefreshShopList();
            }
        }

        public void RefreshShopList()
        {
            using (HalunDbContext db = new HalunDbContext())
            {
                datagridShops.AutoGenerateColumns = false;
                datagridShops.DataSource = db.Shops.ToList();
            }
        }
        private void DatagridShops_SelectionChanged(object sender, EventArgs e)
        {
            bool isEnabled = SelectedRow != null;

            //toolBtnDeleteShop.Enabled = isEnabled;
            toolBtnEditShop.Enabled = isEnabled;
        }
    }
}
