using Assets;

namespace SimpleFactoryPattern
{
    public class SimpleFactoryBicycle
    {
        public Bicycle CreateBicycle(string bicycleType)
        {
            Bicycle bikeToBuild;
            switch (bicycleType)
            {
                case "mountainbike":
                    bikeToBuild = new MountainBicycle();
                    break;
                case "cruiser":
                    bikeToBuild = new CruiserBicycle();
                    break;
                case "recumbent":
                    bikeToBuild = new RecumbentBicycle();
                    break;
                case "roadbike":
                    bikeToBuild = new RoadBicycle();
                    break;
                default:
                    throw new Exception("Unknown bicycle type: " + bicycleType);
            }

            return bikeToBuild;
        }
    }
}
