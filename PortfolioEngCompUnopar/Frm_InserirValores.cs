using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PortfolioEngCompUnopar
{
    public partial class Frm_InserirValores : Form
    {
        public Frm_InserirValores()
        {
            InitializeComponent();
        }

        private static SqlConnection sql;

        private void Tb_Valores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        public void Log(string texto)
        {
            if (Tb_Log.Text.Length == 0)
            {
                Tb_Log.Text = DateTime.Now.ToLongTimeString() + $" - {texto}";
            }
            else
            {
                Tb_Log.Text = Tb_Log.Text + Environment.NewLine + DateTime.Now.ToLongTimeString() + $" - {texto}";
            }
            Tb_Log.SelectionStart = Tb_Log.Text.Length;
            Tb_Log.ScrollToCaret();
        }

        private void Bt_RotEsquerda_Click(object sender, EventArgs e)
        {
            float rotacao;
            if (Tb_ValorRotacao.Text.Length == 0)
            {
                Tb_ValorRotacao.Text = "0";
            }
            if (Tb_ValorRotacao.Text.Equals("-360"))
            {
                MessageBox.Show("O limite para rotaçao é de 360 graus para a esquerda ou para a direita.", "Limite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                rotacao = float.Parse(Tb_ValorRotacao.Text);
                Tb_ValorRotacao.Text = $"{rotacao - 10}";
            }
        }

        private void Bt_RotDireita_Click(object sender, EventArgs e)
        {
            double rotacao;
            if (Tb_ValorRotacao.Text.Length == 0)
            {
                Tb_ValorRotacao.Text = "0";
            }
            if (Tb_ValorRotacao.Text.Equals("360"))
            {
                MessageBox.Show("O limite para rotaçao é de 360° para a esquerda ou para a direita.", "Limite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                rotacao = double.Parse(Tb_ValorRotacao.Text);
                Tb_ValorRotacao.Text = $"{rotacao + 10}";
            }
        }

        private void Bt_RotSalvar_Click(object sender, EventArgs e)
        {
            string valor = Tb_ValorRotacao.Text;
            string query = "UPDATE ROTACAO SET GRAU=" + valor + "";
            sql = ConexaoDB.conectar();
            SqlCommand comando = new SqlCommand(query, sql);
            try
            {
                comando.Parameters.Add(new SqlParameter("GRAU", valor));
                comando.ExecuteNonQuery();
                Log($"O valor \"{valor}\" para rotação foi inserido com sucesso.");
                ConexaoDB.desconectar();
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar a conexão com o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Não foi possível efetuar a conexão com o banco de dados.");
            }
        }

        private void Bt_RotDeletar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE ROTACAO SET GRAU=0";
            sql = ConexaoDB.conectar();
            SqlCommand comando = new SqlCommand(query, sql);
            try
            {
                comando.Parameters.Add(new SqlParameter("GRAU", "0"));
                comando.ExecuteNonQuery();
                Log("O valor para rotação foi deletado com sucesso.");
                ConexaoDB.desconectar();
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar a conexão com o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Não foi possível efetuar a conexão com o banco de dados.");
            }
        }

        private void Bt_TransCima_Click(object sender, EventArgs e)
        {
            double eixoYcima;
            if (Tb_ValorYTranslacao.Text.Length == 0)
            {
                Tb_ValorYTranslacao.Text = "0";
            }
            eixoYcima = double.Parse(Tb_ValorYTranslacao.Text);
            Tb_ValorYTranslacao.Text = $"{eixoYcima + 10}";
        }

        private void Bt_TransBaixo_Click(object sender, EventArgs e)
        {
            double eixoYbaixo;
            if (Tb_ValorYTranslacao.Text.Length == 0)
            {
                Tb_ValorYTranslacao.Text = "0";
            }
            eixoYbaixo = double.Parse(Tb_ValorYTranslacao.Text);
            Tb_ValorYTranslacao.Text = $"{eixoYbaixo - 10}";
        }

        private void Bt_TransEsquerda_Click(object sender, EventArgs e)
        {
            double eixoXesquerda;
            if (Tb_ValorXTranslacao.Text.Length == 0)
            {
                Tb_ValorXTranslacao.Text = "0";
            }
            eixoXesquerda = double.Parse(Tb_ValorXTranslacao.Text);
            Tb_ValorXTranslacao.Text = $"{eixoXesquerda - 10}";
        }

        private void Bt_TransDireita_Click(object sender, EventArgs e)
        {
            double eixoXdireita;
            if (Tb_ValorXTranslacao.Text.Length == 0)
            {
                Tb_ValorXTranslacao.Text = "0";
            }
            eixoXdireita = double.Parse(Tb_ValorXTranslacao.Text);
            Tb_ValorXTranslacao.Text = $"{eixoXdireita + 10}";
        }

        private void Bt_TransSalvar_Click(object sender, EventArgs e)
        {
            string valorX = Tb_ValorXTranslacao.Text;
            string valorY = Tb_ValorYTranslacao.Text;
            string query = "UPDATE TRANSLACAO SET EIXOX=" + valorX + ", EIXOY=" + valorY + "";
            sql = ConexaoDB.conectar();
            SqlCommand comando = new SqlCommand(query, sql);
            try
            {
                comando.Parameters.Add(new SqlParameter("EIXOX", valorX));
                comando.Parameters.Add(new SqlParameter("EIXOY", valorY));
                comando.ExecuteNonQuery();
                Log($"Os valores de \"X= {valorX}\" e \"Y= {valorY}\" para translação foram inseridos com sucesso.");
                ConexaoDB.desconectar();
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar a conexão com o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Não foi possível efetuar a conexão com o banco de dados.");
            }
        }

        private void Bt_TransDeletar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TRANSLACAO SET EIXOX=0, EIXOY=0";
            sql = ConexaoDB.conectar();
            SqlCommand comando = new SqlCommand(query, sql);
            try
            {
                comando.Parameters.Add(new SqlParameter("EIXOX", "0"));
                comando.Parameters.Add(new SqlParameter("EIXOY", "0"));
                comando.ExecuteNonQuery();
                Log("Os valores de X  e Y para translação foram deletados com sucesso.");
                ConexaoDB.desconectar();
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar a conexão com o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Não foi possível efetuar a conexão com o banco de dados.");
            }
        }

        private void Bt_EscCima_Click(object sender, EventArgs e)
        {
            double escalacima;
            if (Tb_ValorEscala.Text.Length == 0)
            {
                Tb_ValorEscala.Text = "100";
            }
            escalacima = double.Parse(Tb_ValorEscala.Text);
            Tb_ValorEscala.Text = $"{escalacima + 10}";
        }

        private void Bt_EscBaixo_Click(object sender, EventArgs e)
        {
            double escalabaixo;
            if (Tb_ValorEscala.Text.Length == 0)
            {
                Tb_ValorEscala.Text = "100";
            }
            escalabaixo = double.Parse(Tb_ValorEscala.Text);
            Tb_ValorEscala.Text = $"{escalabaixo - 10}";
        }

        private void Bt_EcsSalvar_Click(object sender, EventArgs e)
        {
            string valor = Tb_ValorEscala.Text;
            string query = "UPDATE ESCALA SET VALORESCALA=" + valor + "";
            sql = ConexaoDB.conectar();
            SqlCommand comando = new SqlCommand(query, sql);
            try
            {
                comando.Parameters.Add(new SqlParameter("VALORESCALA", valor));
                comando.ExecuteNonQuery();
                Log($"O valor \"{valor}\" para rotação foi inserido com sucesso.");
                ConexaoDB.desconectar();
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar a conexão com o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Não foi possível efetuar a conexão com o banco de dados.");
            }
        }

        private void Bt_EscDeletar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE ESCALA SET VALORESCALA=0";
            sql = ConexaoDB.conectar();
            SqlCommand comando = new SqlCommand(query, sql);
            try
            {
                comando.Parameters.Add(new SqlParameter("VALORESCALA", "0"));
                comando.ExecuteNonQuery();
                Log("O valor para rotação foi deletado com sucesso.");
                ConexaoDB.desconectar();
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar a conexão com o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Não foi possível efetuar a conexão com o banco de dados.");
            }
        }
    }
}