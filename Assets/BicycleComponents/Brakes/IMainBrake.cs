using static Assets.Enumerations;

namespace Assets.BicycleComponents.Brakes
{
    public interface IMainBrake
    {
        public BicycleBrakeTypes BrakeType { get; set; }
    }
}
