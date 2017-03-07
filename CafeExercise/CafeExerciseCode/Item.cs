using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeExerciseCode
{
    public class Item : IItem
    {
        // These would ususally come form another source ie dabase
        public static string COKE = "Coke";
        public static string COFFEE = "Coffee";
        public static string CHEESE_SANDWICH = "Cheese Sandwich";
        public static string STEAK_SANDWICH = "Steak Sandwich";

        public EConsumableType ConsumableType { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ETemperature Temperature { get; set; }

    }

}
