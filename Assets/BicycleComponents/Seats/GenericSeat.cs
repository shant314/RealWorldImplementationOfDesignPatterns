using static Assets.Enumerations;

namespace Assets.BicycleComponents.Seats
{
    public class GenericSeat: AbstractMainSeat
    {
        public GenericSeat()
        {
            PaddingThickness = 0.1f;
            SaddleType = SeatSaddleTypes.ModeratelyWaved;
            SpringCount = 0;
        }
    }
}
