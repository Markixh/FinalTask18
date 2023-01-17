using YoutubeExplode;
using FinalTask18.Commands;

using FinalTask18.Senders;
using FinalTask18.Services;

namespace FinalTask18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var diskSender = new DiskSender();

            var youtubeService = new YoutubeService();

            var command = new DownloadVideoCommand(youtubeService);
            var command2 = new GetInfoForVideoCommand(youtubeService);

            diskSender.SetCommand(command);

            diskSender.Execute();

            diskSender.SetCommand(command2);

            diskSender.Execute();
        }
    }
}