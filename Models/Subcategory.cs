namespace Acquaint.Integrators.Api.Demo.Models
{
    public class Subcategory
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
        public ApiMethodType MethodType { get; set; }
        public string? RequestBody { get; set; }
        public bool isUploadFile { get; set; }
        public string? SupportedFileTypes { get; set; }
    }

    public enum ApiMethodType
    {
        Get,
        Post,
        Put,
        Delete
    }
}
