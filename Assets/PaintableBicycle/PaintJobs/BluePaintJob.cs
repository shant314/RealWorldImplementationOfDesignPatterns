namespace Assets.PaintableBicycle.PaintJobs
{
    public class BluePaintJob : IPaintJob
    {
        public string Name { get; set; }
        public int Cyan { get; set; }
        public int Magenta { get; set; }
        public int Yellow { get; set; }
        public int Black { get; set; }
        public IPaintPrimer Primer { get; set; }
        public IPaintTopCoat TopCoat { get; set; }

        public BluePaintJob()
        {
            Name = "Texas Turquoise";
            Cyan = 100;
            Magenta = 15;
            Yellow = 15;
            Black = 20;
            Primer = new StandardGrayPaintPrimer();
            TopCoat = new StandardProtectivePaintCoat();
        }

        public void ApplyPrimer()
        {
            Console.WriteLine($"Applying the Primer: {Primer.ManufacturerStockKeepingUnit}");
        }

        public void ApplyPaint()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Applying {Name.ToUpper()} paint job.");
            Console.ResetColor();
        }

        public void ApplyTopCoat()
        {
            Console.WriteLine($"Applying protective paint finish: {TopCoat.Name}");
        }
    }
}
