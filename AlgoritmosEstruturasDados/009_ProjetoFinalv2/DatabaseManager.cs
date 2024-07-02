using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _009___Projeto_Final
{
    internal class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager()
        {
            connectionString = "Data Source=DESKTOP-DSEV4I4\\SQLEXPRESS;Initial Catalog=ProjAED;Integrated Security=True";
        }


        //string conString = "Data Source=localhost;Initial Catalog=GestaoVendas-ProjAED;Integrated Security=True";

        //String de conexão à base de dados
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DSEV4I4\\SQLEXPRESS;Initial Catalog=ProjAED;Integrated Security=True");

        public void NonQuery(string query) //Função para inserir/atualizar/apagar dados na base de dados
        {
            try
            {
                con.Open(); //Abre a conexão
                SqlCommand cmd = new SqlCommand(query, con); //Cria um comando SQL com a query e a conexão de parametro
                cmd.ExecuteNonQuery(); //Executa o comando SQL
            }
            catch (Exception ex) //Caso haja erro, mostra uma mensagem de erro
            {
                //MessageBox.Show($"Error: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Foi tirado o MessageBox para que a mensagem de erro seja tratada no form porque senão dava o erro em duplicado.
                throw new Exception($"Erro: {ex.Message}");
            }
            finally //Por fim fecha a conexão
            {
                con.Close();
            }
        }

        public DataTable SelectDataTable(string query) //Função para selecionar dados na base de 
        {                                              //dados para ser usado em ComboBox por exemplo
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd); // Mete os dados do comando SQL num 'adaptador'
                da.Fill(dt);                                 //Preenche a DataTable com os dados do 'adaptador'
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable SelectDataTableWArgs(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Erro ao buscar dados: {ex.Message}", ex);
                }
                return dt; // A conexão será fechada automaticamente aqui
            }
        }

        public void NonQueryWArgs(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Operação no banco de dados falhou: {ex.Message}", ex);
                } // A conexão será fechada automaticamente aqui
            }
        }

        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        return cmd.ExecuteScalar();
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Erro ao executar operação escalar: {ex.Message}", ex);
                }
            }
        }
    }
}
