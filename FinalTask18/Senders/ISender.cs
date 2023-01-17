namespace FinalTask18.Senders
{
    /// <summary>
    /// Интерфейс отправителя команды
    /// </summary>
    internal interface ISender
    {
        public void ExecuteAsync();
    }
}
