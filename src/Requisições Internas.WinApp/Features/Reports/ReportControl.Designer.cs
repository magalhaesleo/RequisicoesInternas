namespace Requisições_Internas.WinApp.Features.Reports
{
    partial class ReportControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pedidos = new System.Windows.Forms.TabPage();
            this.nf = new System.Windows.Forms.TabPage();
            this.users = new System.Windows.Forms.TabPage();
            this.products = new System.Windows.Forms.TabPage();
            this.providers = new System.Windows.Forms.TabPage();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pedidos);
            this.tabControl1.Controls.Add(this.nf);
            this.tabControl1.Controls.Add(this.users);
            this.tabControl1.Controls.Add(this.products);
            this.tabControl1.Controls.Add(this.providers);
            this.tabControl1.Location = new System.Drawing.Point(472, 276);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(308, 127);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // pedidos
            // 
            this.pedidos.Location = new System.Drawing.Point(4, 22);
            this.pedidos.Name = "pedidos";
            this.pedidos.Padding = new System.Windows.Forms.Padding(3);
            this.pedidos.Size = new System.Drawing.Size(300, 101);
            this.pedidos.TabIndex = 0;
            this.pedidos.Text = "Pedidos";
            this.pedidos.UseVisualStyleBackColor = true;
            // 
            // nf
            // 
            this.nf.Location = new System.Drawing.Point(4, 22);
            this.nf.Name = "nf";
            this.nf.Padding = new System.Windows.Forms.Padding(3);
            this.nf.Size = new System.Drawing.Size(300, 101);
            this.nf.TabIndex = 1;
            this.nf.Text = "Notas Fiscais";
            this.nf.UseVisualStyleBackColor = true;
            // 
            // users
            // 
            this.users.Location = new System.Drawing.Point(4, 22);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(300, 101);
            this.users.TabIndex = 2;
            this.users.Text = "Usuários";
            this.users.UseVisualStyleBackColor = true;
            // 
            // products
            // 
            this.products.Location = new System.Drawing.Point(4, 22);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(300, 101);
            this.products.TabIndex = 3;
            this.products.Text = "Produtos";
            this.products.UseVisualStyleBackColor = true;
            // 
            // providers
            // 
            this.providers.Location = new System.Drawing.Point(4, 22);
            this.providers.Name = "providers";
            this.providers.Size = new System.Drawing.Size(300, 101);
            this.providers.TabIndex = 4;
            this.providers.Text = "Fornecedores";
            this.providers.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(455, 151);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateReport.TabIndex = 0;
            this.btnGenerateReport.Text = "Gerar";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Relatorios";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "*.pdf|";
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(270, 124);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(260, 21);
            this.cmbReportType.TabIndex = 30;
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbReportType);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pedidos;
        private System.Windows.Forms.TabPage nf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage users;
        private System.Windows.Forms.TabPage products;
        private System.Windows.Forms.TabPage providers;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cmbReportType;
    }
}
