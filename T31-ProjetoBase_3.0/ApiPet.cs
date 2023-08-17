using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T31_ProjetoBase
{
    public partial class ApiPet : Form
    {
        reqApi reqApi;
        public ApiPet()
        {
            reqApi = new reqApi();
            InitializeComponent();
        }

        private async void btnAPI_Click(object sender, EventArgs e)
        {
            pets petData = new pets
            {
                nome = txtNome.Text,
                sexo = txtSexo.Text,
                doenca = txtDoenca.Text,
                usuarioId = txtDonoId.Text,
                especie = txtEspecie.Text,
                idade = txtIdade.Text,
                obs = txtObs.Text,
                tamanho = txtTamanho.Text,
                peso = txtPeso.Text
            };
                string response = await reqApi.PostAsync<pets>("pets", petData);
                MessageBox.Show(response);
        }
        
    }
}
