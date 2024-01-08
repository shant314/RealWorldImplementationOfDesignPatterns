namespace DecoratorPattern
{
    public class ManualPrinter : IDocumenter
    {
        public void PrintManual()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The manual is printnted!");
            Console.ResetColor();
        }
    }
}
/* This class is only used when an instance that implements the IDocumenter is required.*/