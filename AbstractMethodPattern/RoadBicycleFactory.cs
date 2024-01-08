using Assets.BicycleComponents.BicycleFrames;
using Assets.BicycleComponents.Handlebars;

namespace AbstractMethodPattern
{
    public class RoadBicycleFactory : IBicycleFactory
    {
        public IMainFrame CreateBicycleFrame()
        {
            return new RoadBicycleFrame();
        }

        public IMainHandlebar CreateBicycleHandlebar()
        {
            return new RoadBicycleHandlebar();
        }
    }
}
