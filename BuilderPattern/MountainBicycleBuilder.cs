using Assets.BicycleComponents.BicycleFrames;
using Assets.BicycleComponents.Brakes;
using Assets.BicycleComponents.Drivetrains;
using Assets.BicycleComponents.Handlebars;
using Assets.BicycleComponents.Seats;
using Assets.BicycleComponents.Suspensions;

namespace BuilderPattern
{
    public class MountainBicycleBuilder : IBicycleBuilder
    {
        private BicycleProduct _bicycle;

        public MountainBicycleBuilder()
        {
            Reset(); // the IDE hates this but it is DRY
        }

        public void Reset()
        {
            _bicycle = new BicycleProduct();
        }

        public void BuildFrame()
        {
            _bicycle.Frame = new MountainBicycleFrame();
        }

        public void BuildHandlebars()
        {
            _bicycle.Handlebar = new MountainBicycleHandlebar();
        }

        public void BuildSeat()
        {
            _bicycle.Seat = new GenericSeat();
        }

        public void BuildSuspension()
        {
            _bicycle.Suspension = new FullSuspension();
        }

        public void BuildDrivetrain()
        {
            _bicycle.Drivetrain = new MountainDrivetrain();
        }

        public void BuildBrakes()
        {
            _bicycle.Brake = new DiscBrake();
        }

        public IBicycleProduct GetProduct()
        {
            //BuildFrame();
            //BuildHandlebars();
            //BuildSeat();
            //BuildSuspension();
            //BuildDrivetrain();
            //BuildBrakes();
            return _bicycle;
        }
    }
}