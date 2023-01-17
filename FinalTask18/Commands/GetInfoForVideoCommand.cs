using FinalTask18.Services;

namespace FinalTask18.Commands
{
    internal class GetInfoForVideoCommand : ICommand
    {
        public IVideoService videoService { get; private set; }

        public GetInfoForVideoCommand(IVideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute()
        {
            Console.WriteLine("Команда получена");
            videoService.GetInfoForVideo();
        }
    }
}
