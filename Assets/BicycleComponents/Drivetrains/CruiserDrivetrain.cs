using static Assets.Enumerations;

namespace Assets.BicycleComponents.Drivetrains
{
    public class CruiserDrivetrain : AbstractMainDrivetrain
    {
        public CruiserDrivetrain()
        {
            ShifterType = BicycleShifterTypes.Twist;
            CrankLength = 6.72f;
            ChainLinkCount = 126;
            FrontCassetteCogs = 1;
            RearCassetteCogs = 9;
            IsEnclosed = true;
        }
    }
}
