using SeasonalProductDisc.Model.Products;

namespace SeasonalProductDisc.Model.Discounts;

public interface IDiscount
{
    bool Accepts(Product product, DateTime date);

    string Name { get; }

    int Rate { get; }
}