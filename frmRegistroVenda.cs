﻿using System;
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

        private Venda montaCarrinho ()
        {
            Venda venda = new Venda();
            venda.ItemVendido = cboItem.Text;
            venda.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            venda.Preco = decimal.Parse(cboPreco.Text) * Convert.ToInt32(txtQuantidade.Text);
            return venda;
        }
        
        private Venda montaVenda (Venda venda)
        {
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
            cboItem.ValueMember = cboPreco.ValueMember;
        }

        private void cboItem_SelectedIndexChanged (object sender, EventArgs e)
        {
            cboPreco.ValueMember = cboItem.ValueMember;
        }

        //*************Declaro vetor que persiste o carrinho de itens*************************
        Venda[] carrinho = new Venda[10];
        int cont = 0;
        //************************************************************************************
        private void btnVender_Click (object sender, EventArgs e)
        {
            string mensagem = "";
            for (int i = 0; i < carrinho.Length; i++)
            {
                if (carrinho[i] == null)
                {
                    break;
                }
                Venda venda = new Venda();
                venda = carrinho[i];
                montaVenda(venda);
                this.vendaTableAdapter.inserirVenda(venda.ItemVendido, venda.Preco, venda.Quantidade, venda.Cpf, venda.FormaPagamento, venda.Parcelas);
                this.vendaTableAdapter.Fill(this.vendasDataSet.Venda);
                mensagem = new VendaDAO().RegistrarVenda(venda);
            }
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //limpaCampos();
        }

        private void txtQuantidade_TextChanged (object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint (object sender, PaintEventArgs e)
        {

        }

        private void btnCarrinho_Click (object sender, EventArgs e)
        {
            carrinho[cont] = montaCarrinho();
            MessageBox.Show("Adicionado com sucesso ao carrinho", "Sucesso");

            //imprime na janela o valor total dos itens adicionados no carrinho
            var precoFinal = decimal.Parse(lblPrecoFinal.Text);
            lblPrecoFinal.Text = "" + (precoFinal + carrinho[cont].Preco);
            
            //atualiza na janela a quantidade de itens no carrinho
            var car=0;
            car = Convert.ToInt32(lblCarrinho.Text);
            car = car + 1;
            lblCarrinho.Text = "" + car;

            DataGridCarrinho.Rows.Add(carrinho[cont].ItemVendido, carrinho[cont].Preco);

            //imcremento na variavel para alocar opcionais novos itens ao carrinho
            cont++;
        }

        private void label9_Click (object sender, EventArgs e)
        {

        }

        private void DataGridCarrinho_RowsRemoved (object sender, DataGridViewRowsRemovedEventArgs e)
        {
            carrinho[e.RowIndex] = null;
        }

        private void btnLimparCarrinho_Click (object sender, EventArgs e)
        {
            for (int i = 0; i < carrinho.Length; i++)
            {
                carrinho[i] = null;
            }
            DataGridCarrinho.Rows.Clear();
            lblPrecoFinal.Text = "0";
            lblCarrinho.Text = "0";
            cont = 0;
        }
    }
}
