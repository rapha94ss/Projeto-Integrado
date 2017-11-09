using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Conecta
    {
        public static SqlConnection getConexao()
        {
            //declaro objeto que irá chamar o método de conexão
            SqlConnection conexao;
            try
            {
                //instancio o objeto passando como parametro o banco de dados
                conexao = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\rapha\Desktop\WindowsFormsApp2\WindowsFormsApp2\bancodedados.mdf;Integrated Security=True");
                //para banco2013 = Data Source=(LocalDB)\v11.0;AttachDbFilename="E:\CRUZEIRO_DO_SUL\ADS\ÚLTIMO SEMESTRE\WindowsFormsApp2\WindowsFormsApp2\banco2013.mdf";Integrated Security=True
                //para banco = Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\CRUZEIRO_DO_SUL\ADS\ÚLTIMO SEMESTRE\WindowsFormsApp2\WindowsFormsApp2\banco.mdf';Integrated Security=True
                conexao.Open();
                return conexao;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao abrir conexão com banco de dados\n" + 
                    ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
