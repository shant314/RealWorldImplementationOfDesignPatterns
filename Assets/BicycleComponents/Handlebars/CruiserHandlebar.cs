namespace Assets.BicycleComponents.Handlebars
{
    public class CruiserHandlebar : AbstractMainHandlebar
    {
        public CruiserHandlebar()
        {
            // units are imperial   
            Length = 32.6f;
            Diameter = 1.0f;
            IsDropped = false;
            RiseAngle = 6.35f;
        }
    }
}
