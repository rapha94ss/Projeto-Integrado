namespace WindowsFormsApp2
{
    partial class frmRegistroVenda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVender = new System.Windows.Forms.Button();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.estoqueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSet = new WindowsFormsApp2.estoqueDataSet();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.estoqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bancodedadosDataSet2 = new WindowsFormsApp2.bancodedadosDataSet2();
            this.bancodedadosDataSet1 = new WindowsFormsApp2.bancodedadosDataSet1();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter = new WindowsFormsApp2.bancodedadosDataSet1TableAdapters.EstoqueTableAdapter();
            this.estoqueTableAdapter1 = new WindowsFormsApp2.bancodedadosDataSet2TableAdapters.EstoqueTableAdapter();
            this.estoqueTableAdapter2 = new WindowsFormsApp2.estoqueDataSetTableAdapters.EstoqueTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFormaPagamento = new System.Windows.Forms.ComboBox();
            this.cboParcelas = new System.Windows.Forms.ComboBox();
            this.cboPreco = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrecoFinal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendasDataSet = new WindowsFormsApp2.vendasDataSet();
            this.vendasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new WindowsFormsApp2.vendasDataSetTableAdapters.VendaTableAdapter();
            this.codVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodedadosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodedadosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblPrecoFinal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboPreco);
            this.panel1.Controls.Add(this.cboParcelas);
            this.panel1.Controls.Add(this.cboFormaPagamento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnVender);
            this.panel1.Controls.Add(this.mtbCpf);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboItem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 359);
            this.panel1.TabIndex = 0;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(45, 279);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(112, 23);
            this.btnVender.TabIndex = 7;
            this.btnVender.Text = "Registrar Venda";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(73, 145);
            this.mtbCpf.Mask = "99999999999";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(100, 20);
            this.mtbCpf.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(84, 100);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(73, 20);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preço: ";
            // 
            // estoqueBindingSource2
            // 
            this.estoqueBindingSource2.DataMember = "Estoque";
            this.estoqueBindingSource2.DataSource = this.estoqueDataSet;
            // 
            // estoqueDataSet
            // 
            this.estoqueDataSet.DataSetName = "estoqueDataSet";
            this.estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboItem
            // 
            this.cboItem.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estoqueBindingSource2, "Preco", true));
            this.cboItem.DataSource = this.estoqueBindingSource2;
            this.cboItem.DisplayMember = "Descricao";
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(73, 17);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(200, 21);
            this.cboItem.TabIndex = 1;
            this.cboItem.ValueMember = "CodProduto";
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.cboItem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item: ";
            // 
            // estoqueBindingSource1
            // 
            this.estoqueBindingSource1.DataMember = "Estoque";
            this.estoqueBindingSource1.DataSource = this.bancodedadosDataSet2;
            // 
            // bancodedadosDataSet2
            // 
            this.bancodedadosDataSet2.DataSetName = "bancodedadosDataSet2";
            this.bancodedadosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bancodedadosDataSet1
            // 
            this.bancodedadosDataSet1.DataSetName = "bancodedadosDataSet1";
            this.bancodedadosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "Estoque";
            this.estoqueBindingSource.DataSource = this.bancodedadosDataSet1;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // estoqueTableAdapter1
            // 
            this.estoqueTableAdapter1.ClearBeforeFill = true;
            // 
            // estoqueTableAdapter2
            // 
            this.estoqueTableAdapter2.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Forma de Pagamento: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Parcelas: ";
            // 
            // cboFormaPagamento
            // 
            this.cboFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPagamento.FormattingEnabled = true;
            this.cboFormaPagamento.Items.AddRange(new object[] {
            "Débito",
            "Crédito",
            "Dinheiro",
            "Bitcoin"});
            this.cboFormaPagamento.Location = new System.Drawing.Point(127, 184);
            this.cboFormaPagamento.Name = "cboFormaPagamento";
            this.cboFormaPagamento.Size = new System.Drawing.Size(121, 21);
            this.cboFormaPagamento.TabIndex = 5;
            // 
            // cboParcelas
            // 
            this.cboParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParcelas.FormattingEnabled = true;
            this.cboParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboParcelas.Location = new System.Drawing.Point(73, 228);
            this.cboParcelas.Name = "cboParcelas";
            this.cboParcelas.Size = new System.Drawing.Size(121, 21);
            this.cboParcelas.TabIndex = 6;
            // 
            // cboPreco
            // 
            this.cboPreco.DataSource = this.estoqueBindingSource2;
            this.cboPreco.DisplayMember = "Preco";
            this.cboPreco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPreco.FormattingEnabled = true;
            this.cboPreco.Location = new System.Drawing.Point(73, 57);
            this.cboPreco.Name = "cboPreco";
            this.cboPreco.Size = new System.Drawing.Size(121, 21);
            this.cboPreco.TabIndex = 2;
            this.cboPreco.ValueMember = "CodProduto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "TOTAL À PAGAR: ";
            // 
            // lblPrecoFinal
            // 
            this.lblPrecoFinal.AutoSize = true;
            this.lblPrecoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoFinal.Location = new System.Drawing.Point(382, 104);
            this.lblPrecoFinal.Name = "lblPrecoFinal";
            this.lblPrecoFinal.Size = new System.Drawing.Size(23, 16);
            this.lblPrecoFinal.TabIndex = 19;
            this.lblPrecoFinal.Text = "---";
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
            this.dataGridView1.Location = new System.Drawing.Point(340, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(161, 63);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.Visible = false;
            // 
            // vendasDataSet
            // 
            this.vendasDataSet.DataSetName = "vendasDataSet";
            this.vendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasDataSetBindingSource
            // 
            this.vendasDataSetBindingSource.DataSource = this.vendasDataSet;
            this.vendasDataSetBindingSource.Position = 0;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.vendasDataSetBindingSource;
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
            // frmRegistroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 395);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegistroVenda";
            this.Text = "frmRegistroVenda";
            this.Load += new System.EventHandler(this.frmRegistroVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodedadosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodedadosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboItem;
        private bancodedadosDataSet1 bancodedadosDataSet1;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private bancodedadosDataSet1TableAdapters.EstoqueTableAdapter estoqueTableAdapter;
        private bancodedadosDataSet2 bancodedadosDataSet2;
        private System.Windows.Forms.BindingSource estoqueBindingSource1;
        private bancodedadosDataSet2TableAdapters.EstoqueTableAdapter estoqueTableAdapter1;
        private System.Windows.Forms.Label label2;
        private estoqueDataSet estoqueDataSet;
        private System.Windows.Forms.BindingSource estoqueBindingSource2;
        private estoqueDataSetTableAdapters.EstoqueTableAdapter estoqueTableAdapter2;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.ComboBox cboParcelas;
        private System.Windows.Forms.ComboBox cboFormaPagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPreco;
        private System.Windows.Forms.Label lblPrecoFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vendasDataSetBindingSource;
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