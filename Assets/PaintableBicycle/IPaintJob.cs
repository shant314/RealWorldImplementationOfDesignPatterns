
namespace Assets.PaintableBicycle
{
    public interface IPaintJob
    {
        public string Name { get; set; }
        public int Cyan { get; set; }
        public int Magenta { get; set; }
        public int Yellow { get; set; }
        public int Black { get; set; }
        public IPaintPrimer Primer { get; set; }
        public IPaintTopCoat TopCoat { get; set; }

        public void ApplyPrimer();
        public void ApplyPaint();
        public void ApplyTopCoat();
    }
}
/*The paint system we want to use is based on the same CMYK color space used by traditional 
printing.*/