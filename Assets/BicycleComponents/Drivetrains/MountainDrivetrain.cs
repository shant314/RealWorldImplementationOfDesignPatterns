using static Assets.Enumerations;

namespace Assets.BicycleComponents.Drivetrains
{
    public class MountainDrivetrain : AbstractMainDrivetrain
    {
        public MountainDrivetrain()
        {
            ShifterType = BicycleShifterTypes.Trigger;
            CrankLength = 5.92f;
            ChainLinkCount = 126;
            FrontCassetteCogs = 2;
            RearCassetteCogs = 9;
            IsEnclosed = false;
        }
    }
}
