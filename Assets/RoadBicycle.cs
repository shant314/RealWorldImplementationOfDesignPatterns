using static Assets.Enumerations;

namespace Assets
{
    public class RoadBicycle : Bicycle
    {
        public RoadBicycle()
        {
            ModelName = "Hillcrest";
            SuspensionType = BicycleSuspensionTypes.Hardtail;
            PaintColor = BicyclePaintColorTypes.Blue;
            Geometry = BicycleGeometryTypes.Upright;
        }
    }
}
