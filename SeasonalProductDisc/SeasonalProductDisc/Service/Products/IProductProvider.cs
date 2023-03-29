using SeasonalProductDisc.Model.Products;

namespace SeasonalProductDisc.Service.Products;

public interface IProductProvider
{
    IEnumerable<Product> Products { get; }
}