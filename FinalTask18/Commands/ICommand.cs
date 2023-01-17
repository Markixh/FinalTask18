namespace FinalTask18.Commands
{
    /// <summary>
    /// Команда
    /// </summary>
    public interface ICommand
    {
        public Task ExecuteAsync();
    }
}
