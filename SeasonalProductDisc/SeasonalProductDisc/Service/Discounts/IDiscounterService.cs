using SeasonalProductDisc.Model.Offers;
using SeasonalProductDisc.Model.Products;

namespace SeasonalProductDisc.Service.Discounts;

public interface IDiscounterService
{
    Offer GetOffer(Product product, DateTime date);
}