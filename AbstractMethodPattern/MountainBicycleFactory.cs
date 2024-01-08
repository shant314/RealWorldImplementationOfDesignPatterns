using Assets.BicycleComponents.BicycleFrames;
using Assets.BicycleComponents.Handlebars;

namespace AbstractMethodPattern
{
    public class MountainBicycleFactory : IBicycleFactory
    {
        public IMainFrame CreateBicycleFrame()
        {
            return new MountainBicycleFrame();
        }

        public IMainHandlebar CreateBicycleHandlebar()
        {
            return new MountainBicycleHandlebar();
        }
    }
}
