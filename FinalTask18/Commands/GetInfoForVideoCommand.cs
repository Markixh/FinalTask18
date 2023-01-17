using FinalTask18.Services;

namespace FinalTask18.Commands
{
    /// <summary>
    /// Класс реализует команду получения информации о видеоролике
    /// </summary>
    internal class GetInfoForVideoCommand : ICommand
    {
        public IVideoService VideoService { get; private set; }
                
        public GetInfoForVideoCommand(IVideoService videoService)
        {
            this.VideoService = videoService;
        }

        public async Task ExecuteAsync()
        {
            await VideoService.GetInfoForVideoAsync();
        }
    }
}
