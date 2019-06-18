using Requisições_Internas.Application.Features.Invoices;
using Requisições_Internas.Application.Features.Products;
using Requisições_Internas.Application.Features.Providers;
using Requisições_Internas.Domain.Features.Invoices;
using Requisições_Internas.Domain.Features.Products;
using Requisições_Internas.Domain.Features.Providers;
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
        IProviderService _providerService;
        Invoice _invoice;
        Provider _provider;
        public AddInvoice(IInvoiceService invoiceService, IProductService productService, IProviderService providerService, Invoice invoice = null)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            _productService = productService;
            _providerService = providerService;
            _invoice = invoice == null ? new Invoice() : invoice;

            if (invoice != null)
            {
                dateInvoice.Value = _invoice.Date;
                txtInvoice.Text = _invoice.Sequence;
                List<Product> products = new List<Product>();
                dtgProducts.DataSource = _invoice.Products;
                maksValue.Text = _invoice.Value.ToString();
                txtSerie.Text = _invoice.Sequence;
                txtCNPJ.Text = _invoice.Provider.CNPJ;
                txtName.Text = _invoice.Name;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < dtgProducts.Rows.Count; i++)
            {
                products.Add(_productService.GetById((long)dtgProducts.Rows[i].Cells[4].Value));
            }
           
            ProductSelection productSelection = new ProductSelection(_productService, products);
            productSelection.ShowDialog();
            dtgProducts.DataSource = productSelection.SelectedProducts;
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            _invoice.Date = dateInvoice.Value;
            _invoice.Number = txtInvoice.Text;
            _invoice.Name = txtName.Text;
            List<Product> products = new List<Product>();
            for (int i = 0; i < dtgProducts.Rows.Count; i++)
            {
                products.Add(_productService.GetById((long)dtgProducts.Rows[i].Cells[4].Value));
            }
            _invoice.Products = products;
            _invoice.Provider = _provider;
            maksValue.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            _invoice.Value = decimal.Parse(maksValue.Text);
            maksValue.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            _invoice.Sequence = txtSerie.Text;

            _invoiceService.Add(_invoice);

            this.Close();
        }

        private void btnSelectProvider_Click(object sender, EventArgs e)
        {
            ProviderSelection providerSelection = new ProviderSelection(_providerService);
            providerSelection.ShowDialog();
            _provider = providerSelection.GetSelectedProvider();

            if (_provider != null)
            {
                txtCNPJ.Text = _provider.CNPJ;
            }
        }
    }
}
