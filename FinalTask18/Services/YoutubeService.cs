using YoutubeExplode;
using YoutubeExplode.Converter;

namespace FinalTask18.Services
{
    internal class YoutubeService : IVideoService
    {
        private readonly YoutubeClient youtubeClient;
        private readonly string videoUrl;

        public YoutubeService(string videoUrl)
        {
            youtubeClient = new YoutubeClient();
            this.videoUrl = videoUrl;
        }

        public async Task DownLoadVideoAsync()
        {
            Console.WriteLine("Загрузка начата");
            try
            {
                await youtubeClient.Videos.DownloadAsync(videoUrl, "video.mp4", o => o
                .SetPreset(ConversionPreset.UltraFast));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        public async Task GetInfoForVideoAsync()
        {
            var video = await youtubeClient.Videos.GetAsync(videoUrl);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(video.Title);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(video.Description);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
