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
using Requisições_Internas.Application.Features.Providers;

namespace Requisições_Internas.WinApp.Features.Invoices
{
    public partial class InvoiceControl : UserControl
    {
        IInvoiceService _invoiceService;
        IProductService _productService;
        IProviderService _providerService;
        public InvoiceControl(IInvoiceService invoiceService, IProductService productService, IProviderService providerService)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            _productService = productService;
            _providerService = providerService;
            UpdateList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddInvoice addInvoice = new AddInvoice(_invoiceService, _productService, _providerService);
            addInvoice.ShowDialog();
            UpdateList();
        }

        void UpdateList()
        {
            dtgInvoices.DataSource = _invoiceService.GetAll().ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var invoice = _invoiceService.GetById((long)dtgInvoices.SelectedRows[0].Cells[6].Value);
            AddInvoice addInvoice = new AddInvoice(_invoiceService, _productService, _providerService, invoice);
            addInvoice.ShowDialog();
        }
    }
}
