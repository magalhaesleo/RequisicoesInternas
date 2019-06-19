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

namespace Requisições_Internas.WinApp.Features.Reports
{
    public partial class ReportControl : UserControl
    {
        IRequestService _requestService;
        public ReportControl(IRequestService requestService)
        {
            InitializeComponent();
            _requestService = requestService;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            if (_requestService.GeneratePDFReport(saveFileDialog1.FileName + ".pdf"))
                MessageBox.Show("PDF Gerado com sucesso");
        }
    }
}
