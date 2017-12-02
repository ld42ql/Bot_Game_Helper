using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volshebkaHelper
{
    delegate string PossibleOperations();

    class Operations
    {
        /// <summary>
        /// Как прошло путешествие
        /// </summary>
        static public string EventRandom()
        {
            switch (Dice.ResultDice())
            {
                case 1: return "На пути встретилась засада.";
                case 2: return "На пути встретились враждебные силы";
                case 5: return "На пути встретились нейтральные силы";
                case 6: return "Находка!!!";
                default: return "Ничего не произошло";
            }
        }

        /// <summary>
        /// Кубик d6
        /// </summary>
        static public string ResultDice()
        {
            return Dice.ResultDice().ToString();
        }

        /// <summary>
        /// Сообщение о ошибке
        /// </summary>
        static public string ErrorAnswer()
        {
            return $"\n***********************Справка***********************\n\n\n" +
                $"\\путешествие - Сообщает события во время путешествия.\n" +
                $"\\кубик - Бросок кубика d6.\n\n" +
                $"*****************************************************";
        }
        
    }
}
