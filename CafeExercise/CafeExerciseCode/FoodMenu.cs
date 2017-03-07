using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeExerciseCode
{
    public class FoodMenu :IFoodMenu
    {
        Dictionary<string, Item> _menuItems;

        public IItem GetItem(string name)
        {
            try
            {
                return (IItem)_menuItems[name];

            }
            catch (Exception)
            {
                throw new Exception("Menu item does not exist");
            }
        }

        public FoodMenu()
        {
            _menuItems = new Dictionary<string, Item>()
            {
                {Item.COKE, new Item {ConsumableType=EConsumableType.Drink, Price=0.5m, Description=Item.COKE, Temperature=ETemperature.Cold } },
                {Item.COFFEE, new Item {ConsumableType=EConsumableType.Drink, Price=1.0m, Description=Item.COFFEE, Temperature=ETemperature.Hot} },
                {Item.CHEESE_SANDWICH, new Item {ConsumableType=EConsumableType.Food, Price=2.0m, Description=Item.CHEESE_SANDWICH, Temperature=ETemperature.Cold} },
                {Item.STEAK_SANDWICH, new Item {ConsumableType=EConsumableType.Food, Price=4.5m, Description=Item.STEAK_SANDWICH, Temperature=ETemperature.Hot } },
            };
        }
    }
}

