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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTesteCod = new System.Windows.Forms.Label();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.cboPreco = new System.Windows.Forms.ComboBox();
            this.estoqueBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDefDataSet = new WindowsFormsApp2.EstoqueDefDataSet();
            this.lblCarrinho = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.estoqueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vendaEstoqueDataSet = new WindowsFormsApp2.VendaEstoqueDataSet();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasDataSet = new WindowsFormsApp2.vendasDataSet();
            this.vendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblPrecoFinal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboParcelas = new System.Windows.Forms.ComboBox();
            this.cboFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.estoqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bancodedadosDataSet2 = new WindowsFormsApp2.bancodedadosDataSet2();
            this.bancodedadosDataSet1 = new WindowsFormsApp2.bancodedadosDataSet1();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter = new WindowsFormsApp2.bancodedadosDataSet1TableAdapters.EstoqueTableAdapter();
            this.estoqueTableAdapter1 = new WindowsFormsApp2.bancodedadosDataSet2TableAdapters.EstoqueTableAdapter();
            this.vendaTableAdapter = new WindowsFormsApp2.vendasDataSetTableAdapters.VendaTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridCarrinho = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimparCarrinho = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.estoqueTableAdapter2 = new WindowsFormsApp2.EstoqueDefDataSetTableAdapters.EstoqueTableAdapter();
            this.vendaTableAdapter1 = new WindowsFormsApp2.VendaEstoqueDataSetTableAdapters.VendaTableAdapter();
            this.estoqueBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter3 = new WindowsFormsApp2.VendaEstoqueDataSetTableAdapters.EstoqueTableAdapter();
            this.estoqueBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDefDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaEstoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodedadosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodedadosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTesteCod);
            this.panel1.Controls.Add(this.btnCarrinho);
            this.panel1.Controls.Add(this.cboPreco);
            this.panel1.Controls.Add(this.lblCarrinho);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboItem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 181);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTesteCod
            // 
            this.lblTesteCod.AutoSize = true;
            this.lblTesteCod.Location = new System.Drawing.Point(329, 41);
            this.lblTesteCod.Name = "lblTesteCod";
            this.lblTesteCod.Size = new System.Drawing.Size(63, 13);
            this.lblTesteCod.TabIndex = 23;
            this.lblTesteCod.Text = "CodProduto";
            this.lblTesteCod.Visible = false;
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Location = new System.Drawing.Point(121, 142);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(128, 23);
            this.btnCarrinho.TabIndex = 7;
            this.btnCarrinho.Text = "Adicionar ao Carrinho";
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // cboPreco
            // 
            this.cboPreco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estoqueBindingSource3, "CodProduto", true));
            this.cboPreco.DataSource = this.estoqueBindingSource3;
            this.cboPreco.DisplayMember = "Preco";
            this.cboPreco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPreco.FormattingEnabled = true;
            this.cboPreco.Location = new System.Drawing.Point(73, 57);
            this.cboPreco.Name = "cboPreco";
            this.cboPreco.Size = new System.Drawing.Size(121, 21);
            this.cboPreco.TabIndex = 2;
            this.cboPreco.ValueMember = "CodProduto";
            this.cboPreco.TextChanged += new System.EventHandler(this.cboPreco_TextChanged);
            // 
            // estoqueBindingSource3
            // 
            this.estoqueBindingSource3.DataMember = "Estoque";
            this.estoqueBindingSource3.DataSource = this.estoqueDefDataSet;
            // 
            // estoqueDefDataSet
            // 
            this.estoqueDefDataSet.DataSetName = "EstoqueDefDataSet";
            this.estoqueDefDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCarrinho
            // 
            this.lblCarrinho.AutoSize = true;
            this.lblCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrinho.Location = new System.Drawing.Point(425, 82);
            this.lblCarrinho.Name = "lblCarrinho";
            this.lblCarrinho.Size = new System.Drawing.Size(14, 15);
            this.lblCarrinho.TabIndex = 22;
            this.lblCarrinho.Text = "0";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(84, 100);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(73, 20);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Itens no carrinho: ";
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
            // cboItem
            // 
            this.cboItem.DataSource = this.estoqueBindingSource3;
            this.cboItem.DisplayMember = "Descricao";
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(73, 17);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(200, 21);
            this.cboItem.TabIndex = 1;
            this.cboItem.ValueMember = "Preco";
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
            // estoqueBindingSource2
            // 
            this.estoqueBindingSource2.DataMember = "Estoque";
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
            this.dataGridView1.DataSource = this.vendaBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(305, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(161, 63);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.Visible = false;
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
            // vendaBindingSource2
            // 
            this.vendaBindingSource2.DataMember = "Venda";
            this.vendaBindingSource2.DataSource = this.vendaEstoqueDataSet;
            // 
            // vendaEstoqueDataSet
            // 
            this.vendaEstoqueDataSet.DataSetName = "VendaEstoqueDataSet";
            this.vendaEstoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.vendasDataSetBindingSource;
            // 
            // vendasDataSetBindingSource
            // 
            this.vendasDataSetBindingSource.DataSource = this.vendasDataSet;
            this.vendasDataSetBindingSource.Position = 0;
            // 
            // vendasDataSet
            // 
            this.vendasDataSet.DataSetName = "vendasDataSet";
            this.vendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaBindingSource1
            // 
            this.vendaBindingSource1.DataMember = "Venda";
            this.vendaBindingSource1.DataSource = this.vendaEstoqueDataSet;
            // 
            // lblPrecoFinal
            // 
            this.lblPrecoFinal.AutoSize = true;
            this.lblPrecoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoFinal.Location = new System.Drawing.Point(427, 24);
            this.lblPrecoFinal.Name = "lblPrecoFinal";
            this.lblPrecoFinal.Size = new System.Drawing.Size(13, 20);
            this.lblPrecoFinal.TabIndex = 19;
            this.lblPrecoFinal.Text = "0";
            this.lblPrecoFinal.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "TOTAL À PAGAR: ";
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
            this.cboParcelas.Location = new System.Drawing.Point(73, 103);
            this.cboParcelas.Name = "cboParcelas";
            this.cboParcelas.Size = new System.Drawing.Size(121, 21);
            this.cboParcelas.TabIndex = 6;
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
            this.cboFormaPagamento.Location = new System.Drawing.Point(136, 59);
            this.cboFormaPagamento.Name = "cboFormaPagamento";
            this.cboFormaPagamento.Size = new System.Drawing.Size(121, 21);
            this.cboFormaPagamento.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Parcelas: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Forma de Pagamento: ";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(127, 149);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(112, 23);
            this.btnVender.TabIndex = 8;
            this.btnVender.Text = "Registrar Venda";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(73, 20);
            this.mtbCpf.Mask = "99999999999";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(100, 20);
            this.mtbCpf.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF: ";
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
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "R$";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.mtbCpf);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.cboParcelas);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboFormaPagamento);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblPrecoFinal);
            this.panel2.Controls.Add(this.btnVender);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 187);
            this.panel2.TabIndex = 24;
            // 
            // DataGridCarrinho
            // 
            this.DataGridCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Preço});
            this.DataGridCarrinho.Location = new System.Drawing.Point(520, 56);
            this.DataGridCarrinho.Name = "DataGridCarrinho";
            this.DataGridCarrinho.Size = new System.Drawing.Size(241, 150);
            this.DataGridCarrinho.TabIndex = 25;
            this.DataGridCarrinho.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridCarrinho_RowsRemoved);
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            // 
            // btnLimparCarrinho
            // 
            this.btnLimparCarrinho.Location = new System.Drawing.Point(583, 243);
            this.btnLimparCarrinho.Name = "btnLimparCarrinho";
            this.btnLimparCarrinho.Size = new System.Drawing.Size(124, 23);
            this.btnLimparCarrinho.TabIndex = 26;
            this.btnLimparCarrinho.Text = "Limpar Carrinho";
            this.btnLimparCarrinho.UseVisualStyleBackColor = true;
            this.btnLimparCarrinho.Click += new System.EventHandler(this.btnLimparCarrinho_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(531, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Itens no carrinho: ";
            // 
            // estoqueTableAdapter2
            // 
            this.estoqueTableAdapter2.ClearBeforeFill = true;
            // 
            // vendaTableAdapter1
            // 
            this.vendaTableAdapter1.ClearBeforeFill = true;
            // 
            // estoqueBindingSource4
            // 
            this.estoqueBindingSource4.DataMember = "Estoque";
            this.estoqueBindingSource4.DataSource = this.vendaEstoqueDataSet;
            // 
            // estoqueTableAdapter3
            // 
            this.estoqueTableAdapter3.ClearBeforeFill = true;
            // 
            // estoqueBindingSource5
            // 
            this.estoqueBindingSource5.DataMember = "Estoque";
            this.estoqueBindingSource5.DataSource = this.vendaEstoqueDataSet;
            // 
            // estoqueBindingSource6
            // 
            this.estoqueBindingSource6.DataMember = "Estoque";
            this.estoqueBindingSource6.DataSource = this.vendaEstoqueDataSet;
            // 
            // frmRegistroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 432);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLimparCarrinho);
            this.Controls.Add(this.DataGridCarrinho);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegistroVenda";
            this.Load += new System.EventHandler(this.frmRegistroVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDefDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaEstoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodedadosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodedadosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        //private estoqueDataSet estoqueDataSet;
        private System.Windows.Forms.BindingSource estoqueBindingSource2;
        //private estoqueDataSetTableAdapters.EstoqueTableAdapter estoqueTableAdapter2;
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
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.Label lblCarrinho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DataGridCarrinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.Button btnLimparCarrinho;
        private System.Windows.Forms.Label label10;
        private EstoqueDefDataSet estoqueDefDataSet;
        private System.Windows.Forms.BindingSource estoqueBindingSource3;
        private EstoqueDefDataSetTableAdapters.EstoqueTableAdapter estoqueTableAdapter2;
        private System.Windows.Forms.Label lblTesteCod;
        private VendaEstoqueDataSet vendaEstoqueDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource1;
        private VendaEstoqueDataSetTableAdapters.VendaTableAdapter vendaTableAdapter1;
        private System.Windows.Forms.BindingSource vendaBindingSource2;
        private System.Windows.Forms.BindingSource estoqueBindingSource4;
        private VendaEstoqueDataSetTableAdapters.EstoqueTableAdapter estoqueTableAdapter3;
        private System.Windows.Forms.BindingSource estoqueBindingSource6;
        private System.Windows.Forms.BindingSource estoqueBindingSource5;
    }
}