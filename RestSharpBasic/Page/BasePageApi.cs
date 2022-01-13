using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RestSharpBasic.Page
{
    public class BasePageApi
    {
        public RestClient client;
        public RestRequest request;

        public RestClient SetUrl(string endPoint)
        {
            var url = Path.Combine(Settings.AppUrl + endPoint);
            var client = new RestClient(url);
            return client;
        }

        public RestRequest CreatePostRequest(string payload)
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", payload , ParameterType.RequestBody);

            return request;
        }

        public IRestResponse GetResponse(RestClient client, RestRequest request) 
        {
            return client.Execute(request);

        }

        public BaseEntity GetContent<BaseEntity>(RestResponse response)
        {
            var content = response.Content;
            BaseEntity baseEntity = JsonConvert.DeserializeObject<BaseEntity>(content);

            return baseEntity;
        }
    }
}
