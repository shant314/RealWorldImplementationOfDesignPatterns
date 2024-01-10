
using static Assets.Enumerations;

namespace Assets
{
    /*This interface is replacement for the IBicycle, we are simply removing the BicyclePaintColorTypes PaintColor enum.*/
    public interface ISimplifiedBicycle
    {
        public string ModelName { get; set; }
        public int ProductionYear { get; set; }
        public string SerialNumber { get; set; }
        public BicycleGeometryTypes Geometry { get; set; }
        public BicycleSuspensionTypes SuspensionType { get; set; }
        public BicycleManufacturingStatusTypes ManufacturingStatus { get; set; }

        public void Build();
    }
}
