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

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();

            provider.Name = txtName.Text;
            provider.CNPJ = txtCNPJ.Text;
            provider.Enabled = Domain.Object_Values.Enabled.YES;

            try
            { 
                provider.Validate();
                Provider = provider;
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
