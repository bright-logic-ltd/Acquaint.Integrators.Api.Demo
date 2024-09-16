namespace Acquaint.Integrators.Api.Demo.Models
{
    public class Category
    {
        public string? Name { get; set; }
        public List<Subcategory>? Subcategories { get; set; }
        public bool IsExpanded { get; set; } = false;

        public override string ToString()
        {
            return Name!;
        }
    }
}
