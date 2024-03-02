using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.Interface;
using WebApplication1.Models;
using Newtonsoft.Json;

namespace WebApplication1.Service
{
    public class AnimalService : IAnimal
    {
        private readonly HttpClient _httpClient;
        private readonly string _url = "https://dog.ceo/api/breeds/image/random";

        public AnimalService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ResponeModel> GetAnimalAsync()
        {
            var response = await _httpClient.GetStringAsync(_url);
            return JsonConvert.DeserializeObject<ResponeModel>(response);
        }
    }
}
