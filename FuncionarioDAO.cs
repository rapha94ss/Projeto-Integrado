using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class FuncionarioDAO
    {
        public string gravarFuncionario(Funcionario funcionario)
        {
            string sql;
            int retorno;
            string resp = "";
            try
            {
                SqlConnection conexao = Conecta.getConexao();
                sql = "INSERT INTO Funcionarios (cpf, nome, endereco, dataNascimento, celular, cep, cargo) VALUES (@cpf, @nome, @endereco, @dataNascimento, @celular, @cep, @cargo)";

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                cmd.Parameters.AddWithValue("@dataNascimento", funcionario.DataNascimento);
                cmd.Parameters.AddWithValue("@celular", funcionario.Celular);
                cmd.Parameters.AddWithValue("@cep", funcionario.Cep);
                cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                cmd.Parameters.AddWithValue("@numero", funcionario.Numero);

                retorno = cmd.ExecuteNonQuery();
                if(retorno > 0)
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
            catch(SqlException ex)
            {
                resp = "Erro" + ex.ToString();
            }
            return resp;
        }//fim gravarFuncionario

        public Funcionario consultarFuncionario(string cpf)
        {
            string sql;
            Funcionario func;
            try
            {
                func = new Funcionario();
                sql = "SELECT * FROM Funcionarios WHERE cpf=@cpf";
                SqlConnection conexao = Conecta.getConexao();
                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cpf", cpf);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    func.Cpf = dr["cpf"].ToString();
                    func.Nome = dr["nome"].ToString();
                    func.Endereco = dr["endereco"].ToString();
                    func.DataNascimento = dr["dataNascimento"].ToString();
                    func.Celular = dr["celular"].ToString();
                    func.Cep = dr["cep"].ToString();
                    func.Cargo = Convert.ToInt32(dr["cargo"]);
                    func.Numero = dr["numero"].ToString();

                }
                else
                {
                    MessageBox.Show("Não foi encontrado o CPF informado","IHHHH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                cmd.Dispose();
                return func;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro no catch " + ex.Message);
                return null;
            }
        }//fim consultarFuncionario

        public string alterarFuncionario(Funcionario funcionario)
        {
            string sql;
            int retorno;
            string resp = "";
            try
            {
                SqlConnection conexao = Conecta.getConexao();
                sql = "UPDATE Funcionarios SET nome=@nome, endereco=@endereco, dataNascimento=@dataNascimento, celular=@celular, cep=@cep, cargo=@cargo, numero=@numero WHERE cpf=@cpf";

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                cmd.Parameters.AddWithValue("@dataNascimento", funcionario.DataNascimento);
                cmd.Parameters.AddWithValue("@celular", funcionario.Celular);
                cmd.Parameters.AddWithValue("@cep", funcionario.Cep);
                cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                cmd.Parameters.AddWithValue("@numero", funcionario.Numero);

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
        }//fim alterarFuncionario

        public string excluirFuncionario(string cpf)
        {
            string sql;
            string resp;
            int retorno;
            try
            {
                sql = "DELETE funcionarios WHERE cpf = @cpf";
                SqlConnection conexao = Conecta.getConexao(); //abre conexão
                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;//objeto que executa comando SQL
                cmd.Parameters.AddWithValue("@cpf", cpf);

                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = "Funcionário excluído";
                }
                else
                {
                    resp = "Funcionário não excluído";
                }

                //encerra a conexão com o banco de dados
                cmd.Dispose();
                conexao.Dispose();
            }
            catch (Exception ex)
            {
                resp = "Erro ao excluir funcionário " + ex.Message.ToString();
            }

            return resp;
        }//fim excluirFuncionario
    }
}
