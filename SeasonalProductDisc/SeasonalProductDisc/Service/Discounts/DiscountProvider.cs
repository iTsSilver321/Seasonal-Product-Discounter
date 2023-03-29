using SeasonalProductDisc.Model.Discounts;
using SeasonalProductDisc.Model.Enums;

namespace SeasonalProductDisc.Service.Discounts
{
    public class DiscountProvider : IDiscountProvider
    {
        public IEnumerable<IDiscount> Discounts { get; }

        public DiscountProvider()
        {
            Discounts = new List<IDiscount>
            {
                new MonthlyDiscount("January Sale", 50, new[] { Month.January }),
                new ColorDiscount("Red Sale", 20, new[] { Color.Red }),
                new SeasonalDiscount("Summer Sale", 30, new[] { Season.Summer })
            };
        }
    }
}