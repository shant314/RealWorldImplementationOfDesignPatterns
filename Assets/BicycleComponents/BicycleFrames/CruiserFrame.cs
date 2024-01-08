// This is actually a copy of the Cruiser class presented early in the chapter.

using static Assets.Enumerations;

namespace Assets.BicycleComponents.BicycleFrames
{
    public class CruiserFrame : AbstractMainFrame
    {
        public CruiserFrame()
        {
            ModelName = "Galveston Cruiser";
            SuspensionType = BicycleSuspensionTypes.Hardtail;
            PaintColor = BicyclePaintColorTypes.Red;
            Geometry = BicycleGeometryTypes.Upright;
        }
    }
}
