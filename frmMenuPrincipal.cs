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
    public partial class frmMenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            frmRegistroVenda venda = new frmRegistroVenda();
            venda.MdiParent = this;
            venda.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            /*this.Close();
            Process p = Process.GetCurrentProcess();
            p.Kill();*/
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
            Process p = Process.GetCurrentProcess();
            p.Kill();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            frmCliente frmCli = new frmCliente();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            frmEstoque frmEst = new frmEstoque();
            frmEst.MdiParent = this;
            frmEst.Show();
        }

        private void manutençãoToolStripMenuItem_Click (object sender, EventArgs e)
        {
            
        }

        private void gerenciarManutençõesToolStripMenuItem_Click (object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            frmManutencao frmMan = new frmManutencao();
            frmMan.MdiParent = this;
            frmMan.Show();
        }

        private void manutençõesConcluídasToolStripMenuItem_Click (object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            frmManutencoesConcluidas frmMan = new frmManutencoesConcluidas();
            frmMan.MdiParent = this;
            frmMan.Show();
        }

        private void fileMenu_Click (object sender, EventArgs e)
        {

        }

        private void verTodasToolStripMenuItem_Click (object sender, EventArgs e)
        {
            frmVendasRealizadas vendas = new frmVendasRealizadas();
            vendas.MdiParent = this;
            vendas.Show();
        }

        private void fornecedorToolStripMenuItem_Click (object sender, EventArgs e)
        {
            frmFornecedor fornecedor = new frmFornecedor();
            fornecedor.MdiParent = this;
            fornecedor.Show();
        }

        private void gerenciarContaToolStripMenuItem_Click (object sender, EventArgs e)
        {
            frmAlterarSenha altera = new frmAlterarSenha();
            altera.MdiParent = this;
            altera.Show();
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click (object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            frmFuncionario frmFun = new frmFuncionario();
            frmFun.MdiParent = this;
            frmFun.Show();
        }

        private void frmMenuPrincipal_FormClosing (object sender, FormClosingEventArgs e)
        {
            Process p = Process.GetCurrentProcess();
            p.Kill();
        }
    }
}
