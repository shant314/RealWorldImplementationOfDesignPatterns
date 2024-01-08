using static Assets.Enumerations;

namespace Assets.BicycleComponents.Drivetrains
{
    public class RecumbentDrivetrain : AbstractMainDrivetrain
    {
        public RecumbentDrivetrain()
        {
            ShifterType = BicycleShifterTypes.Paddle;
            CrankLength = 8.13f;
            ChainLinkCount = 421;
            FrontCassetteCogs = 3;
            RearCassetteCogs = 7;
            IsEnclosed = false;
        }
    }
}
