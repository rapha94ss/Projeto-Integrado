namespace WindowsFormsApp2
{
    partial class frmManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManutencao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodManutencao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codManutencaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRequisicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previsaoConclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoManutencaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manutencaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manutencaoDataSet = new WindowsFormsApp2.manutencaoDataSet();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cboTipoManutencao = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.mtbDataPrevisao = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataRequisicao = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.manutencaoTableAdapter = new WindowsFormsApp2.manutencaoDataSetTableAdapters.ManutencaoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCodManutencao);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.cboTipoManutencao);
            this.panel1.Controls.Add(this.cboStatus);
            this.panel1.Controls.Add(this.mtbDataPrevisao);
            this.panel1.Controls.Add(this.mtbDataRequisicao);
            this.panel1.Controls.Add(this.mtbCpf);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 475);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCodManutencao
            // 
            this.txtCodManutencao.Location = new System.Drawing.Point(588, 23);
            this.txtCodManutencao.Name = "txtCodManutencao";
            this.txtCodManutencao.Size = new System.Drawing.Size(73, 20);
            this.txtCodManutencao.TabIndex = 19;
            this.txtCodManutencao.TextChanged += new System.EventHandler(this.txtcodManutencao_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cadastrar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cliente sem cadastro?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codManutencaoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.dataRequisicaoDataGridViewTextBoxColumn,
            this.previsaoConclusaoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.tipoManutencaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.manutencaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 164);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // codManutencaoDataGridViewTextBoxColumn
            // 
            this.codManutencaoDataGridViewTextBoxColumn.DataPropertyName = "CodManutencao";
            this.codManutencaoDataGridViewTextBoxColumn.HeaderText = "CodManutencao";
            this.codManutencaoDataGridViewTextBoxColumn.Name = "codManutencaoDataGridViewTextBoxColumn";
            this.codManutencaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codManutencaoDataGridViewTextBoxColumn.Width = 75;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRequisicaoDataGridViewTextBoxColumn
            // 
            this.dataRequisicaoDataGridViewTextBoxColumn.DataPropertyName = "DataRequisicao";
            this.dataRequisicaoDataGridViewTextBoxColumn.HeaderText = "DataRequisicao";
            this.dataRequisicaoDataGridViewTextBoxColumn.Name = "dataRequisicaoDataGridViewTextBoxColumn";
            this.dataRequisicaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataRequisicaoDataGridViewTextBoxColumn.Width = 85;
            // 
            // previsaoConclusaoDataGridViewTextBoxColumn
            // 
            this.previsaoConclusaoDataGridViewTextBoxColumn.DataPropertyName = "PrevisaoConclusao";
            this.previsaoConclusaoDataGridViewTextBoxColumn.HeaderText = "PrevisaoConclusao";
            this.previsaoConclusaoDataGridViewTextBoxColumn.Name = "previsaoConclusaoDataGridViewTextBoxColumn";
            this.previsaoConclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.previsaoConclusaoDataGridViewTextBoxColumn.Width = 90;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoManutencaoDataGridViewTextBoxColumn
            // 
            this.tipoManutencaoDataGridViewTextBoxColumn.DataPropertyName = "TipoManutencao";
            this.tipoManutencaoDataGridViewTextBoxColumn.HeaderText = "TipoManutencao";
            this.tipoManutencaoDataGridViewTextBoxColumn.Name = "tipoManutencaoDataGridViewTextBoxColumn";
            this.tipoManutencaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manutencaoBindingSource
            // 
            this.manutencaoBindingSource.DataMember = "Manutencao";
            this.manutencaoBindingSource.DataSource = this.manutencaoDataSet;
            // 
            // manutencaoDataSet
            // 
            this.manutencaoDataSet.DataSetName = "manutencaoDataSet";
            this.manutencaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(249, 244);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(133, 244);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(25, 244);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cboTipoManutencao
            // 
            this.cboTipoManutencao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoManutencao.Items.AddRange(new object[] {
            "Preventiva",
            "Corretiva"});
            this.cboTipoManutencao.Location = new System.Drawing.Point(132, 208);
            this.cboTipoManutencao.Name = "cboTipoManutencao";
            this.cboTipoManutencao.Size = new System.Drawing.Size(121, 21);
            this.cboTipoManutencao.TabIndex = 12;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Em análise",
            "Em andamento",
            "Aguardando retorno do cliente",
            "Aguardando fornecedor",
            "Concluído"});
            this.cboStatus.Location = new System.Drawing.Point(68, 172);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(195, 21);
            this.cboStatus.TabIndex = 11;
            // 
            // mtbDataPrevisao
            // 
            this.mtbDataPrevisao.Location = new System.Drawing.Point(80, 136);
            this.mtbDataPrevisao.Mask = "99/99/9999";
            this.mtbDataPrevisao.Name = "mtbDataPrevisao";
            this.mtbDataPrevisao.Size = new System.Drawing.Size(100, 20);
            this.mtbDataPrevisao.TabIndex = 10;
            // 
            // mtbDataRequisicao
            // 
            this.mtbDataRequisicao.Location = new System.Drawing.Point(132, 96);
            this.mtbDataRequisicao.Mask = "99/99/9999";
            this.mtbDataRequisicao.Name = "mtbDataRequisicao";
            this.mtbDataRequisicao.Size = new System.Drawing.Size(100, 20);
            this.mtbDataRequisicao.TabIndex = 9;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(108, 59);
            this.mtbCpf.Mask = "99999999999";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(100, 20);
            this.mtbCpf.TabIndex = 8;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(86, 23);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(447, 20);
            this.txtDescricao.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Manutenção:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Previsão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data da Requisição:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF do Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // manutencaoTableAdapter
            // 
            this.manutencaoTableAdapter.ClearBeforeFill = true;
            // 
            // frmManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 510);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manutencao";
            this.Load += new System.EventHandler(this.frmManutencao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cboTipoManutencao;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.MaskedTextBox mtbDataPrevisao;
        private System.Windows.Forms.MaskedTextBox mtbDataRequisicao;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox txtDescricao;
        private manutencaoDataSet manutencaoDataSet;
        private System.Windows.Forms.BindingSource manutencaoBindingSource;
        private manutencaoDataSetTableAdapters.ManutencaoTableAdapter manutencaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codManutencaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRequisicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previsaoConclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoManutencaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodManutencao;
    }
}