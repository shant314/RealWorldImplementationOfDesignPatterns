namespace Assets.BicycleComponents.Handlebars
{
    public interface IMainHandlebar
    {
        public float Length { get; set; }
        public float Diameter { get; set; }
        public bool IsDropped { get; set; }
        public float RiseAngle { get; set; }
    }
}
