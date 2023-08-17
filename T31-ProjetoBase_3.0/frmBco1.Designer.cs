namespace T31_ProjetoBase
{
    partial class frmBco1
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
            dgvCategories = new DataGridView();
            btnCarregar = new Button();
            cboSuppliers = new ComboBox();
            btnCarregarCbo = new Button();
            btnSelecionarItem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(23, 22);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowTemplate.Height = 25;
            dgvCategories.Size = new Size(746, 304);
            dgvCategories.TabIndex = 0;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(23, 332);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(197, 41);
            btnCarregar.TabIndex = 1;
            btnCarregar.Text = "Carregar GRID";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // cboSuppliers
            // 
            cboSuppliers.FormattingEnabled = true;
            cboSuppliers.Location = new Point(565, 332);
            cboSuppliers.Name = "cboSuppliers";
            cboSuppliers.Size = new Size(204, 23);
            cboSuppliers.TabIndex = 2;
            // 
            // btnCarregarCbo
            // 
            btnCarregarCbo.Location = new Point(362, 332);
            btnCarregarCbo.Name = "btnCarregarCbo";
            btnCarregarCbo.Size = new Size(197, 41);
            btnCarregarCbo.TabIndex = 1;
            btnCarregarCbo.Text = "Carregar Combobox";
            btnCarregarCbo.UseVisualStyleBackColor = true;
            btnCarregarCbo.Click += btnCarregarCbo_Click;
            // 
            // btnSelecionarItem
            // 
            btnSelecionarItem.Enabled = false;
            btnSelecionarItem.Location = new Point(362, 379);
            btnSelecionarItem.Name = "btnSelecionarItem";
            btnSelecionarItem.Size = new Size(197, 41);
            btnSelecionarItem.TabIndex = 1;
            btnSelecionarItem.Text = "Selecionar Item da Combobox";
            btnSelecionarItem.UseVisualStyleBackColor = true;
            btnSelecionarItem.Click += btnSelecionarItem_Click;
            // 
            // frmBco1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboSuppliers);
            Controls.Add(btnSelecionarItem);
            Controls.Add(btnCarregarCbo);
            Controls.Add(btnCarregar);
            Controls.Add(dgvCategories);
            Name = "frmBco1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Northwind - Exemplo 1";
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategories;
        private Button btnCarregar;
        private ComboBox cboSuppliers;
        private Button btnCarregarCbo;
        private Button btnSelecionarItem;
    }
}