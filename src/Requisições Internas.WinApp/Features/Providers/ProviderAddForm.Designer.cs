namespace Requisições_Internas.WinApp.Features.Providers
{
    partial class ProviderAddForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProvider = new System.Windows.Forms.Button();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 20);
            this.txtName.TabIndex = 0;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(23, 133);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(308, 20);
            this.txtTelephone.TabIndex = 2;
            this.txtTelephone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CNPJ";
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.Location = new System.Drawing.Point(256, 186);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(75, 23);
            this.btnAddProvider.TabIndex = 4;
            this.btnAddProvider.Text = "Adicionar";
            this.btnAddProvider.UseVisualStyleBackColor = true;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(23, 76);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(308, 20);
            this.txtCNPJ.TabIndex = 1;
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Checked = true;
            this.cbEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnabled.Location = new System.Drawing.Point(23, 161);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(79, 17);
            this.cbEnabled.TabIndex = 3;
            this.cbEnabled.Text = "Habilitado?";
            this.cbEnabled.UseVisualStyleBackColor = true;
            // 
            // ProviderAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 225);
            this.Controls.Add(this.cbEnabled);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.btnAddProvider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProviderAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProviderAddForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductAddForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProvider;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.CheckBox cbEnabled;
    }
}