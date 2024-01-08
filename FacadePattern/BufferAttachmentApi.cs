using System.Numerics;

namespace FacadePattern
{
    public class BufferAttachmentApi
    {
        /*
        * This is a simulated API.  Imagine a very complicated API perhaps with a lot of exposed methods we don't need
        * or want.  We'll use a facade to hide the complexity.
        */

        public void Buff()
        {
            Console.WriteLine("Buffing and polishing");
            Thread.Sleep(1000);
            Console.WriteLine("Polish complete...");
        }

        // A quaternion is a horribly complex mathematical structure.  There's no reason you'd know that unless
        // you're a Unity developer.  It represents four dimensions including 3 dimensions in space (X, Y, Z) and
        // a rotational vector expressed as an Euler angle normally called W.  An Euler angle describes the
        // orientation of a rigid body with respect to a fixed coordinate system.
        public void Position(Quaternion position)
        {
            Console.WriteLine("Moving the robot arm to {0}, {1}, {2} at angle {3} ", position.X, position.Y, position.Z, position.W);
            Thread.Sleep(1000);
            Console.WriteLine("destination reached!");
        }

        public void SomeOtherSubSystemOperation400()
        {
            Console.WriteLine("Buffer other operations");
            Console.WriteLine("YAGNI!");  // this never gets called on purpose.
        }
    }
}
