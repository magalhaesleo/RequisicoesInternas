namespace Requisições_Internas.WinApp.Features.Providers
{
    partial class ProviderControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgProviders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProviders)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Pesquisar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 30;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(664, 50);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 23);
            this.btnAddNew.TabIndex = 29;
            this.btnAddNew.Text = "Adicionar Novo";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "ItemType";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(709, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(709, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtgProviders
            // 
            this.dtgProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProviders.Location = new System.Drawing.Point(20, 104);
            this.dtgProviders.MultiSelect = false;
            this.dtgProviders.Name = "dtgProviders";
            this.dtgProviders.ReadOnly = true;
            this.dtgProviders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProviders.Size = new System.Drawing.Size(683, 304);
            this.dtgProviders.TabIndex = 24;
            // 
            // ProviderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgProviders);
            this.Name = "ProviderControl";
            this.Size = new System.Drawing.Size(800, 426);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProviders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgProviders;
    }
}
