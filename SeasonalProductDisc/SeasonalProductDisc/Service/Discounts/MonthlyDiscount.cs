using SeasonalProductDisc.Model.Discounts;
using SeasonalProductDisc.Model.Enums;
using SeasonalProductDisc.Model.Products;

namespace SeasonalProductDisc.Service.Discounts
{
    public record MonthlyDiscount(string Name, int Rate, Month[] Months) : IDiscount
    {
        public bool Accepts(Product product, DateTime date)
        {
            return Months.Contains((Month)date.Month);
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, " +
                   $"{nameof(Rate)}: {Rate}, " +
                   $"{nameof(Months)}: {string.Join(",", Months)}";
        }
    }
}