using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using InterdiciplinarFinal.ConexaoBD;
using System.Windows.Forms;

namespace InterdiciplinarFinal.TelasCarros
{
    public partial class relatorioCarro : Form
    {
        public relatorioCarro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void relatorioCarro_Load(object sender, EventArgs e)
        {
            carregarDtaGrid();
        }
        private void carregarDtaGrid()
        {
            SqlConnection sql = Conexao.CriarConexao();
            SqlCommand comand = new SqlCommand("select cod_carro as 'Carros #', modelo_carro as 'Modelo', marca_carro as 'Marca', ano_carro as 'Ano', cor_carro as 'Cor', placa_carro as 'Placa' from carros;", sql);

            SqlDataAdapter objAdp = new SqlDataAdapter(comand);
            DataTable dtList = new DataTable();
            objAdp.Fill(dtList);

            dataGridView.DataSource = dtList;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string information = dataGridView.CurrentRow.Cells[0].Value.ToString();
            CadastroCarro inc = new CadastroCarro(information);
            inc.Show();

            this.Visible = false;
        }
    }
}
