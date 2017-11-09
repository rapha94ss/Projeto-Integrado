using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmFornecerAcesso : Form
    {
        public frmFornecerAcesso()
        {
            InitializeComponent();
        }

        private Login montaLogin()
        {
            Login login = new Login();
            login.Usuario = txtUsuario.Text;
            login.Senha = txtSenha.Text;
            login.Cpf = mtbCpf.Text;

            return login; 
        }

        private void limpaCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtConfirmaSenha.Text = "";
            mtbCpf.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//criar acesso
        {
                if (txtSenha.Text.Equals(txtConfirmaSenha.Text ) && txtSenha.Text!="")
                {
                    Login login = montaLogin();
                    string mensagem = new LoginDAO().CadastrarLogin(login);
                    MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampos();
                }
                else
                {
                    MessageBox.Show("Senhas não conferem", "Ihhh rapai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }           
        }
    }
}
