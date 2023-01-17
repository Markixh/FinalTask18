using FinalTask18.Services;

namespace FinalTask18.Commands
{
    /// <summary>
    /// Класс реализует команду загрузки видеоролика
    /// </summary>
    internal class DownloadVideoCommand : ICommand
    {
        public IVideoService VideoService { get; private set; }

        public DownloadVideoCommand(IVideoService videoService) 
        { 
            this.VideoService = videoService;
        }

        public async Task ExecuteAsync()
        {
            await VideoService.DownLoadVideoAsync();
        }
    }
}
