using Assets.BicycleComponents.BicycleFrames;
using Assets.BicycleComponents.Handlebars;

namespace AbstractMethodPattern
{
    public class CruiserFactory: IBicycleFactory
    {
        public IMainFrame CreateBicycleFrame()
        {
            return new CruiserFrame();
        }

        public IMainHandlebar CreateBicycleHandlebar()
        {
            return new CruiserHandlebar();
        }
    }
}
