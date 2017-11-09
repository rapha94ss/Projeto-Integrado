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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private Cliente montaCliente()
        {
            Cliente cliente = new Cliente();
            cliente.Cpf = mtbCpf.Text;
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Celular = mtbCpf.Text;

            return cliente;
        }

        private void limpaCampos()
        {
            mtbCpf.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            mtbCelular.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = montaCliente();
            string mensagem = new ClienteDAO().CadastrarCliente(cliente);
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente cliente = clienteDAO.consultarCliente(mtbCpf.Text);
            if (cliente != null)
            {
                txtNome.Text = cliente.Nome;
                txtEmail.Text = cliente.Email;
                mtbCelular.Text = cliente.Celular;           
            }
            else
            {
                MessageBox.Show("Dados não encontrados", "Ihh rapai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = montaCliente();
            string mensagem = new ClienteDAO().editarCliente(cliente);
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string mensagem = new ClienteDAO().excluirCliente(mtbCpf.Text);
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCampos();
        }
    }
}
