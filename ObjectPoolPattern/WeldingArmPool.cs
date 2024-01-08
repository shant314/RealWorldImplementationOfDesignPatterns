using Assets.Robotics.Arms;

namespace ObjectPoolPattern
{
    public class WeldingArmPool
    {
        private int _maxSize = 10;
        public int MaxSize
        {
            get => _maxSize;
            set
            {
                _maxSize = value;
                Reset();
            }
        }
        private List<WeldingArm> Pool { get; set; }
        public int ArmsAvailableCount { get => Pool.Count; }

        public WeldingArmPool()
        {
            Reset();
        }

        public void Reset()
        {
            Pool = new List<WeldingArm>();
            for (int i = 0; i < MaxSize; i++)
            {
                Pool.Add(new WeldingArm());
            }
        }

        public WeldingArm GetArmFromPool()
        {
            if (ArmsAvailableCount > 0)
            {
                var arm = Pool[0];
                Pool.RemoveAt(0);
                return arm;
            }
            throw new Exception("You are out of arms.  Return some to the pool and try again.");
        }

        public void ReturnArmToPool(WeldingArm arm)
        {
            arm.CurrentPosition = 0; //not at any station
            Pool.Add(arm);
        }
    }
}
