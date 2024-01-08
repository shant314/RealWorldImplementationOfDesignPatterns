using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class GrabberAttachementApi
    {
        public void Grab()
        {
            Console.WriteLine("The grabber is grabbing!");
            Thread.Sleep(1000);
            Console.WriteLine("Operation completed");
        }

        public void SetLocation(int x, int y)
        {
            Console.WriteLine("Moving to {0}, {1}", x, y);
            Thread.Sleep(1000);
            Console.WriteLine("In position");
        }

        public void SomeOtherSubSystemOperation99()
        {
            Console.WriteLine("Grabber have other operations");
            Console.WriteLine("YAGNI!");  // this never gets called on purpose.
        }
    }
}
