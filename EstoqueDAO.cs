using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class EstoqueDAO
    {
        public string CadastrarEstoque(Estoque estoque)
        {
            string sql;
            int retorno;
            string resp = "";
            try
            {
                SqlConnection conexao = Conecta.getConexao();
                sql = "INSERT INTO Estoque (descricao, quantidade, tipoproduto, preco) VALUES (@descricao, @quantidade, @tipoproduto, @preco)";

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@descricao", estoque.Descricao);
                cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(estoque.Quantidade));
                cmd.Parameters.AddWithValue("@tipoproduto", estoque.TipoProduto);
                cmd.Parameters.AddWithValue("@preco", estoque.PrecoUnitario);

                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = "Cadastro efetuado";
                }
                else
                {
                    resp = "Falha ao cadastrar";
                }
                cmd.Dispose();
                conexao.Dispose();
            }
            catch (SqlException ex)
            {
                resp = "Erro" + ex.ToString();
            }
            return resp;
        }//fim CadastrarProduto

        public string editarEstoque (Estoque estoque, int codProduto)
        {
            string sql;
            int retorno;
            string resp = "";
            try
            {
                SqlConnection conexao = Conecta.getConexao();
                sql = "UPDATE Estoque SET Descricao=@descricao, quantidade=@quantidade, tipoProduto=@tipoProduto, preco=@preco WHERE codProduto=@codProduto";

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@descricao", estoque.Descricao);
                cmd.Parameters.AddWithValue("@quantidade", estoque.Quantidade);
                cmd.Parameters.AddWithValue("@tipoProduto", estoque.TipoProduto);
                cmd.Parameters.AddWithValue("@codProduto", codProduto);
                cmd.Parameters.AddWithValue("@preco", estoque.PrecoUnitario);


                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = "Produto alterado";
                }
                else
                {
                    resp = "Falha ao editar";
                }
                cmd.Dispose();
                conexao.Dispose();
            }
            catch (SqlException ex)
            {
                resp = "Erro" + ex.ToString();
            }
            return resp;
        }//fim editarEstoque

        public string excluirEstoque (int codProduto)
        {
            string sql;
            string resp;
            int retorno;
            try
            {
                sql = "DELETE Estoque WHERE codProduto = @codProduto";
                SqlConnection conexao = Conecta.getConexao(); //abre conexão
                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;//objeto que executa comando SQL
                cmd.Parameters.AddWithValue("@codProduto", codProduto);

                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = "Produto excluído";
                }
                else
                {
                    resp = "produto não excluído";
                }

                //encerra a conexão com o banco de dados
                cmd.Dispose();
                conexao.Dispose();
            }
            catch (Exception ex)
            {
                resp = "Erro ao excluir estoque " + ex.Message.ToString();
            }

            return resp;
        }
    }
}
