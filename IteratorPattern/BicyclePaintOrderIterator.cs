using Assets.PaintableBicycle.PaintJobs;

namespace IteratorPattern
{
    /* This is an concrete implementation of our custom abstract AbstractIterator class.*/
    // it consumes the custom collection that we defined (BicycleOrderCollection).
    public class BicyclePaintOrderIterator : AbstractIterator
    {
        private readonly BicycleOrderCollection _ordersCollection;
        //As the iterator moves through the collection, we need to track its position.
        private int _position;

        //A simple parameterless constructor ensures we start with an empty list
        public BicyclePaintOrderIterator(BicycleOrderCollection orders)
        {
            _ordersCollection = SeparateCustomPaintJobOrders(orders);
            _position = -1;
        }

        //We may need a way to get the private _position field. We’ll use a read-only Key() method for this.
        public override int Key()
        {
            return _position;
        }

        // the next step of an iterator, is defining where the item is located in the collection.
        // this is where we control the index of array items, the current index will be used to get item form array in GetCurrent() method.
        public override bool MoveNext()
        {
            var updatedPosition = _position + 1;
            if (updatedPosition < 0 || updatedPosition >= _ordersCollection.Orders.Count)
                return false;

            _position = updatedPosition;
            return true;
        }

        //The interface requires that have a way to reset the iterator position back to the beginning of the collection
        public override void Reset()
        {
            _position = 0;
        }

        //the last piece of the puzzle when iterating over collection, is getting the item by index.
        public override object GetCurrent()
        {
            return _ordersCollection.Orders[_position];
        }

        private BicycleOrderCollection SeparateCustomPaintJobOrders(BicycleOrderCollection orders)
        {
            // we need the standard paint jobs first and customs at the end

            var customPaintJobOrders = new List<BicycleOrder>();
            var standardPaintJobOrders = new List<BicycleOrder>();

            foreach (var order in orders.Orders)
            {
                var paintJob = order.Bicycle.PaintJob;
                bool isCustom = paintJob.GetType().IsSubclassOf(typeof(AbstractCustomGradientPaintJob));

                if (isCustom)
                    customPaintJobOrders.Add(order);
                else
                    standardPaintJobOrders.Add(order);
            }
            //replace the contents of the original orders list
            orders.Orders.Clear();
            orders.Orders.AddRange(standardPaintJobOrders);
            orders.Orders.AddRange(customPaintJobOrders);
            return orders;
        }
    }
}
