using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeExerciseCode;
using NUnit.Framework;

namespace CafeExercise
{
    public class CafeTestCode
    {
        [TestFixture]

        public class Phase1Tests
        {
            [Test]
            public void Cosntruct_a_FoodMenu()
            {

            }

            // requirement 1. There is a menu that contains a number of items and consists of the following:
            // Coke
            // Coffee
            // Cheese sandwich
            // steak sandwich

            [Test]
            public void Constructing_a_menu_with_items()
            {
                FoodMenu menu = new FoodMenu();
                Assert.IsInstanceOf<Item>(menu.GetItem(Item.COKE));
                Assert.IsInstanceOf<Item>(menu.GetItem(Item.COFFEE));
                Assert.IsInstanceOf<Item>(menu.GetItem(Item.CHEESE_SANDWICH));
                Assert.IsInstanceOf<Item>(menu.GetItem(Item.STEAK_SANDWICH));
            }

            [Test]
            public void Retrieving_coke_item_from_menu()
            {
                postive_test_of_item(Item.COKE, 0.5m, ETemperature.Cold, EConsumableType.Drink);
            }

            [Test]

            public void Retrieving_coffee_item_from_menu()
            {
                postive_test_of_item(Item.COFFEE, 1.0m, ETemperature.Hot, EConsumableType.Drink);
            }

            [Test]
            public void Retrieving_cheese_sandwich_item_from_menu()
            {
                postive_test_of_item(Item.CHEESE_SANDWICH, 2.0m, ETemperature.Cold, EConsumableType.Food);
            }

            [Test]
            public void Retrieving_steak_sandwich_item_from_menu()
            {
                postive_test_of_item(Item.STEAK_SANDWICH, 4.5m, ETemperature.Hot, EConsumableType.Food);
            }

            [Test]
            public void Retrieving_an_invalid_item_from_menu()
            {
                FoodMenu menu = new FoodMenu();
                Assert.Throws<Exception>(() => menu.GetItem("Cake"));
            }

            public void postive_test_of_item(string name, decimal price, ETemperature temperature, EConsumableType consumable)
            {
                FoodMenu menu = new FoodMenu();
                IItem item = menu.GetItem(name);
                Assert.IsInstanceOf<Item>(item);
                Assert.IsTrue(item.Description == name);
                Assert.IsTrue(item.Price == price);
                Assert.IsTrue(item.Temperature == temperature);
                Assert.IsTrue(item.ConsumableType == consumable);
            }

            [Test]
            public void is_totals_for_all_items_are_correct()
            {
                FoodMenu menu = new FoodMenu();
                List<IItem> items = new List<IItem>()
                {
                    menu.GetItem(Item.CHEESE_SANDWICH),
                    menu.GetItem(Item.COFFEE),
                    menu.GetItem(Item.COKE),
                    menu.GetItem(Item.STEAK_SANDWICH)
                };

                IBill bill = new Bill();
                Assert.IsTrue(bill.Total(items) == 8.00m);

            }

            [Test]

            public void is_totals_for_3_items_correct()
            {
                FoodMenu menu = new FoodMenu();
                List<IItem> items = new List<IItem>()
                {
                    menu.GetItem(Item.CHEESE_SANDWICH),
                    menu.GetItem(Item.COFFEE),
                    menu.GetItem(Item.COKE)
                };

                IBill bill = new Bill();
                Assert.IsTrue(bill.Total(items) == 3.5m);
            }

            [Test]
            public void is_totals_for_1_items_correct()
            {
                FoodMenu menu = new FoodMenu();
                List<IItem> items = new List<IItem>()
                {
                    menu.GetItem(Item.COKE)
                };

                IBill bill = new Bill();
                Assert.IsTrue(bill.Total(items) == 0.5m);

            }

            [Test]
            public void is_totals_for_0_items_correct()
            {
                FoodMenu menu = new FoodMenu();
                List<IItem> items = new List<IItem>();
                IBill bill = new Bill();
                Assert.IsTrue(bill.Total(items) == 0m);

            }
        }
    }
}
