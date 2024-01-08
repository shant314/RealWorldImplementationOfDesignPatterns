using static Assets.Enumerations;

namespace Assets.BicycleComponents.Brakes
{
    public class CaliperBrake : AbstractMainBrake
    {
        public CaliperBrake()
        {
            BrakeType = BicycleBrakeTypes.Caliper;
        }
    }
}
