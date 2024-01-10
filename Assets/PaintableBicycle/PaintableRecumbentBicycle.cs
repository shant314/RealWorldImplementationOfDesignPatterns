using static Assets.Enumerations;

namespace Assets.PaintableBicycle
{
    public class PaintableRecumbentBicycle : AbstractPaintableBicycle
    {
        public PaintableRecumbentBicycle(IPaintJob paintJob) : base(paintJob)
        {
            ModelName = "Big Bend";
            SuspensionType = BicycleSuspensionTypes.Front;
            Geometry = BicycleGeometryTypes.Recumbent;
        }
    }
}
