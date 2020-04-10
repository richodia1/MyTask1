using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestDataRepository
{
   public class RegisterRepo
    {
        private const string BaseUrl = "https://reqres.in";
        private readonly RestSharp.IRestClient _client;
        RestSharp.IRestResponse restResponse;
        RestSharp.RestRequest request;
        public RegisterRepo()
        {
            _client = new RestClient(BaseUrl);
            request = new RestRequest("api/register", Method.POST);
        }
        public async Task<IRestResponse<RegisterResponse>> SuccessfulRegistration(string email, string password)
        {
            if (email != null && password != null)
            {
                RegisterRequest req = new RegisterRequest();
                req.email = email;
                req.password = password;
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(req);
            }
            return await _client.ExecutePostAsync<RegisterResponse>(request);
        }
        public async Task<IRestResponse<ErrorResponse>> UnsuccessfulRegistration(string email, string password)
        {

            if (!string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                BadRegisterRequest req = new BadRegisterRequest();
                req.email = email;
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(req);
            }
            return await _client.ExecutePostAsync<ErrorResponse>(request);
        }
        public int getRegisterationStatusCode(string email, string password)
        {

            if (email != null && password != null)
            {
                RegisterRequest req = new RegisterRequest();
                req.email = email;
                req.password = password;
                request.RequestFormat = DataFormat.Json;
                restResponse = _client.Execute(request);
            }
            else if (email != null && password == null)
            {
                BadRegisterRequest req = new BadRegisterRequest();
                req.email = email;
                request.RequestFormat = DataFormat.Json;
                restResponse = _client.Execute(request);
            }

            //Extract status code from received response and store as an Interger
            return (int)restResponse.StatusCode;

        }

    }
}
public class RegisterResponse
{
    public int id { get; set; }
    public string token { get; set; }
}
public class ErrorResponse
{
    public string error { get; set; }

}
public class BadRegisterRequest
{
    public string email { get; set; }

}
class RegisterRequest
{
    public string email { get; set; }
    public string password { get; set; }
}

