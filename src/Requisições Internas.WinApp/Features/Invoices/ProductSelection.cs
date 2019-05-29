using Requisições_Internas.Application.Features.Products;
using Requisições_Internas.Domain.Features.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requisições_Internas.WinApp.Features.Invoices
{
    public partial class ProductSelection : Form
    {
        IProductService _productService;
        public BindingList<Product> SelectedProducts;

        public ProductSelection(IProductService productService, IEnumerable<Product> products)
        {
            InitializeComponent();
            _productService = productService;

            searchProducts();

            if (products.Count() > 0)
                SelectedProducts = new BindingList<Product>(products.ToList());
            else
                SelectedProducts = new BindingList<Product>();

            dtgSelectedProducts.DataSource = SelectedProducts;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchProducts();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            long id = (long)dtgvProductsFound.SelectedRows[0].Cells[4].Value;
            SelectedProducts.Add(_productService.GetById(id));
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchProducts();
            }
        }

        void searchProducts()
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dtgvProductsFound.DataSource = _productService.GetAll().Take(10).ToList();
            }
            else
            {
                dtgvProductsFound.DataSource = _productService.GetByName(txtSearch.Text).ToList();
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            dtgSelectedProducts.Rows.RemoveAt(dtgSelectedProducts.CurrentCell.RowIndex);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
