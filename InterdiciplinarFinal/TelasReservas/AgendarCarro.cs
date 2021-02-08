using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using InterdiciplinarFinal.ConexaoBD;
using System.Runtime.Serialization;

namespace InterdiciplinarFinal
{
    public partial class AgendarCarro : Form
    {
        public object texto;
        public AgendarCarro()
        {
            InitializeComponent();
        }

        public AgendarCarro(string valor)
        {
            InitializeComponent();
            texto = valor;
        }

        private void AgendarCarro_Load(object sender, EventArgs e)
        {

            if (texto != null)
            {

                SqlConnection sql = Conexao.CriarConexao();
                SqlCommand comand = new SqlCommand("select * from reserva where cod_reserva=@id", sql);

                comand.Parameters.Add("@id", SqlDbType.Int).Value = texto;
                carregarCboBox();
                try
                {
                    sql.Open();
                    SqlDataReader drms = comand.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        throw new Exception("Id não encontrado");
                    }

                    drms.Read();
                    txtId.Text = Convert.ToString(drms["cod_reserva"]);
                    txtNome.Text = Convert.ToString(drms["nome_reserva"]);
                    txtDataInicial.Text = Convert.ToString(drms["tempoI"]);
                    txtDataFinal.Text = Convert.ToString(drms["tempoF"]);
                    cboCarroDisponivel.Text = Convert.ToString(drms["carro_reserva"]);
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
                carregarCboBox();
                atualizar_id();
            }
        }
            

        private void carregarCboBox()
        {
            SqlConnection sql = Conexao.CriarConexao();
            sql.Open();
            SqlCommand comand = new SqlCommand("select modelo_carro from carros", sql);

            SqlDataReader t1;
            t1 = comand.ExecuteReader();
            DataTable t2 = new DataTable();
            t2.Load(t1);
            cboCarroDisponivel.DisplayMember = "modelo_carro";
            cboCarroDisponivel.DataSource = t2;
            sql.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtDataInicial.Text = "";
            txtDataFinal.Text = "";
            txtNome.Text = "";
            cboCarroDisponivel.Text = "";

            atualizar_id();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = Conexao.CriarConexao();
            SqlCommand comand2 = new SqlCommand("SELECT dbo.F_CONSULTA_DISPON(@carro_reserva, @tempoI, @tempoF) AS SITUACAO;", sql);  //Não pode usar aspas aqui, rs

            comand2.Parameters.Add("@tempoI", SqlDbType.DateTime).Value = txtDataInicial.Text;
            comand2.Parameters.Add("@tempoF", SqlDbType.DateTime).Value = txtDataFinal.Text;
            comand2.Parameters.Add("@carro_reserva", SqlDbType.VarChar).Value = cboCarroDisponivel.Text;

            sql.Open();
            SqlDataReader dr = comand2.ExecuteReader();
            dr.Read();
            int ret = Convert.ToInt16(dr[0]);
            sql.Close();

            if (ret == 0) 
            {
                SqlCommand comand = new SqlCommand("insert into reserva (cod_reserva, tempoI, tempoF, carro_reserva, nome_reserva) VALUES (@id, @tempoI, @tempoF, @carro_reserva, @nome_reserva)", sql);

                comand.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;
                comand.Parameters.Add("@tempoI", SqlDbType.DateTime).Value = txtDataInicial.Text;
                comand.Parameters.Add("@tempoF", SqlDbType.DateTime).Value = txtDataFinal.Text;
                comand.Parameters.Add("@carro_reserva", SqlDbType.VarChar).Value = cboCarroDisponivel.Text;
                comand.Parameters.Add("@nome_reserva", SqlDbType.VarChar).Value = txtNome.Text;


                if (txtId.Text != "" && txtId.Text != "" && txtDataInicial.Text != "" && txtDataFinal.Text != "" && txtNome.Text != "" && cboCarroDisponivel.Text != "")
                {

                    try //Inserir o cadastro do carro na reserva
                    {
                        sql.Open();
                        comand.ExecuteNonQuery();
                        MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro de Carros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtId.Text = "";
                        txtDataInicial.Text = "";
                        txtDataFinal.Text = "";
                        txtNome.Text = "";
                    }
                    catch (Exception ex) // erro
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally //finalizar com close e atualizar o status do ultimo id automaticamente
                    {
                        atualizar_id();
                    }

                }
                else
                {
                    MessageBox.Show("Digite as informações em todos os campos! É Obrigatório!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("Já existe uma reserva no periodo informado!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = Conexao.CriarConexao();
            SqlCommand comand = new SqlCommand("update reserva set tempoI=@tempoI, tempoF=@tempoF, carro_reserva=@carro_reserva, nome_reserva=@nome_reserva where cod_reserva=@id", sql);

            comand.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;
            comand.Parameters.Add("@tempoI", SqlDbType.DateTime).Value = txtDataInicial.Text;
            comand.Parameters.Add("@tempoF", SqlDbType.DateTime).Value = txtDataFinal.Text;
            comand.Parameters.Add("@carro_reserva", SqlDbType.VarChar).Value = cboCarroDisponivel.Text;
            comand.Parameters.Add("@nome_reserva", SqlDbType.VarChar).Value = txtNome.Text;

            if (txtId.Text != "" && txtId.Text != "" && txtDataInicial.Text != "" && txtDataFinal.Text != "" && txtNome.Text != "" && cboCarroDisponivel.Text != "")
            {
                try
                {
                    sql.Open();
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Alterado com sucesso!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Text = "";
                    txtDataInicial.Text = "";
                    txtDataFinal.Text = "";
                    txtNome.Text = "";
                    cboCarroDisponivel.Text = "";
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
            SqlConnection sql = Conexao.CriarConexao();
            SqlCommand comand = new SqlCommand("select * from reserva where cod_reserva=@id", sql);

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
                txtId.Text = Convert.ToString(drms["cod_reserva"]);
                txtNome.Text = Convert.ToString(drms["nome_reserva"]);
                txtDataInicial.Text = Convert.ToString(drms["tempoI"]);
                txtDataFinal.Text = Convert.ToString(drms["tempoF"]);
                cboCarroDisponivel.Text = Convert.ToString(drms["carro_reserva"]);
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

            SqlConnection sql = Conexao.CriarConexao();
            SqlCommand comand = new SqlCommand("delete from reserva where cod_reserva=@id", sql);

            comand.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;

            if (txtId.Text != "" && txtId.Text != "" && txtDataInicial.Text != "" && txtDataFinal.Text != "" && txtNome.Text != "" && cboCarroDisponivel.Text != "")
            {
                try
                {
                    sql.Open();
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Dados Excluidos Com Sucesso!", "Cadastro de Carros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtId.Text = "";
                    txtDataInicial.Text = "";
                    txtDataFinal.Text = "";
                    txtNome.Text = "";
                    cboCarroDisponivel.Text = "";
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
        private void atualizar_id()
        {
            SqlConnection sql = Conexao.CriarConexao();
            SqlCommand comand = new SqlCommand("SELECT MAX(cod_reserva) as id FROM reserva", sql);

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
