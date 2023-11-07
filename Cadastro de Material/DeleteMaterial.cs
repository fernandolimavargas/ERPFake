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
    public partial class DeleteMaterial : Form
    {
        public DeleteMaterial()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ERPFAKE;Integrated Security=True";
            string stringComandoConsulta = "SELECT id FROM Material WHERE id = @idConsulta"; // Alterado para procurar por Nome
            string stringComando = "DELETE FROM Material WHERE id = @id";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open(); // Abra a conexão aqui

                // Consulta para obter o ID do material com base no Nome
                SqlCommand sqlCommand = new SqlCommand(stringComandoConsulta, con);
                sqlCommand.Parameters.AddWithValue("@idConsulta", Des_Box.Text); // Use o nome para a pesquisa
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    reader.Close(); // Certifique-se de fechar o leitor após obter o ID

                    // Consulta para excluir o material com base no ID
                    SqlCommand deleteCommand = new SqlCommand(stringComando, con);
                    deleteCommand.Parameters.AddWithValue("@id", id);
                    int rowsAffected = deleteCommand.ExecuteNonQuery(); // Execute a consulta de exclusão

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Material excluído com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Material não encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Material não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
