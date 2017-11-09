namespace WindowsFormsApp2
{
    partial class frmVendasRealizadas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendasDataSet = new WindowsFormsApp2.vendasDataSet();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new WindowsFormsApp2.vendasDataSetTableAdapters.VendaTableAdapter();
            this.codVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codVendaDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.precoTotalDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.formaPagamentoDataGridViewTextBoxColumn,
            this.parcelasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // vendasDataSet
            // 
            this.vendasDataSet.DataSetName = "vendasDataSet";
            this.vendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.vendasDataSet;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // codVendaDataGridViewTextBoxColumn
            // 
            this.codVendaDataGridViewTextBoxColumn.DataPropertyName = "CodVenda";
            this.codVendaDataGridViewTextBoxColumn.HeaderText = "CodVenda";
            this.codVendaDataGridViewTextBoxColumn.Name = "codVendaDataGridViewTextBoxColumn";
            this.codVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // precoTotalDataGridViewTextBoxColumn
            // 
            this.precoTotalDataGridViewTextBoxColumn.DataPropertyName = "PrecoTotal";
            this.precoTotalDataGridViewTextBoxColumn.HeaderText = "PrecoTotal";
            this.precoTotalDataGridViewTextBoxColumn.Name = "precoTotalDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // formaPagamentoDataGridViewTextBoxColumn
            // 
            this.formaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "FormaPagamento";
            this.formaPagamentoDataGridViewTextBoxColumn.HeaderText = "FormaPagamento";
            this.formaPagamentoDataGridViewTextBoxColumn.Name = "formaPagamentoDataGridViewTextBoxColumn";
            // 
            // parcelasDataGridViewTextBoxColumn
            // 
            this.parcelasDataGridViewTextBoxColumn.DataPropertyName = "Parcelas";
            this.parcelasDataGridViewTextBoxColumn.HeaderText = "Parcelas";
            this.parcelasDataGridViewTextBoxColumn.Name = "parcelasDataGridViewTextBoxColumn";
            // 
            // frmVendasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 428);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVendasRealizadas";
            this.Text = "frmVendasRealizadas";
            this.Load += new System.EventHandler(this.frmVendasRealizadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private vendasDataSet vendasDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private vendasDataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasDataGridViewTextBoxColumn;
    }
}