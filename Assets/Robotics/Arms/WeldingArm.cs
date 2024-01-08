using static Assets.Enumerations;

namespace Assets.Robotics.Arms
{
    public class WeldingArm
    {
        public float DutyHours { get; set; }// milliseconds
        public float InputVoltage { get; set; }// volts AC
        public float OutputRangeMin { get; set; }// amps
        public float OutputRangeMax { get; set; }// amps
        public RobotArmWelderTypes WelderType { get; set; }
        public int CurrentPosition { get; set; } // the station number for the weld (1-10 but there will be more in the future)

        public void MoveToStation(int stationId)
        {
            CurrentPosition = stationId;
        }

        public bool DoWeld()
        {
            //IRL you'd have code here.
            const int timeToWeld = 5000; // it takes 5 seconds to do a weld
            Thread.Sleep(timeToWeld);
            IncrementDutyHours(timeToWeld);
            return true;
        }

        private void IncrementDutyHours(float milliseconds)
        {
            DutyHours += milliseconds;
        }
    }
}
