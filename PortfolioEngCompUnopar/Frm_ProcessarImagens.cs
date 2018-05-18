using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PortfolioEngCompUnopar
{
    public partial class Frm_ProcessarImagens : Form
    {
        public Frm_ProcessarImagens()
        {
            InitializeComponent();
        }

        private static SqlConnection sql;
        Bitmap bitmap;

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

        private void Bt_Abrir_Click(object sender, EventArgs e)
        {
            Ofd1.Filter = "Imagem|*.jpg|Imagem|*.jpeg|Imagem|*.bmp|Imagem|*.png";
            if (Ofd1.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(@Ofd1.FileName);
                Pb1.Location = new Point((Pnl1.Width - bitmap.Width) / 2, (Pnl1.Height - bitmap.Height) / 2 + 140);
                Pb1.Size = bitmap.Size;
                Pb1.Image = bitmap;
                Log($"Imagem \"{Path.GetFileName(Ofd1.FileName)}\" carregada.");
            }
        }

        private void Bt_Salvar_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Nenhuma imagem a ser salva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Sfd1.Filter = "Imagem|*.jpg|Imagem|*.jpeg|Imagem|*.bmp|Imagem|*.png";
                if (Sfd1.ShowDialog() == DialogResult.OK)
                {
                    Pb1.Image.Save(Sfd1.FileName);
                    Log($"Imagem \"{Path.GetFileName(Sfd1.FileName)}\" salva.");
                }
            }
        }

        private void Bt_Fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja fechar o arquivo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Bt_Sobre_Click(object sender, EventArgs e)
        {
            Frm_Sobre frm_Sobre = new Frm_Sobre();
            frm_Sobre.Show();
        }

        private void Bt_Escala_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "SELECT * FROM ESCALA";
                    sql = ConexaoDB.conectar();
                    SqlCommand comando = new SqlCommand(query, sql);
                    SqlDataReader valores = comando.ExecuteReader();
                    valores.Read();
                    float escala = float.Parse(valores["VALORESCALA"].ToString());
                    if (escala == 0)
                    {
                        MessageBox.Show("Não existem parâmetros para aplicar a escala, nenhuma alteração será feita.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Bitmap bitmaporiginal = new Bitmap(bitmap);
                        Escala escalar = new Escala();
                        Pb1.Image = escalar.Escalar(bitmaporiginal, escala);
                        Log($"Escala de {escala}% aplicada.");
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi possível efetuar a conexão com o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log("Não foi possível efetuar a conexão com o banco de dados.");
                }
            }
        }

        private void Bt_Translacao_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    {
                        string query = "SELECT * FROM TRANSLACAO";
                        sql = ConexaoDB.conectar();
                        SqlCommand comando = new SqlCommand(query, sql);
                        SqlDataReader valores = comando.ExecuteReader();
                        valores.Read();
                        int X, Y;
                        int valorX = int.Parse(valores["EIXOX"].ToString());
                        int valorY = int.Parse(valores["EIXOY"].ToString());
                        if (valorX == 0 & valorY == 0)
                        {
                            MessageBox.Show("Não existem parâmetros para aplicar a translação, nenhuma alteração será feita.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            X = Pb1.Location.X;
                            Y = Pb1.Location.Y;
                            Pb1.Location = new Point(X + valorX, Y + (-valorY));
                            Log($"Translação de X = {valorX} e Y = {valorY} aplicada.");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi possível efetuar a conexão com o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log("Não foi possível efetuar a conexão com o banco de dados.");
                }
            }
        }

        private void Bt_Rotacao_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "SELECT * FROM ROTACAO";
                    sql = ConexaoDB.conectar();
                    SqlCommand comando = new SqlCommand(query, sql);
                    SqlDataReader valores = comando.ExecuteReader();
                    valores.Read();
                    float grau = float.Parse(valores["GRAU"].ToString());
                    if (grau == 0)
                    {
                        MessageBox.Show("Não existem parâmetros para aplicar a rotação, nenhuma alteração será feita.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Bitmap bitmap2 = new Bitmap(Pb1.Image);
                        Rotacao rotacao = new Rotacao();
                        Pb1.Image = rotacao.Girar(bitmap2, grau);
                        Log($"Rotação de {grau}° aplicada.");
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi possível efetuar a conexão com o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log("Não foi possível efetuar a conexão com o banco de dados.");
                }
            }
        }
    }
}