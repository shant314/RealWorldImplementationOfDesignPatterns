using static Assets.Enumerations;

namespace Assets.BicycleComponents.BicycleFrames
{
    public interface IMainFrame
    {
        public string ModelName { get; set; }
        public int ProductionYear { get; set; }
        public string SerialNumber { get; set; }
        public BicycleGeometryTypes Geometry { get; set; }
        public BicyclePaintColorTypes PaintColor { get; set; }
        public BicycleSuspensionTypes SuspensionType { get; set; }
        public BicycleManufacturingStatusTypes ManufacturingStatus { get; set; }
            
        public void Build();
    }
}
