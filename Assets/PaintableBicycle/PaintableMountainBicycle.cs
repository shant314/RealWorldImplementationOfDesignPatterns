using static Assets.Enumerations;

namespace Assets.PaintableBicycle
{
    public class PaintableMountainBicycle : AbstractPaintableBicycle
    {
        public PaintableMountainBicycle(IPaintJob paintJob) : base(paintJob)
        {
            ModelName = "Palo Duro Canyon Ranger";
            SuspensionType = BicycleSuspensionTypes.Full;
            Geometry = BicycleGeometryTypes.Upright;
        }
    }
}
