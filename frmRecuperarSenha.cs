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
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha ()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click (object sender, EventArgs e)
        {
            string mensagem = new LoginDAO().recuperaSenha(mtbCpf.Text);
            MessageBox.Show(mensagem, "Palmeiras não tem mundial", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
