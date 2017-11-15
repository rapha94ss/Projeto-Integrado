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

                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = "Venda realizada";
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
        
    }
}
