using SeasonalProductDisc.Model.Discounts;
using SeasonalProductDisc.Model.Enums;
using SeasonalProductDisc.Model.Products;

namespace SeasonalProductDisc.Service.Discounts;

public record ColorDiscount(string Name, int Rate, Color[] Colors) : IDiscount
{
    public bool Accepts(Product product, DateTime date)
    {
        return Colors.Contains(product.Color);
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, " +
               $"{nameof(Rate)}: {Rate}, " +
               $"{nameof(Colors)}: {string.Join(",", Colors)}";
    }
}