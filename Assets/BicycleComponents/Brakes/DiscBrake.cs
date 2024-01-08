using static Assets.Enumerations;

namespace Assets.BicycleComponents.Brakes
{
    public class DiscBrake : AbstractMainBrake
    {
        public DiscBrake()
        {
            BrakeType = BicycleBrakeTypes.Disc;
        }
    }
}
