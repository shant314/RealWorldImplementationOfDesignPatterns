namespace CompositePattern
{
    public class Pedal : BicycleComponent
    {
        public Pedal(float weight, float cost):base(weight, cost)
        {
            // we can have a name and other properties, but used reflection to get the name.
        }
    }
}
