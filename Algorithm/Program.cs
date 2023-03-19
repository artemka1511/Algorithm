using System;
using System.Collections.Generic;
using System.Threading;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var found = false;

            var users = new List<User>() 
            { 
                new User("Sergey3307", "Sergey", true),
                new User("Vlad1511", "Vlad", false),
                new User("Ivan777", "Ivan", true) 
            };


            Console.Write("Введите ваш логин: ");
            var inputLogin = Console.ReadLine();

            foreach (var user in users)
            {
                if(user.Login == inputLogin)
                {
                    found = true;
                    var greetings = $"Здравствуйте, {user.Name}";

                    Console.WriteLine(greetings);

                    if (!user.IsPremium)
                    {
                        ShowAds();
                    }
                }
            }

            if (!found) { Console.WriteLine("Ошибка! Пользователь не найден"); }

        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
