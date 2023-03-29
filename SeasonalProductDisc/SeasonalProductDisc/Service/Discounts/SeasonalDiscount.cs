using SeasonalProductDisc.Model.Discounts;
using SeasonalProductDisc.Model.Enums;
using SeasonalProductDisc.Model.Products;

namespace SeasonalProductDisc.Service.Discounts
{
    public record SeasonalDiscount(string Name, int Rate, Season[] Seasons) : IDiscount
    {
        public bool Accepts(Product product, DateTime date)
        {
            return Seasons.Contains(product.Season);
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, " +
                   $"{nameof(Rate)}: {Rate}, " +
                   $"{nameof(Seasons)}: {string.Join(",", Seasons)}";
        }
    }
}