using Requisições_Internas.Application.Features.Products;
using Requisições_Internas.Application.Features.Requests;
using Requisições_Internas.Domain.Features.ProductRequests;
using Requisições_Internas.Domain.Features.Requests;
using Requisições_Internas.Domain.Features.Users;
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
        User _user;
        Request _request;
        public AddRequest(IProductService productService, IRequestService requestService, User user, Request request = null)
        {
            InitializeComponent();
            _productService = productService;
            _requestService = requestService;
            _user = user;
            _request = request;

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

            if (_request != null)
            {
                foreach (var item in _request.ProductsRequest)
                {
                    dtgvProductsFound.Rows.Add(item.Product.Name, item.Product.Description, item.Product.Id, item.Quantity, item.Product.Unit);
                }
            }
            else
            {
                foreach (var item in productService.GetAll().ToList())
                {
                    dtgvProductsFound.Rows.Add(item.Name, item.Description, item.Id, 0, item.Unit);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
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
                    return;
                }
            }

         

            if (productRequests.Count > 0)
            {
                Request request = _request != null ? _request : new Request();
                request.ProductsRequest = productRequests;
                request.Status = Domain.Object_Values.Status.Aberto;
                request.DateRequest = DateTime.Now;
                request.AcceptanceDate = null;
                request.DeliveryDate = null;
                request.User = _user;
                _requestService.Add(request);
            }

            this.Close();
        }

        private void dtgvProductsFound_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ColumnQuantity_KeyPress);
            if (dtgvProductsFound.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnQuantity_KeyPress);
                }
            }
        }

        private void ColumnQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
