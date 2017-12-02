using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Threading;

namespace volshebkaHelper
{
    class Program
    {


        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            WorkingBot user;

            int update_id = 0;
            string messageFromId = String.Empty;
            string messageText = String.Empty;
            string lineResult = String.Empty;

            string errorMsg = String.Empty;

            bool flag = true;

            while (true)
            {
                string url = $"{UserSet.startURL}/getUpdates?offset={update_id + 1}";
                string response = webClient.DownloadString(url);

                var list = JObject.Parse(response)["result"].ToArray();

                foreach (var message in list)
                {
                    update_id = Convert.ToInt32(message["update_id"]);
                    try
                    {
                        messageFromId = message["message"]["from"]["id"].ToString();
                        messageText = message["message"]["text"].ToString();

                        if (flag)
                        {
                            webClient.DownloadString($"https://api.telegram.org/bot451203706:AAEXY_QgsHxwwxyqu3t92Lybv0RM2LkirlY/sendMessage?chat_id={messageFromId}&text={Operations.ErrorAnswer()}");
                            flag = false;
                        }
                        user = new WorkingBot(messageFromId, messageText);

                        lineResult = $"\n****************\n{update_id} {messageFromId} {messageText} {DateTime.Now}\n****************\n";

                        Console.WriteLine($"{lineResult}");

                        string str = user.AnswerBots;

                        if (str != "")
                        {
                            webClient.DownloadString(str);
                        }
                        
                    }
                    catch (Exception e)
                    {
                        string error = $"\n****************\n{e.ToString()}\n{DateTime.Now}\n****************\n";
                        Console.WriteLine($"{error}");
                        errorMsg += error;
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
