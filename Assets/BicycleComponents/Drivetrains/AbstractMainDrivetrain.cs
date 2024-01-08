using System.Globalization;
using static Assets.Enumerations;

namespace Assets.BicycleComponents.Drivetrains
{
    public class AbstractMainDrivetrain : IMainDrivetrain, IBicycleComponent
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public decimal Cost { get; set; }

        public float CrankLength { get; set; }
        public int FrontCassetteCogs { get; set; }
        public int RearCassetteCogs { get; set; }
        public float ChainLinkCount { get; set; }
        public BicycleShifterTypes ShifterType { get; set; }
        public bool IsEnclosed { get; set; }

        protected AbstractMainDrivetrain()
        {
            Name = "Unnamed Component";
        }

        public override string ToString()
        {
            return
                $"Your group set consists of a {CrankLength.ToString(CultureInfo.InvariantCulture)} inch crank, {FrontCassetteCogs.ToString(CultureInfo.InvariantCulture)} cost in the front cassette, {RearCassetteCogs.ToString(CultureInfo.InvariantCulture)} cogs in the rear cassette, and a chain with {ChainLinkCount.ToString(CultureInfo.InvariantCulture)} links in the chain and a {ShifterType.ToString()} type shifter.";
        }
    }
}
