﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RemoveVenda : Form
    {
        public RemoveVenda()
        {
            InitializeComponent();
        }

        private void RemoveVenda_Load(object sender, EventArgs e)
        {
            // Instância do gerenciador da base de dados
            DatabaseManager db = new DatabaseManager();

            try
            {
                // Selecionar todos os códigos de venda da tabela "Vendas"
                DataTable dtVendas = db.SelectDataTable("SELECT Codigo FROM Vendas");

                // Preencher a ComboBox com os códigos de venda
                foreach (DataRow row in dtVendas.Rows)
                {
                    cboxNomeEliminarVenda.Items.Add(row["Codigo"].ToString());
                }

                // Verificação para garantir que há itens na ComboBox
                if (cboxNomeEliminarVenda.Items.Count == 0)
                {
                    MessageBox.Show("Nenhuma venda encontrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar códigos das vendas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarDados_Click(object sender, EventArgs e)
        {
            // Obter o código de venda selecionado na ComboBox
            string codigoVenda = cboxNomeEliminarVenda.SelectedItem?.ToString();

            // Validação básica
            if (string.IsNullOrEmpty(codigoVenda))
            {
                MessageBox.Show("Por favor, selecione um código de venda para eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Instância do gerenciador da base de dados
            DatabaseManager db = new DatabaseManager();

            try
            {
                // Verificar se a venda existe
                string querySelect = "SELECT * FROM Vendas WHERE Codigo = @Codigo";
                DataTable dtVenda = db.SelectDataTableWArgs(querySelect, new SqlParameter("@Codigo", codigoVenda));

                if (dtVenda.Rows.Count > 0)
                {
                    // Venda encontrada, realizar a exclusão
                    string queryDelete = "DELETE FROM Vendas WHERE Codigo = @Codigo";
                    db.NonQueryWArgs(queryDelete, new SqlParameter("@Codigo", codigoVenda));
                    MessageBox.Show("Venda eliminada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar a ComboBox após a exclusão
                    cboxNomeEliminarVenda.Items.Remove(codigoVenda);

                    // Fechar o formulário RemoveVenda se desejar
                    this.Close();
                }
                else
                {
                    // Venda não encontrada
                    MessageBox.Show("Venda não encontrada. Verifique o código e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}