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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cadastro_de_Material
{
    public partial class MostraPesquisa : Form
    {
        public MostraPesquisa()
        {
            InitializeComponent();
        }

        public void MostraPesquisa_Load(object sender, EventArgs e)
        {
            this.subfamiliaTableAdapter.Fill(this.eRPFAKEDataSet3.Subfamilia);
            this.familiaTableAdapter.Fill(this.eRPFAKEDataSet.familia);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string termoPesquisa = SearchBox.Text.Trim();

            if (string.IsNullOrEmpty(termoPesquisa))
            {
                MessageBox.Show("Informe um ID ou nome para pesquisa.");
                return;
            }

            DataTable dataTable = new DataTable();

            string connectionString = "Data Source=localhost;Initial Catalog=ERPFAKE;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id as 'Codigo', descricao as 'Mercadoria', familia as 'Família', subfamilia as 'Sub Familia' FROM Material WHERE id = @mercadoria OR descricao LIKE @mercadoria;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mercadoria", termoPesquisa);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    using (SqlDataReader reader = command.ExecuteReader()) ;
                }
            }
            ResultdataGridView.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
            string novaDescricao = NovaDescricaoTextBox.Text;
            string novaFamilia = NovaFamiliaComboBox.SelectedItem.ToString();
            string novaSubfamilia = NovaSubFamiliaComboBox.SelectedItem.ToString();

            int materialID = int.Parse(SearchBox.Text); 

            string connectionString = "Data Source=localhost;Initial Catalog=ERPFAKE;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Material SET descricao = @descricao, familia = @familia, subfamilia = @subfamilia WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@descricao", novaDescricao);
                    command.Parameters.AddWithValue("@familia", novaFamilia);
                    command.Parameters.AddWithValue("@subfamilia", novaSubfamilia);
                    command.Parameters.AddWithValue("@id", materialID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informações atualizadas com sucesso.");
                        DataTable dataTable = new DataTable();



                        query = "SELECT id as 'Codigo', descricao as 'Mercadoria', familia as 'Família', subfamilia as 'Sub Familia' FROM Material WHERE id = @mercadoria OR descricao LIKE @mercadoria;";

                            ;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        using (SqlDataReader reader = command.ExecuteReader()) ; 
                            
                        ResultdataGridView.DataSource = dataTable;
                    }
                
                    else
                    {
                        MessageBox.Show("Falha na atualização das informações.");
                    }
                }
            }
        }
    }
}
