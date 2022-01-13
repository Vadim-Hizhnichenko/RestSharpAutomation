using Newtonsoft.Json;
using RestSharp;
using RestSharpBasic.DTO;
using RestSharpBasic.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpBasic.Page
{
    public class PetsPage
    {
        public PetsEntity GetMethodFindByStatus(string status)
        {
            var client = new RestClient(Settings.AppUrl);
            var request = new RestRequest(status, Method.GET);
            //restRequest.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            var restResponse = client.Execute(request);
            var content = restResponse.Content;

            var listpets = JsonConvert.DeserializeObject<List<PetsEntity>>(content);
            var pets = listpets[0];

            return pets;
        }

        public PetsEntity GetMethodFindById()
        {
            var client = new RestClient(Settings.AppUrl);
            var request = new RestRequest("https://petstore.swagger.io/v2/pet/9223372016854902000", Method.GET);
            var reponse = client.Execute(request);

            var content = reponse.Content;
            var pets = JsonConvert.DeserializeObject<PetsEntity>(content);

            return pets;
        }

        public string GetStatusUrlForPets(EnumStatus status)
        {
            if (status == EnumStatus.Available) return (string)Settings.PetUrlByStatusAlaliable;
            if (status == EnumStatus.Pending) return (string)Settings.PetUrlByStatusPending;
            if (status == EnumStatus.Sold) return (string)Settings.PetUrlByStatusSold;
            else
                throw new ArgumentException();
        }

    }
}
