using Assets;

namespace FactoryMethodPattern
{
    public abstract class BicycleCreator // the creator 3
    {
        public abstract IBicycle CreateProduct(string modelName);
    }
}
