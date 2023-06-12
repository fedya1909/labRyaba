using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace labRyaba
{
    internal class Program
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить пользователя");
            Console.WriteLine("2. Удалить пользователя");
            Console.WriteLine("3. Отправить сообщение пользователям");
            Console.WriteLine("4. Выйти");
        }
        static void Main(string[] args)
        {
            NewService newsService = new NewService();

            PrintMenu();

            while (true)
            {
                PrintMenu();
                String choice = Console.ReadLine();
                if (choice.Equals("1"))
                {
                    Console.WriteLine("Введите имя пользователя: ");
                    String userName = Console.ReadLine();
                    User user = new User(userName);
                    user.Attach(newsService); // добавлем к новому пользователю новостной сервис в качестве наблюдателя с той целью, чтобы уведомлять последнего о том, что пользователю приходят сообщения.
                    newsService.Attach(user);
                }
                else if (choice.Equals("2"))
                {
                    Console.WriteLine("Введите имя пользователя, которого нужно удалить: ");
                    String userName = Console.ReadLine();
                    newsService.DetachObserverByName(userName);
                }
                else if (choice.Equals("3"))
                {
                    Console.WriteLine("Введите сообщение: ");
                    String message = Console.ReadLine();
                    newsService.SendMessageForUsers(message);
                }
                else if (choice.Equals("4"))
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.\n");
                }
            }
        }

    }
}
