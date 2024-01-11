namespace CommandPattern
{
    public class CommandSender
    {
        private ICommand _command;

        public CommandSender(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
