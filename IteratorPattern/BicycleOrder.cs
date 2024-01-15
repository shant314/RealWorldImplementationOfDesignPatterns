using Assets.PaintableBicycle;

namespace IteratorPattern
{
    public class BicycleOrder
    {
        public Customer Customer { get; set; }
        public IPaintableBicycle Bicycle { get; set; }

        public BicycleOrder(Customer customer, IPaintableBicycle bicycle)
        {
            Customer = customer;
            Bicycle = bicycle;
        }
    }
}
