using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ManutencaoDAO
    {
        public string gravarManutencao (Manutencao manutencao)
        {
            string sql;
            int retorno;
            string resp = "";
            try
            {
                SqlConnection conexao = Conecta.getConexao();
                sql = "INSERT INTO Manutencao (descricao, cpf, dataRequisicao, previsaoconclusao, status, tipomanutencao) VALUES (@descricao, @cpf, @dataRequisicao, @previsaoconclusao, @status, @tipomanutencao)";

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@descricao", manutencao.Descricao);
                cmd.Parameters.AddWithValue("@cpf", manutencao.Cpf);
                cmd.Parameters.AddWithValue("@datarequisicao", manutencao.DataRequisicao);
                cmd.Parameters.AddWithValue("@previsaoconclusao", manutencao.PrevisaoConclusao);
                cmd.Parameters.AddWithValue("@status", manutencao.Status);
                cmd.Parameters.AddWithValue("@tipomanutencao", manutencao.TipoManutencao);
                

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
        }//fim cadastrar

        public string alterarManutencao (Manutencao manutencao, string codManutencao)
        {
            string sql;
            int retorno;
            string resp = "";
            try
            {
                SqlConnection conexao = Conecta.getConexao();
                sql = "UPDATE Manutencao SET descricao=@descricao, cpf=@cpf, datarequisicao=@datarequisicao, previsaoconclusao=@previsaoconclusao, status=@status, tipomanutencao=@tipomanutencao WHERE codmanutencao=@codmanutencao";

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@descricao", manutencao.Descricao);
                cmd.Parameters.AddWithValue("@cpf", manutencao.Cpf);
                cmd.Parameters.AddWithValue("@datarequisicao", manutencao.DataRequisicao);
                cmd.Parameters.AddWithValue("@previsaoconclusao", manutencao.PrevisaoConclusao);
                cmd.Parameters.AddWithValue("@status", manutencao.Status);
                cmd.Parameters.AddWithValue("@tipomanutencao", manutencao.TipoManutencao);
                cmd.Parameters.AddWithValue("@codmanutencao",codManutencao);

                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = "Cadastro alterado";
                }
                else
                {
                    resp = "Falha ao alterar";
                }
                cmd.Dispose();
                conexao.Dispose();
            }
            catch (SqlException ex)
            {
                resp = "Erro" + ex.ToString();
            }
            return resp;
        }//fim alterarManutencao

        public string excluirManutencao (string codManutencao)
        {
            string sql;
            string resp;
            int retorno;
            try
            {
                sql = "DELETE Manutencao WHERE codmanutencao = @codmanutencao";
                SqlConnection conexao = Conecta.getConexao(); //abre conexão
                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;//objeto que executa comando SQL
                cmd.Parameters.AddWithValue("@codmanutencao", codManutencao);

                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = "Manutenção excluída";
                }
                else
                {
                    resp = "Manutenção não excluído";
                }

                //encerra a conexão com o banco de dados
                cmd.Dispose();
                conexao.Dispose();
            }
            catch (Exception ex)
            {
                resp = "Erro ao excluir manutenção " + ex.Message.ToString();
            }

            return resp;
        }//fim ExcluirManutenção

    }
}
