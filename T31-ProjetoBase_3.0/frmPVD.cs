using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace T31_ProjetoBase
{
    public partial class frmPVD : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings[2].ConnectionString;
        private decimal total = 0;
        private decimal valorTotal;
        public frmPVD()
        {
            InitializeComponent();
            cboPesquisa.SelectedIndexChanged += cboPesquisa_SelectedIndexChanged;
            dgvProduto.SelectionChanged += dgvProduto_SelectionChanged;
            txtCliente.TextChanged += txtCliente_TextChanged;
            quantidade.ValueChanged += quantidade_ValueChanged;
        }

        private void CarregaCombo()
        {
            string sql = "SELECT codpro, descricao FROM Produtos WHERE (codpro LIKE '%' + @PESQUISA + '%' OR descricao LIKE '%' + @PESQUISA + '%')";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@PESQUISA", txtPesquisa.Text);
                cmd.CommandType = CommandType.Text;

                try
                {
                    con.Open();
                    DataTable table = new DataTable();
                    table.Load(cmd.ExecuteReader());

                    cboPesquisa.DisplayMember = "descricao";
                    cboPesquisa.ValueMember = "codpro";

                    cboPesquisa.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
            }
        }

        private void CarregaGrid()
        {
            if (cboPesquisa.SelectedItem == null) return;

            string codpro = cboPesquisa.SelectedValue.ToString();
            string sql = "SELECT * FROM Produtos WHERE codpro = @CODPRO";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@CODPRO", codpro);
                cmd.CommandType = CommandType.Text;

                try
                {
                    con.Open();
                    DataTable table = new DataTable();
                    table.Load(cmd.ExecuteReader());

                    dgvProduto.DataSource = table;

                    if (dgvProduto.Rows.Count > 0)
                    {
                        dgvProduto.Rows[0].Selected = true; // Seleciona automaticamente a primeira linha
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void CarregaComboCliente()
        {
            string sql = "SELECT codcli, nome FROM Clientes WHERE (codcli LIKE '%' + @PESQUISA + '%' OR nome LIKE '%' + @PESQUISA + '%' OR cpf LIKE '%' + @PESQUISA + '%')";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@PESQUISA", txtCliente.Text);
                cmd.CommandType = CommandType.Text;

                try
                {
                    con.Open();
                    DataTable table = new DataTable();
                    table.Load(cmd.ExecuteReader());

                    cboCliente.DisplayMember = "nome";
                    cboCliente.ValueMember = "codcli";

                    cboCliente.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
            }
        }

        private void AtualizarSubtotal()
        {
            if (dgvProduto.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProduto.SelectedRows[0];
                string codpro = selectedRow.Cells["codpro"].Value.ToString();

                if (selectedRow.Cells["valor"].Value != DBNull.Value)
                {
                    decimal precoUnitario = Convert.ToDecimal(selectedRow.Cells["valor"].Value);
                    int Quantidade = (int)quantidade.Value;

                    valorTotal = precoUnitario * Quantidade;

                    txtsubtotal.Text = valorTotal.ToString("C2"); // Exibe o valor formatado como moeda
                }
            }
        }

        private void frmPVD_Load(object sender, EventArgs e)
        {
            CarregaCombo();
            CarregaComboCliente();
            AtualizarSubtotal();
            ClonarColunas();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregaCombo();
            AtualizarSubtotal();
        }

        private void cboPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaGrid();
            AtualizarSubtotal();
        }

        private void dgvProduto_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarSubtotal();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            CarregaComboCliente();
        }

        private void quantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarSubtotal();
        }
        private void AdicionarLinhaCompra()
        {
            total += valorTotal;
            txtTotal.Text = total.ToString("C2");

            if (dgvProduto.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProduto.SelectedRows[0].Clone() as DataGridViewRow;

                // Copiar os valores das células da linha selecionada do dgvProduto para o dgvCompra
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    selectedRow.Cells[i].Value = dgvProduto.SelectedRows[0].Cells[i].Value;
                }

                // Adicionar a quantidade como uma célula extra
                selectedRow.Cells.Add(new DataGridViewTextBoxCell { Value = quantidade.Value });

                dgvCompra.Rows.Add(selectedRow);
            }
        }

        private void ClonarColunas()
        {
            foreach (DataGridViewColumn col in dgvProduto.Columns)
            {
                dgvCompra.Columns.Add(col.Clone() as DataGridViewColumn);
            }

            // Adicionar a coluna de quantidade
            dgvCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "quantidade",
                HeaderText = "Quantidade"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarLinhaCompra();
            Desconto();
        }
        private void Desconto()
        {
            if (txtDesconto.Text != "" || txtDesconto.Text != null)
            {
                if (decimal.TryParse(txtDesconto.Text, out decimal val))
                {
                    total -= val;
                    txtTotal.Text = total.ToString("C2");
                }
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Desconto();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCompra.SelectedRows[0];
                decimal linhaValor = Convert.ToDecimal(selectedRow.Cells["valor"].Value);

                total -= linhaValor;
                txtTotal.Text = total.ToString("C2");

                dgvCompra.Rows.Remove(selectedRow);
            }
        }

        private void btnDescontar_Click(object sender, EventArgs e)
        {
            Desconto();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.Rows.Count > 0 && cboCliente.SelectedItem != null)
            {
                int codcli = Convert.ToInt32(cboCliente.SelectedValue);
                DateTime dataVenda = DateTime.Now;
                TimeSpan horaVenda = DateTime.Now.TimeOfDay;

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    con.Open();

                    SqlTransaction transaction = con.BeginTransaction();
                    cmd.Transaction = transaction;

                    try
                    {
                        string sql = "INSERT INTO vendas (dataven, hora, valortotal, codcli) VALUES (@data, @hora, @total, @codcli)";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@data", dataVenda);
                        cmd.Parameters.AddWithValue("@hora", horaVenda);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@codcli", codcli);
                        cmd.ExecuteNonQuery();

                        // Recuperar o ID da venda inserida
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT IDENT_CURRENT('vendas')";
                        int idVenda = Convert.ToInt32(cmd.ExecuteScalar());

                        // Inserir os itens da compra na tabela 'itens_venda'
                        foreach (DataGridViewRow row in dgvCompra.Rows)
                        {
                            if (row.Cells["codpro"].Value != null && row.Cells["codpro"].Value != DBNull.Value)
                            {
                                int codpro = Convert.ToInt32(row.Cells["codpro"].Value);

                                decimal valorUnitario = Convert.ToDecimal(row.Cells["valor"].Value);
                                int quantidade = Convert.ToInt32(row.Cells["quantidade"].Value);

                                cmd.Parameters.Clear();
                                cmd.CommandText = "INSERT INTO itensvendas (codpro, codven, subtotal, qtd) VALUES (@codpro, @idvenda, @valorunitario, @quantidade)";
                                cmd.Parameters.AddWithValue("@codpro", codpro);
                                cmd.Parameters.AddWithValue("@idvenda", idVenda);
                                cmd.Parameters.AddWithValue("@valorunitario", valorUnitario);
                                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Venda registrada com sucesso!");

                        // Limpar a lista de compras
                        dgvCompra.Rows.Clear();
                        total = 0;
                        txtTotal.Text = total.ToString("C2");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao registrar venda: " + ex.ToString());

                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente e adicione itens à compra antes de finalizar a venda.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvCompra.Rows.Clear();
            total = 0;
            txtTotal.Text = total.ToString("C2");
        }
    }
}
