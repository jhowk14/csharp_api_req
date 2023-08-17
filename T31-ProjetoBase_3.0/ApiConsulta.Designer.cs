namespace T31_ProjetoBase
{
    partial class ApiConsulta
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
            button1 = new Button();
            txtRota = new TextBox();
            lboAPI = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(204, 350);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtRota
            // 
            txtRota.Location = new Point(30, 350);
            txtRota.Name = "txtRota";
            txtRota.Size = new Size(100, 23);
            txtRota.TabIndex = 10;
            // 
            // lboAPI
            // 
            lboAPI.FormattingEnabled = true;
            lboAPI.ItemHeight = 15;
            lboAPI.Location = new Point(30, 31);
            lboAPI.Name = "lboAPI";
            lboAPI.Size = new Size(394, 289);
            lboAPI.TabIndex = 11;
            // 
            // ApiConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(lboAPI);
            Controls.Add(txtRota);
            Controls.Add(button1);
            Name = "ApiConsulta";
            Text = "ApiConsulta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox txtRota;
        private ListBox lboAPI;
    }
}