using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class ClienteDAO
    {
        public string CadastrarCliente(Cliente cliente)
        {
            string sql;
            int retorno;
            string resp = "";
            try
            {
                SqlConnection conexao = Conecta.getConexao();
                sql = "INSERT INTO Clientes (cpf, nome, email, celular) VALUES (@cpf, @nome, @email, @celular)";

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@celular", cliente.Celular);

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
        }//fimCadastrarCliente

        public Cliente consultarCliente(string cpf)
        {
            string sql;
            Cliente cliente;
            try
            {
                cliente = new Cliente();
                sql = "SELECT * FROM Clientes WHERE cpf=@cpf";
                SqlConnection conexao = Conecta.getConexao();
                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cpf", cpf);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    cliente.Cpf = dr["cpf"].ToString();
                    cliente.Nome = dr["nome"].ToString();
                    cliente.Email = dr["email"].ToString();
                    cliente.Celular = dr["celular"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Não foi encontrado o CPF informado", "IHHHH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                cmd.Dispose();
                return cliente;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no catch " + ex.Message);
                return null;
            }
        }//fim consultarCliente

        public string editarCliente(Cliente cliente)
        {
            string sql;
            int retorno;
            string resp = "";
            try
            {
                SqlConnection conexao = Conecta.getConexao();
                sql = "UPDATE Clientes SET nome=@nome, email=@email, celular=@celular WHERE cpf=@cpf";

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@celular", cliente.Celular);

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
        }//fim EditarCliente

        public string excluirCliente(string cpf)
        {
            string sql;
            string resp;
            int retorno;
            try
            {
                sql = "DELETE clientes WHERE cpf = @cpf";
                SqlConnection conexao = Conecta.getConexao(); //abre conexão
                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;//objeto que executa comando SQL
                cmd.Parameters.AddWithValue("@cpf", cpf);

                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = "Cliente excluído";
                }
                else
                {
                    resp = "Cliente não excluído";
                }

                //encerra a conexão com o banco de dados
                cmd.Dispose();
                conexao.Dispose();
            }
            catch (Exception ex)
            {
                resp = "Erro ao excluir cliente " + ex.Message.ToString();
            }

            return resp;
        }//fim ExcluirCliente
    }
}
