using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;

namespace volshebkaHelper
{
    class WorkingBot : UserSet
    {
        public WorkingBot(string messageFromId, string messageText) : base(messageFromId, messageText)
        {
        }

        private string answerBots = String.Empty;
        public string AnswerBots
        {
            get
            {
                SelectOperations();
                return answerBots;
            }
        }

        /// <summary>
        /// Формируем ответ
        /// </summary>
        /// <param name="operations">Для какого метода</param>
        string AnswerMessage(PossibleOperations operations)
        {
            string str = $"{startURL}/sendMessage?chat_id={MessageFromId}&text={operations()}";
            return str;
        }

        /// <summary>
        /// Выбор ответа
        /// </summary>
        void SelectOperations()
        {
            if (!Char.IsLetter(MessageText, 0))
            {
                switch (MessageText.Substring(1, MessageText.Length - 1))
                {
                    case "путешествие": answerBots = AnswerMessage(operations: Operations.EventRandom); break;
                    case "кубик": answerBots = AnswerMessage(operations: Operations.ResultDice); break;
                    default: answerBots = AnswerMessage(operations: Operations.ErrorAnswer); break;
                }
            }
        }
    }
}
