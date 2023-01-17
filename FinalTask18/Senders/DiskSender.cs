using FinalTask18.Commands;

namespace FinalTask18.Senders
{
    /// <summary>
    /// Отправитель команды, для загрузки видео на диск
    /// </summary>
    internal class DiskSender : ISender
    {
        private ICommand command;

        public DiskSender(ICommand command)
        {
            this.command = command;
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteAsync()
        {
            var task = command.ExecuteAsync();
            task.Wait();
        }
    }
}
