using FinalTask18.Services;

namespace FinalTask18.Commands
{
    internal class GetInfoForVideoCommand : ICommand
    {
        public IVideoService VideoService { get; private set; }

        public GetInfoForVideoCommand(IVideoService videoService)
        {
            this.VideoService = videoService;
        }

        public async Task ExecuteAsync()
        {
            Console.WriteLine("Команда получена");
            await VideoService.GetInfoForVideoAsync();
        }
    }
}
