using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpBasic
{
    public static class Settings
    {
        public static string AppUrl = "https://petstore.swagger.io/v2/swagger.json";
        public static string PetUrlByStatusAlaliable = "https://petstore.swagger.io/v2/pet/findByStatus?status=available";
        public static string PetUrlByStatusPending = "https://petstore.swagger.io/v2/pet/findByStatus?status=pending";
        public static string PetUrlByStatusSold = "https://petstore.swagger.io/v2/pet/findByStatus?status=sold";

    }
}
