using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Requisições_Internas.Application.Features.Requests;
using Requisições_Internas.Application.Features.Invoices;
using Requisições_Internas.Application.Base;
using Requisições_Internas.Application.Features.Users;
using Requisições_Internas.Application.Features.Products;
using Requisições_Internas.Application.Features.Providers;

namespace Requisições_Internas.WinApp.Features.Reports
{
    public partial class ReportControl : UserControl
    {
        IRequestService _requestService;
        IInvoiceService _invoiceService;
        IUserService _userService;
        IProductService _productService;
        IProviderService _providerService;
        public ReportControl(IRequestService requestService, IInvoiceService invoiceService, IUserService userService, IProductService productService, IProviderService providerService)
        {
            InitializeComponent();
            _requestService = requestService;
            _invoiceService = invoiceService;
            _userService = userService;
            _productService = productService;
            _providerService = providerService;

            var items = new List<string>() { "Requisições", "Notas fiscais", "Usuários", "Produtos", "Fornecedores" };

            cmbReportType.Items.AddRange(items.ToArray());
            cmbReportType.SelectedIndex++;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            string selectedItem = (string)cmbReportType.SelectedItem;

            bool generated = false;
            
            if (selectedItem == "Requisições")
            {
                generated = _requestService.GeneratePDFReport(saveFileDialog1.FileName);
            }

            if (selectedItem == "Notas fiscais")
            {
                generated = _invoiceService.GeneratePDFReport(saveFileDialog1.FileName);
            }

            if (selectedItem == "Usuários")
            {
                generated = _userService.GeneratePDFReport(saveFileDialog1.FileName);
            }

            if (selectedItem == "Produtos")
            {
                generated = _productService.GeneratePDFReport(saveFileDialog1.FileName);
            }

            if (selectedItem == "Fornecedores")
            {
                generated = _providerService.GeneratePDFReport(saveFileDialog1.FileName);
            }

            if (generated)
                MessageBox.Show("PDF Gerado com sucesso");
        }
    }
}
