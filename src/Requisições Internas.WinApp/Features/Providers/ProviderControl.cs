using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Requisições_Internas.Application.Features.Providers;
using Requisições_Internas.Domain.Features.Providers;

namespace Requisições_Internas.WinApp.Features.Providers
{
    public partial class ProviderControl : UserControl
    {
        IProviderService _providerService;
        public ProviderControl(IProviderService providerService)
        {
            InitializeComponent();
            _providerService = providerService;
            UpdateList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ProviderAddForm providerAddForm = new ProviderAddForm();
            var result = providerAddForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _providerService.Add(providerAddForm.Provider);
                UpdateList();
            }
        }

        private void UpdateList()
        {
            dtgProviders.DataSource = _providerService.GetAll().ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProviderAddForm providerForm = new ProviderAddForm();
            providerForm.Text = "Update";
            var a = dtgProviders.CurrentRow.Cells[0];
            //var provider = (Provider)dtgProviders.SelectedRows[0];
            
            //providerForm.SetProvider();

            providerForm.ShowDialog();
        }
    }
}
