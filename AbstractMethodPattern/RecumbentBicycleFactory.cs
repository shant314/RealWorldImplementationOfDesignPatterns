using Assets.BicycleComponents.BicycleFrames;
using Assets.BicycleComponents.Handlebars;

namespace AbstractMethodPattern
{
    public class RecumbentBicycleFactory : IBicycleFactory
    {
        public IMainFrame CreateBicycleFrame()
        {
            return new RecumbentFrame();
        }

        public IMainHandlebar CreateBicycleHandlebar()
        {
            return new RecumbentHandlebar();
        }
    }
}
