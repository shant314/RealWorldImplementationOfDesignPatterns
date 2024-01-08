using static Assets.Enumerations;

namespace Assets.BicycleComponents.Drivetrains
{
    public class RoadBicycleDrivetrain : AbstractMainDrivetrain
    {
        public RoadBicycleDrivetrain()
        {
            ShifterType = BicycleShifterTypes.Paddle;
            CrankLength = 6.72f;
            ChainLinkCount = 126;
            FrontCassetteCogs = 3;
            RearCassetteCogs = 8;
            IsEnclosed = false;
        }
    }
}
