namespace WindowsFormsApp2
{
    partial class frmEstoque
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
            this.components = new System.ComponentModel.Container();
            this.bancodedadosDataSet = new WindowsFormsApp2.bancodedadosDataSet();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new WindowsFormsApp2.bancodedadosDataSetTableAdapters.FuncionariosTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cboTipoProduto = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSet1 = new WindowsFormsApp2.EstoqueDataSet1();
            this.estoqueTableAdapter = new WindowsFormsApp2.EstoqueDataSet1TableAdapters.EstoqueTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bancodedadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // bancodedadosDataSet
            // 
            this.bancodedadosDataSet.DataSetName = "bancodedadosDataSet";
            this.bancodedadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.bancodedadosDataSet;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPrecoUnitario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCodProduto);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.cboTipoProduto);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 417);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Este TextBox fica oculto, serve para editar e excluir produtos";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(434, 167);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(57, 20);
            this.txtCodProduto.TabIndex = 5;
            this.txtCodProduto.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(548, 141);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(548, 92);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdutoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.tipoProdutoDataGridViewTextBoxColumn,
            this.Preco});
            this.dataGridView1.DataSource = this.estoqueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(632, 162);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(548, 41);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboTipoProduto
            // 
            this.cboTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProduto.FormattingEnabled = true;
            this.cboTipoProduto.Items.AddRange(new object[] {
            "--Selecione--",
            "Software",
            "Monitor",
            "Gabinete",
            "Fone",
            "Pen Drive",
            "HD",
            "Capa de Celular",
            "Película",
            "Mouse",
            "Teclado",
            "Peças de Manutenção"});
            this.cboTipoProduto.Location = new System.Drawing.Point(120, 86);
            this.cboTipoProduto.Name = "cboTipoProduto";
            this.cboTipoProduto.Size = new System.Drawing.Size(121, 21);
            this.cboTipoProduto.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(92, 51);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(92, 17);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(323, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Produto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição: ";
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "Estoque";
            this.estoqueBindingSource.DataSource = this.estoqueDataSet1;
            // 
            // estoqueDataSet1
            // 
            this.estoqueDataSet1.DataSetName = "EstoqueDataSet1";
            this.estoqueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Preço Unitário: ";
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(104, 124);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoUnitario.TabIndex = 13;
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "CodProduto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "CodProduto";
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            this.codProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codProdutoDataGridViewTextBoxColumn.Width = 90;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoProdutoDataGridViewTextBoxColumn
            // 
            this.tipoProdutoDataGridViewTextBoxColumn.DataPropertyName = "TipoProduto";
            this.tipoProdutoDataGridViewTextBoxColumn.HeaderText = "TipoProduto";
            this.tipoProdutoDataGridViewTextBoxColumn.Name = "tipoProdutoDataGridViewTextBoxColumn";
            this.tipoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoProdutoDataGridViewTextBoxColumn.Width = 150;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preco";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 441);
            this.Controls.Add(this.panel1);
            this.Name = "frmEstoque";
            this.Text = "frmEstoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancodedadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private bancodedadosDataSet bancodedadosDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private bancodedadosDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboTipoProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EstoqueDataSet1 estoqueDataSet1;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private EstoqueDataSet1TableAdapters.EstoqueTableAdapter estoqueTableAdapter;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
    }
}