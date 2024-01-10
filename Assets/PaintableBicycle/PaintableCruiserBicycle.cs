using static Assets.Enumerations;

namespace Assets.PaintableBicycle
{
    public class PaintableCruiserBicycle : AbstractPaintableBicycle
    {
        public PaintableCruiserBicycle(IPaintJob paintJob) : base(paintJob)
        {
            ModelName = "Galveston Cruiser";
            SuspensionType = BicycleSuspensionTypes.Hardtail;
            Geometry = BicycleGeometryTypes.Upright;
        }
    }
}
