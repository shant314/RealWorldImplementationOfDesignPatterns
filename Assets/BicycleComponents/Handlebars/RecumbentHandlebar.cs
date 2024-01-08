namespace Assets.BicycleComponents.Handlebars
{
    public class RecumbentHandlebar : AbstractMainHandlebar
    {
        public RecumbentHandlebar()
        {
            // units are imperial   
            Length = 11.5f;
            Diameter = 1.0f;
            IsDropped = false;
            RiseAngle = 2.5f;
        }
    }
}
