using System.Data.SqlClient;

namespace InterdiciplinarFinal.ConexaoBD
{
    public static class Conexao
    {
        //criar conexao
        public static SqlConnection CriarConexao()
        {
            //return new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=SK020");
            return new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=DESKTOP-RE215OR");
        }

    }
}
