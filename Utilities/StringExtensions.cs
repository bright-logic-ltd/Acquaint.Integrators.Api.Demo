using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Acquaint.Integrators.Api.Tests.Utilities
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
    }
}
