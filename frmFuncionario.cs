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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private Funcionario montaFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Cpf = mtbCpf.Text;
            funcionario.Nome = txtNome.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.DataNascimento =  montaData(mtbDataNascimento.Text);
            funcionario.Celular = mtbCelular.Text;
            funcionario.Cep = mtbCep.Text;
            funcionario.Cargo = Convert.ToInt32(txtCargo.Text);
            funcionario.Numero = txtNumero.Text;
            return funcionario;
        }

        private string montaData(string data)
        {
            string[] sub = data.Split('/');//método para explodir uma cadeia de carecteres a partir do parametro informado no caso foi uma barra que suamos para separar a data
            string data_padrao_banco = sub[2] + "-"; //crio um vetor que armazena dia, mês, ano. Para o padrão do banco que ano-mês-dia
            data_padrao_banco += sub[1] + "-";
            data_padrao_banco += sub[0];

            return data_padrao_banco;
        }

        private void limpaCampos()
        {
            mtbCpf.Text = "";
            txtNome.Text = "";
            mtbDataNascimento.Text = "";
            mtbCep.Text = "";
            mtbCelular.Text = "";
            txtEndereco.Text = "";
            txtCargo.Text = "";
            txtNumero.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = montaFuncionario();
            string mensagem = new FuncionarioDAO().gravarFuncionario(funcionario);
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FuncionarioDAO funcDAO = new FuncionarioDAO();
            Funcionario funcionario = funcDAO.consultarFuncionario(mtbCpf.Text);
            if (funcionario != null)
            {
                txtNome.Text = funcionario.Nome;
                mtbDataNascimento.Text = funcionario.DataNascimento;
                mtbCelular.Text = funcionario.Celular;
                mtbCep.Text = funcionario.Cep;
                txtEndereco.Text = funcionario.Endereco;
                txtNumero.Text = funcionario.Numero;
                txtCargo.Text = funcionario.Cargo + "";
            }
            else
            {
                MessageBox.Show("Dados não encontrados", "Ihh rapai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        /*private void btnConsultaCEP_Click(object sender, EventArgs e)
        {
            try
            {
                var correio = new WSCorreios.AtendeClienteClient();
                var resposta = correio.consultaCEP(mtbCep.Text);
                txtEndereco.Text =resposta.end;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar endereço","",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }*/

        private void mtbCep_Leave(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = montaFuncionario();
            string mensagem = new FuncionarioDAO().alterarFuncionario(funcionario);
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string mensagem = new FuncionarioDAO().excluirFuncionario(mtbCpf.Text);
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
        }

        private void btnFornecerAcesso_Click(object sender, EventArgs e)
        {
            frmFornecerAcesso fornecerAcesso = new frmFornecerAcesso();
            this.Visible = false;
            fornecerAcesso.Show();
        }
    }
}
