using System;
using System.Net.Http;
using System.Threading.Tasks;
using main;

namespace formula
{

/**
{
  "cep": "01001-000",
  "logradouro": "Praça da Sé",
  "complemento": "lado ímpar",
  "bairro": "Sé",
  "localidade": "São Paulo",
  "uf": "SP",
  "unidade": "",
  "ibge": "3550308",
  "gia": "1004"
}
**/
    public class Hello
    {

        static HttpClient client = new HttpClient();
        static string baseUrl = "http://viacep.com.br/ws/";

        public Hello() {
        }

        public void Run(string cep) {
            Console.WriteLine(GetCepAsync(cep).Result);
        }

        static async Task<string> GetCepAsync(string cep)
        {
            string result = null;
            HttpResponseMessage response = await client.GetAsync(baseUrl + cep + "/json");
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
            }
            return result;
        }
    }
}
