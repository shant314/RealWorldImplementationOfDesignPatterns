
namespace Assets
{
    public interface IBicycle
    {
        public string ModelName { get; set; }
        public int ProductionYear { get; set; }
        public string SerialNumber { get; set; }
        public Enumerations.BicycleGeometryTypes Geometry { get; set; }
        public Enumerations.BicyclePaintColorTypes PaintColor { get; set; }
        public Enumerations.BicycleSuspensionTypes SuspensionType { get; set; }
        public Enumerations.ManufacturingStatusTypes ManufacturingStatus { get; set; }

        public void Build();
    }
}
