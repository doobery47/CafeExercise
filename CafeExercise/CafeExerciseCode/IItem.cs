using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeExerciseCode
{
    public interface IItem
    {
        decimal Price { get; set; }
        string Description { get; set; }
        ETemperature Temperature { get; set; }
        EConsumableType ConsumableType { get; set; }

    }


}
