namespace Acquaint.Integrators.Api.Demo.Models
{
    public class Subcategory
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
        public ApiMethodType MethodType { get; set; }
        public string? RequestBody { get; set; }
    }

    public enum ApiMethodType
    {
        GET,
        POST,
        PUT,
        DELETE
    }
}
