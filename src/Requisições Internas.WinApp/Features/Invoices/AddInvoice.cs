using Requisições_Internas.Application.Features.Invoices;
using Requisições_Internas.Application.Features.Products;
using Requisições_Internas.Domain.Features.Invoices;
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
    public partial class AddInvoice : Form
    {
        IInvoiceService _invoiceService;
        IProductService _productService;
        Invoice _invoice;
        public AddInvoice(IInvoiceService invoiceService, IProductService productService, Invoice invoice = null)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            _productService = productService;
            _invoice = invoice == null ? new Invoice() : invoice;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var products = dtgProducts.Rows.Cast<Product>();
            ProductSelection productSelection = new ProductSelection(_productService, products);
            productSelection.ShowDialog();
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            _invoice.Date = dateInvoice.MinDate;
        }
    }
}
