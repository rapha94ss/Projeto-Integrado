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
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha ()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click (object sender, EventArgs e)
        {
            if (new LoginDAO().validaLogin(txtUsuario.Text, txtSenha.Text))//primeiro verifica se usuario e senha atual estão corretos
            {
                if (new LoginDAO().alteraSenha(txtNovaSenha.Text, mtbCpf.Text))//chama método que altera senha
                {
                    MessageBox.Show("Senha alterada com sucesso!", "Aee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {

        }
    }
}
