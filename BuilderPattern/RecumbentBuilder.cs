using Assets.BicycleComponents.BicycleFrames;
using Assets.BicycleComponents.Brakes;
using Assets.BicycleComponents.Drivetrains;
using Assets.BicycleComponents.Handlebars;
using Assets.BicycleComponents.Seats;
using Assets.BicycleComponents.Suspensions;

namespace BuilderPattern
{
    public class RecumbentBuilder : IBicycleBuilder
    {
        private IBicycleProduct _bicycle;

        public RecumbentBuilder()
        {
            _bicycle = new BicycleProduct();
        }

        public void Reset()
        {
            _bicycle = new BicycleProduct();
        }

        public void BuildFrame()
        {
            _bicycle.Frame = new RecumbentFrame();
        }

        public void BuildHandlebars()
        {
            _bicycle.Handlebar = new RecumbentHandlebar();
        }

        public void BuildSeat()
        {
            _bicycle.Seat = new RecumbentSeat();
        }

        public void BuildSuspension()
        {
            _bicycle.Suspension = new FrontSuspension();
        }

        public void BuildDrivetrain()
        {
            _bicycle.Drivetrain = new RecumbentDrivetrain();
        }

        public void BuildBrakes()
        {
            _bicycle.Brake = new DiscBrake();
        }

        public IBicycleProduct GetProduct()
        {
            return _bicycle;
        }
    }
}