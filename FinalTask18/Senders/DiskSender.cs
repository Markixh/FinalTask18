using FinalTask18.Commands;

namespace FinalTask18.Senders
{
    internal class DiskSender : ISender
    {
        ICommand command;

        public DiskSender(ICommand command) 
        {
            this.command = command;
        }

        public void Execute()
        {
            Console.WriteLine("Команда отправлена");
        }
    }
}
