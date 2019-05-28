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
        private BindingList<Product> _selectedProducts;

        public ProductSelection(IProductService productService, IEnumerable<Product> products)
        {
            InitializeComponent();
            _productService = productService;

            dtgvProductsFound.DataSource = _productService.GetAll().Take(10).ToList();
            if (products.Count() > 0)
                _selectedProducts = new BindingList<Product>(products.ToList());
            else
                _selectedProducts = new BindingList<Product>();

            dtgSelectedProducts.DataSource = _selectedProducts;
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            long id = (long)dtgvProductsFound.SelectedRows[0].Cells[4].Value;
            _selectedProducts.Add(_productService.GetById(id));
        }
    }
}
