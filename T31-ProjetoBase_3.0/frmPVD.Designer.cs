namespace T31_ProjetoBase
{
    partial class frmPVD
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
            label1 = new Label();
            cboPesquisa = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            quantidade = new NumericUpDown();
            lblsubTotal = new Label();
            txtsubtotal = new TextBox();
            dgvProduto = new DataGridView();
            dgvCompra = new DataGridView();
            button1 = new Button();
            btnFinalizar = new Button();
            btnCancelar = new Button();
            label7 = new Label();
            txtTotal = new TextBox();
            label8 = new Label();
            txtDesconto = new TextBox();
            groupBox1 = new GroupBox();
            btnDescontar = new Button();
            button4 = new Button();
            groupBox2 = new GroupBox();
            cboCliente = new ComboBox();
            txtCliente = new TextBox();
            txtPesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(500, 25);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "CPF/Nome Cliente";
            // 
            // cboPesquisa
            // 
            cboPesquisa.FormattingEnabled = true;
            cboPesquisa.Location = new Point(86, 45);
            cboPesquisa.Name = "cboPesquisa";
            cboPesquisa.Size = new Size(155, 23);
            cboPesquisa.TabIndex = 0;
            cboPesquisa.SelectedIndexChanged += cboPesquisa_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 25);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 25);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 1;
            label3.Text = "Quantidade";
            // 
            // quantidade
            // 
            quantidade.Location = new Point(330, 23);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(155, 23);
            quantidade.TabIndex = 3;
            quantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            quantidade.ValueChanged += quantidade_ValueChanged;
            // 
            // lblsubTotal
            // 
            lblsubTotal.AutoSize = true;
            lblsubTotal.Location = new Point(269, 52);
            lblsubTotal.Name = "lblsubTotal";
            lblsubTotal.Size = new Size(55, 15);
            lblsubTotal.TabIndex = 1;
            lblsubTotal.Text = "Sub Total";
            // 
            // txtsubtotal
            // 
            txtsubtotal.Enabled = false;
            txtsubtotal.Location = new Point(330, 52);
            txtsubtotal.Name = "txtsubtotal";
            txtsubtotal.Size = new Size(155, 23);
            txtsubtotal.TabIndex = 4;
            // 
            // dgvProduto
            // 
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Location = new Point(8, 95);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.RowTemplate.Height = 25;
            dgvProduto.Size = new Size(931, 81);
            dgvProduto.TabIndex = 5;
            // 
            // dgvCompra
            // 
            dgvCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompra.Location = new Point(6, 22);
            dgvCompra.Name = "dgvCompra";
            dgvCompra.RowTemplate.Height = 25;
            dgvCompra.Size = new Size(937, 341);
            dgvCompra.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(792, 25);
            button1.Name = "button1";
            button1.Size = new Size(145, 46);
            button1.TabIndex = 7;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(11, 393);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(180, 46);
            btnFinalizar.TabIndex = 8;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(197, 393);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(189, 46);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(775, 375);
            label7.Name = "label7";
            label7.Size = new Size(56, 25);
            label7.TabIndex = 9;
            label7.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(837, 377);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(108, 23);
            txtTotal.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(734, 401);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 9;
            label8.Text = "Desconto:";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(835, 406);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.PlaceholderText = "R$";
            txtDesconto.Size = new Size(108, 23);
            txtDesconto.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvCompra);
            groupBox1.Controls.Add(txtDesconto);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnFinalizar);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(btnDescontar);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(33, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(951, 470);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Itens Venda";
            // 
            // btnDescontar
            // 
            btnDescontar.Location = new Point(835, 435);
            btnDescontar.Name = "btnDescontar";
            btnDescontar.Size = new Size(110, 28);
            btnDescontar.TabIndex = 8;
            btnDescontar.Text = "Descontar";
            btnDescontar.UseVisualStyleBackColor = true;
            btnDescontar.Click += btnDescontar_Click;
            // 
            // button4
            // 
            button4.Location = new Point(392, 393);
            button4.Name = "button4";
            button4.Size = new Size(189, 46);
            button4.TabIndex = 8;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dgvProduto);
            groupBox2.Controls.Add(cboCliente);
            groupBox2.Controls.Add(cboPesquisa);
            groupBox2.Controls.Add(lblsubTotal);
            groupBox2.Controls.Add(txtCliente);
            groupBox2.Controls.Add(txtPesquisa);
            groupBox2.Controls.Add(txtsubtotal);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(quantidade);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(39, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(945, 191);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produto";
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(612, 48);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(155, 23);
            cboCliente.TabIndex = 0;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(612, 25);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(155, 23);
            txtCliente.TabIndex = 4;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(86, 22);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(155, 23);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // frmPVD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 704);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmPVD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mercadinho - PDV";
            Load += frmPVD_Load;
            ((System.ComponentModel.ISupportInitialize)quantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ComboBox cboPesquisa;
        private Label label2;
        private Label label3;
        private NumericUpDown quantidade;
        private Label lblsubTotal;
        private TextBox txtsubtotal;
        private DataGridView dgvProduto;
        private DataGridView dgvCompra;
        private Button button1;
        private Button btnFinalizar;
        private Button btnCancelar;
        private Label label7;
        private TextBox txtTotal;
        private Label label8;
        private TextBox txtDesconto;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtPesquisa;
        private ComboBox cboCliente;
        private TextBox txtCliente;
        private Button button4;
        private Button btnDescontar;
    }
}