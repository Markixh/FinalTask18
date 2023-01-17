using FinalTask18.Commands;
using FinalTask18.Senders;
using FinalTask18.Services;

namespace FinalTask18
{
    internal class Program
    {
        static void Main()
        {
            string url;

            // Получаем ссылку на видео из консоли
            while (true)
            {
                Console.WriteLine("Введите ссылку на видеоролик для загрузки:");
                url = Console.ReadLine();

                if (url.StartsWith("https://www.youtube")) break;

                Console.ForegroundColor= ConsoleColor.Red;

                Console.WriteLine("ссылка должна начинаться на https://www.youtube\n");

                Console.ForegroundColor= ConsoleColor.White;
            }

            // Получатель команд
            var youtubeService = new YoutubeService(url);

            // Создаем команды
            var downloadcommand = new DownloadVideoCommand(youtubeService);
            var infoCommand = new GetInfoForVideoCommand(youtubeService);

            Console.WriteLine("\nИнформация о видеоролике:\n");

            // Отправитель команд
            var diskSender = new DiskSender(infoCommand);

            // Запуск команду получения информации о видеофайле
            diskSender.ExecuteAsync();

            // Меняем команду
            diskSender.SetCommand(downloadcommand);

            Console.WriteLine("\nЗагрузка видеоролика...\n");

            // Запуск новую команду загрузки видеоролика
            diskSender.ExecuteAsync();

            Console.WriteLine("\nЗагрузка удачно завершилась.");
            Console.ReadLine();
        }
    }
}