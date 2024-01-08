using static Assets.Enumerations;

namespace Assets.BicycleComponents.Seats
{
    public class CruiserSeat : AbstractMainSeat
    {
        public CruiserSeat()
        {
            PaddingThickness = 0.4f; // very cushy!
            SaddleType = SeatSaddleTypes.Curved;
            SpringCount = 3;
        }
    }
}
