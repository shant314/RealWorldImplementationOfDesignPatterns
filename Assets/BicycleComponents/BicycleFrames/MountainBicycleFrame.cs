// This is actually a copy of the Mountain class presented early in the chapter.
using static Assets.Enumerations;

namespace Assets.BicycleComponents.BicycleFrames
{
    public class MountainBicycleFrame : AbstractMainFrame
    {
        public MountainBicycleFrame()
        {
            ModelName = "Palo Duro Canyon Ranger";
            SuspensionType = BicycleSuspensionTypes.Full;
            PaintColor = BicyclePaintColorTypes.Black;
            Geometry = BicycleGeometryTypes.Upright;
        }
    }
}
