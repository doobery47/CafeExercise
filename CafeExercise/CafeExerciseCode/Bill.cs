using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeExerciseCode
{
    public class Bill : IBill

    {
        enum ChosenFoodType { Drinks, ColdFood, HotFood };
        public decimal Total(List<IItem> customerIItems)
        {

            ChosenFoodType chosenFoodType = Bill.ChosenFoodType.Drinks; // lowest common denominator

            decimal total = 0;
            foreach (IItem item in customerIItems)
            {
                if ((chosenFoodType == ChosenFoodType.ColdFood && item.ConsumableType == EConsumableType.Food && item.Temperature == ETemperature.Hot) ||
                        (chosenFoodType == ChosenFoodType.Drinks) && (item.ConsumableType == EConsumableType.Food && item.Temperature == ETemperature.Hot))
                {
                    chosenFoodType = ChosenFoodType.HotFood;
                }
                else if (chosenFoodType == ChosenFoodType.Drinks && (item.ConsumableType == EConsumableType.Food && item.Temperature == ETemperature.Cold))
                {
                    chosenFoodType = ChosenFoodType.ColdFood;
                }
                // else must be cold drink

                total += item.Price;

            }

            if (chosenFoodType == ChosenFoodType.ColdFood)
            {
                return Math.Round((total + (total / 100) * 10), 2);
            }
            else if (chosenFoodType == ChosenFoodType.HotFood)
            {
                decimal serviceCharge = total / 100 * 20;
                return Math.Round((serviceCharge >= 20 ? 20 + total : serviceCharge + total),2);
            }
            else // drink
            {
                return total;
            }

        }

    }
}
