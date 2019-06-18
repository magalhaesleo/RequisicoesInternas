using Requisições_Internas.Application.Features.Products;
using Requisições_Internas.Application.Features.Requests;
using Requisições_Internas.Domain.Features.ProductRequests;
using Requisições_Internas.Domain.Features.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requisições_Internas.WinApp.Features.Requests
{
    public partial class AddRequest : Form
    {
        IProductService _productService;
        IRequestService _requestService;
        public AddRequest(IProductService productService, IRequestService requestService)
        {
            InitializeComponent();
            _productService = productService;
            _requestService = requestService;
           
            DataGridViewTextBoxColumn description = new DataGridViewTextBoxColumn()
            {
                Name = "description",
                HeaderText = "Descrição",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn productName = new DataGridViewTextBoxColumn()
            {
                Name = "productName",
                HeaderText = "Produto",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn productId = new DataGridViewTextBoxColumn()
            {
                Name = "id",
                HeaderText = "ID",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn productUnit = new DataGridViewTextBoxColumn()
            {
                Name = "unit",
                HeaderText = "Unit",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn quantity = new DataGridViewTextBoxColumn()
            {
                Name = "quantity",
                HeaderText = "Quantidade",
                ReadOnly = false
            };

            dtgvProductsFound.Columns.Add(productName);
            dtgvProductsFound.Columns.Add(description);
            dtgvProductsFound.Columns.Add(productId);
            dtgvProductsFound.Columns.Add(quantity);
            dtgvProductsFound.Columns.Add(productUnit);

            foreach (var item in productService.GetAll().ToList())
            {
                dtgvProductsFound.Rows.Add(item.Name, item.Description, item.Id, 0, item.Unit);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            List < ProductRequest > productRequests= new List<ProductRequest>();

            foreach (DataGridViewRow item in dtgvProductsFound.Rows)
            {
                try
                {
                    int quantity = int.Parse(item.Cells["quantity"].Value.ToString());

                    if (quantity > 0)
                    {
                        var product = _productService.GetById(int.Parse(item.Cells["id"].Value.ToString()));
                        productRequests.Add(new ProductRequest() { Product = product, Quantity = quantity });
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("campo quantidade aceita apenas numeros");
                }
            }
            request.ProductsRequest = productRequests;

            if (productRequests.Count > 0)
            {
                request.DateRequest = DateTime.Now;
                _requestService.Add(request);
            }

            this.Close();
        }
    }
}
