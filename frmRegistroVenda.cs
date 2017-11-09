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
    public partial class frmRegistroVenda : Form
    {
        public frmRegistroVenda ()
        {
            InitializeComponent();
        }

        private Venda montaVenda ()
        {
            Venda venda = new Venda();
            venda.ItemVendido = cboItem.Text;
            venda.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            venda.Preco = float.Parse(cboPreco.Text) * Convert.ToInt32(txtQuantidade.Text);
            venda.Cpf = mtbCpf.Text;
            venda.FormaPagamento = cboFormaPagamento.Text;
            venda.Parcelas = Convert.ToInt32(cboParcelas.Text);
            return venda;
        }

        private void frmRegistroVenda_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendasDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.vendasDataSet.Venda);
            // TODO: This line of code loads data into the 'estoqueDataSet.Estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter2.Fill(this.estoqueDataSet.Estoque);
            // TODO: This line of code loads data into the 'bancodedadosDataSet2.Estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter1.Fill(this.bancodedadosDataSet2.Estoque);
            // TODO: This line of code loads data into the 'bancodedadosDataSet1.Estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter.Fill(this.bancodedadosDataSet1.Estoque);

        }

        private void button1_Click (object sender, EventArgs e)
        {
            /*lblTeste.Text = cboItem.SelectedValue.ToString();
            lblTeste2.Text = cboItem.Text;*/
        }

        private void cboPreco_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void cboItem_SelectedIndexChanged (object sender, EventArgs e)
        {
            cboPreco.ValueMember = cboItem.ValueMember;
        }

        private void btnVender_Click (object sender, EventArgs e)
        {
            Venda venda = montaVenda();
            string mensagem = new VendaDAO().RegistrarVenda(venda);
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.vendaTableAdapter.inserirVenda(cboItem.Text, lblPrecoFinal.Text, Convert.ToInt32(txtQuantidade.Text), mtbCpf.Text, cboFormaPagamento.Text, Convert.ToInt32(cboParcelas.Text));
            this.vendaTableAdapter.Fill(this.vendasDataSet.Venda);
            //limpaCampos();

        }

        private void txtQuantidade_TextChanged (object sender, EventArgs e)
        {
            if (txtQuantidade.Text != "")
            {
                var precoUnitario = float.Parse(cboPreco.Text);
                var quantidade = Convert.ToInt32(txtQuantidade.Text);
                lblPrecoFinal.Text = "R$" + (precoUnitario * quantidade).ToString();
            }
            else
            {
                lblPrecoFinal.Text = "";
            }
        }
    }
}
