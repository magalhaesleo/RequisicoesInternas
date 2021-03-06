﻿namespace Requisições_Internas.WinApp.Features.Requests
{
    partial class RequestControl
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateRequisition = new System.Windows.Forms.Button();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.cmbRequestStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(687, 41);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(94, 23);
            this.btnAddNew.TabIndex = 28;
            this.btnAddNew.Text = "Adicionar Novo";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Requisições";
            // 
            // btnUpdateRequisition
            // 
            this.btnUpdateRequisition.Location = new System.Drawing.Point(687, 70);
            this.btnUpdateRequisition.Name = "btnUpdateRequisition";
            this.btnUpdateRequisition.Size = new System.Drawing.Size(94, 23);
            this.btnUpdateRequisition.TabIndex = 25;
            this.btnUpdateRequisition.Text = "Editar";
            this.btnUpdateRequisition.UseVisualStyleBackColor = true;
            this.btnUpdateRequisition.Click += new System.EventHandler(this.btnUpdateRequisition_Click);
            // 
            // dtgProducts
            // 
            this.dtgProducts.AllowUserToAddRows = false;
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Location = new System.Drawing.Point(15, 41);
            this.dtgProducts.MultiSelect = false;
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.ReadOnly = true;
            this.dtgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducts.Size = new System.Drawing.Size(666, 361);
            this.dtgProducts.TabIndex = 24;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(687, 99);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(94, 23);
            this.btnUpdateStatus.TabIndex = 31;
            this.btnUpdateStatus.Text = "Atualizar Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // cmbRequestStatus
            // 
            this.cmbRequestStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequestStatus.FormattingEnabled = true;
            this.cmbRequestStatus.Location = new System.Drawing.Point(434, 14);
            this.cmbRequestStatus.Name = "cmbRequestStatus";
            this.cmbRequestStatus.Size = new System.Drawing.Size(247, 21);
            this.cmbRequestStatus.TabIndex = 32;
            this.cmbRequestStatus.SelectedIndexChanged += new System.EventHandler(this.cmbRequestStatus_SelectedIndexChanged);
            // 
            // RequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbRequestStatus);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateRequisition);
            this.Controls.Add(this.dtgProducts);
            this.Name = "RequestControl";
            this.Size = new System.Drawing.Size(800, 426);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateRequisition;
        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.ComboBox cmbRequestStatus;
    }
}
