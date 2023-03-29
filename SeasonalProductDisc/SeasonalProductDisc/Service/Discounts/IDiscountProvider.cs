using SeasonalProductDisc.Model.Discounts;

namespace SeasonalProductDisc.Service.Discounts;

public interface IDiscountProvider
{
    IEnumerable<IDiscount> Discounts { get; }
}