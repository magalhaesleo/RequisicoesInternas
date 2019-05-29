namespace Requisições_Internas.WinApp.Features.Invoices
{
    partial class ProviderSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listProviders = new System.Windows.Forms.ListBox();
            this.btnSelectProvider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProviders
            // 
            this.listProviders.FormattingEnabled = true;
            this.listProviders.Location = new System.Drawing.Point(39, 60);
            this.listProviders.Name = "listProviders";
            this.listProviders.Size = new System.Drawing.Size(361, 238);
            this.listProviders.TabIndex = 0;
            // 
            // btnSelectProvider
            // 
            this.btnSelectProvider.Location = new System.Drawing.Point(170, 316);
            this.btnSelectProvider.Name = "btnSelectProvider";
            this.btnSelectProvider.Size = new System.Drawing.Size(75, 23);
            this.btnSelectProvider.TabIndex = 1;
            this.btnSelectProvider.Text = "Selecionar";
            this.btnSelectProvider.UseVisualStyleBackColor = true;
            this.btnSelectProvider.Click += new System.EventHandler(this.btnSelectProvider_Click);
            // 
            // ProviderSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 356);
            this.Controls.Add(this.btnSelectProvider);
            this.Controls.Add(this.listProviders);
            this.Name = "ProviderSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProviderSelection";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectProvider;
        public System.Windows.Forms.ListBox listProviders;
    }
}