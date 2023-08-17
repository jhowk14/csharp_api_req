using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace T31_ProjetoBase
{
    public partial class frmBco4 : Form
    {
        // Criando a variável string que tem a conexão com o banco de dados
        private string connectionString =
            ConfigurationManager.ConnectionStrings[2].ConnectionString;

        // Variável de controle para definir INSERT ou UPDATE
        bool novo;

        public frmBco4()
        {
            InitializeComponent();
        }

        // Método que reseta a tela para começar a operar sem sujeiras e travas no código
        private void ResetaTela()
        {
            // Somente o botão Adicionar pode ser clicado
            btnAdicionar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;

            lblCod.Text = string.Empty;
            
            // Habilita e limpa todos os campos de texto
            foreach (TextBox textBox in GetAllTextBoxes(this))
            {
                textBox.Text = string.Empty;
                textBox.Enabled = false;
            }

            txtpesquisa.Enabled = true;
        }

        private void SetAllTextBoxesEnabled(bool enabled)
        {
            foreach (TextBox textBox in GetAllTextBoxes(this))
            {
                textBox.Enabled = enabled;
            }
        }

        // Método auxiliar para obter todos os controles TextBox dentro do formulário e seus controles filhos recursivamente
        private IEnumerable<TextBox> GetAllTextBoxes(Control container)
        {
            var textBoxes = new List<TextBox>();
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBoxes.Add(textBox);
                }
                else if (control.HasChildren)
                {
                    textBoxes.AddRange(GetAllTextBoxes(control));
                }
            }
            return textBoxes;
        }

        private void CarregaGrid()
        {
            string sql = "SELECT codfor, razaosocial, nomefan, cnpj, rua, bairro, estado, telefone, email, cep, cidade " +
                         "FROM Fornecedores WHERE (razaosocial + nomefan + cnpj + rua + bairro + estado + telefone + email + cep + cidade " +
                         "LIKE '%' + @PESQUISA + '%')";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@PESQUISA", txtpesquisa.Text);
                    cmd.CommandType = CommandType.Text;

                    con.Open();
                    try
                    {
                        DataTable table = new DataTable();
                        table.Load(cmd.ExecuteReader());

                        dgvPesquisa.DataSource = table;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.ToString());
                    }
                }
            }
        }

        private void frmBco4_Load(object sender, EventArgs e)
        {
            ResetaTela();
            CarregaGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Ajustes dos botões ligado/desligado
            btnAdicionar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;

            // Habilitando todas as caixas de texto
            SetAllTextBoxesEnabled(true);

            // Posiciona o cursor na caixa de texto indicada
            txtNome.Focus();

            // Configura o controle para inserir um novo cadastro
            novo = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
            ResetaTela();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ajustes dos botões ligado/desligado
            btnAdicionar.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;

            // Habilitando todas as caixas de texto
            SetAllTextBoxesEnabled(true);

            // Posiciona o cursor na caixa de texto indicada
            txtNome.Focus();

            // Utiliza uma variável para armazenar o índice da linha selecionada
            int selectedIndex = e.RowIndex;

            if (selectedIndex >= 0 && selectedIndex < dgvPesquisa.Rows.Count)
            {
                lblCod.Text = dgvPesquisa.Rows[selectedIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvPesquisa.Rows[selectedIndex].Cells[1].Value.ToString();
                txtRazao.Text = dgvPesquisa.Rows[selectedIndex].Cells[2].Value.ToString();
                txtCnpj.Text = dgvPesquisa.Rows[selectedIndex].Cells[3].Value.ToString();
                txtRua.Text = dgvPesquisa.Rows[selectedIndex].Cells[4].Value.ToString();
                txtBairro.Text = dgvPesquisa.Rows[selectedIndex].Cells[5].Value.ToString();
                txtEstado.Text = dgvPesquisa.Rows[selectedIndex].Cells[6].Value.ToString();
                txtTelefone.Text = dgvPesquisa.Rows[selectedIndex].Cells[7].Value.ToString();
                txtEmail.Text = dgvPesquisa.Rows[selectedIndex].Cells[8].Value.ToString();
                txtCep.Text = dgvPesquisa.Rows[selectedIndex].Cells[9].Value.ToString();
                txtCidade.Text = dgvPesquisa.Rows[selectedIndex].Cells[10].Value.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sql;

            // Verifica se todos os campos obrigatórios foram preenchidos antes de atualizar
            if (novo)
            {
                sql = "INSERT INTO Fornecedores (razaosocial, nomefan, cnpj, rua, bairro, estado, telefone, email, cep, cidade) " +
                      "VALUES (@RAZAOSOCIAL, @NOMEFAN, @CNPJ, @RUA, @BAIRRO, @ESTADO, @TELEFONE, @EMAIL, @CEP, @CIDADE)";
            }
            else
            {
                sql = "UPDATE Fornecedores SET razaosocial = @RAZAOSOCIAL, nomefan = @NOMEFAN, cnpj = @CNPJ, rua = @RUA, " +
                      "bairro = @BAIRRO, estado = @ESTADO, telefone = @TELEFONE, email = @EMAIL, cep = @CEP, cidade = @CIDADE " +
                      "WHERE codfor = @CODFOR";
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@RAZAOSOCIAL", txtNome.Text);
                    cmd.Parameters.AddWithValue("@NOMEFAN", txtRazao.Text);
                    cmd.Parameters.AddWithValue("@CNPJ", txtCnpj.Text);
                    cmd.Parameters.AddWithValue("@RUA", txtRua.Text);
                    cmd.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                    cmd.Parameters.AddWithValue("@ESTADO", txtEstado.Text);
                    cmd.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@CEP", txtCep.Text);
                    cmd.Parameters.AddWithValue("@CIDADE", txtCidade.Text);

                    if (int.TryParse(lblCod.Text, out int n))
                    {
                        cmd.Parameters.AddWithValue("@CODFOR", n);
                    }

                    con.Open();
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro atualizado com sucesso!", "Informação",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro atualizado.", "Informação",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar o registro: " + ex.ToString());
                    }
                }
            }

            // Após atualizar, recarrega o grid e reseta a tela para poder cadastrar um novo fornecedor ou realizar nova pesquisa
            CarregaGrid();
            ResetaTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblCod.Text, out int codFor))
            {
                string sql = "DELETE FROM Fornecedores WHERE codfor = @CODFOR";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@CODFOR", codFor);
                        cmd.CommandType = CommandType.Text;

                        con.Open();
                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registro excluído com sucesso!",
                                                "Informação", MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex.ToString());
                        }
                    }
                }
                CarregaGrid();
                ResetaTela();
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir.", "Informação",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmBco4_Load_1(object sender, EventArgs e)
        {
            CarregaGrid();
            ResetaTela();
        }

        private void CarregaGrid(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
