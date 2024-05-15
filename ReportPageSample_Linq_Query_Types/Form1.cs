using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReportPageSample_Linq_Query_Types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        private void BtnIncreasingProductPrice_Click(object sender, EventArgs e)
        {
            // ascending, descending

            var list = from x in db.Products orderby x.UnitPrice ascending select x;
            DGridView.DataSource = list.ToList();
        }

        private void BtnListSpain_Click(object sender, EventArgs e)
        {
            var list = db.Customers.Where(x => x.Country == "Spain").ToList();
            DGridView.DataSource = list.ToList();
        }

        private void BtnListSevilla_Click(object sender, EventArgs e)
        {
            var list = db.Customers.Where(x => x.Country == "Spain" && x.City == "Sevilla").ToList();
            DGridView.DataSource = list.ToList();
        }

        private void BtnListNameTitle_Click(object sender, EventArgs e)
        {
            var list = from customer in db.Customers
                       select new
                       {
                           customer.ContactName,
                           customer.ContactTitle,
                           customer.Address,
                       };
            DGridView.DataSource = list.ToList();
        }

        private void BtnProductAndCategory_Click(object sender, EventArgs e)
        {
            var list = from x in db.Products
                       join y in db.Categories on x.CategoryID equals y.CategoryID
                       select new
                       {
                           x.ProductName,
                           y.CategoryName,
                           y.Description
                       };
            DGridView.DataSource = list.ToList();
        }

        private void BtnProductsAndSuppliers_Click(object sender, EventArgs e)
        {
            var list = from x in db.Products
                       join y in db.Suppliers on x.SupplierID equals y.SupplierID
                       orderby x.ProductName ascending
                       select new
                       {
                           x.ProductName,
                           y.City,
                           y.Address
                       };
            DGridView.DataSource = list.ToList();
        }

        private void BtnSalesDetailProductsAndCategories_Click(object sender, EventArgs e)
        {
            var list = from x in db.Order_Details
                       join y in db.Products on x.ProductID equals y.ProductID
                       join z in db.Categories on y.CategoryID equals z.CategoryID
                       select new
                       {
                           x.Order,
                           y.ProductName,
                           z.CategoryName,
                       };
            DGridView.DataSource = list.ToList();
        }
    }
}
