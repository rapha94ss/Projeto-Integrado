namespace WindowsFormsApp2
{
    partial class frmManutencoesConcluidas
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
            this.manutencaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByConcluidosToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByConcluidosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.manutencaoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manutencaoDataSet = new WindowsFormsApp2.manutencaoDataSet();
            this.manutencaoTableAdapter = new WindowsFormsApp2.manutencaoDataSetTableAdapters.ManutencaoTableAdapter();
            this.manutencaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.codManutencaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoManutencaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRequisicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previsaoConclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource)).BeginInit();
            this.fillByConcluidosToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codManutencaoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.tipoManutencaoDataGridViewTextBoxColumn,
            this.dataRequisicaoDataGridViewTextBoxColumn,
            this.previsaoConclusaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.manutencaoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 441);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // manutencaoBindingSource
            // 
            this.manutencaoBindingSource.DataMember = "Manutencao";
            this.manutencaoBindingSource.DataSource = this.manutencaoDataSetBindingSource;
            // 
            // fillByConcluidosToolStrip
            // 
            this.fillByConcluidosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByConcluidosToolStripButton});
            this.fillByConcluidosToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByConcluidosToolStrip.Name = "fillByConcluidosToolStrip";
            this.fillByConcluidosToolStrip.Size = new System.Drawing.Size(795, 25);
            this.fillByConcluidosToolStrip.TabIndex = 1;
            this.fillByConcluidosToolStrip.Text = "fillByConcluidosToolStrip";
            this.fillByConcluidosToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByConcluidosToolStrip_ItemClicked);
            // 
            // fillByConcluidosToolStripButton
            // 
            this.fillByConcluidosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByConcluidosToolStripButton.Name = "fillByConcluidosToolStripButton";
            this.fillByConcluidosToolStripButton.Size = new System.Drawing.Size(99, 22);
            this.fillByConcluidosToolStripButton.Text = "FillByConcluidos";
            this.fillByConcluidosToolStripButton.Click += new System.EventHandler(this.fillByConcluidosToolStripButton_Click);
            // 
            // manutencaoDataSetBindingSource
            // 
            this.manutencaoDataSetBindingSource.DataSource = this.manutencaoDataSet;
            this.manutencaoDataSetBindingSource.Position = 0;
            // 
            // manutencaoDataSet
            // 
            this.manutencaoDataSet.DataSetName = "manutencaoDataSet";
            this.manutencaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manutencaoTableAdapter
            // 
            this.manutencaoTableAdapter.ClearBeforeFill = true;
            // 
            // manutencaoBindingSource1
            // 
            this.manutencaoBindingSource1.DataMember = "Manutencao";
            this.manutencaoBindingSource1.DataSource = this.manutencaoDataSetBindingSource;
            // 
            // codManutencaoDataGridViewTextBoxColumn
            // 
            this.codManutencaoDataGridViewTextBoxColumn.DataPropertyName = "CodManutencao";
            this.codManutencaoDataGridViewTextBoxColumn.HeaderText = "CodManutencao";
            this.codManutencaoDataGridViewTextBoxColumn.Name = "codManutencaoDataGridViewTextBoxColumn";
            this.codManutencaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // tipoManutencaoDataGridViewTextBoxColumn
            // 
            this.tipoManutencaoDataGridViewTextBoxColumn.DataPropertyName = "TipoManutencao";
            this.tipoManutencaoDataGridViewTextBoxColumn.HeaderText = "TipoManutencao";
            this.tipoManutencaoDataGridViewTextBoxColumn.Name = "tipoManutencaoDataGridViewTextBoxColumn";
            // 
            // dataRequisicaoDataGridViewTextBoxColumn
            // 
            this.dataRequisicaoDataGridViewTextBoxColumn.DataPropertyName = "DataRequisicao";
            this.dataRequisicaoDataGridViewTextBoxColumn.HeaderText = "DataRequisicao";
            this.dataRequisicaoDataGridViewTextBoxColumn.Name = "dataRequisicaoDataGridViewTextBoxColumn";
            // 
            // previsaoConclusaoDataGridViewTextBoxColumn
            // 
            this.previsaoConclusaoDataGridViewTextBoxColumn.DataPropertyName = "PrevisaoConclusao";
            this.previsaoConclusaoDataGridViewTextBoxColumn.HeaderText = "PrevisaoConclusao";
            this.previsaoConclusaoDataGridViewTextBoxColumn.Name = "previsaoConclusaoDataGridViewTextBoxColumn";
            // 
            // frmManutencoesConcluidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 497);
            this.Controls.Add(this.fillByConcluidosToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmManutencoesConcluidas";
            this.Text = "frmManutencoesConcluidas";
            this.Load += new System.EventHandler(this.frmManutencoesConcluidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource)).EndInit();
            this.fillByConcluidosToolStrip.ResumeLayout(false);
            this.fillByConcluidosToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource manutencaoDataSetBindingSource;
        private manutencaoDataSet manutencaoDataSet;
        private System.Windows.Forms.BindingSource manutencaoBindingSource;
        private manutencaoDataSetTableAdapters.ManutencaoTableAdapter manutencaoTableAdapter;
        private System.Windows.Forms.ToolStrip fillByConcluidosToolStrip;
        private System.Windows.Forms.ToolStripButton fillByConcluidosToolStripButton;
        private System.Windows.Forms.BindingSource manutencaoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codManutencaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoManutencaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRequisicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previsaoConclusaoDataGridViewTextBoxColumn;
    }
}