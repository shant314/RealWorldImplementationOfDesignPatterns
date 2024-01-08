using static Assets.Enumerations;

namespace Assets
{
    public class MountainBicycle : AbstractBicycle
    {
        public MountainBicycle()
        {
            ModelName = "Palo Duro Canyon Ranger";
            SuspensionType = BicycleSuspensionTypes.Full;
            PaintColor = BicyclePaintColorTypes.Black;
            Geometry = BicycleGeometryTypes.Upright;
        }
    }
}
