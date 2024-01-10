using static Assets.Enumerations;

namespace Assets.PaintableBicycle
{
    public class PaintableRoadBicycle : AbstractPaintableBicycle
    {
        public PaintableRoadBicycle(IPaintJob paintJob) : base(paintJob)
        {
            ModelName = "Hillcrest";
            SuspensionType = BicycleSuspensionTypes.Hardtail;
            Geometry = BicycleGeometryTypes.Upright;
        }
    }
}
