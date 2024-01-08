
namespace Assets
{
    public interface IBicycle
    {
        public string ModelName { get; set; }
        public int ProductionYear { get; }
        public string SerialNumber { get; }
        public Enumerations.BicycleGeometryTypes Geometry { get; set; }
        public Enumerations.BicyclePaintColorTypes PaintColor { get; set; }
        public Enumerations.BicycleSuspensionTypes SuspensionType { get; set; }
        public Enumerations.BicycleManufacturingStatusTypes ManufacturingStatus { get; set; }

        public void Build();
    }
}
