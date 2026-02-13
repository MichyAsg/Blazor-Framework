namespace MyApp.Web.Models.ProductModel
{
    public class CreateProductDto
    {
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
