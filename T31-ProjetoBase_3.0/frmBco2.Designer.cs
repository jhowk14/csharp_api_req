namespace T31_ProjetoBase
{
    partial class frmBco2
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
            cboCategories = new ComboBox();
            btnCarregarDados = new Button();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // cboCategories
            // 
            cboCategories.FormattingEnabled = true;
            cboCategories.Location = new Point(12, 21);
            cboCategories.Name = "cboCategories";
            cboCategories.Size = new Size(165, 23);
            cboCategories.TabIndex = 5;
            // 
            // btnCarregarDados
            // 
            btnCarregarDados.Location = new Point(183, 20);
            btnCarregarDados.Name = "btnCarregarDados";
            btnCarregarDados.Size = new Size(228, 23);
            btnCarregarDados.TabIndex = 4;
            btnCarregarDados.Text = "Carregar Produtos Dessa Categoria";
            btnCarregarDados.UseVisualStyleBackColor = true;
            btnCarregarDados.Click += btnCarregarDados_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 49);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(766, 291);
            dgvProducts.TabIndex = 3;
            // 
            // frmBco2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 404);
            Controls.Add(cboCategories);
            Controls.Add(btnCarregarDados);
            Controls.Add(dgvProducts);
            Name = "frmBco2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Northwind - Exemplo 2";
            Load += frmBco2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboCategories;
        private Button btnCarregarDados;
        private DataGridView dgvProducts;
    }
}