namespace CompositePattern
{
    public class CrankSet : BicycleComponent
    {
        public CrankSet(float weight, float cost) : base(weight, cost)
        {
            // this will not have actual weight and cost because it represents to package or assembly that has all sub components.
        }
    }
}
