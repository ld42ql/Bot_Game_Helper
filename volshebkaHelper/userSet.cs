using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volshebkaHelper
{
    /// <summary>
    /// Данные пользователя
    /// </summary>
    class UserSet
    {
        /// <summary>
        /// От кого сообщения
        /// </summary>
        public string MessageText { get => messageText; set => messageText = value; }
        private string messageFromId = String.Empty;

        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string MessageFromId { get => messageFromId; set => messageFromId = value; }
        private string messageText = String.Empty;

        static public string startURL = $"https://api.telegram.org/bot451203706:AAEXY_QgsHxwwxyqu3t92Lybv0RM2LkirlY";

        /// <summary>
        /// Объект с данными от пользователя
        /// </summary>
        /// <param name="messageFromId">От кого сообщение</param>
        /// <param name="messageText">Текст сообщения</param>
        public UserSet(string messageFromId, string messageText)
        {
            this.messageFromId = messageFromId;
            this.messageText = messageText;
        }
    }
}
