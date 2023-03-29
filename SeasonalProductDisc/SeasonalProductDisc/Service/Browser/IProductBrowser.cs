using SeasonalProductDisc.Model.Enums;
using SeasonalProductDisc.Model.Products;

namespace SeasonalProductDisc.Service.Browser;

public interface IProductBrowser
{
    IEnumerable<Product> GetAllProducts();
    IEnumerable<Product> GetProductsByColor(Color color);
    IEnumerable<Product> GetProductsBySeason(Season season);
    IEnumerable<Product> GetProductsByPriceRange(double minPrice, double maxPrice);
}