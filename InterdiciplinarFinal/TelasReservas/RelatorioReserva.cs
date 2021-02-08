using System;
using System.Data;
using System.Data.SqlClient;
using InterdiciplinarFinal.ConexaoBD;
using System.Windows.Forms;
using System.Threading;

namespace InterdiciplinarFinal
{
    public partial class RelatorioReserva : Form
    {

        public RelatorioReserva()
        {
            InitializeComponent();
        }

        private void RelatorioReserva_Load(object sender, EventArgs e)
        {
            carregarDtaGrid();
        }

        private void carregarDtaGrid()
        {
            SqlConnection sql = Conexao.CriarConexao();
            SqlCommand comand = new SqlCommand("select cod_reserva as 'Reserva #', tempoI as 'Inicio da Reserva', tempoF as 'Fim da Reserva', carro_reserva as 'Carro Reservado', nome_reserva as 'Nome da Reserva' from reserva;", sql);

            SqlDataAdapter objAdp = new SqlDataAdapter(comand);
            DataTable dtList = new DataTable();
            objAdp.Fill(dtList);

            dataGridView.DataSource = dtList;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            string information = dataGridView.CurrentRow.Cells[0].Value.ToString();
            AgendarCarro inc = new AgendarCarro(information);
            inc.Show();

            this.Visible = false;

        }
    }
}
