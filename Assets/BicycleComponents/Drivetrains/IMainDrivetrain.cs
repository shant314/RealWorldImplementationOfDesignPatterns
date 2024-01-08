using static Assets.Enumerations;

namespace Assets.BicycleComponents.Drivetrains
{
    public interface IMainDrivetrain
    {
        public float CrankLength { get; set; }
        public int FrontCassetteCogs { get; set; }
        public int RearCassetteCogs { get; set; }
        public float ChainLinkCount { get; set; }
        public BicycleShifterTypes ShifterType { get; set; }
        public bool IsEnclosed { get; set; }
    }
}
