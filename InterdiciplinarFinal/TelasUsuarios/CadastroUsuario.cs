using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterdiciplinarFinal
{
    public partial class CadastroUsuario : Form
    {
        public object texto;
        public CadastroUsuario()
        {
            InitializeComponent();
        }
        public CadastroUsuario(string valor)
        {
            InitializeComponent();
            texto = valor;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=DESKTOP-RE215OR");
            //SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=SK020");
            SqlCommand comand = new SqlCommand("insert into colaborador (cod_colaborador, nome_colaborador, login_colaborador, senha_colaborador, fone_colaborador, nivel_colaborador) VALUES (@cod_colaborador, @nome_colaborador, @login_colaborador, @senha_colaborador, @fone_colaborador, @nivel_colaborador)", sql);
           
            comand.Parameters.Add("@cod_colaborador", SqlDbType.Int).Value = txtId.Text;
            comand.Parameters.Add("@nome_colaborador", SqlDbType.VarChar).Value = txtNome.Text;
            comand.Parameters.Add("@login_colaborador", SqlDbType.VarChar).Value = txtLogin.Text;
            comand.Parameters.Add("@senha_colaborador", SqlDbType.VarChar).Value = txtSenha.Text;
            comand.Parameters.Add("@fone_colaborador", SqlDbType.VarChar).Value = txtFone.Text;
            comand.Parameters.Add("@nivel_colaborador", SqlDbType.VarChar).Value = cboPerfil.Text;

            if(txtId.Text != "" && txtNome.Text != "" && txtLogin.Text != "" && txtSenha.Text != "" && cboPerfil.Text != "")
            {
                try
                {
                    sql.Open();
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Text = "";
                    txtNome.Text = "";
                    txtLogin.Text = "";
                    txtSenha.Text = "";
                    txtFone.Text = "";
                    cboPerfil.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Já existe o usuário cadastrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    sql.Close();
                    atualizar_id();
                }
            }
            else
            {
                MessageBox.Show("Digite as informações nos campos obrigatórios!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=DESKTOP-RE215OR");
            //SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=SK020");

            SqlCommand comand = new SqlCommand("update colaborador set nome_colaborador=@nome_colaborador, login_colaborador=@login_colaborador, senha_colaborador=@senha_colaborador, fone_colaborador=@fone_colaborador, nivel_colaborador=@nivel_colaborador where cod_colaborador=@cod_colaborador", sql);

            comand.Parameters.Add("@cod_colaborador", SqlDbType.Int).Value = txtId.Text;
            comand.Parameters.Add("@nome_colaborador", SqlDbType.VarChar).Value = txtNome.Text;
            comand.Parameters.Add("@login_colaborador", SqlDbType.VarChar).Value = txtLogin.Text;
            comand.Parameters.Add("@senha_colaborador", SqlDbType.VarChar).Value = txtSenha.Text;
            comand.Parameters.Add("@fone_colaborador", SqlDbType.VarChar).Value = txtFone.Text;
            comand.Parameters.Add("@nivel_colaborador", SqlDbType.VarChar).Value = cboPerfil.Text;

            if (txtId.Text != "" && txtNome.Text != "" && txtLogin.Text != "" && txtSenha.Text != "" && cboPerfil.Text != "")
            {
                try
                {
                    sql.Open();
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Alterado com sucesso!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Text = "";
                    txtNome.Text = "";
                    txtLogin.Text = "";
                    txtSenha.Text = "";
                    txtFone.Text = "";
                    cboPerfil.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Close();
                    atualizar_id();
                }
            }
            else
            {
                MessageBox.Show("Digite as informações nos campos obrigatórios!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=DESKTOP-RE215OR");
            SqlCommand comand = new SqlCommand("select * from colaborador where cod_colaborador=@cod_colaborador", sql);

            comand.Parameters.Add("@cod_colaborador", SqlDbType.Int).Value = txtId.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = comand.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("Id não encontrado");
                }

                drms.Read();
                txtId.Text = Convert.ToString(drms["cod_colaborador"]);
                txtNome.Text = Convert.ToString(drms["nome_colaborador"]);
                txtLogin.Text = Convert.ToString(drms["login_colaborador"]);
                txtSenha.Text = Convert.ToString(drms["senha_colaborador"]);
                txtFone.Text = Convert.ToString(drms["fone_colaborador"]);
                cboPerfil.Text = Convert.ToString(drms["nivel_colaborador"]);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sql.Close();
                //atualizar_id();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtFone.Text = "";
            cboPerfil.Text = "";
            atualizar_id();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=DESKTOP-RE215OR");
            //SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=SK020");
            SqlCommand comand = new SqlCommand("delete from colaborador where cod_colaborador=@cod_colaborador", sql);

            comand.Parameters.Add("@cod_colaborador", SqlDbType.Int).Value = txtId.Text;
            if (txtId.Text != "" && txtNome.Text != "" && txtLogin.Text != "" && txtSenha.Text != "" && cboPerfil.Text != "")
            {
                try
                {
                    sql.Open();
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Dados Excluidos Com Sucesso!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtId.Text = "";
                    txtNome.Text = "";
                    txtLogin.Text = "";
                    txtSenha.Text = "";
                    txtFone.Text = "";
                    cboPerfil.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    sql.Close();
                    atualizar_id();
                }
            }
            else
            {
                MessageBox.Show("Não há dados para ser deletados no banco!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            if (texto != null)
            {

                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=DESKTOP-RE215OR");
                SqlCommand comand = new SqlCommand("select * from colaborador where cod_colaborador=@cod_colaborador", sql);

                comand.Parameters.Add("@cod_colaborador", SqlDbType.Int).Value = texto;

                try
                {
                    sql.Open();
                    SqlDataReader drms = comand.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        throw new Exception("Id não encontrado");
                    }

                    drms.Read();
                    txtId.Text = Convert.ToString(drms["cod_colaborador"]);
                    txtNome.Text = Convert.ToString(drms["nome_colaborador"]);
                    txtLogin.Text = Convert.ToString(drms["login_colaborador"]);
                    txtSenha.Text = Convert.ToString(drms["senha_colaborador"]);
                    txtFone.Text = Convert.ToString(drms["fone_colaborador"]);
                    cboPerfil.Text = Convert.ToString(drms["nivel_colaborador"]);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    sql.Close();
                    atualizar_id();
                }

            }
            else
            {
                atualizar_id();
            }
        }

        private void atualizar_id()
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=DESKTOP-RE215OR");
            //SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=SK020");
            SqlCommand comand = new SqlCommand("SELECT MAX(cod_colaborador) as id FROM colaborador", sql);

            sql.Open();
            SqlDataReader drms = comand.ExecuteReader();
            drms.Read();
            txtUltimoID.Text = Convert.ToString(drms["id"]);
            string A = txtUltimoID.Text;
            int num1 = Convert.ToInt32(A);
            int num2 = 1;
            int soma = num1 + num2;
            txtId.Text = Convert.ToString(soma);
            sql.Close();
        }

        private void txtUltimoID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
