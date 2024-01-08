namespace Assets.BicycleComponents
{
    public interface IBicycleComponent
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public decimal Cost { get; set; }
    }
}
