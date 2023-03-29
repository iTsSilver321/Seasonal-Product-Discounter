using SeasonalProductDisc.Model.Discounts;
using SeasonalProductDisc.Model.Offers;
using SeasonalProductDisc.Model.Products;

namespace SeasonalProductDisc.Service.Discounts
{
    public class DiscounterService : IDiscounterService
    {
        private readonly IDiscountProvider _discountProvider;

        public DiscounterService(IDiscountProvider discountProvider)
        {
            _discountProvider = discountProvider;
        }

        public Offer GetOffer(Product product, DateTime date)
        {
            var applicableDiscounts = _discountProvider.Discounts.Where(d => d.Accepts(product, date));
            var discountedPrice = product.Price;

            var enumerable = applicableDiscounts as IDiscount[] ?? applicableDiscounts.ToArray();
            foreach (var discount in enumerable)
            {
                discountedPrice -= (discountedPrice * discount.Rate / 100);
            }

            return new Offer(product, date, enumerable, discountedPrice);
        }
    }
}