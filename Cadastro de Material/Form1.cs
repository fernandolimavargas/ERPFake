using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cadastro_de_Material
{

    public partial class Form1 : Form
    {
        private SqlConnection con;

        public Form1()
        {
            InitializeComponent();
            CamposEmBranco();
            ObterProximoID();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'eRPFAKEDataSet2.Subfamilia'. Você pode movê-la ou removê-la conforme necessário.
            this.subfamiliaTableAdapter.Fill(this.eRPFAKEDataSet2.Subfamilia);
            // TODO: esta linha de código carrega dados na tabela 'eRPFAKEDataSet.familia'. Você pode movê-la ou removê-la conforme necessário.
            this.familiaTableAdapter.Fill(this.eRPFAKEDataSet.familia);


        }



        private void CamposEmBranco()
        {
            Des_Box.Text = "";
            FamiliaComboBox.SelectedIndex = -1;
            SubFamiliaComboBox.SelectedIndex = -1;
            unidadeBox.SelectedIndex = -1;
        }

        private void ObterProximoID()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ERPFAKE;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ISNULL(MAX(ID), 0) + 1 AS ProximoID FROM Material";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int proximoID = reader.GetInt32(0);
                            Cod_Box.Text = proximoID.ToString();
                        }
                    }
                }
            }
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ERPFAKE;Integrated Security=True";
            string stringComando = "INSERT INTO Material (descricao, familia, subfamilia, unidadeMedida) VALUES (@descricao, @familia, @subfamilia, @unidadeMedida);";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(stringComando, con);
                sqlCommand.Parameters.AddWithValue("@descricao", Des_Box.Text);

                if (FamiliaComboBox.SelectedItem != null)
                {
                    sqlCommand.Parameters.AddWithValue("@familia", FamiliaComboBox.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Selecione uma Família.");
                    return;
                }

                if (SubFamiliaComboBox.SelectedItem != null)
                {
                    sqlCommand.Parameters.AddWithValue("@subfamilia", SubFamiliaComboBox.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Selecione uma Subfamília.");
                    return;
                }

                if (unidadeBox.SelectedItem != null)
                {
                    sqlCommand.Parameters.AddWithValue("@unidadeMedida", unidadeBox.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Selecione uma Subfamília.");
                    return;
                }

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Material Inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CamposEmBranco();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            MostraPesquisa novoFormulario = new MostraPesquisa();
            novoFormulario.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteMaterial novoFormulario = new DeleteMaterial();
            novoFormulario.Show();
        }

        private void btn_search_Click(object sender, EventArgs e) 
        {
            MostraPesquisa novoFormulario = new MostraPesquisa();
            novoFormulario.Show();

            string connectionString = "Data Source=localhost;Initial Catalog=ERPFAKE;Integrated Security=True";
            string stringComando = "SELECT descricao FROM familia where descricao=@valorDescricao";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(stringComando, con);
                sqlCommand.Parameters.AddWithValue("@valorDescricao", Des_Box.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                con.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            
        }

        private void FamiliaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
        /*// Certifique-se de limpar os itens anteriores no ComboBox de Subfamília
        FamiliaComboBox.Items.Clear();

        // Recupere a família selecionada no ComboBox de Família
        string familiaSelecionada = FamiliaComboBox.SelectedItem.ToString();

        // Crie uma string de conexão com seu banco de dados
        string connectionString = "Data Source=localhost;Initial Catalog=ERPFAKE;Integrated Security=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Consulta SQL para selecionar a coluna "descricao" da tabela "familia" com base na família selecionada
            string query = "SELECT descricao FROM familia WHERE descricao = @familia";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@familia", familiaSelecionada);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string descricao = reader["descricao"].ToString();
                        // Exiba a descrição da família, por exemplo, em um TextBox ou Label
                        FamiliaComboBox.SelectedItem = descricao;
                    }
                }
            }
        }
    }*/

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SubFamiliaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { }
        /*// Certifique-se de limpar os itens anteriores no ComboBox
        SubFamiliaComboBox.Items.Clear();

        // Recupere a família selecionada no ComboBox de Família
        string familiaSelecionada = FamiliaComboBox.SelectedItem.ToString();

        // Crie uma string de conexão com seu banco de dados
        string connectionString = "Data Source=localhost;Initial Catalog=ERPFAKE;Integrated Security=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Consulta SQL para selecionar a coluna "descricao" da tabela "subfamilia" com base na família selecionada
            string query = "SELECT descricao FROM subfamilia WHERE familia = @familia";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@familia", familiaSelecionada);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string descricao = reader["descricao"].ToString();
                        SubFamiliaComboBox.Items.Add(descricao);
                    }*/
    }
}
            


