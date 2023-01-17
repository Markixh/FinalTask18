using YoutubeExplode;
using FinalTask18.Commands;

using FinalTask18.Senders;
using FinalTask18.Services;
using YoutubeExplode.Converter;

namespace FinalTask18
{
    internal class Program
    {
        static void Main()
        {     
            var youtubeService = new YoutubeService("https://www.youtube.com/watch?v=Mr-z-6EW-Fc");

            var downloadcommand = new DownloadVideoCommand(youtubeService);
            var infoCommand = new GetInfoForVideoCommand(youtubeService);

            var diskSender = new DiskSender(infoCommand);

            diskSender.ExecuteAsync();

            diskSender.SetCommand(downloadcommand);

            diskSender.ExecuteAsync();
        }
    }
}