using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    public class NewService
    {
        static int counter = 0; // количество созданных новостных сервисов

        public NewsService()
        {
            counter += 1;
        }

        public void SendMessageForUsers(String message)
        {
            Notify(message);
        }

        // пользователи уведомляют сервис об успешном получении сообщения.
        // Мы выводим это уведомление.
        @Override
        public void Update(String message)
        {
            System.out.println(message);
        }

        @Override
        public String GetName()
        {
            return "NewsService " + counter;
        }
    }
}
