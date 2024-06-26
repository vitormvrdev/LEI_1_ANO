using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    internal class DatabaseManager
    {
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
            DataTable dt = new DataTable();
   
            try
            {
                // Abre a conexão com a base de dados
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Se houver parâmetros, adiciona-os ao comando SQL
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    // Usa um SqlDataAdapter para executar a consulta e preencher o DataTable com os resultados

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Atira uma exceção se ocorrer um erro ao pegar nos dados
                throw new Exception($"Error fetching data: {ex.Message}", ex);
            }
            // Retorna o DataTable preenchido com os resultados da consulta
            return dt;
        }
        public void NonQueryWArgs(string query, params SqlParameter[] parameters)
        {
            try
            {
                // Cria um comando SQL com a consulta e a conexão
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Se houver parâmetros, adiciona-os ao comando SQL
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    // Executa o comando SQL
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Lança uma exceção se ocorrer um erro durante a operação na base de dados
                throw new Exception($"Database operation failed: {ex.Message}", ex);
            }
        }
    }
}
