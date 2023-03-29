using SeasonalProductDisc.Service.Discounts;
using SeasonalProductDisc.Service.Products;
using SeasonalProductDisc.Ui;

namespace SeasonalProducDisc
{
    class Program
    {
        public static void Main(string[] args)
        {
            IProductProvider productProvider = new ProductProvider();
            IDiscountProvider discountProvider = new DiscountProvider();
            IDiscounterService discounterService = new DiscounterService(discountProvider);

            SeasonalProductDiscounterUi ui = new SeasonalProductDiscounterUi(productProvider, discountProvider, discounterService);
            ui.Run();
        }
    }
}