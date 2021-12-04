using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace WebClient.Models
{
    public class ManagerRepository
    {
        string apiUrl = "http://localhost:55503/api/manager";
        private HttpClient _client;

        public ManagerRepository()
        {
            _client = new HttpClient();
        }

        public List<Manager> GetManager(string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = _client.GetStringAsync(apiUrl).Result;

            List<Manager> list = JsonConvert.DeserializeObject<List<Manager>>(result);
            return list;
        }

        public Manager GetManagerId(int managerId , string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = _client.GetStringAsync(apiUrl + "/" + managerId).Result;
            Manager manager = JsonConvert.DeserializeObject<Manager>(result);
            return manager;
        }


        public void AddManager(Manager manager, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            string jsonManager = JsonConvert.SerializeObject(manager);
            StringContent content = new StringContent(jsonManager, Encoding.UTF8, "application/json");
            var result = _client.PostAsync(apiUrl, content).Result;

        }
        public void UpdateManager(Manager manager, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            string jsonManager = JsonConvert.SerializeObject(manager);
            StringContent content = new StringContent(jsonManager, Encoding.UTF8, "application/json");
            var result = _client.PutAsync(apiUrl + "/" + manager.Id, content).Result;

        }
        public void DeleteManager(int managerId , string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = _client.DeleteAsync(apiUrl + "/" + managerId).Result;
        }

    }


    public class Manager
    {
        public int Id { get; set; }
        public int ManagerNo { get; set; }
        public string ManagerName { get; set; }
        public string ManagerFamily { get; set; }
        public int State { get; set; }
    }
}
