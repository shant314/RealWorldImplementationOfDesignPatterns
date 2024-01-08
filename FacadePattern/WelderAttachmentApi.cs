namespace FacadePattern
{
    public class WelderAttachmentApi
    {
        public void Weld()
        {
            Console.WriteLine("Welding...");
            Thread.Sleep(1000);
            Console.WriteLine("Weld complete...");
        }

        public void MoveTo(int x, int y, int z)
        {
            Console.WriteLine("Moving to {0}, {1}, {2}", x, y, z);
            Thread.Sleep(1000);
            Console.WriteLine("I'm there!");
        }

        public void SomeOtherSubSystemOperation300()
        {
            Console.WriteLine("Welder other operations");
            Console.WriteLine("YAGNI!");  // this never gets called on purpose.
        }
    }
}
