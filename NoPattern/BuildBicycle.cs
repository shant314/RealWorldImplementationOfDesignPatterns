using Assets;

namespace NoPattern
{
    public class BuildBicycle
    {
        const string errorText = "You must pass in mountainbike, cruiser, recumbent, or roadbike";
        private readonly string _bicycleType;
        public BuildBicycle(string bicycleType)
        {
            _bicycleType = bicycleType;
            GetBicycle();
        }

        public void GetBicycle()
        {
            Bicycle bicycle;
            switch (_bicycleType)
            {
                case "mountainbike":
                    bicycle = new MountainBicycle();
                    break;
                case "cruiser":
                    bicycle = new CruiserBicycle();
                    break;
                case "recumbent":
                    bicycle = new RecumbentBicycle();
                    break;
                case "roadbike":
                    bicycle = new RoadBicycle();
                    break;
                default:
                    Console.WriteLine(errorText);
                    throw new Exception("Unknown bicycle type: " + _bicycleType);
            }

            // call the build method.
            bicycle.Build();
        }
    }
}
