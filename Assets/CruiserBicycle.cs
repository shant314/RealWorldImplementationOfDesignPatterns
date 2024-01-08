using static Assets.Enumerations;

namespace Assets
{
    public class CruiserBicycle : AbstractBicycle
    {
        public CruiserBicycle()
        {
            ModelName = "Galveston Cruiser";
            SuspensionType = BicycleSuspensionTypes.Hardtail;
            PaintColor = BicyclePaintColorTypes.Red;
            Geometry = BicycleGeometryTypes.Upright;
        }
    }
}
