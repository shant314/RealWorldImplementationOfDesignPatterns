using System.Collections;

namespace IteratorPattern
{
    //This is just an abstract class that implements the IEnumerable. 
    public abstract class AbstractIterable : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
