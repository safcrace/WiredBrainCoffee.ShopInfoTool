using WiredBrainCoffee.ShopInfoTool.Model;

namespace WiredBrainCoffee.ShopInfoTool.Data;

public class CoffeShopDataProvider
{
    public IEnumerable<CoffeeShop> LoadShops()
    {
        return new CoffeeShop[]
        {
            new CoffeeShop("frankfurt", 45),
            new CoffeeShop("Zurich", 39),
            new CoffeeShop("Rome", 25),
        };
    }
}
