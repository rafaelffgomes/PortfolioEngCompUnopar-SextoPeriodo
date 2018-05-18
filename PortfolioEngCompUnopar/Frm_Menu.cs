using System;
using System.Windows.Forms;

namespace PortfolioEngCompUnopar
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Bt_InserirValores_Click(object sender, EventArgs e)
        {
            Frm_InserirValores frm_InserirValores = new Frm_InserirValores();
            frm_InserirValores.Show();
        }

        private void Bt_ProcessarImagens_Click(object sender, EventArgs e)
        {
            Frm_ProcessarImagens frm_ProcessarImagens = new Frm_ProcessarImagens();
            frm_ProcessarImagens.Show();
        }
    }
}