using SeasonalProductDisc.Model.Enums;
using SeasonalProductDisc.Model.Products;

namespace SeasonalProductDisc.Service.Browser;

public class ProductBrowser: IProductBrowser
{
    
    public IEnumerable<Product> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetProductsByColor(Color color)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetProductsBySeason(Season season)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetProductsByPriceRange(double minPrice, double maxPrice)
    {
        throw new NotImplementedException();
    }
}