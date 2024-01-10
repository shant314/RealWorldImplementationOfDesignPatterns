using static Assets.Enumerations;

namespace Assets.PaintableBicycle
{
    public interface IPaintTopCoat
    {
        public string Name { get; set; }
        public PaintTopCoatTypes Type { get; set; }
    }
}
/*The paint finish will 
make the bicycle’s paint job take on a beautiful glossy sheen and protect the paint from scratches and 
sun exposure.*/