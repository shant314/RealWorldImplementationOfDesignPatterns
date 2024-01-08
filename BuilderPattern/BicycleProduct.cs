using Assets.BicycleComponents.BicycleFrames;
using Assets.BicycleComponents.Brakes;
using Assets.BicycleComponents.Drivetrains;
using Assets.BicycleComponents.Handlebars;
using Assets.BicycleComponents.Seats;
using Assets.BicycleComponents.Suspensions;
using System.Text;

namespace BuilderPattern
{
    /*This class represents a bicycle with no type, is just an implementation of the interface, plus a large ToString() override that we’re 
    using as the meat of our sample code.*/
    public class BicycleProduct : IBicycleProduct
    {
        public IMainFrame Frame { get; set; }
        public IMainSuspension Suspension { get; set; }
        public IMainHandlebar Handlebar { get; set; }
        public IMainDrivetrain Drivetrain { get; set; }
        public IMainSeat Seat { get; set; }
        public IMainBrake Brake { get; set; }

        public override string ToString()
        {
            var fullDescription = new StringBuilder("Here's your new bicycle:");
            fullDescription.AppendLine(Frame.ToString());
            fullDescription.AppendLine(Suspension.ToString());
            fullDescription.AppendLine(Handlebar.ToString());
            fullDescription.AppendLine(Drivetrain.ToString());
            fullDescription.AppendLine(Seat.ToString());
            fullDescription.AppendLine(Brake.ToString());

            return fullDescription.ToString();
        }
    }
}
