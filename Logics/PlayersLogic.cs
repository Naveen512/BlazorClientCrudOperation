
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.CRUD.Sample.Models;
using Newtonsoft.Json;
using System.Text;

namespace Blazor.CRUD.Sample.Logics
{
    public class PlayersLogic : IPlayersLogic
    {
        private readonly HttpClient _http;
        public PlayersLogic(HttpClient http)
        {
            _http = http;
        }

        private async Task<bool> SaveOrUpdatePlayer(HttpRequestMessage request, Player player)
        {
            string postData = JsonConvert.SerializeObject(player);


            request.Content = new StringContent(postData, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await _http.SendAsync(request);

            return responseMessage.IsSuccessStatusCode;
        }
        public async Task<bool> CreatePlayer(Player player)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:44316/api/player/save");
            return await SaveOrUpdatePlayer(request, player);
        }


        public async Task<bool> UpdatePlayer(Player player)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:44316/api/player/update");
            return await SaveOrUpdatePlayer(request, player);
        }

        public async Task<IList<Player>> GetAll()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44316/api/player/all");

            HttpResponseMessage responseMessage = await _http.SendAsync(request);
            if (responseMessage.IsSuccessStatusCode)
            {
                string data = await responseMessage.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(data))
                {
                    return JsonConvert.DeserializeObject<List<Player>>(data);
                }
            }
            return null;
        }

        public async Task<Player> GetById(int id)
        {
            string url = $"https://localhost:44316/api/player/get_by_id?id={id}";
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, url);

            HttpResponseMessage responseMessage = await _http.SendAsync(requestMessage);
            if (responseMessage.IsSuccessStatusCode)
            {
                string data = await responseMessage.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(data))
                {
                    return JsonConvert.DeserializeObject<Player>(data);
                }
            }
            return null;
        }

        public async Task<List<Player>> DeleteById(int id)
        {
            string url = $"https://localhost:44316/api/player/delete?id={id}";

            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Delete,url);

            HttpResponseMessage responseMessage = await _http.SendAsync(requestMessage);
            if(responseMessage.IsSuccessStatusCode)
            {
                string data = await responseMessage.Content.ReadAsStringAsync();

                if(!string.IsNullOrEmpty(data))
                {
                    return JsonConvert.DeserializeObject<List<Player>>(data);
                }
            }
            return null;
        }
    }
}

