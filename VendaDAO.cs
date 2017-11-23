using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class VendaDAO
    {
        public string RegistrarVenda(Venda venda){
            string sql;
            int retorno;
            string resp = "";
            try
            {
                SqlConnection conexao = Conecta.getConexao();
                sql = "INSERT INTO Venda (item, precototal, quantidade, cpf, formapagamento, parcelas) VALUES (@item, @precototal, @quantidade, @cpf, @formaPagamento, @parcelas)";

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@item", venda.ItemVendido);
                cmd.Parameters.AddWithValue("@precototal", venda.Preco);
                cmd.Parameters.AddWithValue("@quantidade", venda.Quantidade);
                cmd.Parameters.AddWithValue("@cpf", venda.Cpf);
                cmd.Parameters.AddWithValue("@formapagamento", venda.FormaPagamento);
                cmd.Parameters.AddWithValue("@parcelas", venda.Parcelas);
                //cmd.Parameters.AddWithValue("@quantidadeEstoque", venda.Quantidade);
                //cmd.Parameters.AddWithValue("@CodProduto", codVenda);

                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = "Venda realizada";
                    //atualizarEstoque(venda.Quantidade, codVenda);
                }
                else
                {
                    resp = "Falha ao registrar venda";
                }
                cmd.Dispose();
                conexao.Dispose();
            }
            catch (SqlException ex)
            {
                resp = "Erro" + ex.ToString();
            }
            catch (NullReferenceException ex)
            {
               
            }
            return resp;
        }

        public string atualizarEstoque (int quantidade, int codVenda)
        {
            string sql;
            int retorno;
            string resp = "";
            try
            {
                SqlConnection conexao = Conecta.getConexao();
                sql = "UPDATE Estoque SET Quantidade = Quantidade - @quantidadeEstoque WHERE CodProduto=@CodProduto";

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@quantidadeEstoque", quantidade);
                cmd.Parameters.AddWithValue("@CodProduto", codVenda);

                //cmd
                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = "Estoque atualizado";
                }
                else
                {
                    resp = "Falha ao atualizar estoque";
                }
                cmd.Dispose();
                conexao.Dispose();
            }
            catch (SqlException ex)
            {
                resp = "Erro na atualização do estoque" + ex.ToString();
            }
            return resp;
        }
        
    }
}
