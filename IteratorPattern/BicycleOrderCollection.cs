using System.Collections;

namespace IteratorPattern
{
    /* This is an concrete implementation of our custom abstract AbstractIterable class,
     * that has a wrapper around a List<BicycleOrder>*/
    public class BicycleOrderCollection : AbstractIterable
    {
        //our custom collection must have its items collection, we will not recreate the wheel and define what a collection is,
        //instead, we are using the already defined List class.
        public List<BicycleOrder> Orders { get; set; }

        //A simple parameterless constructor ensures we start with an empty list
        public BicycleOrderCollection()
        {
            Orders = new List<BicycleOrder>();
        }

        //because we are using an already defined collection (List) that has the Add() functionality,
        //we can remove this method, for simplicity let's keep it.
        public void AddOrder(BicycleOrder order)
        {
            Orders.Add(order);
        }

        //this is where you define how a foreach statement will fetch collection that can be enumerated.
        public override IEnumerator GetEnumerator()
        {
            // returning a class that implements IEnumerator.
            return new BicyclePaintOrderIterator(this);
        }

    }
}
