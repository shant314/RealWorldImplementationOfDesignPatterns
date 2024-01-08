namespace Assets.BicycleComponents.Suspensions
{
    public class FrontSuspension : AbstractMainSuspension
    {
        public FrontSuspension()
        {
            HasFrontShock = true;
            HasRearShock = false;
        }
    }
}