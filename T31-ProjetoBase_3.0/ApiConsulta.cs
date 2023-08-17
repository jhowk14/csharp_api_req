using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ApiConsulta : Form
    {
        reqApi reqApi;
        public ApiConsulta()
        {
            reqApi = new reqApi();
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            lboAPI.Items.Clear();
            try
            {
                string response = await reqApi.GetAsync<users>(txtRota.Text);
                List<users> usersList = JsonConvert.DeserializeObject<List<users>>(response);

                string nomes = ""; // Variável para armazenar os nomes

                foreach (users user in usersList)
                {

                    lboAPI.Items.Add("ID: " + user.id + Environment.NewLine + "   Nome: " + user.nome + Environment.NewLine + "   E-mail: " + user.email + Environment.NewLine); // Atribui os nomes ao controle

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.ToString());
            }
        }
    }
}
