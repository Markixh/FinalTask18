namespace FinalTask18.Services
{
    /// <summary>
    /// Интерфейс получателя команд
    /// </summary>
    public interface IVideoService
    {
        public Task DownLoadVideoAsync();

        public Task GetInfoForVideoAsync();
    }
}