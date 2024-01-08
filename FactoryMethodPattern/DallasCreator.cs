using Assets;

namespace FactoryMethodPattern
{
    public class DallasCreator : BicycleCreator // child creator
    {
        public override IBicycle CreateProduct(string modelName)
        {
            return modelName.ToLower() switch
            {
                "hillcrest" => new RoadBicycle(),
                "big bend" => new RecumbentBicycle(),
                _ => throw new Exception("Invalid bicycle model")
            };
        }
    }
}
