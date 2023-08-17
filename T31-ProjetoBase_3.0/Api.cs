using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace T31_ProjetoBase
{
    public partial class Api : Form
    {
        reqApi reqApi;
        public Api()
        {
            reqApi = new reqApi();
            InitializeComponent();
        }
        private async void btnAPI_Click(object sender, EventArgs e)
        {
            users userData = new users
            {
                nome = txtNome.Text,
                email = txtEmail.Text,
                cpf = txtCpf.Text,
                telefone = txtTelefone.Text,
                whatsapp = txtWhatsapp.Text,
                senha = txtSenha.Text,
                confirmacao = txtConfirmacao.Text,
            };
            string response = await reqApi.PostAsync<users>("usuarios", userData);
            lboAPI.Items.Add(response);
            MessageBox.Show(response);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Api_Load(object sender, EventArgs e)
        {

        }
    }
}
