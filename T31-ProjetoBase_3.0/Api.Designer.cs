namespace T31_ProjetoBase
{
    partial class Api
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
            btnAPI = new Button();
            lboAPI = new ListBox();
            label1 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtCpf = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label4 = new Label();
            txtWhatsapp = new TextBox();
            label5 = new Label();
            txtSenha = new TextBox();
            txtConfirmacao = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnAPI
            // 
            btnAPI.Location = new Point(99, 261);
            btnAPI.Name = "btnAPI";
            btnAPI.Size = new Size(134, 42);
            btnAPI.TabIndex = 1;
            btnAPI.Text = "Chamada";
            btnAPI.UseVisualStyleBackColor = true;
            btnAPI.Click += btnAPI_Click;
            // 
            // lboAPI
            // 
            lboAPI.FormattingEnabled = true;
            lboAPI.ItemHeight = 15;
            lboAPI.Location = new Point(263, 29);
            lboAPI.Name = "lboAPI";
            lboAPI.Size = new Size(249, 319);
            lboAPI.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 32);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(99, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(134, 23);
            txtNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(99, 58);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(134, 23);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 61);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "email";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(99, 87);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(134, 23);
            txtCpf.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 90);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 4;
            label3.Text = "cpf";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(99, 116);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(134, 23);
            txtTelefone.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 119);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 4;
            label4.Text = "telefone";
            // 
            // txtWhatsapp
            // 
            txtWhatsapp.Location = new Point(99, 145);
            txtWhatsapp.Name = "txtWhatsapp";
            txtWhatsapp.Size = new Size(134, 23);
            txtWhatsapp.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 148);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "whatsapp";
            label5.Click += label5_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(99, 174);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(134, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtConfirmacao
            // 
            txtConfirmacao.Location = new Point(99, 203);
            txtConfirmacao.Name = "txtConfirmacao";
            txtConfirmacao.Size = new Size(134, 23);
            txtConfirmacao.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 177);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 4;
            label6.Text = "senha";
            label6.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 203);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 4;
            label7.Text = "confirmação";
            label7.Click += label5_Click;
            // 
            // Api
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 387);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfirmacao);
            Controls.Add(txtSenha);
            Controls.Add(txtWhatsapp);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lboAPI);
            Controls.Add(btnAPI);
            Name = "Api";
            Text = "Api";
            Load += Api_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAPI;
        private ListBox lboAPI;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtCpf;
        private Label label3;
        private TextBox txtTelefone;
        private Label label4;
        private TextBox txtWhatsapp;
        private Label label5;
        private TextBox txtSenha;
        private TextBox txtConfirmacao;
        private Label label6;
        private Label label7;
    }
}