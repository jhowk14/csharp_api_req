using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T31_ProjetoBase
{
    internal class reqApi
    {
        private string baseUrl = "http://localhost:3200/";

        public reqApi() 
        {

        }

        public async Task<string> GetAsync<T>(string route, int? id = null)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = baseUrl+ "consultar/" + route;
                    if (id.HasValue)
                    {
                        url += id.Value.ToString();
                    }

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        return responseBody;
                    }
                    else
                    {
                        MessageBox.Show("A chamada à API falhou com o código de status: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao fazer a chamada à API: " + ex.Message);
            }

            return null;
        }

        public async Task<string> PostAsync<T>(string route, T data)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = baseUrl +"cadastrar/"+ route;

                    string jsonData = JsonConvert.SerializeObject(data);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        return responseBody;
                    }
                    else
                    {

                        MessageBox.Show("A chamada à API falhou com o código de status: " + response.StatusCode);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao fazer a chamada à API: " + ex.Message);
            }

            return null;
        }
        public async Task<string> PutAsync<T>(string route, T data, int id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = baseUrl + "atualizar/" + route +"/"+ id;
                    string jsonData = JsonConvert.SerializeObject(data);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PutAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        return responseBody;
                    }
                    else
                    {
                        MessageBox.Show("A chamada à API falhou com o código de status: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao fazer a chamada à API: " + ex.Message);
            }

            return null;
        }

    }

    public class pets
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string doenca { get; set; }
        public string usuarioId { get; set; }
        public string especie { get; set; }
        public string idade { get; set; }
        public string obs { get; set; }
        public string tamanho { get; set; }
        public string peso { get; set; }
    }

    public class users
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string whatsapp { get; set; }
        public string senha { get; set; }
        public string confirmacao { get; set; }
    }

    public class doacao
    {

        public string data_interesse { get; set; }
        public string data_doacao { get; set; }
        public string usuarioId { get; set; }
        public string petId { get; set; }
    }
}
