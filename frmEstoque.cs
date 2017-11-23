using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
            this.estoqueTableAdapter.Fill(this.estoqueDataSet1.Estoque);
        }

        private Estoque montaEstoque()
        {
            Estoque estoque = new Estoque();
            estoque.Descricao = txtDescricao.Text;
            estoque.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            estoque.TipoProduto = cboTipoProduto.Text;
            estoque.PrecoUnitario = decimal.Parse(txtPrecoUnitario.Text);
            estoque.Fornecedor = cboFornecedor.Text;
            return estoque;
        }

        private void limpaCampos ()
        {
            txtDescricao.Text = "";
            txtQuantidade.Text = "";
            cboTipoProduto.Text = "";
            txtPrecoUnitario.Text = "";
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fornecedorEstoqueDataSet.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.fornecedorEstoqueDataSet.Fornecedor);
            // TODO: This line of code loads data into the 'vendaEstoqueDataSet.Estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter1.Fill(this.vendaEstoqueDataSet.Estoque);
            // TODO: This line of code loads data into the 'estoqueDataSet1.Estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter.Fill(this.estoqueDataSet1.Estoque);
            // TODO: This line of code loads data into the 'bancodedadosDataSet.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.bancodedadosDataSet.Funcionarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Ops, preencha o campo DESCRICAO do produto", "IHH Rapai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Ops, preencha o campo QUANTIDADE do produto", "IHH Rapai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboTipoProduto.Text == "")
            {
                MessageBox.Show("Ops, selecione o TIPO DO PRODUTO", "IHH Rapai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPrecoUnitario.Text == "")
            {
                MessageBox.Show("Ops, preencha o VALOR UNITÁRIO DO PRODUTO", "IHH Rapai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Estoque estoque = montaEstoque();
                string mensagem = new EstoqueDAO().CadastrarEstoque(estoque);
                MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.estoqueTableAdapter1.inserirEstoque(txtDescricao.Text, Convert.ToInt32(txtQuantidade.Text), cboTipoProduto.Text, decimal.Parse(txtPrecoUnitario.Text), cboFornecedor.Text);
                this.estoqueTableAdapter1.Fill(this.vendaEstoqueDataSet.Estoque);//insere no banco de dados
                limpaCampos();
            }
        }

        private void btnEditar_Click (object sender, EventArgs e)
        {
            if (txtCodProduto.Text == "")
            {
                MessageBox.Show("Ops, preencha o campo de CÓDIGO do produto", "IHH Rapai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtDescricao.Text == "")
            {
                MessageBox.Show("Ops, preencha o campo DESCRICAO do produto", "IHH Rapai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Ops, preencha o campo QUANTIDADE do produto", "IHH Rapai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboTipoProduto.Text == "")
            {
                MessageBox.Show("Ops, selecione o TIPO DO PRODUTO", "IHH Rapai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPrecoUnitario.Text == "")
            {
                MessageBox.Show("Ops, preencha o VALOR UNITÁRIO DO PRODUTO", "IHH Rapai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Estoque estoque = montaEstoque();
                string mensagem = new EstoqueDAO().editarEstoque(estoque, Convert.ToInt32(txtCodProduto.Text));
                MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.estoqueTableAdapter1.editarEstoque(estoque.Descricao, estoque.Quantidade, estoque.TipoProduto, estoque.PrecoUnitario, estoque.Fornecedor, Convert.ToInt32(txtCodProduto.Text));
                this.estoqueTableAdapter1.Fill(this.vendaEstoqueDataSet.Estoque);
                limpaCampos();
            }
        }

        private void btnExcluir_Click (object sender, EventArgs e)
        {
            string mensagem = new EstoqueDAO().excluirEstoque(Convert.ToInt32(txtCodProduto.Text));
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.estoqueTableAdapter1.excluirEstoque(Convert.ToInt32(txtCodProduto.Text));
            this.estoqueTableAdapter1.Fill(this.vendaEstoqueDataSet.Estoque);
            limpaCampos();
        }

        private void label4_Click (object sender, EventArgs e)
        {

        }

        //carrega os dados no formulário assim que uma linha do DataGrid é selecionada
        private void dataGridView1_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodProduto.Text = dataGridView1.SelectedCells[0].Value.ToString();
                txtDescricao.Text = dataGridView1.SelectedCells[1].Value.ToString();
                txtQuantidade.Text = dataGridView1.SelectedCells[2].Value.ToString();
                cboTipoProduto.Text = dataGridView1.SelectedCells[3].Value.ToString();
                txtPrecoUnitario.Text = dataGridView1.SelectedCells[4].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint (object sender, PaintEventArgs e)
        {

        }

        private void frmEstoque_Shown (object sender, EventArgs e)
        {
            this.estoqueTableAdapter.Fill(this.estoqueDataSet1.Estoque);
        }

        private void panel1_MouseEnter (object sender, EventArgs e)
        {
            this.estoqueTableAdapter.Fill(this.estoqueDataSet1.Estoque);
        }

        private void panel1_MouseHover (object sender, EventArgs e)
        {
            this.estoqueTableAdapter.Fill(this.estoqueDataSet1.Estoque);
        }

        private void btnAtualizarEstoque_Click (object sender, EventArgs e)
        {
            this.estoqueTableAdapter.Fill(this.estoqueDataSet1.Estoque);
        }
    }
}
