namespace T31_ProjetoBase
{
    partial class frmBco3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPesquisa = new TextBox();
            dgvDados = new DataGridView();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnAdicionar = new Button();
            label12 = new Label();
            txtTelefone = new TextBox();
            txtRua = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            txtCep = new TextBox();
            txtRg = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label13 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblCodigo = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            txtCpf = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisa
            // 
            txtPesquisa.BackColor = Color.DarkOliveGreen;
            txtPesquisa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPesquisa.ForeColor = Color.White;
            txtPesquisa.Location = new Point(64, 228);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(330, 23);
            txtPesquisa.TabIndex = 14;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(9, 257);
            dgvDados.Name = "dgvDados";
            dgvDados.RowTemplate.Height = 25;
            dgvDados.Size = new Size(985, 150);
            dgvDados.TabIndex = 15;
            dgvDados.CellClick += dgvDados_CellClick;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(888, 119);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 47);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(807, 119);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 47);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(726, 119);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 47);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.ForeColor = Color.FromArgb(64, 0, 64);
            btnAdicionar.Location = new Point(645, 119);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 47);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(442, 147);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 73;
            label12.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(501, 148);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 9;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(73, 177);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(330, 23);
            txtRua.TabIndex = 5;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(501, 90);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 7;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(501, 61);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(161, 23);
            txtCidade.TabIndex = 6;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(501, 119);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 8;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(73, 148);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 4;
            // 
            // txtRg
            // 
            txtRg.Location = new Point(73, 119);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(100, 23);
            txtRg.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 178);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 65;
            label11.Text = "Rua";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(442, 91);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 64;
            label10.Text = "Bairro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(442, 63);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 63;
            label9.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 231);
            label13.Name = "label13";
            label13.Size = new Size(53, 15);
            label13.TabIndex = 62;
            label13.Text = "Pesquisa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 119);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 61;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 151);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 60;
            label6.Text = "Cep";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 124);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 59;
            label5.Text = "RG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 97);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 58;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 70);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 57;
            label3.Text = "Nome";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = Color.Blue;
            lblCodigo.Location = new Point(73, 43);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(28, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "XXX";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(73, 61);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(330, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 43);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 54;
            label1.Text = "Código";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(73, 90);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 2;
            // 
            // frmBco3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 450);
            Controls.Add(txtPesquisa);
            Controls.Add(dgvDados);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnAdicionar);
            Controls.Add(label12);
            Controls.Add(txtTelefone);
            Controls.Add(txtRua);
            Controls.Add(txtBairro);
            Controls.Add(txtCidade);
            Controls.Add(txtEstado);
            Controls.Add(txtCep);
            Controls.Add(txtRg);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label13);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblCodigo);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(txtCpf);
            Name = "frmBco3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mercadinho - Clientes";
            Load += frmBco3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisa;
        private DataGridView dgvDados;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnAdicionar;
        private Label label12;
        private TextBox txtTelefone;
        private TextBox txtRua;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private TextBox txtCep;
        private TextBox txtRg;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label13;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblCodigo;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtCpf;
    }
}