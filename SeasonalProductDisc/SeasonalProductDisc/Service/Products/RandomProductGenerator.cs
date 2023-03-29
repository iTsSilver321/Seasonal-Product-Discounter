using SeasonalProductDisc.Extensions;
using SeasonalProductDisc.Model.Enums;
using SeasonalProductDisc.Model.Products;

namespace SeasonalProductDisc.Service.Products
{
    public class RandomProductGenerator : IProductProvider
    {
        private static readonly Random Random = new();
        private static readonly string[] ProductTypes = { "skirt", "T-Shirt", "jacket", "shirt", "hat", "gloves" };

        public IEnumerable<Product> Products => GenerateRandomProducts();

        private static IEnumerable<Product> GenerateRandomProducts()
        {
            var products = new List<Product>();
            var productCount = Random.Next(1, 11);

            for (var i = 0; i < productCount; i++)
            {
                var color = (Color)Random.Next(0, Enum.GetNames(typeof(Color)).Length);
                var season = (Season)Random.Next(0, Enum.GetNames(typeof(Season)).Length);
                var type = ProductTypes[Random.Next(0, ProductTypes.Length)];
                var price = Math.Round(Random.NextDouble(5.00, 50.00), 2);
                var name = $"{color} {type}";

                products.Add(new Product(name, color, season, price));
            }

            return products;
        }
    }
}