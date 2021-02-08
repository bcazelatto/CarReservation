using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using InterdiciplinarFinal.ConexaoBD;


namespace InterdiciplinarFinal
{
    public partial class TelaLogin : System.Windows.Forms.Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = Conexao.CriarConexao();
            SqlCommand comand = new SqlCommand("select * from colaborador where login_colaborador=@login_colaborador and senha_colaborador=@senha_colaborador", sql);

            comand.Parameters.Add("@login_colaborador", SqlDbType.VarChar).Value = txtFrmLogin.Text;
            comand.Parameters.Add("@senha_colaborador", SqlDbType.VarChar).Value = txtFrmSenha.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = comand.ExecuteReader();

                if (drms.HasRows == false)
                {
                    throw new Exception("Usuário ou Senha Incorreta!");
                }

                //Comando para resgatar informação do banco -------------
                drms.Read();
                string a1 = Convert.ToString(drms["nivel_colaborador"]);
                //---------------------------------------------------------

                if (a1 == "Administrador")
                {
                    drms.Read();
                    MessageBox.Show("Login com Sucesso!, Bem Vindo", "Reserva de Carros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TelaInicial inic = new TelaInicial();
                    inic.Show();
                    this.Visible = false;
                }

                else if (a1 == "Usuario")
                {
                    drms.Read();
                    MessageBox.Show("Login com Sucesso!, Bem Vindo", "Reserva de Carros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TelaInicial2 inic = new TelaInicial2();
                    inic.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Não deu certo");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sql.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
