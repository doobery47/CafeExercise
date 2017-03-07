using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeExerciseCode
{
    public class Bill : IBill

    {
        public decimal Total(List<IItem> customerItems)
        {
            decimal total = 0;

            foreach (Item item in customerItems)
            {
                total += item.Price;
            }
            return total;
        }

    }
}
