using Assets.BicycleComponents.BicycleFrames;
using Assets.BicycleComponents.Brakes;
using Assets.BicycleComponents.Drivetrains;
using Assets.BicycleComponents.Handlebars;
using Assets.BicycleComponents.Seats;
using Assets.BicycleComponents.Suspensions;

namespace BuilderPattern
{
    /*creating an abstraction for what the builders will be producing – that is, the product*/
    public interface IBicycleProduct
    {
        public IMainFrame Frame { get; set; }
        public IMainSuspension Suspension { get; set; }
        public IMainHandlebar Handlebar { get; set; }
        public IMainDrivetrain Drivetrain { get; set; }
        public IMainSeat Seat { get; set; }
        public IMainBrake Brake { get; set; }
    }
}
