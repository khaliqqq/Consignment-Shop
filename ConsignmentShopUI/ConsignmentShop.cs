using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();


        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items;
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Smith", LastName = "Bill" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item
            {
                Title = "Naruto Shippudden",
                Description = "A tale about Ninja",
                Price = 4.50M, Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Fairy Tail",
                Description = "The advanture of Fairy Tail's wizards",
                Price = 2.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Dragon Ball Z",
                Description = "Goku and friends adventure",
                Price = 14.50M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Bleach",
                Description = "Ichigo Kurosaki and friends",
                Price = 42.50M,
                Owner = store.Vendors[1]
            });

            store.Name = "Seconds are better";
        }
    }
}
