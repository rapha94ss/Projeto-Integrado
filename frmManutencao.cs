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
    public partial class frmManutencao : Form
    {
        public frmManutencao ()
        {
            InitializeComponent();
        }

        private Manutencao montaManutencao ()
        {
            Manutencao manutencao = new Manutencao();
            manutencao.Descricao = txtDescricao.Text;
            manutencao.Cpf = mtbCpf.Text;
            manutencao.DataRequisicao = montaData(mtbDataRequisicao.Text);
            manutencao.PrevisaoConclusao = montaData(mtbDataPrevisao.Text);
            manutencao.Status = cboStatus.Text;
            manutencao.TipoManutencao = cboTipoManutencao.Text;
            return manutencao;
        }

        private string montaData (string data)
        {
            string[] sub = data.Split('/');//método para explodir uma cadeia de carecteres a partir do parametro informado no caso foi uma barra que suamos para separar a data
            string data_padrao_banco = sub[2] + "-"; //crio um vetor que armazena dia, mês, ano. Para o padrão do banco que ano-mês-dia
            data_padrao_banco += sub[1] + "-";
            data_padrao_banco += sub[0];

            return data_padrao_banco;
        }

        private void limpaCampos ()
        {
            txtCodManutencao.Text = "";
            txtDescricao.Text = "";
            mtbCpf.Text = "";
            mtbDataPrevisao.Text = "";
            mtbDataRequisicao.Text = "";
            cboStatus.Text = "";
            cboTipoManutencao.Text = "";
        }

        private void label4_Click (object sender, EventArgs e)
        {

        }

        private void label7_Click (object sender, EventArgs e)
        {

        }

        private void frmManutencao_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manutencaoDataSet.Manutencao' table. You can move, or remove it, as needed.
            this.manutencaoTableAdapter.Fill(this.manutencaoDataSet.Manutencao);

        }

        private void btnCadastrar_Click (object sender, EventArgs e)
        {
            Manutencao manutencao = montaManutencao();
            string mensagem = new ManutencaoDAO().gravarManutencao(manutencao);
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.manutencaoTableAdapter.inserirManutencao(txtDescricao.Text, mtbCpf.Text, Convert.ToDateTime(mtbDataRequisicao.Text), Convert.ToDateTime(mtbDataPrevisao.Text), cboStatus.Text, cboTipoManutencao.Text);
            this.manutencaoTableAdapter.Fill(this.manutencaoDataSet.Manutencao);
            limpaCampos();
        }

        private void dataGridView1_CellContentDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodManutencao.Text = dataGridView1.SelectedCells[0].Value.ToString();
                txtDescricao.Text = dataGridView1.SelectedCells[1].Value.ToString();
                mtbCpf.Text = dataGridView1.SelectedCells[2].Value.ToString();
                mtbDataRequisicao.Text = dataGridView1.SelectedCells[3].Value.ToString();
                mtbDataPrevisao.Text = dataGridView1.SelectedCells[4].Value.ToString();
                cboStatus.Text = dataGridView1.SelectedCells[5].Value.ToString();
                cboTipoManutencao.Text = dataGridView1.SelectedCells[6].Value.ToString();
            }
            catch (Exception ex)
            {

            }
            
        }

        private void panel1_Paint (object sender, PaintEventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            frmCli.Show();
        }

        private void txtcodManutencao_TextChanged (object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click (object sender, EventArgs e)
        {
            try
            {
                string cod = txtCodManutencao.Text;
                Manutencao manutencao = montaManutencao();
                string mensagem = new ManutencaoDAO().alterarManutencao(montaManutencao(), cod);
                MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.manutencaoTableAdapter.editarManutencao(txtDescricao.Text, mtbCpf.Text, Convert.ToDateTime(mtbDataRequisicao.Text), Convert.ToDateTime(mtbDataPrevisao.Text), cboStatus.Text, cboTipoManutencao.Text, Convert.ToInt32(txtCodManutencao.Text));
                this.manutencaoTableAdapter.Fill(this.manutencaoDataSet.Manutencao);
                limpaCampos();
            }
            catch (Exception ex)
            {

            }
            
        }

        private void btnExcluir_Click (object sender, EventArgs e)
        {
            string mensagem = new ManutencaoDAO().excluirManutencao(txtCodManutencao.Text);
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.manutencaoTableAdapter.excluirManutencao(Convert.ToInt32(txtCodManutencao.Text));
            this.manutencaoTableAdapter.Fill(this.manutencaoDataSet.Manutencao);
            limpaCampos();
        }

        private void dataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
