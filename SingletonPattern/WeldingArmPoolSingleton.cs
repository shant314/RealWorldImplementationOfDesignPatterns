using Assets.Robotics.Arms;

namespace SingletonPattern
{
    /*Singleton patern over Object pool pattern*/

    // the first thing to do for a singleton is to seal it so that it can’t be extended.
    public sealed class WeldingArmPoolSingleton
    {
        private static WeldingArmPoolSingleton _instance;
        public static WeldingArmPoolSingleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WeldingArmPoolSingleton();

                return _instance;
            }
        }

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

        // a private constructor.
        private WeldingArmPoolSingleton()
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
