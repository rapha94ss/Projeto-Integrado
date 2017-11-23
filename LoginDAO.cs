using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class LoginDAO
    {
        public bool validaLogin(string usuario, string senha)
        {
            string query;
            bool resp;
            try
            {
                query = "SELECT * FROM Logins WHERE usuario=@usuario AND senha=@senha";
                SqlConnection conexao = Conecta.getConexao();
                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                SqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(SqlException ex)
            {
                MessageBox.Show("Falha na consulta\n" + ex.ToString(),
                    "ERROOO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resp = false;
            }
            return resp;
        }

        public bool verificaPermissao (string cpf)
        {
            return false;
        }

        //método que cria acesso ao sistema
        public string CadastrarLogin(Login login)
        {
            string sql;
            int retorno;
            string resp = "";
            try
            {
                SqlConnection conexao = Conecta.getConexao();
                sql = "INSERT INTO Logins (usuario, senha, cpf) VALUES (@usuario, @senha, @cpf)";

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@usuario", login.Usuario);
                cmd.Parameters.AddWithValue("@senha", login.Senha);
                cmd.Parameters.AddWithValue("@cpf", login.Cpf);
                
                

                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = "Login criado";
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
                //resp = "Erro" + ex.ToString();
                if (ex.Number == 547)
                {
                    resp = "Funcionário não registrado. Favor registrar antes de fornecer acesso";
                }
                else if (ex.Number == 2627)
                {
                    resp = "Nome de usuário já em uso.";
                }
                else
                {
                    resp = "Erro não identificado" + ex.ToString();
                }
            }
            return resp;
        }

        //método que verifica quais privilégios o usuário tem
        /*public bool verificaCargo()
        {

        }*/

        public string recuperaSenha (string cpf)
        {
            string sql;
            Login login;
            string resp = "";
            try
            {
                login = new Login();
                sql = "SELECT * from Logins WHERE cpf=@cpf";
                SqlConnection conexao = Conecta.getConexao();
                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cpf", cpf);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    login.Usuario = dr["usuario"].ToString();
                    login.Senha = dr["senha"].ToString();
                    resp = "Login: " + login.Usuario + " Senha: " + login.Senha;
                }
                else
                {
                    MessageBox.Show("Não foi encontrado o CPF informado", "IHHHH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                cmd.Dispose();
                return resp;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no catch " + ex.Message);
                return null;
            }
        }

        public bool alteraSenha (string novaSenha, string cpf)
        {
            string sql;
            bool resp = false;
            Login login;
            int retorno;
            try
            {
                login = new Login();
                sql = "UPDATE Logins SET senha=@novaSenha WHERE cpf=@cpf";
                SqlConnection conexao = Conecta.getConexao();
                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("novaSenha", novaSenha);
                cmd.Parameters.AddWithValue("cpf", cpf);
                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = true;
                }
                else
                {
                    resp = false;
                }
                cmd.Dispose();
                conexao.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Erro");
            }
            return resp;
        }
    }
}
