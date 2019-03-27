using Requisições_Internas.WinApp.Features.Invoices;
using Requisições_Internas.WinApp.Features.Orders;
using Requisições_Internas.WinApp.Features.Personal_Data;
using Requisições_Internas.WinApp.Features.Products;
using Requisições_Internas.WinApp.Features.Providers;
using Requisições_Internas.WinApp.Features.Reports;
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
       // private readonly ProductControl _productControl;
        private readonly ProviderControl _providerControl;
        private readonly InvoiceControl _invoiceControl;
        private readonly OrderControl _orderControl;
        private readonly UsersControl _usersControl;
        private readonly ReportControl _reportsControl;
        private readonly PersonalDataControl _personalDataControl;

        public Main(ProviderControl providerControl, InvoiceControl invoiceControl, OrderControl orderControl, UsersControl usersControl, ReportControl reportsControl,  PersonalDataControl personalDataControl)
        {
            InitializeComponent();
            _providerControl = providerControl;
            _invoiceControl = invoiceControl;
            _orderControl = orderControl;
          //  _productControl = productControl;
            _usersControl = usersControl;
            _reportsControl = reportsControl;
            _personalDataControl = personalDataControl;
        }

        private void ChangeControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(control);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
       //     ChangeControl(_productControl);
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
            ChangeControl(_orderControl);
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
