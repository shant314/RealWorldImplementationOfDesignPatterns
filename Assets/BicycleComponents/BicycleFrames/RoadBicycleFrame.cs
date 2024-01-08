// This is actually a copy of the RoadBicycle class presented early in the chapter.

using static Assets.Enumerations;

namespace Assets.BicycleComponents.BicycleFrames
{
    public class RoadBicycleFrame : AbstractMainFrame
    {
        public RoadBicycleFrame()
        {
            ModelName = "Hillcrest";
            SuspensionType = BicycleSuspensionTypes.Hardtail;
            PaintColor = BicyclePaintColorTypes.Blue;
            Geometry = BicycleGeometryTypes.Upright;
        }
    }
}
