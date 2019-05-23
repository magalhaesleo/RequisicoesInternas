using Requisições_Internas.Application.Features.Products;
using Requisições_Internas.Application.Features.Units;
using Requisições_Internas.Domain.Features.Products;
using Requisições_Internas.Domain.Features.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requisições_Internas.WinApp.Features.Products
{
    public partial class ProductAddForm : Form
    {
        IUnitService _unitService;
        IProductService _productService;
        public ProductAddForm(IUnitService unitService, IProductService productService)
        {
            InitializeComponent();
            _unitService = unitService;
            _productService = productService;

            cmbUnit.Items.AddRange(_unitService.GetAll().ToArray());

            cmbUnit.SelectedIndex++;
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cmbUnit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtDescription_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ProductAddForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = txtName.Text;
            product.Description = txtDescription.Text;
            product.Unit = (Unit)cmbUnit.SelectedItem;


            _productService.Add(product);

            this.Close();
        }
    }
}
