using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Web;

namespace Acquaint.Integrators.Api.Demo.Utilities
{
    public static class StringExtensions
    {
        public static string SerializeObjectToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            });
        }
        public static string FormatStringObjectToJson(this string str)
        {
            return JToken.Parse(str).ToString(Formatting.Indented);
        }

        public static string ToQueryString(this string jsonString)
        {
           var jsonObject = JObject.Parse(jsonString);
            var queryString = string.Empty;
            foreach (var property in jsonObject.Properties())
            {
                string propertyName = property.Name;
                JToken propertyValue = property.Value;
                if (propertyValue.Type == JTokenType.Date)
                {
                    DateTime dateTime = propertyValue.ToObject<DateTime>();
                    string formattedDate = dateTime.ToString("yyyy-MM-dd");
                    queryString += $"{HttpUtility.UrlEncode(propertyName)}={HttpUtility.UrlEncode(formattedDate?.ToString())}&";
                }
                else
                {
                    queryString += $"{HttpUtility.UrlEncode(propertyName)}={HttpUtility.UrlEncode(propertyValue?.ToString())}&";
                }                
            }

            return "?" + queryString;
        }
    }
}
