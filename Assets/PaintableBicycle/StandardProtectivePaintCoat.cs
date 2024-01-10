using static Assets.Enumerations;

namespace Assets.PaintableBicycle
{
    public class StandardProtectivePaintCoat : IPaintTopCoat
    {
        public string Name { get; set; }
        public PaintTopCoatTypes Type { get; set; }

        public StandardProtectivePaintCoat()
        {
            Name = "Standard Protective Paint Coating";
            Type = PaintTopCoatTypes.GlamorClear;  // gives a very glossy finish and blocks UV
        }
    }
}
