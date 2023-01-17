using FinalTask18.Commands;

namespace FinalTask18.Senders
{
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
