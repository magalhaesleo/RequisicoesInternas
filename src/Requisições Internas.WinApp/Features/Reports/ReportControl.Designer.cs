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
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.providers = new System.Windows.Forms.TabPage();
            this.products = new System.Windows.Forms.TabPage();
            this.users = new System.Windows.Forms.TabPage();
            this.nf = new System.Windows.Forms.TabPage();
            this.pedidos = new System.Windows.Forms.TabPage();
            this.cbAllStates = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.finalDate = new System.Windows.Forms.DateTimePicker();
            this.initialDate = new System.Windows.Forms.DateTimePicker();
            this.tabReports = new System.Windows.Forms.TabControl();
            this.cmbProductUnits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.products.SuspendLayout();
            this.pedidos.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(417, 248);
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
            this.saveFileDialog1.FileName = "Report";
            this.saveFileDialog1.Filter = "*.pdf|";
            // 
            // providers
            // 
            this.providers.Location = new System.Drawing.Point(4, 22);
            this.providers.Name = "providers";
            this.providers.Size = new System.Drawing.Size(468, 153);
            this.providers.TabIndex = 4;
            this.providers.Text = "Fornecedores";
            this.providers.UseVisualStyleBackColor = true;
            // 
            // products
            // 
            this.products.Controls.Add(this.label6);
            this.products.Controls.Add(this.cmbProductUnits);
            this.products.Location = new System.Drawing.Point(4, 22);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(468, 153);
            this.products.TabIndex = 3;
            this.products.Text = "Produtos";
            this.products.UseVisualStyleBackColor = true;
            // 
            // users
            // 
            this.users.Location = new System.Drawing.Point(4, 22);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(468, 153);
            this.users.TabIndex = 2;
            this.users.Text = "Usuários";
            this.users.UseVisualStyleBackColor = true;
            // 
            // nf
            // 
            this.nf.Location = new System.Drawing.Point(4, 22);
            this.nf.Name = "nf";
            this.nf.Padding = new System.Windows.Forms.Padding(3);
            this.nf.Size = new System.Drawing.Size(468, 153);
            this.nf.TabIndex = 1;
            this.nf.Text = "Notas Fiscais";
            this.nf.UseVisualStyleBackColor = true;
            // 
            // pedidos
            // 
            this.pedidos.Controls.Add(this.cbAllStates);
            this.pedidos.Controls.Add(this.label5);
            this.pedidos.Controls.Add(this.label4);
            this.pedidos.Controls.Add(this.label3);
            this.pedidos.Controls.Add(this.label2);
            this.pedidos.Controls.Add(this.cmbStatus);
            this.pedidos.Controls.Add(this.finalDate);
            this.pedidos.Controls.Add(this.initialDate);
            this.pedidos.Location = new System.Drawing.Point(4, 22);
            this.pedidos.Name = "pedidos";
            this.pedidos.Padding = new System.Windows.Forms.Padding(3);
            this.pedidos.Size = new System.Drawing.Size(468, 153);
            this.pedidos.TabIndex = 0;
            this.pedidos.Text = "Pedidos";
            this.pedidos.UseVisualStyleBackColor = true;
            // 
            // cbAllStates
            // 
            this.cbAllStates.AutoSize = true;
            this.cbAllStates.Location = new System.Drawing.Point(9, 125);
            this.cbAllStates.Name = "cbAllStates";
            this.cbAllStates.Size = new System.Drawing.Size(103, 17);
            this.cbAllStates.TabIndex = 30;
            this.cbAllStates.Text = "Todos os Status";
            this.cbAllStates.UseVisualStyleBackColor = true;
            this.cbAllStates.CheckedChanged += new System.EventHandler(this.cbAllStates_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Requisição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inicial";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(9, 98);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 3;
            // 
            // finalDate
            // 
            this.finalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finalDate.Location = new System.Drawing.Point(231, 52);
            this.finalDate.Name = "finalDate";
            this.finalDate.Size = new System.Drawing.Size(200, 20);
            this.finalDate.TabIndex = 2;
            // 
            // initialDate
            // 
            this.initialDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.initialDate.Location = new System.Drawing.Point(9, 52);
            this.initialDate.Name = "initialDate";
            this.initialDate.Size = new System.Drawing.Size(200, 20);
            this.initialDate.TabIndex = 1;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.pedidos);
            this.tabReports.Controls.Add(this.nf);
            this.tabReports.Controls.Add(this.users);
            this.tabReports.Controls.Add(this.products);
            this.tabReports.Controls.Add(this.providers);
            this.tabReports.Location = new System.Drawing.Point(20, 63);
            this.tabReports.Name = "tabReports";
            this.tabReports.SelectedIndex = 0;
            this.tabReports.Size = new System.Drawing.Size(476, 179);
            this.tabReports.TabIndex = 0;
            // 
            // cmbProductUnits
            // 
            this.cmbProductUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductUnits.FormattingEnabled = true;
            this.cmbProductUnits.Location = new System.Drawing.Point(3, 26);
            this.cmbProductUnits.Name = "cmbProductUnits";
            this.cmbProductUnits.Size = new System.Drawing.Size(121, 21);
            this.cmbProductUnits.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Unidade:";
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabReports);
            this.Controls.Add(this.btnGenerateReport);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(800, 426);
            this.products.ResumeLayout(false);
            this.products.PerformLayout();
            this.pedidos.ResumeLayout(false);
            this.pedidos.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.TabPage providers;
        private System.Windows.Forms.TabPage products;
        private System.Windows.Forms.TabPage users;
        private System.Windows.Forms.TabPage nf;
        private System.Windows.Forms.TabPage pedidos;
        private System.Windows.Forms.CheckBox cbAllStates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker finalDate;
        private System.Windows.Forms.DateTimePicker initialDate;
        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProductUnits;
    }
}
