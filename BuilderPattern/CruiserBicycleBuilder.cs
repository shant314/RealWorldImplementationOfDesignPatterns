using Assets.BicycleComponents.BicycleFrames;
using Assets.BicycleComponents.Brakes;
using Assets.BicycleComponents.Drivetrains;
using Assets.BicycleComponents.Handlebars;
using Assets.BicycleComponents.Seats;
using Assets.BicycleComponents.Suspensions;

namespace BuilderPattern
{
    public class CruiserBicycleBuilder : IBicycleBuilder
    {
        private IBicycleProduct _bicycle;

        public CruiserBicycleBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _bicycle = new BicycleProduct();
        }

        public void BuildFrame()
        {
            _bicycle.Frame = new CruiserFrame();
        }

        public void BuildHandlebars()
        {
            _bicycle.Handlebar = new CruiserHandlebar();
        }

        public void BuildSeat()
        {
            _bicycle.Seat = new CruiserSeat();
        }

        public void BuildSuspension()
        {
            _bicycle.Suspension = new HardTailSuspension();
        }

        public void BuildDrivetrain()
        {
            _bicycle.Drivetrain = new CruiserDrivetrain();
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
