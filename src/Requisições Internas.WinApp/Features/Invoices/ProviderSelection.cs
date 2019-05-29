using Requisições_Internas.Application.Features.Providers;
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
    public partial class ProviderSelection : Form
    {
        IProviderService _providerService;
        public ProviderSelection(IProviderService providerService)
        {
            InitializeComponent();
            _providerService = providerService;

            listProviders.Items.AddRange(_providerService.GetAll().ToArray());
        }

        private void btnSelectProvider_Click(object sender, EventArgs e)
        {
            if (listProviders.SelectedIndex >= 0)
            {
                this.Close();
            }
        }

        public Provider GetSelectedProvider()
        {
            return listProviders.SelectedItem as Provider;
        }
    }
}
