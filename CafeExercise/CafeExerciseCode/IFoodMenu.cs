using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeExerciseCode
{
    public interface IFoodMenu
    {
        Item GetItem(string name);
    }

}
