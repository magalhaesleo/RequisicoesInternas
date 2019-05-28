using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Requisições_Internas.Application.Features.Invoices;
using Requisições_Internas.Application.Features.Products;

namespace Requisições_Internas.WinApp.Features.Invoices
{
    public partial class InvoiceControl : UserControl
    {
        IInvoiceService _invoiceService;
        IProductService _productService;
        public InvoiceControl(IInvoiceService invoiceService, IProductService productService)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            _productService = productService;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddInvoice addInvoice = new AddInvoice(_invoiceService, _productService);
            addInvoice.ShowDialog();
        }
    }
}
