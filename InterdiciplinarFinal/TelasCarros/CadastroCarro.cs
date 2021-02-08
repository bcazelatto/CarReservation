using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterdiciplinarFinal
{
    public partial class CadastroCarro : System.Windows.Forms.Form
    {
        public object texto;
        public CadastroCarro()
        {
            InitializeComponent();
        }
        public CadastroCarro(string valor)
        {
            InitializeComponent();
            texto = valor;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtPlaca.Text = "";
            txtAno.Text = "";
            txtCor.Text = "";
            atualizar_id();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=DESKTOP-RE215OR");
            //SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=SK020");
            SqlCommand comand = new SqlCommand("insert into carros (cod_carro, modelo_carro, marca_carro, ano_carro, placa_carro, cor_carro) VALUES (@id, @modelo, @marca, @ano, @placa, @cor)", sql);

            comand.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;
            comand.Parameters.Add("@placa", SqlDbType.VarChar).Value = txtPlaca.Text;
            comand.Parameters.Add("@modelo", SqlDbType.VarChar).Value = txtModelo.Text;
            comand.Parameters.Add("@marca", SqlDbType.VarChar).Value = txtMarca.Text;
            comand.Parameters.Add("@ano", SqlDbType.Int).Value = txtAno.Text;
            comand.Parameters.Add("@cor", SqlDbType.VarChar).Value = txtCor.Text;

            if (txtId.Text != "" && txtMarca.Text != "" && txtModelo.Text != "" && txtAno.Text != "" && txtPlaca.Text != "" && txtCor.Text != "")
            {
                try
                {
                    sql.Open();
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro de Carros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Text = "";
                    txtModelo.Text = "";
                    txtMarca.Text = "";
                    txtPlaca.Text = "";
                    txtAno.Text = "";
                    txtCor.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Já Existe esta Placa Cadastrada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    sql.Close();
                    atualizar_id();
                }
            }
            else
            {
                MessageBox.Show("Digite as informações em todos os campos! É Obrigatório!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=DESKTOP-RE215OR");
            //SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=SK020");
            SqlCommand comand = new SqlCommand("select * from carros where cod_carro=@id", sql);

            comand.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = comand.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("Id não encontrado");
                }

                drms.Read();
                txtId.Text = Convert.ToString(drms["cod_carro"]);
                txtModelo.Text = Convert.ToString(drms["modelo_carro"]);
                txtMarca.Text = Convert.ToString(drms["marca_carro"]);
                txtAno.Text = Convert.ToString(drms["ano_carro"]);
                txtPlaca.Text = Convert.ToString(drms["placa_carro"]);
                txtCor.Text = Convert.ToString(drms["cor_carro"]);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=DESKTOP-RE215OR");
            //SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=SK020");
            SqlCommand comand = new SqlCommand("delete from carros where cod_carro=@id", sql);

            comand.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;


            if (txtId.Text != "" && txtMarca.Text != "" && txtModelo.Text != "" && txtAno.Text != "" && txtPlaca.Text != "" && txtCor.Text != "")
            {
                try
                {
                    sql.Open();
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Dados Excluidos Com Sucesso!", "Cadastro de Carros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtId.Text = "";
                    txtModelo.Text = "";
                    txtMarca.Text = "";
                    txtAno.Text = "";
                    txtPlaca.Text = "";
                    txtCor.Text = "";
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
                MessageBox.Show("Não há dados para serem deletados no banco!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=DESKTOP-RE215OR");
            //SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=SK020");
            SqlCommand comand = new SqlCommand("update carros set modelo_carro=@modelo, marca_carro=@marca, placa_carro=@placa, ano_carro=@ano, cor_carro=@cor where cod_carro=@id", sql);

            comand.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;
            comand.Parameters.Add("@modelo", SqlDbType.VarChar).Value = txtModelo.Text;
            comand.Parameters.Add("@marca", SqlDbType.VarChar).Value = txtMarca.Text;
            comand.Parameters.Add("@placa", SqlDbType.VarChar).Value = txtPlaca.Text;
            comand.Parameters.Add("@ano", SqlDbType.Int).Value = txtAno.Text;
            comand.Parameters.Add("@cor", SqlDbType.VarChar).Value = txtCor.Text;

            if (txtId.Text != "" && txtMarca.Text != "" && txtModelo.Text != "" && txtAno.Text != "" && txtPlaca.Text != "" && txtCor.Text != "")
            {
                try
                {
                    sql.Open();
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Alterado com sucesso!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Text = "";
                    txtModelo.Text = "";
                    txtMarca.Text = "";
                    txtAno.Text = "";
                    txtPlaca.Text = "";
                    txtCor.Text = "";
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

        private void CadastroCarro_Load(object sender, EventArgs e)
        {
            
            if(texto != null)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_de_Reserva;Data Source=DESKTOP-RE215OR");
                SqlCommand comand = new SqlCommand("select * from carros where cod_carro=@carro", sql);

                comand.Parameters.Add("@carro", SqlDbType.Int).Value = texto;

                try
                {
                    
                    sql.Open();
                    SqlDataReader drms = comand.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        throw new Exception("Id não encontrado");
                    }

                    drms.Read();
                    txtId.Text = Convert.ToString(drms["cod_carro"]);
                    txtModelo.Text = Convert.ToString(drms["modelo_carro"]);
                    txtMarca.Text = Convert.ToString(drms["marca_carro"]);
                    txtAno.Text = Convert.ToString(drms["ano_carro"]);
                    txtPlaca.Text = Convert.ToString(drms["placa_carro"]);
                    txtCor.Text = Convert.ToString(drms["cor_carro"]);
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
            SqlCommand comand = new SqlCommand("SELECT MAX(cod_carro) as id FROM carros", sql);

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
    }
}
