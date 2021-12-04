using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebClient.Models;

namespace WebClient.Repository
{
    public class OfficialRepository
    {
        string apiUrl = "http://localhost:55503/api/official/GetOfficialInDate";
        private HttpClient _client;

        public OfficialRepository()
        {
            _client = new HttpClient();
        }

        public List<OfficialViewModel> GetOfficial(string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = _client.GetStringAsync(apiUrl).Result;

            List<OfficialViewModel> list = JsonConvert.DeserializeObject<List<OfficialViewModel>>(result);
            return list;
        }

        public OfficialViewModel GetOfficialId(int officialId, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = _client.GetStringAsync(apiUrl + "/" + officialId).Result;
            OfficialViewModel Official = JsonConvert.DeserializeObject<OfficialViewModel>(result);
            return Official;
        }


        public void AddOfficial(OfficialViewModel official, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            string jsonOfficial = JsonConvert.SerializeObject(official);
            StringContent content = new StringContent(jsonOfficial, Encoding.UTF8, "application/json");
            var result = _client.PostAsync(apiUrl, content).Result;

        }
        public void UpdateOfficial(OfficialViewModel official, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            string jsonOfficial = JsonConvert.SerializeObject(official);
            StringContent content = new StringContent(jsonOfficial, Encoding.UTF8, "application/json");
            var result = _client.PutAsync(apiUrl + "/" + official.Id, content).Result;

        }
        public void DeleteOfficial(int officialId, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = _client.DeleteAsync(apiUrl + "/" + officialId).Result;
        }

    }
}
