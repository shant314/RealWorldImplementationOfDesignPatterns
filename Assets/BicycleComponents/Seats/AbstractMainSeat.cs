using System.Globalization;
using static Assets.Enumerations;

namespace Assets.BicycleComponents.Seats
{
    public abstract class AbstractMainSeat : IMainSeat
    {
        public SeatSaddleTypes SaddleType { get; set; }
        public float PaddingThickness { get; set; }
        public int SpringCount { get; set; }

        public override string ToString()
        {
            return
                $"Your seat has a {SaddleType} type saddle with a padding thickness of {PaddingThickness.ToString(CultureInfo.InvariantCulture)}, and {SpringCount.ToString(CultureInfo.InvariantCulture)} springs.";
        }
    }
}
