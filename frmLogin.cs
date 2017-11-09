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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            bool validou = new LoginDAO().validaLogin(usuario, senha);

            if (validou)
            {
                frmMenuPrincipal principal = new frmMenuPrincipal();
                this.Visible = false;
                principal.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos", "OOOPS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSuporte suporte = new frmSuporte();
            suporte.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
