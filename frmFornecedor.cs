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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor ()
        {
            InitializeComponent();
        }

        private Fornecedor montaFornecedor ()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Nome = txtNome.Text;
            fornecedor.Tipo = cboTipo.Text;
            fornecedor.Cnpj = mtbCnpj.Text;
            fornecedor.Cep = mtbCep.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Numero = txtNumero.Text;
            fornecedor.Site = txtSite.Text;
            fornecedor.Telefone = mtbTelefone.Text;
            fornecedor.Email = txtEmail.Text;

            return fornecedor;
        }

        private void label3_Click (object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged (object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click (object sender, EventArgs e)
        {
            Fornecedor fornecedor = montaFornecedor();
            string mensagem = new FornecedorDAO().registrarFornecedor(fornecedor);
            this.fornecedorTableAdapter.inserirFornecedor(fornecedor.Nome, fornecedor.Tipo, fornecedor.Cnpj, fornecedor.Cep, fornecedor.Endereco, fornecedor.Numero, fornecedor.Site, fornecedor.Telefone, fornecedor.Email);
            this.fornecedorTableAdapter.Fill(this.fornecedorEstoqueDataSet.Fornecedor);//preenche o DataGrid com dados vindos da tabela fornecedor
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmFornecedor_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fornecedorEstoqueDataSet.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.fornecedorEstoqueDataSet.Fornecedor);

        }

        private void dataGridViewFornecedor_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblCodFornecedor.Text = dataGridViewFornecedor.SelectedCells[0].Value.ToString();
                txtNome.Text = dataGridViewFornecedor.SelectedCells[1].Value.ToString();
                cboTipo.Text = dataGridViewFornecedor.SelectedCells[2].Value.ToString();
                mtbCnpj.Text = dataGridViewFornecedor.SelectedCells[3].Value.ToString();
                mtbCep.Text = dataGridViewFornecedor.SelectedCells[4].Value.ToString();
                txtEndereco.Text = dataGridViewFornecedor.SelectedCells[5].Value.ToString();
                txtNumero.Text = dataGridViewFornecedor.SelectedCells[6].Value.ToString();
                txtSite.Text = dataGridViewFornecedor.SelectedCells[7].Value.ToString();
                mtbTelefone.Text = dataGridViewFornecedor.SelectedCells[8].Value.ToString();
                txtEmail.Text = dataGridViewFornecedor.SelectedCells[9].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void mtbCep_Leave (object sender, EventArgs e)
        {
            try
            {
                var correio = new WSCorreios.AtendeClienteClient();
                var resposta = correio.consultaCEP(mtbCep.Text);
                txtEndereco.Text = resposta.end;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar endereço", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
