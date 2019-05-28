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
            try
            {
                var datasource = _providerService.GetAll();
                dtgProviders.DataSource = datasource.ToList();
            }
            catch (Exception)
            {
                dtgProviders.DataSource = new List<object>();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var a = dtgProviders.SelectedRows[0].Cells[4].Value;
            ProviderAddForm providerForm = new ProviderAddForm(_providerService.GetById((long)a));
            providerForm.Text = "Atualizar";
            providerForm.btnAddProvider.Text = "Atualizar";
            providerForm.ShowDialog();

            _providerService.Update(providerForm.Provider);
            UpdateList();
        }

        private void btnDeleteProvider_Click(object sender, EventArgs e)
        {
            if (dtgProviders.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem Certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _providerService.Delete((long)dtgProviders.SelectedRows[0].Cells[4].Value);
                    UpdateList();
                }
            }
        }
    }
}
