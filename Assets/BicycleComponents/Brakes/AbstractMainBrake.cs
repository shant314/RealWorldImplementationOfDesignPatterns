using System.Globalization;
using static Assets.Enumerations;

namespace Assets.BicycleComponents.Brakes
{
    public class AbstractMainBrake: IMainBrake
    {
        public BicycleBrakeTypes BrakeType { get; set; }

        public override string ToString()
        {
            return $"Your brakes are {BrakeType.ToString(CultureInfo.InvariantCulture)}";
        }
    }
}
