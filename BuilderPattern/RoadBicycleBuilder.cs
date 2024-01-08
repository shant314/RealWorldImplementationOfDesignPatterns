using Assets.BicycleComponents.BicycleFrames;
using Assets.BicycleComponents.Brakes;
using Assets.BicycleComponents.Drivetrains;
using Assets.BicycleComponents.Handlebars;
using Assets.BicycleComponents.Seats;
using Assets.BicycleComponents.Suspensions;

namespace BuilderPattern
{
    public class RoadBicycleBuilder : IBicycleBuilder
    {
        /*a private field called _bicycle to hold the product to be built by the Director class*/
        private BicycleProduct _bicycle;

        public RoadBicycleBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _bicycle = new BicycleProduct();
        }

        public void BuildFrame()
        {
            _bicycle.Frame = new RoadBicycleFrame();
        }

        public void BuildHandlebars()
        {
            _bicycle.Handlebar = new RoadBicycleHandlebar();
        }

        public void BuildSeat()
        {
            _bicycle.Seat = new GenericSeat();
        }

        public void BuildSuspension()
        {
            _bicycle.Suspension = new HardTailSuspension();
        }

        public void BuildDrivetrain()
        {
            _bicycle.Drivetrain = new RoadBicycleDrivetrain();
        }

        public void BuildBrakes()
        {
            _bicycle.Brake = new CaliperBrake();
        }

        public IBicycleProduct GetProduct()
        {
            return _bicycle;
        }
    }
}
