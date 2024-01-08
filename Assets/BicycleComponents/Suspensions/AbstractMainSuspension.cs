﻿namespace Assets.BicycleComponents.Suspensions
{
    public class AbstractMainSuspension : IMainSuspension
    {
        public bool HasFrontShock { get; set; }
        public bool HasRearShock { get; set; }

        public override string ToString()
        {
            var suspension = "Hardtail";

            if (HasFrontShock && !HasRearShock) suspension = "Front Suspension";

            if (HasFrontShock && HasRearShock) suspension = "Full Suspension";

            return suspension;
        }
    }
}
