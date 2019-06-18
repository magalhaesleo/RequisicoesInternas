using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Requisições_Internas.Application.Features.Products;
using Requisições_Internas.Application.Features.Requests;

namespace Requisições_Internas.WinApp.Features.Requests
{
    public partial class RequestControl : UserControl
    {
        IProductService _productService;
        IRequestService _requestService;
        public RequestControl(IProductService productService, IRequestService requestService)
        {
            InitializeComponent();
            _productService = productService;
            _requestService = requestService;
            UpdateListRequests();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddRequest addRequest = new AddRequest(_productService, _requestService);
            addRequest.ShowDialog();
            UpdateListRequests();
        }

        void UpdateListRequests()
        {
            dtgProducts.DataSource = _requestService.GetAll().ToList();
            dtgProducts.Columns["ProductsRequest"].Visible = false;
        }
    }
}
