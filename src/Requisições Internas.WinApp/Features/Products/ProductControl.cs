using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Requisições_Internas.Application.Features.Units;
using Requisições_Internas.Application.Features.Products;

namespace Requisições_Internas.WinApp.Features.Products
{
    public partial class ProductControl : UserControl
    {
        IUnitService _unitService;
        IProductService _productService;
        public ProductControl(IUnitService unitService, IProductService productService)
        {
            InitializeComponent();
            _unitService = unitService;
            _productService = productService;
            UpdateList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ProductAddForm productAddFrm = new ProductAddForm(_unitService, _productService);
            productAddFrm.ShowDialog();
            UpdateList();
        }

        private void UpdateList()
        {
            this.dtgProducts.DataSource = _productService.GetAll().ToList();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dtgProducts.SelectedRows.Count > 0)
            {
                var product = _productService.GetById((long)dtgProducts.SelectedRows[0].Cells[4].Value);
                ProductAddForm productAddForm = new ProductAddForm(_unitService, _productService, product);
                productAddForm.ShowDialog();
                UpdateList();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

            if (dtgProducts.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem Certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _productService.Delete((long)dtgProducts.SelectedRows[0].Cells[4].Value);
                    UpdateList();
                }
            }
        }
    }
}
