using System;
using System.Linq;
using System.Windows.Forms;
using ZamanyCyclet.App.Pages;
using ZamanyCyclet.Domain;
using ZamanyCyclet.Infrastructure;


namespace ZamanyCyclet.App.Forms
{
    public partial class MainForm : Form
    {
        public User _operator { get; private set; }
        public MainForm()
        {
            InitializeComponent();

            var login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK)
            {
                this.Hide();
                Environment.Exit(0);
            }

            _operator = login.Operator;

            InitilizeUi();

            menu_BtnShopManage.Click += (s,e)=> { ShowPage(new ShopManagerPage()); };
            menu_BtnShopInventory.Click += (s,e)=> { ShowPage(new InventoryManagerPage()); };
        }

        private void ShowPage(UserControl page)
        {
            panelView.Controls.Clear();

            page.Dock = DockStyle.Fill; 
            panelView.Controls.Add(page);
        }
        void InitilizeUi()
        {
            toolUser.Text = $"{_operator.DisplayName}";
            AddShops();


        }
        void AddShops()
        {
            //using (HalunDbContext db = new HalunDbContext())
            //{
            //    var shops = db.Shops.ToList();
            //    foreach (var shop in shops)
            //    {
            //        var menuItem = new ToolStripMenuItem(shop.Name);
            //        //menuItem.AutoSize = false;
            //        menuItem.Image = Properties.Resources.motorbike_helmet80x;
            //        menuItem.Name = $"toolshop:{shop.Id}";
            //        menuItem.Size = new System.Drawing.Size(80, 90);
            //        menuItem.Text = shop.Name;
            //        menuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;

            //        menuItem.Click += (s, e) =>
            //        {

            //        };
            //        toolShops.Items.Add(menuItem);
            //    }
            //}
        }



    }
}
