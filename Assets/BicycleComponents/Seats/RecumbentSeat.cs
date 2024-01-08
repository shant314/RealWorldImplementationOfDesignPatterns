using static Assets.Enumerations;

namespace Assets.BicycleComponents.Seats
{
    public class RecumbentSeat : AbstractMainSeat
    {
        public RecumbentSeat()
        {
            SaddleType = SeatSaddleTypes.LazyBoyRecliner;
            SpringCount = 6;
            PaddingThickness = 0.5f;
        }
    }
}
