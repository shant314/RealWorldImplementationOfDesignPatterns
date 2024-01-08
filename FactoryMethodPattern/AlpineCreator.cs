using Assets;

namespace FactoryMethodPattern
{
    public class AlpineCreator : BicycleCreator // child creator
    {
        public override IBicycle CreateProduct(string modelName)
        {
            return modelName.ToLower() switch
            {
                "palo duro canyon ranger" => new MountainBicycle(),
                "galveston cruiser" => new CruiserBicycle(),
                _ => throw new Exception("Invalid bicycle model")
            };
        }
    }
}
