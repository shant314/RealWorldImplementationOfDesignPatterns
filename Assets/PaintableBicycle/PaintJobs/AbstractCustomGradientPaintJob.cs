namespace Assets.PaintableBicycle.PaintJobs
{
    public abstract class AbstractCustomGradientPaintJob : IPaintJob
    {
        public string Name { get; set; }
        public int Cyan { get; set; }
        public int Magenta { get; set; }
        public int Yellow { get; set; }
        public int Black { get; set; }
        public IPaintPrimer Primer { get; set; }
        public IPaintTopCoat TopCoat { get; set; }

        // To do a gradient we need a starting color value and an ending value.  We'll use
        // The normal CMYK colors for the starting color and add a set for the ending color.
        // We'll get warnings because the getters are never used, but in a real program, there
        // would conceivably be a painting system that accesses them to mix the paint.
        public int EndCyan { get; set; }
        public int EndMagenta { get; set; }
        public int EndYellow { get; set; }
        public int EndBlack { get; set; }

        public AbstractCustomGradientPaintJob()
        {
            Name = string.Empty;
            Primer = new StandardGrayPaintPrimer();  // We'll use this for the default
            TopCoat = new StandardProtectivePaintCoat();  // Another sane default
        }
        public void ApplyPrimer()
        {
            Console.WriteLine("Applying the Primer: " + Primer.ManufacturerStockKeepingUnit);
        }

        public abstract void ApplyPaint();

        public void ApplyTopCoat()
        {
            Console.WriteLine("Applying protective paint finish: " + TopCoat.Name);
        }
    }
}
