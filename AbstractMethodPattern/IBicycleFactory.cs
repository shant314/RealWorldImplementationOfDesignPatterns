using Assets.BicycleComponents.BicycleFrames;
using Assets.BicycleComponents.Handlebars;

namespace AbstractMethodPattern
{
    public interface IBicycleFactory
    {
        public IMainFrame CreateBicycleFrame();
        public IMainHandlebar CreateBicycleHandlebar();
    }
}
