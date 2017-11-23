using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            frmRecuperarSenha recupera = new frmRecuperarSenha();
            recupera.Show();
        }

        private void frmLogin_FormClosed (object sender, FormClosedEventArgs e)
        {
            /*this.Close();
            Process p = Process.GetCurrentProcess();
            p.Kill();*/
        }

        private void frmLogin_FormClosing (object sender, FormClosingEventArgs e)
        {
            //this.Close();
            Process p = Process.GetCurrentProcess();
            p.Kill();
        }

        private void frmLogin_Load (object sender, EventArgs e)
        {

        }

        private void btnFechar_Click (object sender, EventArgs e)
        {
            //this.Close();
            Process p = Process.GetCurrentProcess();
            p.Kill();
        }
    }
}
