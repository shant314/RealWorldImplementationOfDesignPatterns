using static Assets.Enumerations;

namespace Assets.PaintableBicycle
{
    public interface IPaintPrimer
    {
        public string ManufacturerStockKeepingUnit { get; set; }//manufacturer’s Stock Keeping Unit (SKU), to order the primer easily
        public PaintPrimerTypes Type { get; set; }
        public PaintPrimerColorTypes Color { get; set; }
        public bool IsLowVoc { get; set; } //Volatile Organic Compound(s).
    }
}
/*A primer or undercoat is a preparatory coating put on materials before painting.
 * Priming ensures better adhesion of paint to the surface, increases paint durability, and
 * provides additional protection for the material being painted.*/