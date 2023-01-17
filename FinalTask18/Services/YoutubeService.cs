namespace FinalTask18.Services
{
    internal class YoutubeService : IVideoService
    {
        public void DownLoadVideo()
        {
            Console.WriteLine("Загрузка начата");
        }

        public void GetInfoForVideo()
        {
            Console.WriteLine("Информация о файле получена");
        }
    }
}
