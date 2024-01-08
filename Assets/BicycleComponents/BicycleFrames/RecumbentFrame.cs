using static Assets.Enumerations;

namespace Assets.BicycleComponents.BicycleFrames
{
    public class RecumbentFrame: AbstractMainFrame
    {
        public RecumbentFrame()
        {
            ModelName = "Big Bend";
            SuspensionType = BicycleSuspensionTypes.Front;
            PaintColor = BicyclePaintColorTypes.White;
            Geometry = BicycleGeometryTypes.Recumbent;
        }
    }
}
