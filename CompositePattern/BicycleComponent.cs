namespace CompositePattern
{
    public abstract class BicycleComponent
    {
        private float Weight { get; set; }
        private float Cost { get; set; }
        public IList<BicycleComponent> SubBicycleComponents { get; set; }

        /*protected constructor:
         *Can limit your class to be instantiated only by its subclasses.
        An abstract class by definition cannot be instantiated directly. It can only be instantiated by an instance of a derived type.
        By convention, we declare it as protected to emphasize the creation limit to its subclasses*/
        private protected BicycleComponent(float weight, float cost)
        {
            SubBicycleComponents = new List<BicycleComponent>();
            Weight = weight;
            Cost = cost;
        }

        public void DisplayWeight()
        {
            // determine whether we’re dealing with a leaf.
            if (SubBicycleComponents.Count == 0)
                return; // returning void.

            
            foreach (var component in SubBicycleComponents)
            {
                Console.WriteLine(component.GetType().Name + " weights: " + component.Weight);
                
                // to keep the recursion and print the weight of subcomponents.
                component.DisplayWeight();
            }
        }

        public void DisplayCost()
        {
            if (SubBicycleComponents.Count == 0)
                return;

            foreach (var component in SubBicycleComponents)
            {
                Console.WriteLine(component.GetType().Name + " costs $" + component.Cost + " USD");

                // to keep the recursion and print the cost of subcomponents.
                component.DisplayCost();
            }
        }

        // we can display the depth, but it is irrelevant for this sample.
    }
}
