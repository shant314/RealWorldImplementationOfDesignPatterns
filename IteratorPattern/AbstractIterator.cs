using System.Collections;

namespace IteratorPattern
{
    /* This is just an abstract class that implements the IEnumerator interface.
     * We are defining our perspective of an enumerator definition, based on the IEnumerator interface template*/
    public abstract class AbstractIterator : IEnumerator
    {
        // our custom method that will get the current instance, to be implemented by children.
        public abstract object GetCurrent();

        public abstract int Key();

        // implementing the Current property of the base IEnumerator, in the abstract class.
        public object Current
        {
            get
            {
                return GetCurrent();
            }
        }

        public abstract bool MoveNext();

        public abstract void Reset();

        // not required for my use case, we will keep the default object.Dispose();
        //public abstract void Dispose();
    }
}
