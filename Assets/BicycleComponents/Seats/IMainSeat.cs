using static Assets.Enumerations;

namespace Assets.BicycleComponents.Seats
{
    public interface IMainSeat
    {
        public SeatSaddleTypes SaddleType { get; set; }
        public float PaddingThickness { get; set; }
        public int SpringCount { get; set; }
    }
}
