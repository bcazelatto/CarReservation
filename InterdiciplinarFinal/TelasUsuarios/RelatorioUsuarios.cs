using System;
using System.Data;
using InterdiciplinarFinal.ConexaoBD;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterdiciplinarFinal
{
    public partial class RelatorioUsuarios : Form
    {
        public RelatorioUsuarios()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void RelatorioUsuarios_Load(object sender, EventArgs e)
        {
            carregarDadosDataGrid();
        }

        private void carregarDadosDataGrid()
        {
            SqlConnection sql = Conexao.CriarConexao();
            SqlCommand comand = new SqlCommand("select cod_colaborador as 'Colaborador #', nome_colaborador as 'Nome do Colaborador', login_colaborador as 'Login', senha_colaborador as 'Senha', fone_colaborador as 'Telefone', nivel_colaborador as 'Nivel de Acesso' from colaborador", sql);

            SqlDataAdapter objAdp = new SqlDataAdapter(comand);
            DataTable dtList = new DataTable();
            objAdp.Fill(dtList);

            dataGridView1.DataSource = dtList;
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string information = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CadastroUsuario inc = new CadastroUsuario(information);
            inc.Show();

            this.Visible = false;
        }

    }
}
