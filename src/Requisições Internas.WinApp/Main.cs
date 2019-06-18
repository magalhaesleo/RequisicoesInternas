using NLog;
using Requisições_Internas.Domain.Features.Users;
using Requisições_Internas.WinApp.Features.Invoices;
using Requisições_Internas.WinApp.Features.Personal_Data;
using Requisições_Internas.WinApp.Features.Products;
using Requisições_Internas.WinApp.Features.Providers;
using Requisições_Internas.WinApp.Features.Reports;
using Requisições_Internas.WinApp.Features.Requests;
using Requisições_Internas.WinApp.Features.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requisições_Internas.WinApp
{
    public partial class Main : Form
    {
        private readonly ProductControl _productControl;
        private readonly ProviderControl _providerControl;
        private readonly InvoiceControl _invoiceControl;
        private readonly RequestControl _requestControl;
        private readonly UsersControl _usersControl;
        private readonly ReportControl _reportsControl;
        private readonly PersonalDataControl _personalDataControl;
        Logger _logger;
        User _user;

        public Main(ProviderControl providerControl, InvoiceControl invoiceControl, RequestControl requestControl, UsersControl usersControl, ReportControl reportsControl, ProductControl productControl, PersonalDataControl personalDataControl)
        {
            _logger = LogManager.GetCurrentClassLogger();
            _logger.Debug("Iniciando Menu Principal");
            InitializeComponent();
            _providerControl = providerControl;
            _invoiceControl = invoiceControl;
            _requestControl = requestControl;
            _productControl = productControl;
            _usersControl = usersControl;
            _reportsControl = reportsControl;
            _personalDataControl = personalDataControl;
        }

        public void SetUser(User user)
        {
            _user = user;
        }

        private void ChangeControl(UserControl control)
        {
            _logger.Debug("Alterando control");
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(control);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeControl(_productControl);
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeControl(_providerControl);
        }


        private void notasFiscaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeControl(_invoiceControl);
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeControl(_requestControl);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeControl(_usersControl);
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeControl(_reportsControl);
        }

        private void seusDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeControl(_personalDataControl);
        }
    }
}
