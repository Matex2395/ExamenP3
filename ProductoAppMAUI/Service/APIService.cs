using Microsoft.Extensions.Configuration;
using ProductoAppMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace ProductoAppMAUI.Service
{
    public class APIService
    {
        public static string _baseUrl;
        public HttpClient _httpClient;
        public APIService()
        {
            _baseUrl = "https://apiproductos20240122074440.azurewebsites.net";
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }



        public async Task<Tarea> PostResena(Tarea tarea)
        {
            var content = new StringContent(JsonConvert.SerializeObject(tarea), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/Tarea", content);

            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Tarea tarea2 = JsonConvert.DeserializeObject<Tarea>(json_response);
                return tarea2;
            }
            return new Tarea();
        }

        public async Task<List<Tarea>> GetTareas(String Nombre, String Estado)
        {
            var response = await _httpClient.GetAsync($"/api/Tarea/{Nombre}/{Estado}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                List<Tarea> listaTareas = JsonConvert.DeserializeObject<List<Tarea>>(json_response);
                return listaTareas;
            }
            return null;

        }

    }
}
