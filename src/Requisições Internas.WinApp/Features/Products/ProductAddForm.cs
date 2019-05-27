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
        Product _product;
        public ProductAddForm(IUnitService unitService, IProductService productService, Product product = null)
        {
            InitializeComponent();
            _unitService = unitService;
            _productService = productService;

            cmbUnit.Items.AddRange(_unitService.GetAll().ToArray());

            if (product == null)
            {
                cmbUnit.SelectedIndex++;
            }
            else
            {
                _product = product;
                txtName.Text = product.Name;
                txtDescription.Text = product.Description;
                cmbUnit.SelectedItem = product.Unit;
                btnAddProduct.Text = "Atualizar";
                this.Text = "Atualizar produto";
            }
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
            _product = _product == null ? new Product() : _product;

            _product.Name = txtName.Text;
            _product.Description = txtDescription.Text;
            _product.Unit = (Unit)cmbUnit.SelectedItem;


            if (_product.Id > 0)
            {
                _productService.Update(_product);
            }
            else
            {
                _productService.Add(_product);
            }
            

            this.Close();
        }
    }
}
