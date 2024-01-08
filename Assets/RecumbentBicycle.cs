
namespace Assets
{
    public class RecumbentBicycle : AbstractBicycle
    {
        public RecumbentBicycle()
        {
            ModelName = "Big Bend";
            SuspensionType = Enumerations.BicycleSuspensionTypes.Front;
            PaintColor = Enumerations.BicyclePaintColorTypes.White;
            Geometry = Enumerations.BicycleGeometryTypes.Recumbent;
        }
    }
}
