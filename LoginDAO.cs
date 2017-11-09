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
    }
}
