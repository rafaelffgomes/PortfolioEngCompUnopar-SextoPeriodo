using System.Data.SqlClient;

namespace PortfolioEngCompUnopar
{
    class ConexaoDB
    {
        private static string conexao = "DATA SOURCE=LOCALHOST;INITIAL CATALOG=ptg;User ID=sa;Password=Aa12345678";
        private static SqlConnection sql;
        public static SqlConnection conectar()
        {
            sql = new SqlConnection(conexao);
            try
            {
                sql.Open();
            }
            catch
            {
                //MessageBox.Show("Não foi possível efetuar a conexão com o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sql;
        }

        public static void desconectar()
        {
            try
            {
                sql.Close();
            }
            catch
            {
                //MessageBox.Show("Ocorreu um erro de conexão com o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}