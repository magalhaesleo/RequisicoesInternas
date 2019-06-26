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
using Requisições_Internas.Domain.Object_Values;
using Requisições_Internas.Application.Features.Units;
using Requisições_Internas.Domain.Features.Units;

namespace Requisições_Internas.WinApp.Features.Reports
{
    public partial class ReportControl : UserControl
    {
        IRequestService _requestService;
        IInvoiceService _invoiceService;
        IUserService _userService;
        IProductService _productService;
        IProviderService _providerService;
        IUnitService _unitService;
        bool allStates = false;
        public ReportControl(IRequestService requestService, IInvoiceService invoiceService, IUserService userService, IProductService productService, IProviderService providerService, IUnitService unitService)
        {
            InitializeComponent();
            _requestService = requestService;
            _invoiceService = invoiceService;
            _userService = userService;
            _productService = productService;
            _providerService = providerService;
            _unitService = unitService;

            foreach (var item in Enum.GetValues(typeof(Status)))
            {
                cmbStatus.Items.Add(item);
            }
            
            cmbProductUnits.Items.AddRange(_unitService.GetAll().ToArray());

            cmbProductUnits.SelectedIndex++;
            cmbStatus.SelectedIndex++;
        }

        public void GenerateReport()
        {
            saveFileDialog1.ShowDialog();

            bool generated = false;

            switch (tabReports.SelectedIndex)
            {
                case 0:
                    if (allStates)
                        generated = _requestService.GeneratePDFReport(initialDate.Value, finalDate.Value, saveFileDialog1.FileName);
                    else
                        generated = _requestService.GeneratePDFReport(initialDate.Value, finalDate.Value, (Status)cmbStatus.SelectedItem, saveFileDialog1.FileName);
                    break;
                case 1:
                    generated = _invoiceService.GeneratePDFReport(saveFileDialog1.FileName);
                    break;
                case 2:
                    generated = _userService.GeneratePDFReport(saveFileDialog1.FileName);
                    break;
                case 3:
                    generated = _productService.GeneratePDFReport((Unit)cmbProductUnits.SelectedItem, saveFileDialog1.FileName);
                    break;
                case 4:
                    generated = _providerService.GeneratePDFReport(saveFileDialog1.FileName);
                    break;
                default:
                    break;
            }


            if (generated)
                MessageBox.Show("PDF Gerado com sucesso");
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void cbAllStates_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllStates.Checked)
            {
                cmbStatus.Enabled = false;
                allStates = true;
            }
            else
            {
                cmbStatus.Enabled = true;
                allStates = false;
            }
        }

    }
}
