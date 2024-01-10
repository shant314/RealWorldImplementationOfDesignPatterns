using static Assets.Enumerations;

namespace Assets.PaintableBicycle
{
    public class StandardGrayPaintPrimer : IPaintPrimer
    {
        public string ManufacturerStockKeepingUnit { get; set; }
        public PaintPrimerTypes Type { get; set; }
        public PaintPrimerColorTypes Color { get; set; }
        public bool IsLowVoc { get; set; } 

        public StandardGrayPaintPrimer()
        {
            Type = PaintPrimerTypes.Epoxy;
            Color = PaintPrimerColorTypes.Gray;
            IsLowVoc = false;
            ManufacturerStockKeepingUnit = "PRIMER-GRAY-001";
        }
    }
}
