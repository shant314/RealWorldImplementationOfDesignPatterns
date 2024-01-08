namespace Assets.BicycleComponents.Suspensions
{
    public class FullSuspension : AbstractMainSuspension
    {
        public FullSuspension()
        {
            HasFrontShock = true;
            HasRearShock = true;
        }
    }
}