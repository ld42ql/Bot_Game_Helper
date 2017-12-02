using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volshebkaHelper
{
    /// <summary>
    /// Кубик
    /// </summary>
   static class Dice
    {
       static Random random = new Random();

        /// <summary>
        /// Результат d6
        /// </summary>
        static public int ResultDice()
        {
            return random.Next(1, 6);
        }

        /// <summary>
        /// Результат в выбранном диапозоне
        /// </summary>
        static public int ResultDice(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
