namespace FinalTask18.Services
{
    public interface IVideoService
    {
        public Task DownLoadVideoAsync();

        public Task GetInfoForVideoAsync();
    }
}