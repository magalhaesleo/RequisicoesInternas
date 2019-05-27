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

namespace Requisições_Internas.WinApp.Features.Providers
{
    public partial class ProviderAddForm : Form
    {
        public Provider Provider { get; set; }
        public ProviderAddForm()
        {
            InitializeComponent();
        }

        public ProviderAddForm(Provider provider) : this()
        {
            Provider = provider;
            txtName.Text = Provider.Name;
            txtCNPJ.Text = Provider.CNPJ;
            txtTelephone.Text = Provider.Telephone;
            cbEnabled.Checked = Provider.Enabled;
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cmbUnit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtDescription_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ProductAddForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        public void SetProvider(Provider provider)
        {
            txtName.Text = provider.Name;
            txtCNPJ.Text = provider.CNPJ;
            txtTelephone.Text = provider.Telephone;
            cbEnabled.Checked = provider.Enabled;
        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            Provider = Provider == null ? new Provider() : Provider;

            Provider.Name = txtName.Text;
            Provider.CNPJ = txtCNPJ.Text;
            Provider.Telephone = txtTelephone.Text;
            Provider.Enabled = cbEnabled.Checked;

            try
            {
                Provider.Validate();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                throw;
            }

        }
    }
}
