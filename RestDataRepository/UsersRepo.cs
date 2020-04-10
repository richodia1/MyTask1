using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestDataRepository
{
   public class UsersRepo
    {
        private const string BaseUrl = "https://reqres.in";
        private readonly IRestClient _client;
        private IRestResponse restResponse;
        private RestRequest request;
        public UsersRepo()
        {
            _client = new RestClient(BaseUrl);
            request = new RestRequest("api/users?page=2", Method.GET);
        }

        public async Task<IRestResponse<Users>> GetUsersList()
        {
            return await _client.ExecuteGetAsync<Users>(request);
        }
        public int getUsersStatusCode()
        {
            restResponse = _client.Execute(request);
            //Extract status code from received response and store as an Interger
            return (int)restResponse.StatusCode;

        }
    }
}
public class Users
{

    public int page { get; set; }
    public int per_page { get; set; }
    public int total { get; set; }
    public int total_pages { get; set; }
    public Datum[] data { get; set; }
    public Ad ad { get; set; }

}
public class Datum
{
    public int id { get; set; }
    public string email { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string avatar { get; set; }
}
public class Ad
{
    public string company { get; set; }
    public string url { get; set; }
    public string text { get; set; }
}